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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          //  LENIN formLenin = new LENIN();
            this.progressBar1.Increment(5);

            if (this.progressBar1.Value == this.progressBar1.Maximum)
            {
                this.timer1.Stop();
                this.timer1.Start();

                //formLenin.show

            }
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.timer1.Start();

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
