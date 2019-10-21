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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SUMAR_Click(object sender, EventArgs e)
        {
            txtN3.Text = (Convert.ToInt32(txtN1.Text) + Convert.ToInt32(txtN2.Text)).ToString();
        }
    }
}
