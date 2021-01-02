using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace BiServis
{
    public partial class Kullanici_giris : Form
    {
        public Kullanici_giris()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider= Microsoft.ACE.Oledb.12.0;Data Source=BiServis.accdb");
        public static string user_name;


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

            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM kullanici where user_name='" + user_name + "' AND user_pass='" + user_pass + "'", con);
            OleDbDataReader dr = cmd.ExecuteReader();
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
            con.Close();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
