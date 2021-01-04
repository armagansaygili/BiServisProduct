using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace BiServis
{
    public partial class Kullanici_giris : Form
    {
        public Kullanici_giris()
        {
            InitializeComponent();
        }


        public static string user_name;


        sqlcon baglan = new sqlcon();
        MySqlCommand cmd = new MySqlCommand();
        

        public void userPass_tbx_Enter(object sender, EventArgs e)
        {
            if (userPass_tbx.PlaceholderText == "Şifre")
            {
                userPass_tbx.PlaceholderText = "Şifre";
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



        private void uye_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Uye_kayit uye_Kayit = new Uye_kayit();
            uye_Kayit.ShowDialog();
        }

        private void grs_btn_Click(object sender, EventArgs e)
        {
            user_name = userName_tbx.Text;
            string user_pass = userPass_tbx.Text;

            cmd.Connection = baglan.baglan();
            cmd.CommandText = "SELECT * FROM kullanici where user_name='" + user_name + "' AND user_pass='" + user_pass + "'";
            MySqlDataReader dr = cmd.ExecuteReader();    
            if (dr.Read())
            {
                Musteri musteri = new Musteri();

                this.Refresh();
                this.Visible = false;
                musteri.ShowDialog();
            }
            else
            {
                MsgBox msgBox = new MsgBox();
                msgBox.Show();
            }
            
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
