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

namespace GymManegmentApp
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            passwardTextBox.UseSystemPasswordChar = true;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7MEADEG\SQLEXPRESS;Initial Catalog=GymData;Integrated Security=True");
            connection.Open();
            SqlDataAdapter adapter =new SqlDataAdapter("select count(*) from LogIn where UserName='" +userNameTextBox.Text+"' and Password='" +passwardTextBox.Text+"'",connection);
            
            DataTable table =new DataTable();
            adapter.Fill(table);
            if (table.Rows[0][0].ToString() == "1")
            {
               
                SqlDataAdapter adapter1 = new SqlDataAdapter("select Role from LogIn where UserName='" + userNameTextBox.Text + "' and Password='" + passwardTextBox.Text + "'", connection);
                DataTable table1 =new DataTable();
            adapter1.Fill(table1);
                if (table1.Rows[0][0].ToString() == "Admin")
                {
                    this.Hide();
                    GymManegment gym = new GymManegment();
                    gym.Show();
                }
                if (table1.Rows[0][0].ToString() == "User")
                {
                    this.Hide();
                    Members add = new Members();
                    add.Show();

                }
                
            }
            else
            {
                MessageBox.Show("Please check Your User Name and Password And try again!!");
            }
        }

        private void showCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!showCheckBox.Checked)
            {
                passwardTextBox.UseSystemPasswordChar = true;

            }
            else
            {
                passwardTextBox.UseSystemPasswordChar = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
