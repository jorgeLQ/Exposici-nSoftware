using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.textBox3.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text
            //textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //txtBox3.Text = (Convert.ToInt32(txtN1.Text) + Convert.ToInt32(txtN2.Text)).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
