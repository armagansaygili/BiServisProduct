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

namespace BiServis
{
    public partial class Uye_kayit : Form
    {
        public Uye_kayit()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=BiServis.accdb");


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
                Form1 form = new Form1();
                form.Show();
            }
            else
            {
                if ((user_pass == user_pass1) & (MailKontrolu.EmailKontrol(mail)))
                {

                    if (con.State == ConnectionState.Closed) con.Open();
                    OleDbCommand sorgu = new OleDbCommand("SELECT * FROM kullanici where user_name='" + user_name + "'", con);
                    OleDbDataReader reader = sorgu.ExecuteReader();
                    if (reader.Read())
                    {

                        MsgKullaniciKullaniliyor msgKullaniciKullaniliyor = new MsgKullaniciKullaniliyor();
                        msgKullaniciKullaniliyor.Show();
                        
                    }
                    else
                    {
                        sorgu = new OleDbCommand("INSERT INTO kullanici(user_name,user_pass,kullanici_ad,kullanici_sad,kullanici_mail) values ('" + user_name + "','" + user_pass + "','" + k_adi + "','" + k_sadi + "','" + mail + "')", con);
                        OleDbDataReader dr = sorgu.ExecuteReader();
                        MsgKullaniciEkle msgKullaniciEkle = new MsgKullaniciEkle();
                        msgKullaniciEkle.Show();
                        Close();
                    }
                    con.Close();
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
