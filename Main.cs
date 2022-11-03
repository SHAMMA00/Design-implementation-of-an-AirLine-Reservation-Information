using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARS
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //move to user login interface
            User_Login ul = new User_Login();
            ul.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //move to admin login interface
            Admin_Log al = new Admin_Log();
            this.Hide();
            al.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            about_us us = new about_us ();
            this .Hide ();
            us.Show();
        }

    }
}
