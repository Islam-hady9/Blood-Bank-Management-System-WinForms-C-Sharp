using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            Hospital_Blood_Bank login = new Hospital_Blood_Bank();
            login.Show();
        }

        private void LOGIN_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if(username == "islam" && password == "112002")
            {
                Hospital_Blood_Bank login = new Hospital_Blood_Bank();
                login.Show();
                this.Hide();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect...!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
