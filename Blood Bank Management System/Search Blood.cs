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
    public partial class Search_Blood : Form
    {
        public Search_Blood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hospital_Blood_Bank hospital = new Hospital_Blood_Bank();
            hospital.Show();
        }
    }
}
