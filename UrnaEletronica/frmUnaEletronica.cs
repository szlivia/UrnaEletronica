using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;
using UrnaEletronica.Models;

namespace UrnaEletronica
{
    public partial class frmUnaEletronica : Form
    {
        List<Label> labels = new List<Label>();
        DataTable dtCategoria = new DataTable();

        bool votoBranco = false;
        string vote = "";
        byte[] imagemBytes;

        int[] digitIndex = { 4, 5, 3, 2, 2 };
        int index = 0;

        public frmUnaEletronica()
        {
            InitializeComponent();
        }

        private void frmUnaEletronica_Load(object sender, EventArgs e)
        {
            labels.Add(lbl_num1);
            labels.Add(lbl_num2);
            labels.Add(lbl_num3);
            labels.Add(lbl_num4);
            labels.Add(lbl_num5);
            bbiNovaSimulacao.Visible = false;
            dtCategoria = Votacao.Categoria();
            AtualizaTela();
        }
        private void AtualizaTela()
        {
            votoBranco = false;
            OcultarControles(panel1);
            foreach (var label in labels)
            {
                label.Visible = false;
                label.Text = "0";
            }

            if (index < digitIndex.Length)
            {
                for (int i = 0; i < digitIndex[index]; i++)
                    labels[i].Visible = true;

                for (int i = 0; i < vote.Length; i++)
                {
                    labels[i].Text = vote[i].ToString();
                }

                lblVotPara.Visible = true;
                lblVotPara.Text = dtCategoria.Rows[index]["NOME"].ToString();


                lbl_Votacao.Visible = true;
                lbl_SeuVotoPara.Visible = true;
                lbl_numero.Visible = true;

            }
        }
        private void OcultarControles(Panel painel)
        {
            foreach (Control c in painel.Controls)
            {
                c.Visible = false;
            }
        }

        private void Digita(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            if (vote.Length >= digitIndex[index])
                return;
            else
            {
                vote += botao.Text;
                AtualizaTela();
            }
        }
        private void btn_Confirma_Click(object sender, EventArgs e)
        {
            string numeroConcatenado = string.Concat(labels.Where(l => l.Visible).Select(l => l.Text));

            if (numeroConcatenado.Length == digitIndex[index] || votoBranco == true)
            {
                numeroConcatenado = dtCategoria.Rows[index]["ID"].ToString() + "-" + numeroConcatenado;

                if (votoBranco)
                {
                    numeroConcatenado = dtCategoria.Rows[index]["ID"].ToString() + "-" + "BRANCO";
                }

                string hashVoto = GerarHash(numeroConcatenado);

                string caminhoPasta = Path.Combine(Application.StartupPath, "VotosRegistrados");
                Directory.CreateDirectory(caminhoPasta);

                string nomeArquivo = $"voto_{DateTime.Now:yyyyMMdd_HHmmssfff}.txt";
                string caminhoCompleto = Path.Combine(caminhoPasta, nomeArquivo);

                File.WriteAllText(caminhoCompleto, hashVoto);

                lbl_voto_nulo.Visible = true;

                

                index++;
                if (index >= digitIndex.Length)
                {
                    OcultarControles(panel1);

                    MostrarBarraProgressoFinal();
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + "\\Sound\\Confirma.wav");
                    player.Play();

                    lbl_FIM.Visible = true;
                    lbl_votou.Visible = true;
                    bbiNovaSimulacao.Visible = true;

                    return;
                }

                vote = "";
                AtualizaTela();
            }
        }
        private void btn_Branco_Click(object sender, EventArgs e)
        {
            OcultarControles(panel1);
            MostrarCamposAcao(true, true);
            votoBranco = true;
        }
        private void btn_Corrige_Click(object sender, EventArgs e)
        {
            vote = vote.Substring(0, vote.Length - vote.Length);
            AtualizaTela();
        }

        private void VerificaNumeroCandidato(object sender, EventArgs e)
        {
            if (vote.Length > 0)
            {
                string numeroConcatenado = string.Concat(labels.Where(l => l.Visible).Select(l => l.Text));

                if (numeroConcatenado.Length > 0)
                {
                    var dt = Votacao.Candidatos(dtCategoria.Rows[index]["ID"].ToString(), numeroConcatenado);
                    if (dt.Rows.Count > 0)
                    {
                        MostrarCamposCandidato(true);
                        MostrarCamposAcao(true);
                        MostrarCamposErro(false);

                        lblCandidato.Text = dt.Rows[0]["NOME"].ToString();
                        lblPartidoCandidato.Text = dt.Rows[0]["NOME_PARTIDO"].ToString();


                        imagemBytes = (byte[])dt.Rows[0]["FOTO"];
                        using (var ms = new MemoryStream(imagemBytes))
                        {
                            picCandidato.Image = Image.FromStream(ms);
                        }
                    }
                }

                else
                {
                    MostrarCamposCandidato(false);
                    MostrarCamposAcao(true);
                    MostrarCamposErro(true);
                }
            }
        }

        private void MostrarCamposCandidato(bool mostrar)
        {
            lbl_nome.Visible = mostrar;
            lbl_Partido.Visible = mostrar;
            lblCandidato.Visible = mostrar;
            lblPartidoCandidato.Visible = mostrar;
            picCandidato.Visible = mostrar;
            panelLinha.Visible = mostrar;
        }

        private void MostrarCamposErro(bool mostrar)
        {
            lbl_numero_errado.Visible = mostrar;
            lbl_voto_nulo.Visible = mostrar;
        }

        private void MostrarCamposAcao(bool mostrar, bool votoBranco = false)
        {
            lbl_aperte_a_tecla.Visible = mostrar;
            lbl_confirma.Visible = mostrar;
            lbl_corrige.Visible = mostrar;
            panelLinha.Visible = mostrar;
            if (votoBranco)
            {
                lbl_voto_branco.Visible = mostrar;
            }
        }
        private string GerarHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        private async void MostrarBarraProgressoFinal()
        {
            progressBar.Visible = true;
            progressBar.Value = 0;

            for (int i = 0; i <= 100; i += 10)
            {
                await Task.Delay(80);
                progressBar.Value = i;
            }

            await Task.Delay(300);

            progressBar.Visible = false;
        }

        private void bbiNovaSimulacao_Click(object sender, EventArgs e)
        {
            index = 0;
            vote = "";
            AtualizaTela();
        }
    }
}