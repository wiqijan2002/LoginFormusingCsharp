using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wiqilogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            createaccount ac = new createaccount();
            ac.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            signin si = new signin();
            si.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Displayform ds = new Displayform();
            ds.Show();

        }
    }
}
