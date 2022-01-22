using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ceviri_Projesi
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-1MBBQE4\\SQLEXPRESS;Initial Catalog=Ceviri_Proje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
