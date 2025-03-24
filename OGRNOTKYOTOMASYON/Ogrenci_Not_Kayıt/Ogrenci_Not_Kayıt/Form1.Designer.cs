namespace Ogrenci_Not_Kayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnOgretmenGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MskOgretmenNumara = new System.Windows.Forms.MaskedTextBox();
            this.TxtOgretmenSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOgrenciGiris = new System.Windows.Forms.Button();
            this.MskOgrenciNumara = new System.Windows.Forms.MaskedTextBox();
            this.TxtOgrenciSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BtnOgretmenGiris);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MskOgretmenNumara);
            this.groupBox1.Controls.Add(this.TxtOgretmenSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(446, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnOgretmenGiris
            // 
            this.BtnOgretmenGiris.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnOgretmenGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOgretmenGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgretmenGiris.Location = new System.Drawing.Point(286, 104);
            this.BtnOgretmenGiris.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOgretmenGiris.Name = "BtnOgretmenGiris";
            this.BtnOgretmenGiris.Size = new System.Drawing.Size(154, 33);
            this.BtnOgretmenGiris.TabIndex = 2;
            this.BtnOgretmenGiris.Text = "Giriş Yap";
            this.BtnOgretmenGiris.UseVisualStyleBackColor = false;
            this.BtnOgretmenGiris.Click += new System.EventHandler(this.BtnOgretmenGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Öğretmen";
            // 
            // MskOgretmenNumara
            // 
            this.MskOgretmenNumara.Location = new System.Drawing.Point(286, 35);
            this.MskOgretmenNumara.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MskOgretmenNumara.Mask = "0000";
            this.MskOgretmenNumara.Name = "MskOgretmenNumara";
            this.MskOgretmenNumara.Size = new System.Drawing.Size(154, 22);
            this.MskOgretmenNumara.TabIndex = 4;
            // 
            // TxtOgretmenSifre
            // 
            this.TxtOgretmenSifre.Location = new System.Drawing.Point(286, 76);
            this.TxtOgretmenSifre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtOgretmenSifre.Name = "TxtOgretmenSifre";
            this.TxtOgretmenSifre.Size = new System.Drawing.Size(154, 22);
            this.TxtOgretmenSifre.TabIndex = 3;
            this.TxtOgretmenSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(214, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(186, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numara:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnOgrenciGiris);
            this.groupBox2.Controls.Add(this.MskOgrenciNumara);
            this.groupBox2.Controls.Add(this.TxtOgrenciSifre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(446, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BtnOgrenciGiris
            // 
            this.BtnOgrenciGiris.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnOgrenciGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOgrenciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgrenciGiris.Location = new System.Drawing.Point(286, 106);
            this.BtnOgrenciGiris.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOgrenciGiris.Name = "BtnOgrenciGiris";
            this.BtnOgrenciGiris.Size = new System.Drawing.Size(154, 33);
            this.BtnOgrenciGiris.TabIndex = 6;
            this.BtnOgrenciGiris.Text = "Giriş Yap";
            this.BtnOgrenciGiris.UseVisualStyleBackColor = false;
            this.BtnOgrenciGiris.Click += new System.EventHandler(this.BtnOgrenciGiris_Click);
            // 
            // MskOgrenciNumara
            // 
            this.MskOgrenciNumara.Location = new System.Drawing.Point(286, 37);
            this.MskOgrenciNumara.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MskOgrenciNumara.Mask = "0000";
            this.MskOgrenciNumara.Name = "MskOgrenciNumara";
            this.MskOgrenciNumara.Size = new System.Drawing.Size(154, 22);
            this.MskOgrenciNumara.TabIndex = 9;
            // 
            // TxtOgrenciSifre
            // 
            this.TxtOgrenciSifre.Location = new System.Drawing.Point(286, 78);
            this.TxtOgrenciSifre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtOgrenciSifre.Name = "TxtOgrenciSifre";
            this.TxtOgrenciSifre.Size = new System.Drawing.Size(154, 22);
            this.TxtOgrenciSifre.TabIndex = 8;
            this.TxtOgrenciSifre.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(214, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(186, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numara:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Öğrenci";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(286, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Yeni Öğretmen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Not Sistemi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskOgretmenNumara;
        private System.Windows.Forms.TextBox TxtOgretmenSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnOgretmenGiris;
        private System.Windows.Forms.Button BtnOgrenciGiris;
        private System.Windows.Forms.MaskedTextBox MskOgrenciNumara;
        private System.Windows.Forms.TextBox TxtOgrenciSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

