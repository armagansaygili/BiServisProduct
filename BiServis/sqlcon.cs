using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BiServis
{
    public class sqlcon
    {
        public MySqlConnection baglan()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=biservis;user=root;Pwd='';SslMode=none");

            baglanti.Open();
            MySqlConnection.ClearPool(baglanti);
            MySqlConnection.ClearAllPools();
            return (baglanti);
        }
    }
}
