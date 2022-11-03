using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ARS
{
    public partial class Reserve_For_User : Form
      
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Desktop\ARS\n1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Reserve_For_User()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User_Login uu = new User_Login();
            uu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //INSERT IN PASSENGER DETAIL AND SHOWN IN PASSENGER DETAILS FOR ADMIN & PRINT TICKET
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Your Name");
                return;
            }
            else if (textBox2.Text == ""  )
            {
                MessageBox.Show("Please Enter Your Age");
                return;
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Please Enter Your Phone Number");
                return;
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Please Enter Your Email");
                return;
            }
            else if (comboBox4.Text == "Select Your Gender")
            {
                string myStringVariable3 = string.Empty;
                MessageBox.Show("Please Select Your Gender");
                return;
            }
            else if (comboBox1.Text == "Select Your Flight")
            {
                string myStringVariable3 = string.Empty;
                MessageBox.Show("Please Select Your Flight");
                return;
            }
            else if (comboBox2.Text == "Select Your Station")
            {
                string myStringVariable3 = string.Empty;
                MessageBox.Show("Please Select Your First Station");
                return;
            }
            else if (comboBox3.Text == "Select Your Station")
            {
                string myStringVariable3 = string.Empty;
                MessageBox.Show("Please Select Your Second Station");
                return;
            }
            else if (comboBox5.Text == "Select Your Class")
            {
                string myStringVariable3 = string.Empty;
                MessageBox.Show("Please Select Your Class Type");
                return;
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("insert into User1 (Passenger_Name, Age, phone_number, Email, Gender, Flight_name, From_station, To_station, Departure_Date, Class) Values ('" + textBox1.Text + " ', '" + textBox2.Text + " ', '" + textBox3.Text + " ','" + textBox4.Text + " ','" + comboBox4.Text + " ','" + comboBox1.Text + " ','" + comboBox2.Text + " ','" + comboBox3.Text + " ','" + dateTimePicker1.Text + " ','" + comboBox5.Text + " ')", con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Reservation successful");
                print prt = new print();
                prt.label12.Text = textBox1.Text.ToString();
                prt.label13.Text = textBox2.Text.ToString();
                prt.label14.Text = textBox3.Text.ToString();
                prt.label15.Text = textBox4.Text.ToString();
                prt.label16.Text = comboBox4.SelectedItem.ToString();
                prt.label17.Text = comboBox1.SelectedItem.ToString();
                prt.label18.Text = comboBox2.SelectedItem.ToString();
                prt.label19.Text = comboBox3.SelectedItem.ToString();
                prt.label20.Text = dateTimePicker1.Value.ToLongDateString();
                prt.label21.Text = comboBox5.SelectedItem.ToString();
                prt.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //view operation in admin interface
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select* From User1 ", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
