using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiServis
{
    public partial class Kullanici_giris : Form
    {
        public Kullanici_giris()
        {
            InitializeComponent();
        }

        OleDbConnection con= new OleDbConnection("Provider= Microsoft.ACE.Oledb.12.0;Data Source=BiServis.accdb");
        public static string user_name;

        private void grs_btn_Click(object sender, EventArgs e)
        {
            user_name = userName_tbx.Text;
            string user_pass = userPass_tbx.Text;
             
            if (con.State == ConnectionState.Closed) con.Open(); 
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM kullanici where user_name='" + user_name + "' AND user_pass='" + user_pass + "'" ,con);          
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
                MessageBox.Show("Kullanıcı adı veya şifre yanlış","Bilgi");
            }
            con.Close();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uye_kayit uye_Kayit = new Uye_kayit();
            uye_Kayit.ShowDialog();
        }
    }
}
