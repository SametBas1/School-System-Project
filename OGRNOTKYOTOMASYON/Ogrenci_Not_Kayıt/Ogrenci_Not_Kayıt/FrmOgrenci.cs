using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_Not_Kayıt
{
    public partial class FrmOgrenci : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string numara;
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            lblnmr.Text = numara;

            SqlCommand komut = new SqlCommand("Select * From TblOgrencı where Numara=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblhsgldnn.Text = dr[1] + " " + dr[2];
                pictureBox1.ImageLocation = dr[5].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select * From TblNotlar where OGRID=(Select ID From TblOgrencı Where Numara=@p1)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", lblnmr.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label11.Text = dr2[1].ToString();
                label12.Text = dr2[2].ToString();
                label13.Text = dr2[3].ToString();
                label14.Text = dr2[4].ToString();
                label15.Text = dr2[5].ToString();
            }
            bgl.baglanti().Close();
            
            if(Convert.ToDouble(label15.Text)  >= 50)
            {
                label16.Text = "Geçti";
            }
            else
            {
                label16.Text = "Kaldı";
            }
        }

        private void btnmsj_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.numara = lblnmr.Text;
            frm.Show();
        }

        private void btndyr_Click(object sender, EventArgs e)
        {
            FrmDuyuruListesi frm = new FrmDuyuruListesi();
            frm.Show();
        }

        private void btnhsp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btncks_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Gerçekten Kapatmak İstiyormusunuz ?", "UYARI !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
