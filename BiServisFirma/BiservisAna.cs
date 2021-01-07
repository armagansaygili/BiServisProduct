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
    public partial class BiservisAna : Form
    {
        public BiservisAna()
        {
            InitializeComponent();
        }
        sqlcon con = new sqlcon();

        private void BiservisAna_Load(object sender, EventArgs e)
        {

            SqlCommand cmd1 = new SqlCommand("select * from personel where per_userName='" + PersonelGiris.perName + "'",con.baglan());
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                if (dr1["yetki"].ToString() == "Yönetici")
                {
                    perIs_btn.Visible = true;
                }
                else
                {
                    perIs_btn.Visible = false;
                }
            }

            Datagetir();
            Datagrid_ayar();
        }
        public void Datagetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("select randevu_id,bis_sahibi,bis_isim, tarih,saat, teslim_tarihi, durum from randevu", con.baglan());
            DataTable ds = new DataTable();
            da.Fill(ds);
            randevuDgv.DataSource = ds;

        }

        public void Datagrid_ayar()
        {
            randevuDgv.Columns[0].HeaderText = "Randevu Numarası";
            randevuDgv.Columns[1].HeaderText = "Bisiklet Sahibi";
            randevuDgv.Columns[2].HeaderText = "Bisiklet İsmi";
            randevuDgv.Columns[3].HeaderText = "Randevu Tarihi";
            randevuDgv.Columns[4].HeaderText = "Randevu Saati";
            randevuDgv.Columns[5].HeaderText = "Teslim Tarihi";
            randevuDgv.Columns[6].HeaderText = "Onarım Durumu";

            Font HeaderCellFont = new Font("Cambria", 10, FontStyle.Bold);
            for (int i = 0; i < randevuDgv.ColumnCount; i++)
            {
                randevuDgv.Columns[i].HeaderCell.Style.Font = HeaderCellFont;
            }

            randevuDgv.DefaultCellStyle.Font = new Font("Cambria", 9, FontStyle.Regular);
        }

        private void arizaEkle_btn_Click(object sender, EventArgs e)
        {
            string arizaBil = arizaBil_tbx.Text;
            string arizaUcret = arizaUcret_tbx.Text;
            SqlCommand cmd = new SqlCommand("Insert into onarim(ariza,ariza_ucret) values ('" + arizaBil + "','" + arizaUcret + "')", con.baglan());
            SqlDataReader dr = cmd.ExecuteReader();

            MessageBox.Show("Arıza/Bakım Hizmeti Eklendi.");

        }
        public static string musAd;
        public static string musSad;

        private void musBil_btn_Click(object sender, EventArgs e)
        {
            musAd = musAd_tbx.Text;
            musSad = musSad_tbx.Text;

            MusteriBilgi musteriBilgi = new MusteriBilgi();
            musteriBilgi.Show();
        }

        private void ranSil_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < randevuDgv.SelectedRows.Count; i++)
            {

                SqlCommand cmd = new SqlCommand("DELETE from randevu where randevu_id=" + randevuDgv.SelectedRows[i].Cells["randevu_id"].Value + "", con.baglan());                
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Close();
                SqlCommand cmd1 = new SqlCommand("DELETE from randevu_bakim where randevu_id=" + randevuDgv.SelectedRows[i].Cells["randevu_id"].Value + "", con.baglan());
                SqlDataReader dr1 = cmd1.ExecuteReader();
                MessageBox.Show("Randevu iptal edildi. Müşteri ile iletişim kurmayı unutmayın.");
                dr1.Close();

                Datagetir();

            }
        }

        private void BiservisAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public static int r_id;
        private void ranDetay_btn_Click(object sender, EventArgs e)
        {
            r_id = Convert.ToInt32(randevuDgv.CurrentRow.Cells["randevu_id"].Value);
            Detay detay = new Detay();
            detay.Show();
        }

        private void perIs_btn_Click(object sender, EventArgs e)
        {
            PerIslem perIslem = new PerIslem();
            perIslem.Show();
        }
    }
}
