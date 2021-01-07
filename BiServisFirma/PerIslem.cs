using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiServisFirma
{
    public partial class PerIslem : Form
    {

        sqlcon con = new sqlcon();
        public static string tarih; 

        public PerIslem()
        {
            InitializeComponent();
        }

        private void PerIslem_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From personel",con.baglan());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["per_userName"]);
            }
            dr.Close();

            comboBox2.Items.Add("Yönetici");
            comboBox2.Items.Add("Çalışan");

        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            string user_name = perAdi_tbx.Text;
            string user_pass = perSifre_tbx.Text;
            string user_pass1 = perSTekrar_tbx.Text;
            string k_adi = perAdi_tbx.Text;
            string k_sadi = perSadi_tbx.Text;
            string mail = perMail_tbx.Text;
            string tel = perTel_tbx.Text;


            if ((user_name == "") || (user_pass == "") || (k_adi == "") || (k_sadi == "") || (mail == "") || (tel == ""))
            {
                MessageBox.Show("Tüm alanları doldurunuz.","Bilgi");
            }
            else
            {
                if ((user_pass == user_pass1) & (MailKontrolu.EmailKontrol(mail)))
                {

                    con.baglan();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM personel where per_userName='" + user_name + "'", con.baglan());
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {

                        MessageBox.Show("Personel bulunuyor.", "Bilgi");


                    }
                    else
                    {
                        dr.Close();
                        SqlCommand cmd1 = new SqlCommand("INSERT INTO personel(per_userName,per_sifre,per_adi,per_soyadi,per_giris,telefon,per_mail,yetki) values ('" + k_adi + "','" + user_pass + "','" + user_name + "','" + k_sadi + "','" + tarih + "','" + tel + "','" + mail + "','" + comboBox2.Text + "')", con.baglan());
                        cmd1.ExecuteReader();

                        MessageBox.Show("Personel başarıyla eklendi.", "Bilgi");
                        Close();
                    }
                    con.baglan().Close();


                }
                else
                {
                    MessageBox.Show("Şifre ve Mail alanlarını kontrol ediniz.", "Bilgi");
                }
            }
        }
       
        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            tarih = dateTimePicker1.Text;
        }
    }
}
