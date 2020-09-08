using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Data.SqlClient;

namespace GymManegmentApp
{
    public partial class MembersFee : Form
    {
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder builder;
        private string totalvalue;
        public MembersFee()
        {

            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7MEADEG\SQLEXPRESS;Initial Catalog=GymData;Integrated Security=True");


        private SqlDataReader reader;
        private SqlCommand command;
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        
        }

        private void goButton_Click(object sender, EventArgs e)
        {

            connection.Open();

            string query = "select Name,Fees,Date from MemberInfo where Id = " + int.Parse(idTextBox.Text);
            command = new SqlCommand(query, connection);

            reader = command.ExecuteReader();
            if (reader.Read())
            {

                nameTextBox.Text = (reader["Name"].ToString());
                feesTextBox.Text = (reader["Fees"].ToString());
                dateTimePicker1.Text = (reader["Date"].ToString());
            }

            //DateTime joiningDate = dateTimePicker1.Value.Date;
            //DateTime paydate = dateTimePicker.Value.Date;
            //TimeSpan total = (paydate - joiningDate);
            //int days = (total.Days / 30) * 1500;
            //= days.ToString();

            reader.Close();
            connection.Close();



            
        }

        

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GymManegment gym = new GymManegment();
            gym.Show();
            
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //connection.Open();
            //string query = "Update MemberFee set Pays = pays +'"+paysTextBox.Text+"',Due";
            //int value;
            //int due;
            //value = Convert.ToInt32(feesTextBox.Text);
            //due = Convert.ToInt32(paysTextBox.Text);
            //int total = value - due;


            //totalvalue = total.ToString();


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string cmd = "Insert Into MemberFee (Id,Pays,Date,joiningDate) values ('"+idTextBox.Text+"','"+paysTextBox.Text+"','"+dateTimePicker.Text+"','"+dateTimePicker1.Text+"')";


           command = new SqlCommand(cmd, connection);
            
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Row Is Inserted");
            }

            else
            {
                MessageBox.Show(" Row can't Inserted");
            }
            connection.Close();
        }

        private void paysTextBox_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
