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
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
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
                        MessageBox.Show("Kullanıcı adı kullanılıyor.");
                    }
                    else
                    {
                        sorgu = new OleDbCommand("INSERT INTO kullanici(user_name,user_pass,kullanici_ad,kullanici_sad,kullanici_mail) values ('" + user_name + "','" + user_pass + "','" + k_adi + "','" + k_sadi + "','" + mail + "')", con);
                        OleDbDataReader dr = sorgu.ExecuteReader();
                        MessageBox.Show("Kullanıcı eklendi", "Bilgi");
                        Close();
                    }
                    con.Close();
                }
                else
                {


                    MessageBox.Show("Girdiğiniz şifreler uyuşmuyor veya mail adresiniz yanlış girilmiş.");

                }
            }
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
