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
    public partial class Yillik_rapor : Form
    {
        public Yillik_rapor()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0;Data Source=BiServis.accdb");
        string user_name = Kullanici_giris.user_name;

        private void Yillik_rapor_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand cmd1 = new OleDbCommand("SELECT * from bisiklet where bis_sahibi='" + user_name + "'", con);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            OleDbDataAdapter da_acilis = new OleDbDataAdapter("select tarih,islem, ucret from randevu where bis_sahibi='" + user_name + "'", con);
            DataSet ds = new DataSet();
            da_acilis.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables["randevu"];
            

            comboBox1.Items.Add("Tümü");

            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1["bis_isim"]);
            }
            con.Close();

        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Randevu_list randevu_List = new Randevu_list();
            Close();
            randevu_List.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if (comboBox1.Text == "Tümü")
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select tarih,islem, ucret from randevu where bis_sahibi='" + user_name + "'", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds, "randevu");
                dataGridView1.DataSource = ds.Tables["randevu"];
                con.Close();
            }
            else
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select tarih,islem, ucret from randevu where bis_sahibi='" + user_name + "' AND bis_isim ='" + comboBox1.Text + "'", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds, "randevu");
                dataGridView1.DataSource = ds.Tables["randevu"];
                con.Close();
            }


            
        }
    }
}
