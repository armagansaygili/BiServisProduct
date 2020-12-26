using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace BiServis
{   
    
    public partial class Randevu_list : Form
    {

        
        public Randevu_list()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0;Data Source=BiServis.accdb");

        string user_name = Kullanici_giris.user_name;
        private void Randevu_list_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select bis_isim, tarih,islem, ucret, teslim_tarihi, durum from randevu where bis_sahibi='" + user_name + "'", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables["randevu"];
            con.Close();

            dataGridView1.Columns[0].HeaderText = "Bisiklet ismi";
            dataGridView1.Columns[1].HeaderText = "Randevu tarihi";
            dataGridView1.Columns[2].HeaderText = "İşlem";
            dataGridView1.Columns[3].HeaderText = "İşlem Ücreti";
            dataGridView1.Columns[4].HeaderText = "Teslim tarihi";
            dataGridView1.Columns[5].HeaderText = "Onarım durumu";

            dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Cambria", 9, FontStyle.Bold);
            dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Cambria", 9, FontStyle.Bold);
            dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Cambria", 9, FontStyle.Bold);
            dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Cambria", 9, FontStyle.Bold);
            dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Cambria", 9, FontStyle.Bold);
            dataGridView1.Columns[5].HeaderCell.Style.Font = new Font("Cambria", 9, FontStyle.Bold);

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            Close();
            musteri.Visible = true;
            
        }

        private void randevuSil_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void YillikRapor_btn_Click(object sender, EventArgs e)
        {
            Yillik_rapor yillik_Rapor = new Yillik_rapor();
            this.Refresh();
            this.Visible = false;
            yillik_Rapor.ShowDialog();
        }
    }
}
