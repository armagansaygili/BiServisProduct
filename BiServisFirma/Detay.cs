using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BiServisFirma
{
    public partial class Detay : Form
    {
        public Detay()
        {
            InitializeComponent();
        }
        sqlcon con = new sqlcon();
        int r_id = BiservisAna.r_id;
        public static string bis_sahibi;
        public static string tarih;
        private void Detay_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select randevu.randevu_id,randevu.bis_isim,randevu.tarih,randevu.saat, randevu_bakim.bakim, randevu_bakim.bakim_ucret, randevu.durum, randevu.teslim_tarihi from randevu inner join randevu_bakim on randevu.randevu_id = randevu_bakim.randevu_id where randevu.randevu_id=" + r_id + "", con.baglan());
            DataTable ds = new DataTable();
            da.Fill(ds);
            detayDgv.DataSource = ds;
            Datagrid_ayar();
            
            SqlCommand cmd = new SqlCommand("Select * from randevu where randevu_id='" + r_id + "'", con.baglan());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bis_sahibi = dr["bis_sahibi"].ToString();
                
            }
            dr.Close();
            MessageBox.Show(bis_sahibi);
            SqlCommand cmd1 = new SqlCommand("Select * from kullanici where user_name='" + bis_sahibi + "'", con.baglan());
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                isim_lbl.Text = dr1["kullanici_ad"].ToString();
                soyisim_lbl.Text = dr1["kullanici_sad"].ToString();
                telefon_lbl.Text = dr1["telefon"].ToString();
            }

            dr1.Close();

        }
        public void Datagrid_ayar()
        {
            detayDgv.Columns[0].HeaderText = "Randevu Numarası";

            detayDgv.Columns[1].HeaderText = "Bisiklet İsmi";
            detayDgv.Columns[2].HeaderText = "Randevu Tarihi";
            detayDgv.Columns[3].HeaderText = "Randevu Saati";
            detayDgv.Columns[4].HeaderText = "Yapılan İşlem";
            detayDgv.Columns[5].HeaderText = "Yapılan İşlem Ücreti";
            detayDgv.Columns[6].HeaderText = "Onarım Durumu";
            detayDgv.Columns[7].HeaderText = "Teslim Tarihi";

            Font HeaderCellFont = new Font("Cambria", 10, FontStyle.Bold);
            for (int i = 0; i < detayDgv.ColumnCount; i++)
            {
                detayDgv.Columns[i].HeaderCell.Style.Font = HeaderCellFont;
            }

            detayDgv.DefaultCellStyle.Font = new Font("Cambria", 9, FontStyle.Regular);
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            tarih = dateTimePicker1.Text;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    SqlCommand cmd = new SqlCommand("  Update randevu set teslim_tarihi='" + tarih +"' and durum='" + textBox2.Text+ "' where randevu_id="+ r_id +"", con.baglan());
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    this.Refresh();
        //    MessageBox.Show("Güncellemeleriniz gerçekleşti");
        //}
    }
}
