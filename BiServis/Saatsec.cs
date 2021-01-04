using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BiServis
{
    public partial class Saatsec : Form
    {
        public Saatsec()
        {
            InitializeComponent();
        }
        sqlcon con = new sqlcon();

        public static string saat;
        string tarih = Musteri.tarih1;
        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region saat butonları

        private void btn10_Click(object sender, EventArgs e)
        {
            saat = btn10.ButtonText;
            Close();
        }

        private void btn1030_Click(object sender, EventArgs e)
        {
            saat = btn1030.ButtonText;
            Close();

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            saat = btn11.ButtonText;
            Close();

        }

        private void btn1130_Click(object sender, EventArgs e)
        {
            saat = btn1130.ButtonText;
            Close();

        }

        private void btn12_Click(object sender, EventArgs e)
        {
            saat = btn12.ButtonText;
            Close();

        }

        private void btn1230_Click(object sender, EventArgs e)
        {
            saat = btn1230.ButtonText;
            Close();

        }

        private void btn13_Click(object sender, EventArgs e)
        {
            saat = btn13.ButtonText;
            Close();

        }

        private void btn1330_Click(object sender, EventArgs e)
        {
            saat = btn1330.ButtonText;
            Close();

        }

        private void btn14_Click(object sender, EventArgs e)
        {
            saat = btn14.ButtonText;
            Close();

        }

        private void btn1430_Click(object sender, EventArgs e)
        {
            saat = btn1430.ButtonText;
            Close();

        }

        private void btn15_Click(object sender, EventArgs e)
        {
            saat = btn15.ButtonText;
            Close();

        }

        private void btn1530_Click(object sender, EventArgs e)
        {
            saat = btn1530.ButtonText;
            Close();

        }

        private void btn16_Click(object sender, EventArgs e)
        {
            saat = btn16.ButtonText;
            Close();

        }

        private void btn1630_Click(object sender, EventArgs e)
        {
            saat = btn1630.ButtonText;
            Close();

        }

        private void btn17_Click(object sender, EventArgs e)
        {
            saat = btn17.ButtonText;
            Close();

        }

        private void btn1730_Click(object sender, EventArgs e)
        {
            saat = btn1730.ButtonText;
            Close();

        }

        private void btn18_Click(object sender, EventArgs e)
        {
            saat = btn18.ButtonText;
            Close();

        }

        private void btn1830_Click(object sender, EventArgs e)
        {
            saat = btn1930.ButtonText;
            Close();

        }

        private void btn19_Click(object sender, EventArgs e)
        {
            saat = btn19.ButtonText;
            Close();

        }

        private void btn1930_Click(object sender, EventArgs e)
        {
            saat = btn1930.ButtonText;
            Close();

        }
        #endregion


        private void Saatsec_Load(object sender, EventArgs e)
        {
            saat = "";

            #region Saatlerin müsaitlik ayarı
            #region 10:00
            MySqlCommand cmd = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='10:00' ", con.baglan());
            int saat10 = Convert.ToInt32(cmd.ExecuteScalar());

            if (saat10 > 0)
            {
                btn10.Visible = false;
            }
            #endregion

            #region 10:30
            MySqlCommand cmd1 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='10:30' ", con.baglan());
            int saat1030 = Convert.ToInt32(cmd1.ExecuteScalar());

            if (saat1030 > 0)
            {
                btn1030.Visible = false;
            }
            #endregion

            #region 11:00
            MySqlCommand cmd2 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='11:00' ", con.baglan());
            int saat11 = Convert.ToInt32(cmd2.ExecuteScalar());

            if (saat11 > 0)
            {
                btn11.Visible = false;
            }
            #endregion

            #region 11:30
            MySqlCommand cmd3 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='11:30' ", con.baglan());
            int saat1130 = Convert.ToInt32(cmd3.ExecuteScalar());

            if (saat1130 > 0)
            {
                btn1130.Visible = false;
            }
            #endregion

            #region 12:00
            MySqlCommand cmd4 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='12:00' ", con.baglan());
            int saat1200 = Convert.ToInt32(cmd4.ExecuteScalar());

            if (saat1200 > 0)
            {
                btn12.Visible = false;
            }
            #endregion

            #region 12:30
            MySqlCommand cmd5 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='12:30' ", con.baglan());
            int saat1230 = Convert.ToInt32(cmd5.ExecuteScalar());

            if (saat1230 > 0)
            {
                btn1230.Visible = false;
            }
            #endregion

            #region 13:00
            MySqlCommand cmd6 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='13:00' ", con.baglan());
            int saat1300 = Convert.ToInt32(cmd6.ExecuteScalar());

            if (saat1300 > 0)
            {
                btn13.Visible = false;
            }           
            #endregion

            #region 13:30
            MySqlCommand cmd7 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='13:30' ", con.baglan());
            int saat1330 = Convert.ToInt32(cmd7.ExecuteScalar());

            if (saat1330 > 0)
            {
                btn1330.Visible = false;
            }
            #endregion

            #region 14:00
            MySqlCommand cmd8 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='14:00' ", con.baglan());
            int saat1400 = Convert.ToInt32(cmd8.ExecuteScalar());

            if (saat1400 > 0)
            {
                btn14.Visible = false;
            }
            #endregion

            #region 14:30
            MySqlCommand cmd9 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='14:30' ", con.baglan());
            int saat1430 = Convert.ToInt32(cmd9.ExecuteScalar());

            if (saat1430 > 0)
            {
                btn1430.Visible = false;
            }
            #endregion

            #region 15:00
            MySqlCommand cmd10 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='15:00' ", con.baglan());
            int saat15 = Convert.ToInt32(cmd10.ExecuteScalar());

            if (saat15 > 0)
            {
                btn15.Visible = false;
            }
            #endregion

            #region 15:30
            MySqlCommand cmd11 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='15:30' ", con.baglan());
            int saat1530 = Convert.ToInt32(cmd11.ExecuteScalar());

            if (saat1530 > 0)
            {
                btn1530.Visible = false;
            }
            #endregion

            #region 16:00
            MySqlCommand cmd12 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='16:00' ", con.baglan());
            int saat16 = Convert.ToInt32(cmd12.ExecuteScalar());

            if (saat16 > 0)
            {
                btn16.Visible = false;
            }
            #endregion

            #region 16:30
            MySqlCommand cmd13 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='16:30' ", con.baglan());
            int saat1630 = Convert.ToInt32(cmd13.ExecuteScalar());

            if (saat1630 > 0)
            {
                btn1630.Visible = false;
            }
            #endregion

            #region 17:00
            MySqlCommand cmd14 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='17:00' ", con.baglan());
            int saat17 = Convert.ToInt32(cmd14.ExecuteScalar());

            if (saat17 > 0)
            {
                btn17.Visible = false;
            }
            #endregion

            #region 17:30
            MySqlCommand cmd15 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='17:30' ", con.baglan());
            int saat1730 = Convert.ToInt32(cmd15.ExecuteScalar());

            if (saat1730 > 0)
            {
                btn1730.Visible = false;
            }
            #endregion

            #region 18:00
            MySqlCommand cmd16 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='18:00' ", con.baglan());
            int saat18 = Convert.ToInt32(cmd16.ExecuteScalar());

            if (saat18 > 0)
            {
                btn18.Visible = false;
            }
            #endregion

            #region 18:30
            MySqlCommand cmd17 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='18:30' ", con.baglan());
            int saat1830 = Convert.ToInt32(cmd17.ExecuteScalar());

            if (saat1830 > 0)
            {
                btn1830.Visible = false;
            }
            #endregion

            #region 19:00
            MySqlCommand cmd18 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='19:00' ", con.baglan());
            int saat19 = Convert.ToInt32(cmd18.ExecuteScalar());

            if (saat19 > 0)
            {
                btn19.Visible = false;
            }
            #endregion

            #region 19:30
            MySqlCommand cmd19 = new MySqlCommand("Select count(saat) from randevu where tarih='" + tarih + "' AND saat='19:30' ", con.baglan());
            int saat1930 = Convert.ToInt32(cmd19.ExecuteScalar());

            if (saat1930 > 0)
            {
                btn1930.Visible = false;
            }
            #endregion

            #endregion



        }
    }
}
