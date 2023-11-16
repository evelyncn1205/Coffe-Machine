namespace Forms_Avaliação_01
{
    partial class FrmMaquinaDeCafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaquinaDeCafe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpBox_Produtos = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_Preparando = new System.Windows.Forms.Label();
            this.btn_Chocolate = new System.Windows.Forms.Button();
            this.btn_Cha = new System.Windows.Forms.Button();
            this.btn_Cappuccino = new System.Windows.Forms.Button();
            this.btn_Cafe = new System.Windows.Forms.Button();
            this.gpBox_Moedas = new System.Windows.Forms.GroupBox();
            this.btn_InserirMoeda = new System.Windows.Forms.Button();
            this.rb_Dois = new System.Windows.Forms.RadioButton();
            this.rb_Um = new System.Windows.Forms.RadioButton();
            this.rb_Cinquenta = new System.Windows.Forms.RadioButton();
            this.rb_Vinte = new System.Windows.Forms.RadioButton();
            this.rb_Dez = new System.Windows.Forms.RadioButton();
            this.rb_Cinco = new System.Windows.Forms.RadioButton();
            this.btn_Devolver = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpBox_Produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gpBox_Moedas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 97);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(528, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Café Express ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(740, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bem vindo à Café Express!!!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpBox_Produtos
            // 
            this.gpBox_Produtos.Controls.Add(this.pictureBox5);
            this.gpBox_Produtos.Controls.Add(this.pictureBox4);
            this.gpBox_Produtos.Controls.Add(this.pictureBox3);
            this.gpBox_Produtos.Controls.Add(this.pictureBox2);
            this.gpBox_Produtos.Controls.Add(this.progressBar1);
            this.gpBox_Produtos.Controls.Add(this.lbl_Preparando);
            this.gpBox_Produtos.Controls.Add(this.btn_Chocolate);
            this.gpBox_Produtos.Controls.Add(this.btn_Cha);
            this.gpBox_Produtos.Controls.Add(this.btn_Cappuccino);
            this.gpBox_Produtos.Controls.Add(this.btn_Cafe);
            this.gpBox_Produtos.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpBox_Produtos.Location = new System.Drawing.Point(8, 140);
            this.gpBox_Produtos.Name = "gpBox_Produtos";
            this.gpBox_Produtos.Size = new System.Drawing.Size(353, 415);
            this.gpBox_Produtos.TabIndex = 2;
            this.gpBox_Produtos.TabStop = false;
            this.gpBox_Produtos.Text = "Produtos";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(203, 25);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(127, 98);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 171);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 96);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(203, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 362);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(233, 27);
            this.progressBar1.TabIndex = 5;
            // 
            // lbl_Preparando
            // 
            this.lbl_Preparando.Location = new System.Drawing.Point(81, 331);
            this.lbl_Preparando.Name = "lbl_Preparando";
            this.lbl_Preparando.Size = new System.Drawing.Size(155, 22);
            this.lbl_Preparando.TabIndex = 4;
            this.lbl_Preparando.Text = "Preparando ...";
            this.lbl_Preparando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Chocolate
            // 
            this.btn_Chocolate.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_Chocolate.ForeColor = System.Drawing.Color.White;
            this.btn_Chocolate.Location = new System.Drawing.Point(203, 273);
            this.btn_Chocolate.Name = "btn_Chocolate";
            this.btn_Chocolate.Size = new System.Drawing.Size(127, 36);
            this.btn_Chocolate.TabIndex = 3;
            this.btn_Chocolate.Text = "0,35";
            this.btn_Chocolate.UseVisualStyleBackColor = false;
            this.btn_Chocolate.Click += new System.EventHandler(this.btn_Chocolate_Click);
            // 
            // btn_Cha
            // 
            this.btn_Cha.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_Cha.ForeColor = System.Drawing.Color.White;
            this.btn_Cha.Location = new System.Drawing.Point(6, 273);
            this.btn_Cha.Name = "btn_Cha";
            this.btn_Cha.Size = new System.Drawing.Size(127, 36);
            this.btn_Cha.TabIndex = 2;
            this.btn_Cha.Text = "0,20";
            this.btn_Cha.UseVisualStyleBackColor = false;
            this.btn_Cha.Click += new System.EventHandler(this.btn_Cha_Click);
            // 
            // btn_Cappuccino
            // 
            this.btn_Cappuccino.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_Cappuccino.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cappuccino.ForeColor = System.Drawing.Color.White;
            this.btn_Cappuccino.Location = new System.Drawing.Point(203, 129);
            this.btn_Cappuccino.Name = "btn_Cappuccino";
            this.btn_Cappuccino.Size = new System.Drawing.Size(127, 33);
            this.btn_Cappuccino.TabIndex = 1;
            this.btn_Cappuccino.Text = "0,30";
            this.btn_Cappuccino.UseVisualStyleBackColor = false;
            this.btn_Cappuccino.Click += new System.EventHandler(this.btn_Cappuccino_Click);
            // 
            // btn_Cafe
            // 
            this.btn_Cafe.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_Cafe.ForeColor = System.Drawing.Color.White;
            this.btn_Cafe.Location = new System.Drawing.Point(6, 129);
            this.btn_Cafe.Name = "btn_Cafe";
            this.btn_Cafe.Size = new System.Drawing.Size(127, 36);
            this.btn_Cafe.TabIndex = 0;
            this.btn_Cafe.Text = "0,25";
            this.btn_Cafe.UseVisualStyleBackColor = false;
            this.btn_Cafe.Click += new System.EventHandler(this.btn_Cafe_Click);
            // 
            // gpBox_Moedas
            // 
            this.gpBox_Moedas.Controls.Add(this.btn_InserirMoeda);
            this.gpBox_Moedas.Controls.Add(this.rb_Dois);
            this.gpBox_Moedas.Controls.Add(this.rb_Um);
            this.gpBox_Moedas.Controls.Add(this.rb_Cinquenta);
            this.gpBox_Moedas.Controls.Add(this.rb_Vinte);
            this.gpBox_Moedas.Controls.Add(this.rb_Dez);
            this.gpBox_Moedas.Controls.Add(this.rb_Cinco);
            this.gpBox_Moedas.Controls.Add(this.btn_Devolver);
            this.gpBox_Moedas.Controls.Add(this.panel2);
            this.gpBox_Moedas.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpBox_Moedas.Location = new System.Drawing.Point(377, 143);
            this.gpBox_Moedas.Name = "gpBox_Moedas";
            this.gpBox_Moedas.Size = new System.Drawing.Size(350, 412);
            this.gpBox_Moedas.TabIndex = 0;
            this.gpBox_Moedas.TabStop = false;
            this.gpBox_Moedas.Text = "Moedas";
            // 
            // btn_InserirMoeda
            // 
            this.btn_InserirMoeda.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_InserirMoeda.ForeColor = System.Drawing.Color.White;
            this.btn_InserirMoeda.Location = new System.Drawing.Point(75, 178);
            this.btn_InserirMoeda.Name = "btn_InserirMoeda";
            this.btn_InserirMoeda.Size = new System.Drawing.Size(193, 44);
            this.btn_InserirMoeda.TabIndex = 15;
            this.btn_InserirMoeda.Text = "Inserir  Moeda";
            this.btn_InserirMoeda.UseVisualStyleBackColor = false;
            this.btn_InserirMoeda.Click += new System.EventHandler(this.btn_InserirMoeda_Click);
            // 
            // rb_Dois
            // 
            this.rb_Dois.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_Dois.BackColor = System.Drawing.Color.SaddleBrown;
            this.rb_Dois.ForeColor = System.Drawing.Color.White;
            this.rb_Dois.Location = new System.Drawing.Point(203, 143);
            this.rb_Dois.Name = "rb_Dois";
            this.rb_Dois.Size = new System.Drawing.Size(78, 29);
            this.rb_Dois.TabIndex = 14;
            this.rb_Dois.TabStop = true;
            this.rb_Dois.Text = "2,00";
            this.rb_Dois.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_Dois.UseVisualStyleBackColor = false;
            this.rb_Dois.CheckedChanged += new System.EventHandler(this.rbMoedas_CheckedValue);
            // 
            // rb_Um
            // 
            this.rb_Um.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_Um.BackColor = System.Drawing.Color.SaddleBrown;
            this.rb_Um.ForeColor = System.Drawing.Color.White;
            this.rb_Um.Location = new System.Drawing.Point(203, 91);
            this.rb_Um.Name = "rb_Um";
            this.rb_Um.Size = new System.Drawing.Size(78, 29);
            this.rb_Um.TabIndex = 13;
            this.rb_Um.TabStop = true;
            this.rb_Um.Text = "1,00";
            this.rb_Um.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_Um.UseVisualStyleBackColor = false;
            this.rb_Um.CheckedChanged += new System.EventHandler(this.rbMoedas_CheckedValue);
            // 
            // rb_Cinquenta
            // 
            this.rb_Cinquenta.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_Cinquenta.BackColor = System.Drawing.Color.SaddleBrown;
            this.rb_Cinquenta.ForeColor = System.Drawing.Color.White;
            this.rb_Cinquenta.Location = new System.Drawing.Point(203, 40);
            this.rb_Cinquenta.Name = "rb_Cinquenta";
            this.rb_Cinquenta.Size = new System.Drawing.Size(78, 29);
            this.rb_Cinquenta.TabIndex = 12;
            this.rb_Cinquenta.TabStop = true;
            this.rb_Cinquenta.Text = "0,50";
            this.rb_Cinquenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_Cinquenta.UseVisualStyleBackColor = false;
            this.rb_Cinquenta.CheckedChanged += new System.EventHandler(this.rbMoedas_CheckedValue);
            // 
            // rb_Vinte
            // 
            this.rb_Vinte.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_Vinte.BackColor = System.Drawing.Color.SaddleBrown;
            this.rb_Vinte.ForeColor = System.Drawing.Color.White;
            this.rb_Vinte.Location = new System.Drawing.Point(51, 143);
            this.rb_Vinte.Name = "rb_Vinte";
            this.rb_Vinte.Size = new System.Drawing.Size(76, 29);
            this.rb_Vinte.TabIndex = 11;
            this.rb_Vinte.TabStop = true;
            this.rb_Vinte.Text = "0,20";
            this.rb_Vinte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_Vinte.UseVisualStyleBackColor = false;
            this.rb_Vinte.CheckedChanged += new System.EventHandler(this.rbMoedas_CheckedValue);
            // 
            // rb_Dez
            // 
            this.rb_Dez.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_Dez.BackColor = System.Drawing.Color.SaddleBrown;
            this.rb_Dez.ForeColor = System.Drawing.Color.White;
            this.rb_Dez.Location = new System.Drawing.Point(51, 91);
            this.rb_Dez.Name = "rb_Dez";
            this.rb_Dez.Size = new System.Drawing.Size(76, 29);
            this.rb_Dez.TabIndex = 10;
            this.rb_Dez.TabStop = true;
            this.rb_Dez.Text = "0,10";
            this.rb_Dez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_Dez.UseVisualStyleBackColor = false;
            this.rb_Dez.CheckedChanged += new System.EventHandler(this.rbMoedas_CheckedValue);
            // 
            // rb_Cinco
            // 
            this.rb_Cinco.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_Cinco.BackColor = System.Drawing.Color.SaddleBrown;
            this.rb_Cinco.ForeColor = System.Drawing.Color.White;
            this.rb_Cinco.Location = new System.Drawing.Point(51, 40);
            this.rb_Cinco.Name = "rb_Cinco";
            this.rb_Cinco.Size = new System.Drawing.Size(76, 29);
            this.rb_Cinco.TabIndex = 9;
            this.rb_Cinco.TabStop = true;
            this.rb_Cinco.Text = "0,05";
            this.rb_Cinco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_Cinco.UseVisualStyleBackColor = false;
            this.rb_Cinco.CheckedChanged += new System.EventHandler(this.rbMoedas_CheckedValue);
            // 
            // btn_Devolver
            // 
            this.btn_Devolver.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_Devolver.ForeColor = System.Drawing.Color.White;
            this.btn_Devolver.Location = new System.Drawing.Point(75, 343);
            this.btn_Devolver.Name = "btn_Devolver";
            this.btn_Devolver.Size = new System.Drawing.Size(193, 50);
            this.btn_Devolver.TabIndex = 8;
            this.btn_Devolver.Text = "Devolver Saldo";
            this.btn_Devolver.UseVisualStyleBackColor = false;
            this.btn_Devolver.Click += new System.EventHandler(this.btn_Devolver_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_Saldo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(106, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 83);
            this.panel2.TabIndex = 7;
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Saldo.ForeColor = System.Drawing.Color.White;
            this.lbl_Saldo.Location = new System.Drawing.Point(3, 36);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(129, 33);
            this.lbl_Saldo.TabIndex = 7;
            this.lbl_Saldo.Text = "-";
            this.lbl_Saldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMaquinaDeCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(739, 567);
            this.Controls.Add(this.gpBox_Moedas);
            this.Controls.Add(this.gpBox_Produtos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmMaquinaDeCafe";
            this.Text = "Café Express";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpBox_Produtos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gpBox_Moedas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        protected PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private GroupBox gpBox_Produtos;
        private Button btn_Chocolate;
        private Button btn_Cha;
        private Button btn_Cappuccino;
        private Button btn_Cafe;
        private GroupBox gpBox_Moedas;
        private Panel panel2;
        private Label lbl_Saldo;
        private Label label3;
        private ProgressBar progressBar1;
        private Label lbl_Preparando;
        private Button btn_Devolver;
        private Button btn_InserirMoeda;
        private RadioButton rb_Dois;
        private RadioButton rb_Um;
        private RadioButton rb_Cinquenta;
        private RadioButton rb_Vinte;
        private RadioButton rb_Dez;
        private RadioButton rb_Cinco;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}