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
    public partial class Answer : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7MEADEG\SQLEXPRESS;Initial Catalog=GymData;Integrated Security=True");
        SqlCommand command;
        DataTable data;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder builder;
        public Answer()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select * from Question";
            command = new SqlCommand(query, connection);
            data = new DataTable();
            dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            connection.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            builder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(data);
            MessageBox.Show("Success!!!!!!!!");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GymManegment gym =new GymManegment();
            gym.Show();
        }
    }
}
