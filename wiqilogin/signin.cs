using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wiqilogin
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " " & textBox2.Text != " ")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=WAQASALI;Initial Catalog=login;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Login where Username ='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Congrats Your details exist");
                }
                else
                {
                    MessageBox.Show("User Name or Password is not correct, Please enter Your details");
                }
            }
        }
    }
}
   
