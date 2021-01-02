using System;
using System.Windows.Forms;

namespace BiServis
{
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
        }

        private void tamamBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
