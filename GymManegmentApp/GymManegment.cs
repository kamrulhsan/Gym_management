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
    public partial class GymManegment : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7MEADEG\SQLEXPRESS;Initial Catalog=GymData;Integrated Security=True");
         SqlCommand command;
         DataTable data;
        SqlDataAdapter dataAdapter;
         SqlCommandBuilder builder;

        public GymManegment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMember add=new AddMember();
            add.Show();
        }

        private void userAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Answer answer= new Answer();
            answer.Show();
        }

        private void feesReciveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MembersFee fee = new MembersFee();
            fee.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select Id,Name,Gender,Address,Height,Weight,Contact_No,Batch,Fees,Date from MemberInfo";
            command = new SqlCommand(query, connection);
             data = new DataTable();
             dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            connection.Close();

        }

        private void purchaseProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products products = new Products();
            products.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            builder =new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(data);
            MessageBox.Show("Success!!!!!!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
           // SqlCommand cmd = connection.CreateCommand();
            //cmd.CommandType =CommandType.Text;
            //cmd.CommandText = "delete from MemberInfo where Id = '"+deleteTextBox.Text+"'";
             string query = ("delete from MemberInfo where Id ='"+deleteTextBox.Text+"'");
            command =new SqlCommand(query,connection);
            command.ExecuteNonQuery();
            
            connection.Close();

            MessageBox.Show("Delete Succesfully");
        }

        private void pendingFeesbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PendingFees pending =new PendingFees();
            pending.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select *from MemberInfo WHERE Id ='" + searchTextBox.Text + "'";
            command = new SqlCommand(query, connection);
            data = new DataTable();
            dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            connection.Close();
        }
        }
    }

