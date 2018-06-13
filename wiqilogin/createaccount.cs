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
    public partial class createaccount : Form
    {
       
        public createaccount()
        {
            InitializeComponent();
        }

               private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " " & textBox2.Text == " " & textBox3.Text == " ")
            {
                MessageBox.Show("Please enter you details");
            }
            else
            {
                SqlConnection sc = new SqlConnection(@"Data Source = WAQASALI; Initial Catalog = login; Integrated Security = True");
                string querry = "select * from Login Where Username ='"+textBox2.Text+ "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Username is alreday taken");
                }

                try
                {
                    string connetionString = null;
                    string sql = null;
                    connetionString = "Data Source=WAQASALI;Initial Catalog=login;Integrated Security=True";
                    using (SqlConnection cnn = new SqlConnection(connetionString))
                    {
                        sql = "insert into Login ( [Name], [Username], [Password]) values(@Name,@Username,@Password)";
                        cnn.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, cnn))
                        {
                            cmd.Parameters.AddWithValue("Name", textBox1.Text);
                            cmd.Parameters.AddWithValue("Username", textBox2.Text);
                            cmd.Parameters.AddWithValue("Password", textBox3.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Row inserted !! ");
                        }

                    }

                }
                catch {
                    MessageBox.Show("done");
                }
            }
        }
    }
}
