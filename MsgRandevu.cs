﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiServis
{
    public partial class MsgRandevu : Form
    {
        public MsgRandevu()
        {
            InitializeComponent();
        }

        private void tamamBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
