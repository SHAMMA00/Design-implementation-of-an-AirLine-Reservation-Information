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
    public partial class User_registration : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Desktop\ARS\n1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public User_registration()
        {
            InitializeComponent();
        }

        private void User_registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Registraion operation
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Insert into User2 (User_name, Password) Values ('" + textBox1.Text + "', '" + textBox2.Text + "') ", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registeration Done Successfully");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Login Operations
            string query = " Select* From User2 WHERE User_name ='" + textBox1.Text.Trim() + "' and Password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Form1 usa = new Form1();
                usa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Please Check Your User Name and Password");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main mm = new Main();
            mm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
