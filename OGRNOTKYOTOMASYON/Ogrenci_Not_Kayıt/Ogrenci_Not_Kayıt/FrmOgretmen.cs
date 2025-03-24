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
    public partial class FrmOgretmen : Form
    {
        public string numara;
        string Fotograf;
        SqlBaglantisi bgl = new SqlBaglantisi();
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            LblNmr.Text = numara;
            OgrenciListesi();
            NotListesi();
            SqlCommand komut = new SqlCommand("Select * from TblOgretmen where Numara=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
            }
   
            bgl.baglanti().Close();

        }
        void OgrenciListesi()
        {
            SqlCommand komut = new SqlCommand("Select * from TblOgrencı ", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void NotListesi()
        {
            SqlCommand komut = new SqlCommand("Execute Ogrenciler",bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void BtnFtgrSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Fotograf = openFileDialog1.FileName;
            pictureBox1.ImageLocation = Fotograf;
        }

        private void button2_Click(object sender, EventArgs e) //kaydetme butonu
        {
            SqlCommand komut = new SqlCommand("insert into TblOgrencı(ad,soyad,numara,sıfre,fotograf) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtad.Text);
            komut.Parameters.AddWithValue("@p2",txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3",MskOgrnNumara.Text);
            komut.Parameters.AddWithValue("@p4",txtsifre.Text);
            komut.Parameters.AddWithValue("@p5",Fotograf);
            komut.ExecuteNonQuery();
            
            MessageBox.Show("Öğrenci Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            OgrenciListesi();
            NotListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskOgrnNumara.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            
            bgl.baglanti().Close();
        }


        private void btnhspla_Click(object sender, EventArgs e)
        {
            double sınav1, sınav2, sınav3, proje, ortalama;
            sınav1 = Convert.ToDouble(txtsnv1.Text);
            sınav2 = Convert.ToDouble(txtsnv2.Text);
            sınav3 = Convert.ToDouble(txtsnv3.Text);
            proje = Convert.ToDouble(txtprj.Text);
            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
            txtort.Text = ortalama.ToString();  
            if (ortalama >= 50)
            {
                txtdrm.Text = "Geçti";
            }
            else
            {
                txtdrm.Text = "Kaldı";
            }
        }

        private void btngncll_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblOgrencı set ad=@p1,soyad=@p2,sıfre=@p3 where Numara=@p5",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtsifre.Text);
            //komut.Parameters.AddWithValue("@p4", Fotograf);
            komut.Parameters.AddWithValue("@p5", MskOgrnNumara.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("update TblNotlar set Sınav1=@p1,Sınav2=@p2,Sınav3=@p3,Proje=@p4,Ortalama=@p5,Durum=@p6 where OGRID = (Select TOP 1 ID from TblOgrencı Where Numara=@p7)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtsnv1.Text);
            komut2.Parameters.AddWithValue("@p2", txtsnv2.Text);
            komut2.Parameters.AddWithValue("@p3", txtsnv3.Text);
            komut2.Parameters.AddWithValue("@p4", txtprj.Text);
            komut2.Parameters.AddWithValue("@p5", Convert.ToDecimal(txtort.Text));
            komut2.Parameters.AddWithValue("@p6", txtdrm.Text);
            komut2.Parameters.AddWithValue("@p7", MskOgrnNumara.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
            OgrenciListesi();
            NotListesi();
        }

        private void btndyrolstr_Click(object sender, EventArgs e)
        {
            FrmDuyuruOlustur frm = new FrmDuyuruOlustur();
            frm.Show();
        }

        private void btndyrlst_Click(object sender, EventArgs e)
        {
            FrmDuyuruListesi frm = new FrmDuyuruListesi();
            frm.Show(); 
        }

        private void btnmsj_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.numara = LblNmr.Text; 
            frm.Show();
        }

        private void btncks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
