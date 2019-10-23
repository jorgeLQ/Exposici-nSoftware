using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.textBox3.Enabled = false;
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString();
        }
    }
}
