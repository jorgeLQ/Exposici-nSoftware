using System;
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

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar pb1 = new ProgressBar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(15);
            // progressBar1.Value = 100;
            // timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.timer1.Enabled = true;
        }
    }
}
