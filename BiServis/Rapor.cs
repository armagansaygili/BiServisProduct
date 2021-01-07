using System;
using System.Data;
using System.Data.SqlClient;
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


        sqlcon con = new sqlcon();
        string user_name = Kullanici_giris.user_name;
        int r_id = Randevu_list.deger;


        private void Rapor_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select randevu.bis_isim,randevu.tarih,randevu.saat, randevu_bakim.bakim, randevu_bakim.bakim_ucret, randevu.teslim_tarihi from randevu inner join randevu_bakim on randevu.randevu_id = randevu_bakim.randevu_id where randevu.randevu_id=" + r_id + "", con.baglan());
            DataTable ds = new DataTable();
            da.Fill(ds);
            dataGridView1.DataSource = ds;



            dataGridView1.Columns[0].HeaderText = "Bisiklet İsmi";
            dataGridView1.Columns[1].HeaderText = "Randevu Tarihi";
            dataGridView1.Columns[2].HeaderText = "Randevu Saati";
            dataGridView1.Columns[3].HeaderText = "Yapılan İşlem";
            dataGridView1.Columns[4].HeaderText = "Yapılan İşlem Ücreti";
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

        private void yillik_Rapor_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }


        Font Baslik = new Font("Cambria", 15, FontStyle.Bold);
        Font altBaslik = new Font("Cambria", 12, FontStyle.Regular);
        Font Icerik = new Font("Cambria", 10);
        SolidBrush sb = new SolidBrush(Color.Black);



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
            e.Graphics.DrawString("Yapılan İşlem", altBaslik, sb, 450, 250, st);
            e.Graphics.DrawString("Tutar", altBaslik, sb, 649, 250, st);
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------", altBaslik, sb, 150, 280, st);


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), Icerik, sb, 150, 300 + i * 30, st);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), Icerik, sb, 300, 300 + i * 30, st);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), Icerik, sb, 450, 300 + i * 30, st);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString() + " TL", Icerik, sb, 649, 300 + i * 30, st);
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.baglan();
            cmd.CommandText = "Select sum(bakim_ucret) from randevu_bakim where randevu_id=" + r_id + "";
            string toplam = cmd.ExecuteScalar().ToString();
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------", altBaslik, sb, 150, 300 + 30 * dataGridView1.Rows.Count, st);
            e.Graphics.DrawString("Toplam Harcamanız: " + toplam + " TL", Icerik, sb, 520, 300 + 30 * (dataGridView1.Rows.Count + 1), st);




        }

    }
}
