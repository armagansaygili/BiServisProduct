using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace BiServis
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }




        private void randevuSil_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0;Data Source=BiServis.accdb");
        string user_name = Kullanici_giris.user_name;
        int r_id = Randevu_list.deger;


        private void Rapor_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select randevu.bis_isim,randevu.tarih, randevu_bakim.bakim, randevu_bakim.bakim_ucret, randevu.durum, randevu.teslim_tarihi from randevu inner join randevu_bakim on randevu.randevu_id = randevu_bakim.randevu_id where randevu.randevu_id=" + r_id + "", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables["randevu"];

            con.Close();

            dataGridView1.Columns[0].HeaderText = "Bisiklet İsmi";
            dataGridView1.Columns[1].HeaderText = "Randevu Tarihi";
            dataGridView1.Columns[2].HeaderText = "Yapılan İşlem";
            dataGridView1.Columns[3].HeaderText = "Yapılan İşlem Ücreti";
            dataGridView1.Columns[4].HeaderText = "Onarım Durumu";
            dataGridView1.Columns[5].HeaderText = "Teslim Tarihi";


            Font HeaderCellFont = new Font("Cambria", 10, FontStyle.Bold);

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].HeaderCell.Style.Font = HeaderCellFont;
            }
            dataGridView1.DefaultCellStyle.Font = new Font("Cambria", 10, FontStyle.Regular);

        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
