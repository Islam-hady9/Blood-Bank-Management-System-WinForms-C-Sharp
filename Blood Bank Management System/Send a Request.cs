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
    public partial class Send_a_Request : Form
    {
        public Send_a_Request()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Request_Blood request = new Request_Blood();
            request.Show();
        }
    }
}
