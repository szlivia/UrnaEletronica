namespace UrnaEletronica
{
    public partial class frmUnaEletronica : Form
    {
        List<Label> labels = new List<Label>();
        string[] voteIndex = { "Deputado Federal", "Deputado Estadual", "Senador", "Governador", "Presidente" };
        string vote = "";

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
            OcultarControles(panel1);
            AtualizaTela();
        }
        private void AtualizaTela()
        {
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
                lblVotPara.Text = voteIndex[index];

                lbl_Votacao.Visible = true;
                lbl_SeuVotoPara.Visible = true;
            }
        }
        private void OcultarControles(Panel painel)
        {
            foreach (Control c in painel.Controls)
            {
                if (c is not Panel)
                    c.Visible = false;
            }
        }

        private void Digita(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + "\\Sound\\Click.wav");
            //player.Play();

            if (vote.Length >= digitIndex[index])
                return;
            else
            {
                vote += botao.Text;
                AtualizaTela();
            }
        }

        private void btn_Corrige_Click(object sender, EventArgs e)
        {
            if (vote.Length > 0)
            {
                vote = vote.Substring(0, vote.Length - 1);
                AtualizaTela();
            }
        }

        private void VerificaNumeroCandidato(object sender, EventArgs e)
        {

        }
    }
}
