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
    public partial class Admin_Interface : Form
    {
        public Admin_Interface()
        {
            InitializeComponent();
        }

        private void Admin_Interface_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Passenger_Details pd = new Passenger_Details();
            pd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Log ab = new Admin_Log();
            ab.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
