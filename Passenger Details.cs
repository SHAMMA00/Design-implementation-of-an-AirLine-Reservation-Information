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
    public partial class Passenger_Details : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Desktop\ARS\n1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        
        public Passenger_Details()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Interface ff = new Admin_Interface();
            ff.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                //INSERT IN RESERVE FOR USER INTERFACE & PASSENGER DETAILS INTERFACE AND IT WILL SHOWN IN PASSENGER DETAILS INTERFACE FOR ADMIN
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

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //view operation in admin interface
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select* From User1 ", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Update operation in admin inetface
           con.Open();
           SqlDataAdapter sda = new SqlDataAdapter("Update User1 Set Passenger_Name= '" + textBox1.Text + "', Age= '" + textBox2.Text + "', Email=' " + textBox4.Text + "' , Gender= '" + comboBox4.Text + "'  , Flight_name= '" + comboBox1.Text + "' , From_station= '" + comboBox2.Text + "' , To_station= '" + comboBox3.Text + "'  , Departure_Date= '" + dateTimePicker1.Text + "', Class= '" + comboBox5.Text + "'  Where phone_number=' " + textBox3.Text + " ' ", con);
           sda.SelectCommand.ExecuteNonQuery();
           con.Close();
           MessageBox.Show("Updated Done Successfully");

        }  
            
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBox3.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            comboBox5.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //delete operation in admin interface
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Delete From User1 WHERE phone_number= ' " + textBox3.Text + " ' ", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Done Successfully");

        }

       

        

       

        
    }

}
