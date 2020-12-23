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
    
    public partial class Randevu_list : Form
    {

        
        public Randevu_list()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.Oledb.12.0;Data Source=BiServis.accdb");

        private void Randevu_list_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from randevu", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables["randevu"];
            con.Close();
            
        }
    }
}
