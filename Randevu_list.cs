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
            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand cmd1 = new OleDbCommand("SELECT * from bisiklet where bis_sahibi='" + user_name + "'", con);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            comboBox1.Items.Add("Tümü");

            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1["bis_isim"]);
            }


            OleDbDataAdapter da = new OleDbDataAdapter("select bis_isim, tarih,islem, ucret, teslim_tarihi, durum from randevu where bis_sahibi='" + user_name + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables["randevu"];


            con.Close();

            dataGridView1.Columns[0].HeaderText = "Bisiklet İsmi";
            dataGridView1.Columns[1].HeaderText = "Randevu Tarihi";
            dataGridView1.Columns[2].HeaderText = "Yapılan İşlem";
            dataGridView1.Columns[3].HeaderText = "İşlem Ücreti";
            dataGridView1.Columns[4].HeaderText = "Teslim Tarihi";
            dataGridView1.Columns[5].HeaderText = "Onarım Durumu";

            dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Cambria", 10, FontStyle.Bold);
            dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Cambria", 10, FontStyle.Bold);
            dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Cambria", 10, FontStyle.Bold);
            dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Cambria", 10, FontStyle.Bold);
            dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Cambria", 10, FontStyle.Bold);
            dataGridView1.Columns[5].HeaderCell.Style.Font = new Font("Cambria", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Cambria", 10, FontStyle.Regular);

            }


        private void randevuSil_btn_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand cmd1 = new OleDbCommand("DELETE from randevu where bis_isim='" + dataGridView1.SelectedRows + "'", con);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            MessageBox.Show("Randevu iptal edildi.");
            this.Controls.Clear();
            this.InitializeComponent();
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Tümü")
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select bis_isim, tarih,islem, ucret, teslim_tarihi, durum from randevu where bis_sahibi='" + user_name + "'", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds, "randevu");
                dataGridView1.DataSource = ds.Tables["randevu"];
                con.Close();
            }
            else
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select bis_isim, tarih,islem, ucret, teslim_tarihi, durum from randevu where bis_sahibi='" + user_name + "' AND bis_isim ='" + comboBox1.Text + "'", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds, "randevu");
                dataGridView1.DataSource = ds.Tables["randevu"];
                con.Close();
            }

            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
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

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            Close();
            musteri.Visible = true;
        }
    }
}
