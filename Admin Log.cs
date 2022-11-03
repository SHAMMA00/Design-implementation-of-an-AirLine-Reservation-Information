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
    public partial class Admin_Log : Form
    {
        public Admin_Log()
        {

            InitializeComponent();
            string xmllink = Application.StartupPath + @"\database2.xml";
            DataSet2 D2 = new DataSet2();
            DataTable T2 = D2.Tables["adminlogin"];
            T2.Rows.Add("shamma", "123456");
            D2.WriteXml(xmllink);
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Main mm = new Main();
            mm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // admin log in code using data set
            string xmllink = Application.StartupPath + @"\database2.xml";
            DataSet2 D2 = new DataSet2();
            D2.ReadXml(xmllink);
            for (int i = 0; D2.Tables["adminlogin"].Rows.Count > i; ++i)

                if (textBox1.Text == D2.Tables["adminlogin"].Rows[i]["username"].ToString() && textBox2.Text == D2.Tables["adminlogin"].Rows[i]["password"].ToString())
                {
                    Admin_Interface ii = new Admin_Interface();
                    ii.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("please write the correct user name and password");
                }


        }
    }
}
