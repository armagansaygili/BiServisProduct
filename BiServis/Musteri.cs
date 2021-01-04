using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BiServis
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        sqlcon baglan = new sqlcon();
        MySqlCommand cmd = new MySqlCommand();

        private void Musteri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        string user_name = Kullanici_giris.user_name;

        private void Musteri_Load(object sender, EventArgs e)
        {

            cmd.Connection = baglan.baglan();
            cmd.CommandText = "SELECT * FROM onarim";
            MySqlDataReader dr = cmd.ExecuteReader();
            

            while (dr.Read())
            {
                checkedListBox1.Items.Add(dr["bakim"]);
            }
            dr.Close();


            cmd.CommandText = "SELECT * FROM bisiklet where bis_sahibi='" + user_name + "'";
            MySqlDataReader dr1 = cmd.ExecuteReader();

            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1["bis_isim"]);
              
            }
            dr1.Close();

            checkedListBox1.Font = new Font("Cambria", 9, FontStyle.Bold);


        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {

            cmd.Connection = baglan.baglan();
            cmd.CommandText = "INSERT INTO bisiklet(bis_sahibi,bis_isim,bis_marka,bis_model,bis_yil,on_aktarici,arka_aktarici,fren_seti,jant_seti) values ('" + user_name + "','" + isim_tbx.Text + "','" + marka_tbx.Text + "','"
                + model_tbx.Text + "','" + yil_tbx.Text + "','" + onAk_tbx.Text + "','" + arAk_tbx.Text + "','" + fren_tbx.Text + "','" + jant_tbx.Text + "')";
            MySqlDataReader dr = cmd.ExecuteReader();

            comboBox1.Items.Add(isim_tbx.Text);

            MsgBisEkle msgBisEkle = new MsgBisEkle();
            msgBisEkle.Show();
        }

        private void randevuList_btn_Click(object sender, EventArgs e)
        {
            Randevu_list randevu_List = new Randevu_list();
            this.Refresh();
            this.Visible = false;
            randevu_List.ShowDialog();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void randevu_btn_Click(object sender, EventArgs e)
        {

            //sqlcon con = new sqlcon();
            cmd.Connection = baglan.baglan();
            cmd.CommandText = "SELECT * from bisiklet where bis_isim='" + comboBox1.Text + "'";
            MySqlDataReader bis_ismidr = cmd.ExecuteReader();

            string tarih = dateTimePicker1.Text;
            while (bis_ismidr.Read())
            {

                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO randevu(bis_sahibi,bis_isim,tarih) values ('" + user_name + "','" + bis_ismidr["bis_isim"] + "','" + tarih + "')", baglan.baglan()); 
                MySqlDataReader dr2 = cmd1.ExecuteReader();

                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    MySqlCommand cmd2 = new MySqlCommand("SELECT randevu_id FROM randevu ORDER BY randevu_id DESC LIMIT 1", baglan.baglan());
                    MySqlDataReader randevu_iddr = cmd2.ExecuteReader();

                    MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM `onarim` WHERE `bakim`='" + checkedListBox1.CheckedItems[i] + "'", baglan.baglan());
                    MySqlDataReader ucretdr = cmd3.ExecuteReader();

                    while (ucretdr.Read() && randevu_iddr.Read())
                    {

                        MySqlCommand cmd4 = new MySqlCommand("INSERT INTO randevu_bakim(randevu_id,bis_sahibi,bis_ismi,bakim,bakim_ucret) values ('" + randevu_iddr["randevu_id"] + "','" + user_name + "','" + comboBox1.Text + "','" + checkedListBox1.CheckedItems[i] + "','" + ucretdr["ariza_ucret"] + "')", baglan.baglan());
                        MySqlDataReader dr3 = cmd4.ExecuteReader();
                        dr3.Close();

                    }
                    ucretdr.Close();
                    randevu_iddr.Close();

                }
                dr2.Close();
                MsgRandevu msgRandevu = new MsgRandevu();
                msgRandevu.Show();

            }
            bis_ismidr.Close();
        }
    }
}

