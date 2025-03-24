namespace Ogrenci_Not_Kayıt
{
    partial class FrmDuyuruOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuyuruOlustur));
            this.rchdyr = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngncll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchdyr
            // 
            this.rchdyr.Location = new System.Drawing.Point(0, 0);
            this.rchdyr.Name = "rchdyr";
            this.rchdyr.Size = new System.Drawing.Size(372, 131);
            this.rchdyr.TabIndex = 0;
            this.rchdyr.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(520, 186);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(3, 6);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(116, 23);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.IndianRed;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(125, 6);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(116, 23);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngncll
            // 
            this.btngncll.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btngncll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngncll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngncll.Location = new System.Drawing.Point(247, 6);
            this.btngncll.Name = "btngncll";
            this.btngncll.Size = new System.Drawing.Size(122, 23);
            this.btngncll.TabIndex = 4;
            this.btngncll.Text = "GÜNCELLE";
            this.btngncll.UseVisualStyleBackColor = false;
            this.btngncll.Click += new System.EventHandler(this.btngncll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(378, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnekle);
            this.panel1.Controls.Add(this.btnsil);
            this.panel1.Controls.Add(this.btngncll);
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 33);
            this.panel1.TabIndex = 6;
            // 
            // FrmDuyuruOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(521, 352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rchdyr);
            this.Name = "FrmDuyuruOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDuyuruOlustur";
            this.Load += new System.EventHandler(this.FrmDuyuruOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchdyr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngncll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}