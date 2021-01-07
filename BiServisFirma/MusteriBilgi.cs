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
    public partial class MusteriBilgi : Form
    {
        public MusteriBilgi()
        {
            InitializeComponent();
        }
        sqlcon con = new sqlcon();
        private void MusteriBilgi_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from kullanici where kullanici_ad='"+BiservisAna.musAd+"' and kullanici_sad='"+BiservisAna.musSad+ "'", con.baglan());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                kullaniciAdi_tbx.Text = dr["user_name"].ToString();
                ad_tbx.Text = dr["kullanici_ad"].ToString();
                sad_tbx.Text = dr["kullanici_sad"].ToString();
                tel_tbx.Text = dr["telefon"].ToString();
                mail_tbx.Text = dr["kullanici_mail"].ToString();

            }

        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
