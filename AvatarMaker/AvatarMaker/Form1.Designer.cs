
namespace AvatarMaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_forca = new System.Windows.Forms.CheckBox();
            this.chk_telep = new System.Windows.Forms.CheckBox();
            this.chk_elast = new System.Windows.Forms.CheckBox();
            this.chk_transf = new System.Windows.Forms.CheckBox();
            this.chk_escudo = new System.Windows.Forms.CheckBox();
            this.chk_inv = new System.Windows.Forms.CheckBox();
            this.chk_raiox = new System.Windows.Forms.CheckBox();
            this.chk_voar = new System.Windows.Forms.CheckBox();
            this.btn_criar = new System.Windows.Forms.Button();
            this.lst_cidades = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_nave = new System.Windows.Forms.RadioButton();
            this.rdo_veiculo = new System.Windows.Forms.RadioButton();
            this.rdo_tele = new System.Windows.Forms.RadioButton();
            this.rdo_jetpack = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_pontos = new System.Windows.Forms.Label();
            this.lbl_forca = new System.Windows.Forms.Label();
            this.lbl_resistencia = new System.Windows.Forms.Label();
            this.lbl_velocidade = new System.Windows.Forms.Label();
            this.lbl_6 = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.scroll_forca = new System.Windows.Forms.HScrollBar();
            this.scroll_resistencia = new System.Windows.Forms.HScrollBar();
            this.scroll_vel = new System.Windows.Forms.HScrollBar();
            this.trk_lado_mau = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_falecimento = new System.Windows.Forms.DateTimePicker();
            this.date_descobrimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_aniversario = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.num_exp = new System.Windows.Forms.NumericUpDown();
            this.pic_capa = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_mau = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_lado_mau)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_capa)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Herói";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(99, 7);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(244, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_forca);
            this.groupBox1.Controls.Add(this.chk_telep);
            this.groupBox1.Controls.Add(this.chk_elast);
            this.groupBox1.Controls.Add(this.chk_transf);
            this.groupBox1.Controls.Add(this.chk_escudo);
            this.groupBox1.Controls.Add(this.chk_inv);
            this.groupBox1.Controls.Add(this.chk_raiox);
            this.groupBox1.Controls.Add(this.chk_voar);
            this.groupBox1.Location = new System.Drawing.Point(16, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habilidades Especiais";
            // 
            // chk_forca
            // 
            this.chk_forca.AutoSize = true;
            this.chk_forca.Location = new System.Drawing.Point(93, 90);
            this.chk_forca.Name = "chk_forca";
            this.chk_forca.Size = new System.Drawing.Size(84, 17);
            this.chk_forca.TabIndex = 7;
            this.chk_forca.Text = "Super Força";
            this.chk_forca.UseVisualStyleBackColor = true;
            // 
            // chk_telep
            // 
            this.chk_telep.AutoSize = true;
            this.chk_telep.Location = new System.Drawing.Point(94, 67);
            this.chk_telep.Name = "chk_telep";
            this.chk_telep.Size = new System.Drawing.Size(70, 17);
            this.chk_telep.TabIndex = 6;
            this.chk_telep.Text = "Telepatia";
            this.chk_telep.UseVisualStyleBackColor = true;
            // 
            // chk_elast
            // 
            this.chk_elast.AutoSize = true;
            this.chk_elast.Location = new System.Drawing.Point(94, 43);
            this.chk_elast.Name = "chk_elast";
            this.chk_elast.Size = new System.Drawing.Size(83, 17);
            this.chk_elast.TabIndex = 5;
            this.chk_elast.Text = "Elasticidade";
            this.chk_elast.UseVisualStyleBackColor = true;
            // 
            // chk_transf
            // 
            this.chk_transf.AutoSize = true;
            this.chk_transf.Location = new System.Drawing.Point(94, 20);
            this.chk_transf.Name = "chk_transf";
            this.chk_transf.Size = new System.Drawing.Size(97, 17);
            this.chk_transf.TabIndex = 4;
            this.chk_transf.Text = "Transformação";
            this.chk_transf.UseVisualStyleBackColor = true;
            // 
            // chk_escudo
            // 
            this.chk_escudo.AutoSize = true;
            this.chk_escudo.Location = new System.Drawing.Point(7, 90);
            this.chk_escudo.Name = "chk_escudo";
            this.chk_escudo.Size = new System.Drawing.Size(62, 17);
            this.chk_escudo.TabIndex = 3;
            this.chk_escudo.Text = "Escudo";
            this.chk_escudo.UseVisualStyleBackColor = true;
            // 
            // chk_inv
            // 
            this.chk_inv.AutoSize = true;
            this.chk_inv.Location = new System.Drawing.Point(7, 67);
            this.chk_inv.Name = "chk_inv";
            this.chk_inv.Size = new System.Drawing.Size(86, 17);
            this.chk_inv.TabIndex = 2;
            this.chk_inv.Text = "Invisibilidade";
            this.chk_inv.UseVisualStyleBackColor = true;
            // 
            // chk_raiox
            // 
            this.chk_raiox.AutoSize = true;
            this.chk_raiox.Location = new System.Drawing.Point(7, 43);
            this.chk_raiox.Name = "chk_raiox";
            this.chk_raiox.Size = new System.Drawing.Size(84, 17);
            this.chk_raiox.TabIndex = 1;
            this.chk_raiox.Text = "Visão RaioX";
            this.chk_raiox.UseVisualStyleBackColor = true;
            // 
            // chk_voar
            // 
            this.chk_voar.AutoSize = true;
            this.chk_voar.Location = new System.Drawing.Point(7, 20);
            this.chk_voar.Name = "chk_voar";
            this.chk_voar.Size = new System.Drawing.Size(48, 17);
            this.chk_voar.TabIndex = 0;
            this.chk_voar.Text = "Voar";
            this.chk_voar.UseVisualStyleBackColor = true;
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(713, 415);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(75, 23);
            this.btn_criar.TabIndex = 3;
            this.btn_criar.Text = "Criar Herói";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // lst_cidades
            // 
            this.lst_cidades.FormattingEnabled = true;
            this.lst_cidades.Items.AddRange(new object[] {
            "Moscovo",
            "Nova Iorque",
            "Londres",
            "Roma",
            "Paris",
            "Tóquio",
            "Rio de Janeiro",
            "Berlim",
            "Cidade do México"});
            this.lst_cidades.Location = new System.Drawing.Point(16, 175);
            this.lst_cidades.Name = "lst_cidades";
            this.lst_cidades.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_cidades.Size = new System.Drawing.Size(111, 95);
            this.lst_cidades.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Localizações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_nave);
            this.groupBox2.Controls.Add(this.rdo_veiculo);
            this.groupBox2.Controls.Add(this.rdo_tele);
            this.groupBox2.Controls.Add(this.rdo_jetpack);
            this.groupBox2.Location = new System.Drawing.Point(142, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 114);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transporte";
            // 
            // rdo_nave
            // 
            this.rdo_nave.AutoSize = true;
            this.rdo_nave.Location = new System.Drawing.Point(7, 88);
            this.rdo_nave.Name = "rdo_nave";
            this.rdo_nave.Size = new System.Drawing.Size(51, 17);
            this.rdo_nave.TabIndex = 9;
            this.rdo_nave.Text = "Nave";
            this.rdo_nave.UseVisualStyleBackColor = true;
            // 
            // rdo_veiculo
            // 
            this.rdo_veiculo.AutoSize = true;
            this.rdo_veiculo.Location = new System.Drawing.Point(7, 65);
            this.rdo_veiculo.Name = "rdo_veiculo";
            this.rdo_veiculo.Size = new System.Drawing.Size(62, 17);
            this.rdo_veiculo.TabIndex = 8;
            this.rdo_veiculo.Text = "Veículo";
            this.rdo_veiculo.UseVisualStyleBackColor = true;
            // 
            // rdo_tele
            // 
            this.rdo_tele.AutoSize = true;
            this.rdo_tele.Location = new System.Drawing.Point(7, 42);
            this.rdo_tele.Name = "rdo_tele";
            this.rdo_tele.Size = new System.Drawing.Size(93, 17);
            this.rdo_tele.TabIndex = 7;
            this.rdo_tele.Text = "Teletransporte";
            this.rdo_tele.UseVisualStyleBackColor = true;
            // 
            // rdo_jetpack
            // 
            this.rdo_jetpack.AutoSize = true;
            this.rdo_jetpack.Checked = true;
            this.rdo_jetpack.Location = new System.Drawing.Point(7, 19);
            this.rdo_jetpack.Name = "rdo_jetpack";
            this.rdo_jetpack.Size = new System.Drawing.Size(67, 17);
            this.rdo_jetpack.TabIndex = 0;
            this.rdo_jetpack.TabStop = true;
            this.rdo_jetpack.Text = "Jet Pack";
            this.rdo_jetpack.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbl_pontos);
            this.groupBox3.Controls.Add(this.lbl_forca);
            this.groupBox3.Controls.Add(this.lbl_resistencia);
            this.groupBox3.Controls.Add(this.lbl_velocidade);
            this.groupBox3.Controls.Add(this.lbl_6);
            this.groupBox3.Controls.Add(this.lbl_5);
            this.groupBox3.Controls.Add(this.lbl_4);
            this.groupBox3.Controls.Add(this.scroll_forca);
            this.groupBox3.Controls.Add(this.scroll_resistencia);
            this.groupBox3.Controls.Add(this.scroll_vel);
            this.groupBox3.Location = new System.Drawing.Point(13, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 161);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Velocidade-Resistência-Força";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pontos usados:";
            // 
            // lbl_pontos
            // 
            this.lbl_pontos.AutoSize = true;
            this.lbl_pontos.Location = new System.Drawing.Point(305, 10);
            this.lbl_pontos.Name = "lbl_pontos";
            this.lbl_pontos.Size = new System.Drawing.Size(19, 13);
            this.lbl_pontos.TabIndex = 9;
            this.lbl_pontos.Text = "99";
            // 
            // lbl_forca
            // 
            this.lbl_forca.AutoSize = true;
            this.lbl_forca.Location = new System.Drawing.Point(61, 110);
            this.lbl_forca.Name = "lbl_forca";
            this.lbl_forca.Size = new System.Drawing.Size(19, 13);
            this.lbl_forca.TabIndex = 8;
            this.lbl_forca.Text = "33";
            // 
            // lbl_resistencia
            // 
            this.lbl_resistencia.AutoSize = true;
            this.lbl_resistencia.Location = new System.Drawing.Point(61, 65);
            this.lbl_resistencia.Name = "lbl_resistencia";
            this.lbl_resistencia.Size = new System.Drawing.Size(19, 13);
            this.lbl_resistencia.TabIndex = 7;
            this.lbl_resistencia.Text = "33";
            // 
            // lbl_velocidade
            // 
            this.lbl_velocidade.AutoSize = true;
            this.lbl_velocidade.Location = new System.Drawing.Point(61, 20);
            this.lbl_velocidade.Name = "lbl_velocidade";
            this.lbl_velocidade.Size = new System.Drawing.Size(19, 13);
            this.lbl_velocidade.TabIndex = 6;
            this.lbl_velocidade.Text = "33";
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.Location = new System.Drawing.Point(0, 110);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(37, 13);
            this.lbl_6.TabIndex = 5;
            this.lbl_6.Text = "Força:";
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Location = new System.Drawing.Point(0, 65);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(65, 13);
            this.lbl_5.TabIndex = 4;
            this.lbl_5.Text = "Resistência:";
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Location = new System.Drawing.Point(0, 20);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(63, 13);
            this.lbl_4.TabIndex = 3;
            this.lbl_4.Text = "Velocidade:";
            // 
            // scroll_forca
            // 
            this.scroll_forca.Location = new System.Drawing.Point(3, 123);
            this.scroll_forca.Maximum = 109;
            this.scroll_forca.Name = "scroll_forca";
            this.scroll_forca.Size = new System.Drawing.Size(312, 22);
            this.scroll_forca.TabIndex = 2;
            this.scroll_forca.Value = 33;
            this.scroll_forca.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_forca_Scroll);
            // 
            // scroll_resistencia
            // 
            this.scroll_resistencia.Location = new System.Drawing.Point(3, 78);
            this.scroll_resistencia.Maximum = 109;
            this.scroll_resistencia.Name = "scroll_resistencia";
            this.scroll_resistencia.Size = new System.Drawing.Size(312, 22);
            this.scroll_resistencia.TabIndex = 1;
            this.scroll_resistencia.Value = 33;
            this.scroll_resistencia.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_resistencia_Scroll);
            // 
            // scroll_vel
            // 
            this.scroll_vel.Location = new System.Drawing.Point(3, 34);
            this.scroll_vel.Maximum = 109;
            this.scroll_vel.Name = "scroll_vel";
            this.scroll_vel.Size = new System.Drawing.Size(312, 22);
            this.scroll_vel.TabIndex = 0;
            this.scroll_vel.Value = 33;
            this.scroll_vel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_vel_Scroll);
            // 
            // trk_lado_mau
            // 
            this.trk_lado_mau.LargeChange = 3;
            this.trk_lado_mau.Location = new System.Drawing.Point(482, 255);
            this.trk_lado_mau.Minimum = -10;
            this.trk_lado_mau.Name = "trk_lado_mau";
            this.trk_lado_mau.Size = new System.Drawing.Size(104, 45);
            this.trk_lado_mau.TabIndex = 1;
            this.trk_lado_mau.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.date_falecimento);
            this.groupBox4.Controls.Add(this.date_descobrimento);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.date_aniversario);
            this.groupBox4.Location = new System.Drawing.Point(354, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 145);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dia do Falecimento";
            // 
            // date_falecimento
            // 
            this.date_falecimento.Location = new System.Drawing.Point(6, 110);
            this.date_falecimento.Name = "date_falecimento";
            this.date_falecimento.Size = new System.Drawing.Size(200, 20);
            this.date_falecimento.TabIndex = 4;
            // 
            // date_descobrimento
            // 
            this.date_descobrimento.Location = new System.Drawing.Point(6, 71);
            this.date_descobrimento.Name = "date_descobrimento";
            this.date_descobrimento.Size = new System.Drawing.Size(200, 20);
            this.date_descobrimento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descobrimento dos poderes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dia de Aniversário";
            // 
            // date_aniversario
            // 
            this.date_aniversario.Location = new System.Drawing.Point(6, 32);
            this.date_aniversario.Name = "date_aniversario";
            this.date_aniversario.Size = new System.Drawing.Size(200, 20);
            this.date_aniversario.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Anos de experiência:";
            // 
            // num_exp
            // 
            this.num_exp.Location = new System.Drawing.Point(466, 163);
            this.num_exp.Name = "num_exp";
            this.num_exp.Size = new System.Drawing.Size(120, 20);
            this.num_exp.TabIndex = 10;
            // 
            // pic_capa
            // 
            this.pic_capa.BackColor = System.Drawing.Color.Red;
            this.pic_capa.Location = new System.Drawing.Point(466, 198);
            this.pic_capa.Name = "pic_capa";
            this.pic_capa.Size = new System.Drawing.Size(120, 40);
            this.pic_capa.TabIndex = 11;
            this.pic_capa.TabStop = false;
            this.pic_capa.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cor da capa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Propensão para lado mau:";
            // 
            // lbl_mau
            // 
            this.lbl_mau.AutoSize = true;
            this.lbl_mau.Location = new System.Drawing.Point(592, 257);
            this.lbl_mau.Name = "lbl_mau";
            this.lbl_mau.Size = new System.Drawing.Size(13, 13);
            this.lbl_mau.TabIndex = 14;
            this.lbl_mau.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(363, 287);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(223, 135);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Portrait";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(713, 386);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lbl_mau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pic_capa);
            this.Controls.Add(this.num_exp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.trk_lado_mau);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_cidades);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Criador de Herói";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_lado_mau)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_capa)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_forca;
        private System.Windows.Forms.CheckBox chk_telep;
        private System.Windows.Forms.CheckBox chk_elast;
        private System.Windows.Forms.CheckBox chk_transf;
        private System.Windows.Forms.CheckBox chk_escudo;
        private System.Windows.Forms.CheckBox chk_inv;
        private System.Windows.Forms.CheckBox chk_raiox;
        private System.Windows.Forms.CheckBox chk_voar;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.ListBox lst_cidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_nave;
        private System.Windows.Forms.RadioButton rdo_veiculo;
        private System.Windows.Forms.RadioButton rdo_tele;
        private System.Windows.Forms.RadioButton rdo_jetpack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_forca;
        private System.Windows.Forms.Label lbl_resistencia;
        private System.Windows.Forms.Label lbl_velocidade;
        private System.Windows.Forms.Label lbl_6;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.HScrollBar scroll_forca;
        private System.Windows.Forms.HScrollBar scroll_resistencia;
        private System.Windows.Forms.HScrollBar scroll_vel;
        private System.Windows.Forms.TrackBar trk_lado_mau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_pontos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_falecimento;
        private System.Windows.Forms.DateTimePicker date_descobrimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_aniversario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_exp;
        private System.Windows.Forms.PictureBox pic_capa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_mau;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_reset;
    }
}

