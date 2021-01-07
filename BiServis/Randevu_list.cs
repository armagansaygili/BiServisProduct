using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace BiServis
{

    public partial class Randevu_list : Form
    {
        string user_name = Kullanici_giris.user_name;
        int r_id = Randevu_list.deger;
        sqlcon con = new sqlcon();
        SqlCommand cmd = new SqlCommand();
        public void Datagetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("select randevu_id,bis_isim, tarih, teslim_tarihi, durum from randevu where bis_sahibi='" + user_name + "'", con.baglan());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }


        public void Bisiklet_secim()
        {
            cmd.Connection = con.baglan();
            cmd.CommandText = "SELECT * from bisiklet where bis_sahibi='" + user_name + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            comboBox1.Items.Add("Tümü");

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["bis_isim"]);
            }
            dr.Close();

            comboBox1.SelectedIndex = 0;
        }

        public void Datagrid_ayar()
        {
            dataGridView1.Columns[0].HeaderText = "Randevu Numarası";
            dataGridView1.Columns[1].HeaderText = "Bisiklet İsmi";
            dataGridView1.Columns[2].HeaderText = "Randevu Tarihi";
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

                cmd.Connection = con.baglan();
                cmd.CommandText = "select randevu_id from randevu";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox2.Items.Add(dr["randevu_id"]);
                }
                dr.Close();

            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("select randevu_id,bis_isim, tarih, teslim_tarihi, durum from randevu where bis_sahibi='" + user_name + "' AND bis_isim ='" + comboBox1.Text + "'", con.baglan());
                DataTable ds = new DataTable();
                da.Fill(ds);
                dataGridView1.DataSource = ds;

                comboBox2.Items.Clear();

                cmd.Connection = con.baglan();
                cmd.CommandText = "select randevu_id from randevu where bis_isim='" + comboBox1.Text + "'";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox2.Items.Add(dr["randevu_id"]);
                }
                dr.Close();
            }



        }


        private void randevuSil_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {

                cmd.Connection = con.baglan();
                cmd.CommandText = "DELETE from randevu where randevu_id=" + dataGridView1.SelectedRows[i].Cells["randevu_id"].Value + "";
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Close();
                SqlCommand cmd1 = new SqlCommand("DELETE from randevu_bakim where randevu_id=" + dataGridView1.SelectedRows[i].Cells["randevu_id"].Value + "", con.baglan());
                SqlDataReader dr1 = cmd1.ExecuteReader();
                MsgRanduvuSil msgRandevuSil = new MsgRanduvuSil();
                msgRandevuSil.Show();

                dr1.Close();
                comboBox1.SelectedIndex = 0;
                Datagetir();

            }

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

                    cmd.Connection = con.baglan();
                    cmd.CommandText = "Select sum(bakim_ucret) from randevu_bakim where randevu_id=" + comboBox2.Items[i] + "";
                    toplam = cmd.ExecuteScalar().ToString() + " TL";
                    e.Graphics.DrawString(toplam, Icerik, sb, 649, 300 + i * 30, st);

                }


            if (comboBox1.Text == "Tümü")
            {

                cmd.Connection = con.baglan();
                cmd.CommandText = "Select sum(bakim_ucret) from randevu_bakim where bis_sahibi='" + user_name + "'";
                toplam1 = cmd.ExecuteScalar().ToString();

            }
            else
            {
                cmd.Connection = con.baglan();
                cmd.CommandText = "Select sum(bakim_ucret) from randevu_bakim where bis_sahibi='" + user_name + "' AND bis_ismi='" + comboBox1.Text + "'";
                toplam1 = cmd.ExecuteScalar().ToString();
                
            }
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
