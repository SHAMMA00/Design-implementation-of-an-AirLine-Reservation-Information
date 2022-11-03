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
    public partial class User_Login : Form
    {
        public User_Login()
        {
            InitializeComponent();
            string xmllink = Application.StartupPath + @"\database1.xml";
            DataSet1 D1 = new DataSet1();
            DataTable T1 = D1.Tables["userlogin"];
            T1.Rows.Add("maram", "123456");
            D1.WriteXml(xmllink);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // user log in code using data set
            string xmllink = Application.StartupPath + @"\database1.xml";
            DataSet1 D1 = new DataSet1();
            D1.ReadXml(xmllink);
            for (int i = 0; D1.Tables["userlogin"].Rows.Count > i; ++i) 
           
            if (textBox1.Text == D1.Tables["userlogin"].Rows [i]["username"].ToString() && textBox2.Text == D1.Tables["userlogin"].Rows[i]["password"].ToString())
            {
                
                Form1 userint = new Form1();
                userint.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("please write the correct user name and password");
            }


            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User_registration ur = new User_registration();
            ur.Show();
            this.Hide();
        }

        private void User_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
