﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softwareII
{
    public partial class LENIN : Form
    {
        public LENIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            txtN3.Text = (Convert.ToInt32(txtN1.Text) + Convert.ToInt32(txtN2.Text)).ToString();
        }
    }
}
