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
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }
        sqlcon con = new sqlcon();
        private void girisBtn_Click(object sender, EventArgs e)
        {
            string user_name = userName_tbx.Text;
            string user_pass = userPass_tbx.Text;

            SqlCommand cmd = new SqlCommand("SELECT * FROM personel where per_userName='" + user_name + "' AND per_sifre='" + user_pass + "'", con.baglan());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                BiservisAna biservisAna = new BiservisAna();

                this.Refresh();
                this.Visible = false;
                biservisAna.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
