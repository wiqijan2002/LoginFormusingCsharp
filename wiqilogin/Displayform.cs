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
    public partial class Displayform : Form
    {
        public Displayform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.loginTableAdapter1.Fill(this.loginDataSet2.Login);
        }

        private void Displayform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataSet2.Login' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'loginDataSet1.Login' table. You can move, or remove it, as needed.


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
