using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace BiServis
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        private void Musteri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0;Data Source=BiServis.accdb");
        string user_name = Kullanici_giris.user_name;

        private void Musteri_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM onarim", con);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //comboBox2.Items.Add(dr["ariza"]);
                checkedListBox1.Items.Add(dr["ariza"]);
            }


            OleDbCommand cmd1 = new OleDbCommand("SELECT * from bisiklet where bis_sahibi='" + user_name + "'", con);
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1["bis_isim"]);
            }
            con.Close();
            checkedListBox1.Font = new Font("Cambria", 9, FontStyle.Bold);


        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO bisiklet(bis_sahibi,bis_isim,bis_marka,bis_model,bis_yil,on_aktarici,arka_aktarici,fren_seti,jant_seti) values ('" + user_name + "','" + isim_tbx.Text + "','" + marka_tbx.Text + "','"
                + model_tbx.Text + "','" + yil_tbx.Text + "','" + onAk_tbx.Text + "','" + arAk_tbx.Text + "','" + fren_tbx.Text + "','" + jant_tbx.Text + "')", con);
            OleDbDataReader dr = cmd.ExecuteReader();

            comboBox1.Items.Add(isim_tbx.Text);
            con.Close();

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
            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand bis_ismi = new OleDbCommand("SELECT * from bisiklet where bis_isim='" + comboBox1.Text + "'", con);
            OleDbDataReader bis_ismidr = bis_ismi.ExecuteReader();





            string tarih = dateTimePicker1.Text;
            while (bis_ismidr.Read())
            {

                OleDbCommand cmd2 = new OleDbCommand("INSERT INTO randevu(bis_sahibi,bis_isim,tarih) values ('" + user_name + "','" + bis_ismidr["bis_isim"] + "','" + tarih + "')", con);
                OleDbDataReader dr2 = cmd2.ExecuteReader();

                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {

                    OleDbCommand randevu_id = new OleDbCommand("SELECT LAST(randevu_id) as randevu_id1 FROM randevu", con);
                    OleDbDataReader randevu_iddr = randevu_id.ExecuteReader();


                    OleDbCommand ucret = new OleDbCommand("select * from onarim where ariza='" + checkedListBox1.CheckedItems[i] + "'", con);
                    OleDbDataReader ucretdr = ucret.ExecuteReader();

                    while (ucretdr.Read() && randevu_iddr.Read())
                    {

                        OleDbCommand cmd3 = new OleDbCommand("INSERT INTO randevu_bakim(randevu_id,bis_sahibi,bis_ismi,bakim,bakim_ucret) values ('" + randevu_iddr["randevu_id1"] + "','" + user_name + "','" + comboBox1.Text + "','" + checkedListBox1.CheckedItems[i] + "','" + ucretdr["ariza_ucret"] + "')", con);
                        OleDbDataReader dr3 = cmd3.ExecuteReader();


                    }


                }

                MsgRandevu msgRandevu = new MsgRandevu();
                msgRandevu.Show();

            }


            con.Close();
        }


    }
}

