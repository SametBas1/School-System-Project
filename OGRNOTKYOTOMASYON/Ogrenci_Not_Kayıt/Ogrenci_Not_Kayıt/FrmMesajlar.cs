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
    public partial class FrmMesajlar : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string numara;

        public FrmMesajlar()
        {
            InitializeComponent();
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text= numara;
            GelenMesajlar();
            GidenMesajlar();

        }
        void GelenMesajlar()
        {
            SqlCommand komut = new SqlCommand("Select * From TblMesajlar Where Alıcı=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void GidenMesajlar()
        {
            SqlCommand komut = new SqlCommand("Select * From TblMesajlar Where Gonderen=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblMesajlar(Gonderen,Alıcı,Baslık,Icerık) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",maskedTextBox1.Text); 
            komut.Parameters.AddWithValue("@p2",maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p3",textBox1.Text);
            komut.Parameters.AddWithValue("@p4",richTextBox1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Mesajınız İletildi ...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            GelenMesajlar();
            GidenMesajlar();
        }
    }
}
