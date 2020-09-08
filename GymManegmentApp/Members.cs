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
    public partial class Members : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7MEADEG\SQLEXPRESS;Initial Catalog=GymData;Integrated Security=True");
        SqlCommand command;
        DataTable data;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder builder;
        public Members()
        {
            InitializeComponent();
        }

        private void questionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Question question =new Question();
            question.Show();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select Id,Name,Gender,Height,Weight,Batch from MemberInfo";
            command = new SqlCommand(query, connection);
            data = new DataTable();
            dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            connection.Close();
        }
    }
}
