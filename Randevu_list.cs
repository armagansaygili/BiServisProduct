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

        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0;Data Source=BiServis.accdb");
        string user_name = Kullanici_giris.user_name;

        public void Datagetir()
        {

            if (con.State == ConnectionState.Closed) con.Open();

            string user_name = Kullanici_giris.user_name;

            OleDbDataAdapter da = new OleDbDataAdapter("select randevu_id,bis_isim, tarih,islem, ucret, teslim_tarihi, durum from randevu where bis_sahibi='" + user_name + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables["randevu"];
            con.Close();

        }

        public void Hesapla()
        {
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            toplam_lbl.Text = toplam.ToString() + " TL";
            toplam_lbl.Visible = true;

            int satir = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                satir = (dataGridView1.RowCount);

            }
            randevu_lbl.Text = satir.ToString();
            randevu_lbl.Visible = true;
        }

        public void Bisiklet_secim()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand cmd1 = new OleDbCommand("SELECT * from bisiklet where bis_sahibi='" + user_name + "'", con);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            comboBox1.Items.Add("Tümü");

            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1["bis_isim"]);
            }
            con.Close();

            comboBox1.SelectedIndex = 0;
        }

        public void Datagrid_ayar()
        {
            dataGridView1.Columns[0].HeaderText = "Randevu Numarası";
            dataGridView1.Columns[1].HeaderText = "Bisiklet İsmi";
            dataGridView1.Columns[2].HeaderText = "Randevu Tarihi";
            dataGridView1.Columns[3].HeaderText = "Yapılan İşlem";
            dataGridView1.Columns[4].HeaderText = "İşlem Ücreti";
            dataGridView1.Columns[5].HeaderText = "Teslim Tarihi";
            dataGridView1.Columns[6].HeaderText = "Onarım Durumu";

            Font HeaderCellFont = new Font("Cambria", 10, FontStyle.Bold);
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].HeaderCell.Style.Font = HeaderCellFont;
            }                      

            dataGridView1.DefaultCellStyle.Font = new Font("Cambria", 10, FontStyle.Regular);
        }


        public Randevu_list()
        {
            InitializeComponent();
        }

        
        private void Randevu_list_Load(object sender, EventArgs e)
        {


            Bisiklet_secim();
            Datagrid_ayar();
            Datagetir();
            
            
        }       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Tümü")
            {
                Datagetir();
                con.Close();
            }
            else
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select randevu_id,bis_isim, tarih,islem, ucret, teslim_tarihi, durum from randevu where bis_sahibi='" + user_name + "' AND bis_isim ='" + comboBox1.Text + "'", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds, "randevu");
                dataGridView1.DataSource = ds.Tables["randevu"];
                con.Close();
            }

            Hesapla();

        }


        private void randevuSil_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                if (con.State == ConnectionState.Closed) con.Open();

                OleDbCommand cmd1 = new OleDbCommand("DELETE * from randevu where randevu_id=" + dataGridView1.SelectedRows[i].Cells["randevu_id"].Value + "", con);
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                MessageBox.Show("Randevu iptal edildi.");
                Datagetir();
            }

            Hesapla();
            

        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            Close();
            musteri.Visible = true;
        }        
    }
}
