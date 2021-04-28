using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kargo_takip_otomasyonu
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-S95JB6JC\\SQLEXPRESS;Initial Catalog=KargoOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
