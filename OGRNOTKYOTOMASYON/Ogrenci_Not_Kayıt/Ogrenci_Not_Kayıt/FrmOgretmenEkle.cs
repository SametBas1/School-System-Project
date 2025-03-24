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
    public partial class FrmOgretmenEkle : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();

        public FrmOgretmenEkle()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            toolTip1.SetToolTip(button1, "Bu butona tıklayınca işlem gerçekleşir!");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.ControlDark;
        }
        ToolTip toolTip1 = new ToolTip();

        private void FrmOgretmenEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();

            {
                SqlCommand komut = new SqlCommand("INSERT INTO TblOgretmen (AD, SOYAD, NUMARA, SIFRE) VALUES (@p1, @p2, @p3, @p4)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p3", msknmr.Text);
                komut.Parameters.AddWithValue("@p4", txtsfr.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Öğretmen başarıyla eklendi!");
                this.Close();
            }
        }
    }
}
