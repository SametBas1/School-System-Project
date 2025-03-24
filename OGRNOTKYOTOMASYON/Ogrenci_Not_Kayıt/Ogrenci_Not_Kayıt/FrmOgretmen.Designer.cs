namespace Ogrenci_Not_Kayıt
{
    partial class FrmOgretmen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNmr = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnFtgrSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MskOgrnNumara = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnhspla = new System.Windows.Forms.Button();
            this.txtdrm = new System.Windows.Forms.TextBox();
            this.txtort = new System.Windows.Forms.TextBox();
            this.txtprj = new System.Windows.Forms.TextBox();
            this.txtsnv3 = new System.Windows.Forms.TextBox();
            this.txtsnv2 = new System.Windows.Forms.TextBox();
            this.txtsnv1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btngncll = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btndyrolstr = new System.Windows.Forms.Button();
            this.btndyrlst = new System.Windows.Forms.Button();
            this.btnmsj = new System.Windows.Forms.Button();
            this.btncks = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNmr);
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(310, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblNmr
            // 
            this.LblNmr.AutoSize = true;
            this.LblNmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblNmr.Location = new System.Drawing.Point(142, 61);
            this.LblNmr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNmr.Name = "LblNmr";
            this.LblNmr.Size = new System.Drawing.Size(0, 16);
            this.LblNmr.TabIndex = 4;
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdSoyad.Location = new System.Drawing.Point(142, 24);
            this.LblAdSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(0, 22);
            this.LblAdSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numara:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoşgeldiniz:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnFtgrSec);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtsifre);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtsoyad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtad);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.MskOgrnNumara);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(310, 336);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // BtnFtgrSec
            // 
            this.BtnFtgrSec.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnFtgrSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFtgrSec.Location = new System.Drawing.Point(146, 277);
            this.BtnFtgrSec.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnFtgrSec.Name = "BtnFtgrSec";
            this.BtnFtgrSec.Size = new System.Drawing.Size(142, 34);
            this.BtnFtgrSec.TabIndex = 6;
            this.BtnFtgrSec.Text = "Fotoğraf Seç";
            this.BtnFtgrSec.UseVisualStyleBackColor = false;
            this.BtnFtgrSec.Click += new System.EventHandler(this.BtnFtgrSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(146, 157);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(46, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fotoğraf:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(146, 118);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(142, 22);
            this.txtsifre.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(74, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Şifre:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(146, 90);
            this.txtsoyad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(142, 22);
            this.txtsoyad.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(64, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Soyad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(146, 62);
            this.txtad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(142, 22);
            this.txtad.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(94, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ad:";
            // 
            // MskOgrnNumara
            // 
            this.MskOgrnNumara.Location = new System.Drawing.Point(146, 34);
            this.MskOgrnNumara.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MskOgrnNumara.Mask = "0000";
            this.MskOgrnNumara.Name = "MskOgrnNumara";
            this.MskOgrnNumara.Size = new System.Drawing.Size(142, 22);
            this.MskOgrnNumara.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Numara:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnhspla);
            this.groupBox3.Controls.Add(this.txtdrm);
            this.groupBox3.Controls.Add(this.txtort);
            this.groupBox3.Controls.Add(this.txtprj);
            this.groupBox3.Controls.Add(this.txtsnv3);
            this.groupBox3.Controls.Add(this.txtsnv2);
            this.groupBox3.Controls.Add(this.txtsnv1);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(326, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(220, 295);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btnhspla
            // 
            this.btnhspla.BackColor = System.Drawing.Color.SpringGreen;
            this.btnhspla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhspla.Location = new System.Drawing.Point(34, 248);
            this.btnhspla.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnhspla.Name = "btnhspla";
            this.btnhspla.Size = new System.Drawing.Size(170, 34);
            this.btnhspla.TabIndex = 14;
            this.btnhspla.Text = "Hesapla";
            this.btnhspla.UseVisualStyleBackColor = false;
            this.btnhspla.Click += new System.EventHandler(this.btnhspla_Click);
            // 
            // txtdrm
            // 
            this.txtdrm.Location = new System.Drawing.Point(106, 220);
            this.txtdrm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtdrm.Name = "txtdrm";
            this.txtdrm.Size = new System.Drawing.Size(100, 22);
            this.txtdrm.TabIndex = 11;
            // 
            // txtort
            // 
            this.txtort.Location = new System.Drawing.Point(106, 180);
            this.txtort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtort.Name = "txtort";
            this.txtort.Size = new System.Drawing.Size(100, 22);
            this.txtort.TabIndex = 10;
            // 
            // txtprj
            // 
            this.txtprj.Location = new System.Drawing.Point(106, 139);
            this.txtprj.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtprj.Name = "txtprj";
            this.txtprj.Size = new System.Drawing.Size(100, 22);
            this.txtprj.TabIndex = 9;
            // 
            // txtsnv3
            // 
            this.txtsnv3.Location = new System.Drawing.Point(106, 96);
            this.txtsnv3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsnv3.Name = "txtsnv3";
            this.txtsnv3.Size = new System.Drawing.Size(100, 22);
            this.txtsnv3.TabIndex = 8;
            // 
            // txtsnv2
            // 
            this.txtsnv2.Location = new System.Drawing.Point(106, 55);
            this.txtsnv2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsnv2.Name = "txtsnv2";
            this.txtsnv2.Size = new System.Drawing.Size(100, 22);
            this.txtsnv2.TabIndex = 7;
            // 
            // txtsnv1
            // 
            this.txtsnv1.Location = new System.Drawing.Point(106, 18);
            this.txtsnv1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsnv1.Name = "txtsnv1";
            this.txtsnv1.Size = new System.Drawing.Size(100, 22);
            this.txtsnv1.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(30, 221);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 18);
            this.label15.TabIndex = 5;
            this.label15.Text = "Durum :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(12, 180);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "Ortalama :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(42, 139);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "Proje :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(30, 98);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Sınav 3:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(30, 59);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Sınav 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(30, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sınav 1:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.btngncll);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(326, 313);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(220, 153);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MintCream;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(14, 110);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 24);
            this.button6.TabIndex = 18;
            this.button6.Text = "Listele";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btngncll
            // 
            this.btngncll.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btngncll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngncll.Location = new System.Drawing.Point(14, 82);
            this.btngncll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btngncll.Name = "btngncll";
            this.btngncll.Size = new System.Drawing.Size(190, 24);
            this.btngncll.TabIndex = 17;
            this.btngncll.Text = "Güncelle";
            this.btngncll.UseVisualStyleBackColor = false;
            this.btngncll.Click += new System.EventHandler(this.btngncll_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(14, 51);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 24);
            this.button4.TabIndex = 16;
            this.button4.Text = "Sil";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(14, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 24);
            this.button2.TabIndex = 15;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(554, 12);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Size = new System.Drawing.Size(454, 218);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(450, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btncks);
            this.groupBox6.Controls.Add(this.btnmsj);
            this.groupBox6.Controls.Add(this.btndyrlst);
            this.groupBox6.Controls.Add(this.btndyrolstr);
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.Location = new System.Drawing.Point(554, 236);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox6.Size = new System.Drawing.Size(454, 224);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.Location = new System.Drawing.Point(2, 18);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(450, 165);
            this.dataGridView2.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btndyrolstr
            // 
            this.btndyrolstr.BackColor = System.Drawing.Color.MintCream;
            this.btndyrolstr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndyrolstr.Location = new System.Drawing.Point(4, 194);
            this.btndyrolstr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btndyrolstr.Name = "btndyrolstr";
            this.btndyrolstr.Size = new System.Drawing.Size(119, 24);
            this.btndyrolstr.TabIndex = 19;
            this.btndyrolstr.Text = "Duyuru Oluştur";
            this.btndyrolstr.UseVisualStyleBackColor = false;
            this.btndyrolstr.Click += new System.EventHandler(this.btndyrolstr_Click);
            // 
            // btndyrlst
            // 
            this.btndyrlst.BackColor = System.Drawing.Color.MintCream;
            this.btndyrlst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndyrlst.Location = new System.Drawing.Point(127, 194);
            this.btndyrlst.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btndyrlst.Name = "btndyrlst";
            this.btndyrlst.Size = new System.Drawing.Size(105, 24);
            this.btndyrlst.TabIndex = 20;
            this.btndyrlst.Text = "Duyuru Listesi";
            this.btndyrlst.UseVisualStyleBackColor = false;
            this.btndyrlst.Click += new System.EventHandler(this.btndyrlst_Click);
            // 
            // btnmsj
            // 
            this.btnmsj.BackColor = System.Drawing.Color.MintCream;
            this.btnmsj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmsj.Location = new System.Drawing.Point(236, 194);
            this.btnmsj.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnmsj.Name = "btnmsj";
            this.btnmsj.Size = new System.Drawing.Size(105, 24);
            this.btnmsj.TabIndex = 21;
            this.btnmsj.Text = "Mesajlar";
            this.btnmsj.UseVisualStyleBackColor = false;
            this.btnmsj.Click += new System.EventHandler(this.btnmsj_Click);
            // 
            // btncks
            // 
            this.btncks.BackColor = System.Drawing.Color.Crimson;
            this.btncks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncks.Location = new System.Drawing.Point(345, 194);
            this.btncks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btncks.Name = "btncks";
            this.btncks.Size = new System.Drawing.Size(105, 24);
            this.btncks.TabIndex = 22;
            this.btncks.Text = "ÇIKIŞ";
            this.btncks.UseVisualStyleBackColor = false;
            this.btncks.Click += new System.EventHandler(this.btncks_Click);
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1018, 478);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmOgretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOgretmen";
            this.Load += new System.EventHandler(this.FrmOgretmen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LblNmr;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox MskOgrnNumara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnFtgrSec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnhspla;
        private System.Windows.Forms.TextBox txtdrm;
        private System.Windows.Forms.TextBox txtort;
        private System.Windows.Forms.TextBox txtprj;
        private System.Windows.Forms.TextBox txtsnv3;
        private System.Windows.Forms.TextBox txtsnv2;
        private System.Windows.Forms.TextBox txtsnv1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btngncll;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btndyrolstr;
        private System.Windows.Forms.Button btncks;
        private System.Windows.Forms.Button btnmsj;
        private System.Windows.Forms.Button btndyrlst;
    }
}