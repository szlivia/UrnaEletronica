namespace UrnaEletronica
{
    partial class frmUnaEletronica
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnaEletronica));
            panel1 = new Panel();
            progressBar = new ProgressBar();
            lbl_voto_branco = new Label();
            lbl_voto_nulo = new Label();
            lbl_numero_errado = new Label();
            lbl_FIM = new Label();
            lbl_relogio = new Label();
            panelLinha = new Panel();
            lbl_votou = new Label();
            picCandidato = new PictureBox();
            lblVotPara = new Label();
            lbl_Votacao = new Label();
            lbl_corrige = new Label();
            lbl_confirma = new Label();
            lbl_aperte_a_tecla = new Label();
            lblPartidoCandidato = new Label();
            lbl_Partido = new Label();
            lblCandidato = new Label();
            lbl_nome = new Label();
            lbl_numero = new Label();
            lbl_SeuVotoPara = new Label();
            lbl_num5 = new Label();
            lbl_num4 = new Label();
            lbl_num3 = new Label();
            lbl_num2 = new Label();
            lbl_num1 = new Label();
            panel2 = new Panel();
            btn10 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn_Confirma = new Button();
            btn_Corrige = new Button();
            btn_Branco = new Button();
            btn2 = new Button();
            btn1 = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            bbiNovaSimulacao = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCandidato).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(lbl_voto_branco);
            panel1.Controls.Add(lbl_voto_nulo);
            panel1.Controls.Add(lbl_numero_errado);
            panel1.Controls.Add(lbl_FIM);
            panel1.Controls.Add(lbl_relogio);
            panel1.Controls.Add(panelLinha);
            panel1.Controls.Add(lbl_votou);
            panel1.Controls.Add(picCandidato);
            panel1.Controls.Add(lblVotPara);
            panel1.Controls.Add(lbl_Votacao);
            panel1.Controls.Add(lbl_corrige);
            panel1.Controls.Add(lbl_confirma);
            panel1.Controls.Add(lbl_aperte_a_tecla);
            panel1.Controls.Add(lblPartidoCandidato);
            panel1.Controls.Add(lbl_Partido);
            panel1.Controls.Add(lblCandidato);
            panel1.Controls.Add(lbl_nome);
            panel1.Controls.Add(lbl_numero);
            panel1.Controls.Add(lbl_SeuVotoPara);
            panel1.Controls.Add(lbl_num5);
            panel1.Controls.Add(lbl_num4);
            panel1.Controls.Add(lbl_num3);
            panel1.Controls.Add(lbl_num2);
            panel1.Controls.Add(lbl_num1);
            panel1.Location = new Point(25, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 422);
            panel1.TabIndex = 0;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(149, 196);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(222, 23);
            progressBar.TabIndex = 27;
            // 
            // lbl_voto_branco
            // 
            lbl_voto_branco.AutoSize = true;
            lbl_voto_branco.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_voto_branco.Location = new Point(70, 146);
            lbl_voto_branco.Name = "lbl_voto_branco";
            lbl_voto_branco.Size = new Size(460, 55);
            lbl_voto_branco.TabIndex = 26;
            lbl_voto_branco.Text = "VOTO EM BRANCO";
            // 
            // lbl_voto_nulo
            // 
            lbl_voto_nulo.AutoSize = true;
            lbl_voto_nulo.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_voto_nulo.Location = new Point(193, 275);
            lbl_voto_nulo.Name = "lbl_voto_nulo";
            lbl_voto_nulo.Size = new Size(187, 33);
            lbl_voto_nulo.TabIndex = 25;
            lbl_voto_nulo.Text = "VOTO NULO";
            // 
            // lbl_numero_errado
            // 
            lbl_numero_errado.AutoSize = true;
            lbl_numero_errado.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_numero_errado.Location = new Point(9, 222);
            lbl_numero_errado.Name = "lbl_numero_errado";
            lbl_numero_errado.Size = new Size(181, 22);
            lbl_numero_errado.TabIndex = 24;
            lbl_numero_errado.Text = "NÚMERO ERRADO";
            // 
            // lbl_FIM
            // 
            lbl_FIM.AutoSize = true;
            lbl_FIM.Font = new Font("Arial", 120F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_FIM.Location = new Point(103, 110);
            lbl_FIM.Name = "lbl_FIM";
            lbl_FIM.Size = new Size(352, 183);
            lbl_FIM.TabIndex = 23;
            lbl_FIM.Text = "FIM";
            // 
            // lbl_relogio
            // 
            lbl_relogio.AutoSize = true;
            lbl_relogio.Location = new Point(12, 9);
            lbl_relogio.Name = "lbl_relogio";
            lbl_relogio.Size = new Size(138, 15);
            lbl_relogio.TabIndex = 22;
            lbl_relogio.Text = "QUA 09/04/2025 21:44:10";
            // 
            // panelLinha
            // 
            panelLinha.BackColor = Color.Black;
            panelLinha.Location = new Point(0, 341);
            panelLinha.Name = "panelLinha";
            panelLinha.Size = new Size(576, 2);
            panelLinha.TabIndex = 21;
            // 
            // lbl_votou
            // 
            lbl_votou.AutoSize = true;
            lbl_votou.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_votou.ForeColor = Color.FromArgb(185, 188, 193);
            lbl_votou.Location = new Point(453, 371);
            lbl_votou.Name = "lbl_votou";
            lbl_votou.Size = new Size(120, 42);
            lbl_votou.TabIndex = 19;
            lbl_votou.Text = "VOTOU";
            // 
            // picCandidato
            // 
            picCandidato.Location = new Point(377, 67);
            picCandidato.Name = "picCandidato";
            picCandidato.Size = new Size(187, 205);
            picCandidato.SizeMode = PictureBoxSizeMode.StretchImage;
            picCandidato.TabIndex = 16;
            picCandidato.TabStop = false;
            // 
            // lblVotPara
            // 
            lblVotPara.AutoSize = true;
            lblVotPara.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblVotPara.Location = new Point(144, 66);
            lblVotPara.Name = "lblVotPara";
            lblVotPara.Size = new Size(149, 29);
            lblVotPara.TabIndex = 15;
            lblVotPara.Text = "Gorvenador";
            // 
            // lbl_Votacao
            // 
            lbl_Votacao.AutoSize = true;
            lbl_Votacao.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Votacao.ForeColor = Color.FromArgb(185, 188, 193);
            lbl_Votacao.Location = new Point(245, 9);
            lbl_Votacao.Name = "lbl_Votacao";
            lbl_Votacao.Size = new Size(111, 24);
            lbl_Votacao.TabIndex = 14;
            lbl_Votacao.Text = "VOTAÇÃO";
            // 
            // lbl_corrige
            // 
            lbl_corrige.AutoSize = true;
            lbl_corrige.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_corrige.Location = new Point(45, 390);
            lbl_corrige.Name = "lbl_corrige";
            lbl_corrige.Size = new Size(248, 17);
            lbl_corrige.TabIndex = 13;
            lbl_corrige.Text = "CORRIGE para REINICIAR este voto";
            // 
            // lbl_confirma
            // 
            lbl_confirma.AutoSize = true;
            lbl_confirma.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_confirma.Location = new Point(35, 368);
            lbl_confirma.Name = "lbl_confirma";
            lbl_confirma.Size = new Size(270, 17);
            lbl_confirma.TabIndex = 12;
            lbl_confirma.Text = "CONFIRMA para CONFIRMAR este voto";
            // 
            // lbl_aperte_a_tecla
            // 
            lbl_aperte_a_tecla.AutoSize = true;
            lbl_aperte_a_tecla.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_aperte_a_tecla.Location = new Point(12, 346);
            lbl_aperte_a_tecla.Name = "lbl_aperte_a_tecla";
            lbl_aperte_a_tecla.Size = new Size(101, 17);
            lbl_aperte_a_tecla.TabIndex = 11;
            lbl_aperte_a_tecla.Text = "Aperte a tecla:";
            // 
            // lblPartidoCandidato
            // 
            lblPartidoCandidato.AutoSize = true;
            lblPartidoCandidato.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPartidoCandidato.Location = new Point(70, 244);
            lblPartidoCandidato.Name = "lblPartidoCandidato";
            lblPartidoCandidato.Size = new Size(78, 17);
            lblPartidoCandidato.TabIndex = 10;
            lblPartidoCandidato.Text = "Presidente";
            // 
            // lbl_Partido
            // 
            lbl_Partido.AutoSize = true;
            lbl_Partido.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Partido.Location = new Point(9, 244);
            lbl_Partido.Name = "lbl_Partido";
            lbl_Partido.Size = new Size(62, 17);
            lbl_Partido.TabIndex = 9;
            lbl_Partido.Text = "Partido: ";
            // 
            // lblCandidato
            // 
            lblCandidato.AutoSize = true;
            lblCandidato.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCandidato.Location = new Point(70, 184);
            lblCandidato.Name = "lblCandidato";
            lblCandidato.Size = new Size(78, 17);
            lblCandidato.TabIndex = 8;
            lblCandidato.Text = "Presidente";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nome.Location = new Point(9, 184);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(55, 17);
            lbl_nome.TabIndex = 7;
            lbl_nome.Text = "Nome: ";
            // 
            // lbl_numero
            // 
            lbl_numero.AutoSize = true;
            lbl_numero.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_numero.Location = new Point(9, 138);
            lbl_numero.Name = "lbl_numero";
            lbl_numero.Size = new Size(68, 17);
            lbl_numero.TabIndex = 6;
            lbl_numero.Text = "Número: ";
            // 
            // lbl_SeuVotoPara
            // 
            lbl_SeuVotoPara.AutoSize = true;
            lbl_SeuVotoPara.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SeuVotoPara.Location = new Point(12, 35);
            lbl_SeuVotoPara.Name = "lbl_SeuVotoPara";
            lbl_SeuVotoPara.Size = new Size(166, 22);
            lbl_SeuVotoPara.TabIndex = 5;
            lbl_SeuVotoPara.Text = "SEU VOTO PARA";
            // 
            // lbl_num5
            // 
            lbl_num5.AutoSize = true;
            lbl_num5.BorderStyle = BorderStyle.FixedSingle;
            lbl_num5.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_num5.Location = new Point(230, 128);
            lbl_num5.Name = "lbl_num5";
            lbl_num5.Size = new Size(31, 34);
            lbl_num5.TabIndex = 4;
            lbl_num5.Text = "5";
            lbl_num5.TextChanged += VerificaNumeroCandidato;
            // 
            // lbl_num4
            // 
            lbl_num4.AutoSize = true;
            lbl_num4.BorderStyle = BorderStyle.FixedSingle;
            lbl_num4.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_num4.Location = new Point(193, 128);
            lbl_num4.Name = "lbl_num4";
            lbl_num4.Size = new Size(31, 34);
            lbl_num4.TabIndex = 3;
            lbl_num4.Text = "4";
            lbl_num4.TextChanged += VerificaNumeroCandidato;
            // 
            // lbl_num3
            // 
            lbl_num3.AutoSize = true;
            lbl_num3.BorderStyle = BorderStyle.FixedSingle;
            lbl_num3.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_num3.Location = new Point(156, 128);
            lbl_num3.Name = "lbl_num3";
            lbl_num3.Size = new Size(31, 34);
            lbl_num3.TabIndex = 2;
            lbl_num3.Text = "3";
            lbl_num3.TextChanged += VerificaNumeroCandidato;
            // 
            // lbl_num2
            // 
            lbl_num2.AutoSize = true;
            lbl_num2.BorderStyle = BorderStyle.FixedSingle;
            lbl_num2.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_num2.Location = new Point(119, 128);
            lbl_num2.Name = "lbl_num2";
            lbl_num2.Size = new Size(31, 34);
            lbl_num2.TabIndex = 1;
            lbl_num2.Text = "2";
            lbl_num2.TextChanged += VerificaNumeroCandidato;
            // 
            // lbl_num1
            // 
            lbl_num1.AutoSize = true;
            lbl_num1.BorderStyle = BorderStyle.FixedSingle;
            lbl_num1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_num1.Location = new Point(82, 128);
            lbl_num1.Name = "lbl_num1";
            lbl_num1.Size = new Size(31, 34);
            lbl_num1.TabIndex = 0;
            lbl_num1.Text = "1";
            lbl_num1.TextChanged += VerificaNumeroCandidato;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(57, 52, 49);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn10);
            panel2.Controls.Add(btn9);
            panel2.Controls.Add(btn8);
            panel2.Controls.Add(btn7);
            panel2.Controls.Add(btn6);
            panel2.Controls.Add(btn5);
            panel2.Controls.Add(btn4);
            panel2.Controls.Add(btn3);
            panel2.Controls.Add(btn_Confirma);
            panel2.Controls.Add(btn_Corrige);
            panel2.Controls.Add(btn_Branco);
            panel2.Controls.Add(btn2);
            panel2.Controls.Add(btn1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(625, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 454);
            panel2.TabIndex = 1;
            // 
            // btn10
            // 
            btn10.BackColor = Color.FromArgb(48, 44, 45);
            btn10.FlatAppearance.BorderColor = Color.FromArgb(50, 45, 45);
            btn10.FlatStyle = FlatStyle.Flat;
            btn10.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn10.ForeColor = Color.FromArgb(168, 161, 147);
            btn10.Location = new Point(149, 318);
            btn10.Name = "btn10";
            btn10.Size = new Size(87, 43);
            btn10.TabIndex = 22;
            btn10.Text = "0";
            btn10.UseVisualStyleBackColor = false;
            btn10.Click += Digita;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(48, 44, 45);
            btn9.FlatAppearance.BorderColor = Color.FromArgb(50, 45, 45);
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.ForeColor = Color.FromArgb(168, 161, 147);
            btn9.Location = new Point(254, 259);
            btn9.Name = "btn9";
            btn9.Size = new Size(87, 43);
            btn9.TabIndex = 21;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Digita;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(48, 44, 45);
            btn8.FlatAppearance.BorderColor = Color.FromArgb(50, 45, 45);
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.ForeColor = Color.FromArgb(168, 161, 147);
            btn8.Location = new Point(149, 259);
            btn8.Name = "btn8";
            btn8.Size = new Size(87, 43);
            btn8.TabIndex = 20;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Digita;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(48, 44, 45);
            btn7.FlatAppearance.BorderColor = Color.FromArgb(50, 45, 45);
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.ForeColor = Color.FromArgb(168, 161, 147);
            btn7.Location = new Point(46, 259);
            btn7.Name = "btn7";
            btn7.Size = new Size(87, 43);
            btn7.TabIndex = 19;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Digita;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(48, 44, 45);
            btn6.FlatAppearance.BorderColor = Color.FromArgb(50, 45, 45);
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.ForeColor = Color.FromArgb(168, 161, 147);
            btn6.Location = new Point(254, 199);
            btn6.Name = "btn6";
            btn6.Size = new Size(87, 43);
            btn6.TabIndex = 18;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Digita;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(48, 44, 45);
            btn5.FlatAppearance.BorderColor = Color.FromArgb(50, 45, 45);
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.ForeColor = Color.FromArgb(168, 161, 147);
            btn5.Location = new Point(149, 199);
            btn5.Name = "btn5";
            btn5.Size = new Size(87, 43);
            btn5.TabIndex = 17;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Digita;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(48, 44, 45);
            btn4.FlatAppearance.BorderColor = Color.FromArgb(50, 45, 45);
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.ForeColor = Color.FromArgb(168, 161, 147);
            btn4.Location = new Point(46, 199);
            btn4.Name = "btn4";
            btn4.Size = new Size(87, 43);
            btn4.TabIndex = 16;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Digita;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(48, 44, 45);
            btn3.FlatAppearance.BorderColor = Color.FromArgb(50, 45, 45);
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.ForeColor = Color.FromArgb(168, 161, 147);
            btn3.Location = new Point(254, 139);
            btn3.Name = "btn3";
            btn3.Size = new Size(87, 43);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Digita;
            // 
            // btn_Confirma
            // 
            btn_Confirma.BackColor = Color.FromArgb(65, 188, 111);
            btn_Confirma.FlatAppearance.BorderSize = 0;
            btn_Confirma.FlatStyle = FlatStyle.Flat;
            btn_Confirma.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Confirma.Location = new Point(254, 383);
            btn_Confirma.Name = "btn_Confirma";
            btn_Confirma.Size = new Size(111, 54);
            btn_Confirma.TabIndex = 14;
            btn_Confirma.Text = "CONFIRMA";
            btn_Confirma.UseVisualStyleBackColor = false;
            btn_Confirma.Click += btn_Confirma_Click;
            // 
            // btn_Corrige
            // 
            btn_Corrige.BackColor = Color.FromArgb(249, 175, 96);
            btn_Corrige.FlatAppearance.BorderSize = 0;
            btn_Corrige.FlatStyle = FlatStyle.Flat;
            btn_Corrige.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Corrige.Location = new Point(135, 389);
            btn_Corrige.Name = "btn_Corrige";
            btn_Corrige.Size = new Size(100, 48);
            btn_Corrige.TabIndex = 13;
            btn_Corrige.Text = "CORRIGE";
            btn_Corrige.UseVisualStyleBackColor = false;
            btn_Corrige.Click += btn_Corrige_Click;
            // 
            // btn_Branco
            // 
            btn_Branco.BackColor = Color.FromArgb(251, 250, 245);
            btn_Branco.FlatAppearance.BorderSize = 0;
            btn_Branco.FlatStyle = FlatStyle.Flat;
            btn_Branco.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Branco.Location = new Point(18, 389);
            btn_Branco.Name = "btn_Branco";
            btn_Branco.Size = new Size(100, 48);
            btn_Branco.TabIndex = 12;
            btn_Branco.Text = "BRANCO";
            btn_Branco.UseVisualStyleBackColor = false;
            btn_Branco.Click += btn_Branco_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(48, 44, 45);
            btn2.FlatAppearance.BorderColor = Color.FromArgb(50, 45, 45);
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.ForeColor = Color.FromArgb(168, 161, 147);
            btn2.Location = new Point(149, 139);
            btn2.Name = "btn2";
            btn2.Size = new Size(87, 43);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Digita;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(48, 44, 45);
            btn1.FlatAppearance.BorderColor = Color.FromArgb(50, 45, 45);
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = Color.FromArgb(168, 161, 147);
            btn1.Location = new Point(46, 139);
            btn1.Name = "btn1";
            btn1.Size = new Size(87, 43);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Digita;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bbiNovaSimulacao
            // 
            bbiNovaSimulacao.Location = new Point(492, 10);
            bbiNovaSimulacao.Name = "bbiNovaSimulacao";
            bbiNovaSimulacao.Size = new Size(109, 23);
            bbiNovaSimulacao.TabIndex = 2;
            bbiNovaSimulacao.Text = "Nova Simulação";
            bbiNovaSimulacao.UseVisualStyleBackColor = true;
            bbiNovaSimulacao.Click += bbiNovaSimulacao_Click;
            // 
            // frmUnaEletronica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(213, 207, 193);
            ClientSize = new Size(1025, 489);
            Controls.Add(bbiNovaSimulacao);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmUnaEletronica";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmUnaEletronica_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCandidato).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private PictureBox pictureBox1;
        private Button btn_Confirma;
        private Button btn_Corrige;
        private Button btn_Branco;
        private Button btn10;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Label lbl_num1;
        private Label lbl_SeuVotoPara;
        private Label lbl_num5;
        private Label lbl_num4;
        private Label lbl_num3;
        private Label lbl_num2;
        private Label lblPartidoCandidato;
        private Label lbl_Partido;
        private Label lblCandidato;
        private Label lbl_nome;
        private Label lbl_numero;
        private Label lbl_Votacao;
        private Label lbl_corrige;
        private Label lbl_confirma;
        private Label lbl_aperte_a_tecla;
        private Label lblVotPara;
        private PictureBox picCandidato;
        private Label lbl_votou;
        private Label lbl_relogio;
        private Panel panelLinha;
        private Label lbl_FIM;
        private Label lbl_voto_nulo;
        private Label lbl_numero_errado;
        private Panel panel1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_voto_branco;
        private ProgressBar progressBar;
        private Button bbiNovaSimulacao;
    }
}
