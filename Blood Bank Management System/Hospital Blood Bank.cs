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
    public partial class Hospital_Blood_Bank : Form
    {
        public Hospital_Blood_Bank()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Request_Blood request = new Request_Blood();
            request.Show();
        }

        private void Hospital_Blood_Bank_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Request_Blood request = new Request_Blood();
            request.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search_Blood search = new Search_Blood();
            search.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Donors donors = new Donors();
            donors.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Management management = new Management();
            management.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
