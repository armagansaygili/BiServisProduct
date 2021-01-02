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
        int r_id = Randevu_list.deger;

        public void Datagetir()
        {

            if (con.State == ConnectionState.Closed) con.Open();

            string user_name = Kullanici_giris.user_name;

            OleDbDataAdapter da = new OleDbDataAdapter("select randevu_id,bis_isim, tarih, teslim_tarihi, durum from randevu where bis_sahibi='" + user_name + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables["randevu"];
            con.Close();

        }

        //public int Hesapla()
        //{
        //    if (con.State == ConnectionState.Closed) con.Open();
        //    OleDbCommand cmd1 = new OleDbCommand("SELECT bakim_ucret from randevu_bakim where randevu_id=" + r_id + "", con);
        //    OleDbDataReader dr1 = cmd1.ExecuteReader();
        //    int toplam = 0;
        //    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
        //    {
        //        toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
        //    }
        //    con.Close();

        //    return toplam;
        //}

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
            //dataGridView1.Columns[3].HeaderText = "Yapılan İşlem";
            //dataGridView1.Columns[4].HeaderText = "İşlem Ücreti";
            dataGridView1.Columns[3].HeaderText = "Teslim Tarihi";
            dataGridView1.Columns[4].HeaderText = "Onarım Durumu";

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
            comboBox2.Visible = false;
            
            
            
        }       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Tümü")
            {
                Datagetir();
                if (con.State == ConnectionState.Closed) con.Open();

                OleDbCommand cmd = new OleDbCommand("select randevu_id from randevu", con);
                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox2.Items.Add(dr["randevu_id"]);
                }
                
                con.Close();
            }
            else
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select randevu_id,bis_isim, tarih, teslim_tarihi, durum from randevu where bis_sahibi='" + user_name + "' AND bis_isim ='" + comboBox1.Text + "'", con);
                DataSet ds = new DataSet();
                if (con.State == ConnectionState.Closed) con.Open();

                da.Fill(ds, "randevu");
                dataGridView1.DataSource = ds.Tables["randevu"];

                comboBox2.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("select randevu_id from randevu where bis_isim='"+comboBox1.Text+"'", con);
                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox2.Items.Add(dr["randevu_id"]);
                }
               
                con.Close();
            }

                       

        }


        private void randevuSil_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                if (con.State == ConnectionState.Closed) con.Open();

                OleDbCommand cmd1 = new OleDbCommand("DELETE * from randevu where randevu_id=" + dataGridView1.SelectedRows[i].Cells["randevu_id"].Value + "", con);
                OleDbCommand cmd2 = new OleDbCommand("DELETE * from randevu_bakim where randevu_id=" + dataGridView1.SelectedRows[i].Cells["randevu_id"].Value + "", con);

                OleDbDataReader dr1 = cmd1.ExecuteReader();
                OleDbDataReader dr2 = cmd2.ExecuteReader();
                MsgRanduvuSil msgRandevuSil = new MsgRanduvuSil();
                msgRandevuSil.Show();

                Datagetir();
            }

            //Hesapla();
            

        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            Close();
            musteri.Visible = true;
        }

        private void yillik_Rapor_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        Font Baslik = new Font("Cambria", 15, FontStyle.Bold);
        Font altBaslik = new Font("Cambria", 12, FontStyle.Regular);
        Font Icerik = new Font("Cambria", 10);
        SolidBrush sb = new SolidBrush(Color.Black);
        public static string toplam;
        public static string toplam1;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat st = new StringFormat();
            st.Alignment = StringAlignment.Near;

            DateTime bugun = DateTime.Now;
            e.Graphics.DrawString("BiServis", Baslik, sb, 353, 100, st);
            e.Graphics.DrawString(bugun.ToLongDateString(), Icerik, sb, 550, 107, st);

            e.Graphics.DrawString("--------------------------------------------------------------", altBaslik, sb, 353, 120, st);
            e.Graphics.DrawString("Tarih", altBaslik, sb, 150, 250, st);
            e.Graphics.DrawString("Bisiklet İsmi", altBaslik, sb, 300, 250, st);
            e.Graphics.DrawString("Tutar", altBaslik, sb, 649, 250, st);
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------", altBaslik, sb, 150, 280, st);


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), Icerik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), Icerik, sb, 300, 300 + i * 30, st);


                if (con.State == ConnectionState.Closed) con.Open();
                OleDbCommand cmd = new OleDbCommand("Select sum(bakim_ucret) from randevu_bakim where randevu_id=" + comboBox2.Items[i] + "", con);
                toplam = cmd.ExecuteScalar().ToString() + " TL";
                e.Graphics.DrawString(toplam, Icerik, sb, 649, 300 + i * 30, st);
                con.Close();
            }

            if (con.State == ConnectionState.Closed) con.Open();
            if (comboBox1.Text == "Tümü")
            {
                OleDbCommand cmd1 = new OleDbCommand("Select sum(bakim_ucret) from randevu_bakim where bis_sahibi='" + user_name + "'", con);
                toplam1 = cmd1.ExecuteScalar().ToString();


            }
            else {
                OleDbCommand cmd1 = new OleDbCommand("Select sum(bakim_ucret) from randevu_bakim where bis_sahibi='" + user_name + "' AND bis_ismi='" +comboBox1.Text + "'", con);
                toplam1 = cmd1.ExecuteScalar().ToString();
            }
            con.Close();


            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------", altBaslik, sb, 150, 300 + 30 * dataGridView1.Rows.Count, st);
            e.Graphics.DrawString("Toplam Harcamanız: " + toplam1 + " TL", Icerik, sb, 520, 300 + 30 * (dataGridView1.Rows.Count + 1), st);
            



        }
        public static int deger;
        private void detay_btn_Click(object sender, EventArgs e)
        {

            deger = Convert.ToInt32(dataGridView1.CurrentRow.Cells["randevu_id"].Value);
            


            Rapor rapor = new Rapor();
            rapor.Show();

            
        }
    }
}
