using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BiServis
{
    public partial class Uye_kayit : Form
    {
        public Uye_kayit()
        {
            InitializeComponent();
        }


        sqlcon baglan = new sqlcon();
        MySqlCommand cmd = new MySqlCommand();

        public void userPass_tbx_Enter(object sender, EventArgs e)
        {
            if (userPass_tbx.PlaceholderText == "Şifre")
            {
                //userPass_tbx.PlaceholderText = "";
                userPass_tbx.UseSystemPasswordChar = true;
            }
        }

        public void userPass_tbx_Leave(object sender, EventArgs e)
        {
            if (userPass_tbx.Text == "")
            {
                userPass_tbx.PlaceholderText = "Şifre";
                userPass_tbx.UseSystemPasswordChar = false;
            }
        }

        public void userPass1_tbx_Enter(object sender, EventArgs e)
        {
            if (userPass1_tbx.PlaceholderText == "Şifre Tekrarı")
            {
                userPass1_tbx.PlaceholderText = "Şifre";
                userPass1_tbx.UseSystemPasswordChar = true;
            }
        }

        public void userPass1_tbx_Leave(object sender, EventArgs e)
        {
            if (userPass1_tbx.Text == "")
            {
                userPass1_tbx.PlaceholderText = "Şifre Tekrarı";
                userPass1_tbx.UseSystemPasswordChar = false;
            }
        }


        private void kayit_btn_Click(object sender, EventArgs e)
        {
            string user_name = userName_tbx.Text;
            string user_pass = userPass_tbx.Text;
            string user_pass1 = userPass1_tbx.Text;
            string k_adi = name_tbx.Text;
            string k_sadi = lastName_tbx.Text;
            string mail = mail_tbx.Text;


            if ((user_name == "") || (user_pass == "") || (k_adi == "") || (k_sadi == "") || (mail == ""))
            {
                MsgAlanDoldur form = new MsgAlanDoldur();
                form.Show();
            }
            else
            {
                if ((user_pass == user_pass1) & (MailKontrolu.EmailKontrol(mail)))
                {

                    cmd.Connection = baglan.baglan();
                    cmd.CommandText = "SELECT * FROM kullanici where user_name='" + user_name + "'";
                    cmd.ExecuteNonQuery();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    
                    if (dr.Read())
                    {

                        MsgKullaniciKullaniliyor msgKullaniciKullaniliyor = new MsgKullaniciKullaniliyor();
                        msgKullaniciKullaniliyor.Show();
                        

                    }
                    else
                    {
                        cmd.Connection = baglan.baglan();
                        cmd.CommandText = "INSERT INTO kullanici(user_name,user_pass,kullanici_ad,kullanici_sad,kullanici_mail) values ('" + user_name + "','" + user_pass + "','" + k_adi + "','" + k_sadi + "','" + mail + "')";
                        cmd.ExecuteNonQuery();
                        

                        MsgKullaniciEkle msgKullaniciEkle = new MsgKullaniciEkle();
                        msgKullaniciEkle.Show();
                        Close();
                    }
                    

                }
                else
                {
                    MsgYanlis msgYanlis = new MsgYanlis();
                    msgYanlis.Show();
                }
            }
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
