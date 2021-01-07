using System.Data.SqlClient;

namespace BiServis
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
