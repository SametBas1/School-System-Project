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
    public partial class FrmDuyuruOlustur : Form
    {
        string id;
        SqlBaglantisi bgl = new SqlBaglantisi();
        public FrmDuyuruOlustur()
        {
            InitializeComponent();
        }

        private void FrmDuyuruOlustur_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            SqlCommand komut = new SqlCommand("Select * From TblDuyurular", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblDuyurular(ıcerik)values(@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",rchdyr.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            rchdyr.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            this.Text = id;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TblDuyurular where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", id);
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            Listele();
        }

        private void btngncll_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblDuyurular set ıcerik=@p1 where ID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", rchdyr.Text);
            komut.Parameters.AddWithValue("@p2",id);
            komut.ExecuteNonQuery();
            MessageBox.Show("Duyuru Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            Listele();
        }
    }
}
