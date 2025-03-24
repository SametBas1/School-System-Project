using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Not_Kayıt
{
     class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=SAMET\SQLEXPRESS;Initial Catalog=OgrenciNotKayıt;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
    }
}
