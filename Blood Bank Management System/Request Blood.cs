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
    public partial class Request_Blood : Form
    {
        public Request_Blood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hospital_Blood_Bank login = new Hospital_Blood_Bank();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Send_a_Request send = new Send_a_Request();
            send.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Requests view = new View_Requests();
            view.Show();
        }
    }
}
