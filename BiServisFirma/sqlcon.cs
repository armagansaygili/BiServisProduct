using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace BiServisFirma
{
    public class sqlcon
    {
        public SqlConnection baglan()
        {
            
            SqlConnection baglanti = new SqlConnection("Server=localhost;Database=biservis;Trusted_Connection=True");
            baglanti.Open();
            SqlConnection.ClearPool(baglanti);
            SqlConnection.ClearAllPools();
            return (baglanti);
        }
    }
}
