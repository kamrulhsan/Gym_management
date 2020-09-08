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
using System.Runtime.CompilerServices;
using System.Data.Sql;
using Microsoft.SqlServer.Server;
using System.IO;

namespace GymManegmentApp
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           

            byte[] imageBytes = null;
            FileStream file =new FileStream(this.pictureTextBox.Text,FileMode.Open,FileAccess.Read);
            BinaryReader binary =new BinaryReader(file);
            imageBytes = binary.ReadBytes((int) file.Length);
            
            
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7MEADEG\SQLEXPRESS;Initial Catalog=GymData;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand(@"Insert into MemberInfo (Id,Name,Gender,Address,Height,Weight,Contact_No,Batch,Fees,AdmisionFee,Date) values('" + idTextBox.Text + "','" + nameTextBox.Text + "','" + genderComboBox.SelectedItem.ToString() + "','" + addressTextBox.Text + "','" + HeighttextBox.Text + "','" + weighttextBox.Text + "','" + contuctNoTextBox.Text + "','" + bathcomboBox.SelectedItem.ToString() + "','" + feesTextBox.Text + "','" + admitionFeeTextBox.Text + "','" + dateTimePicker.Text + "')", connection);

            SqlCommand com = new SqlCommand(@"Inesrt into Image (IMAGE) Values ('" + imageBytes + "')");
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
                dlg.Title = "Select User Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string picpath = dlg.FileName.ToString();
                    pictureTextBox.Text = picpath;
                    userPictureBox.ImageLocation = picpath;
                }﻿
        }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GymManegment gym = new GymManegment();
            gym.Show();
            
        }

        private void exeptionalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int totalNumber = int.Parse(feesTextBox.Text);
            double parcentage = 20;
            double totalfee;
            double total = (parcentage / 100) * totalNumber;
            totalfee = totalNumber - total;
            if (exeptionalCheckBox.Checked)
            {

                feesTextBox.Text = totalfee.ToString();
            }

            
        }

        private void pictureTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
