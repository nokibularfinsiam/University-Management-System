using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    public partial class Admin_home : Form
    {
        public Admin_home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Admin_home_Load(object sender, EventArgs e)
        {

        }

        private void buttonDep_Click(object sender, EventArgs e)
        {
            Admin_Employee Ad = new Admin_Employee();
            Ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Faculty Af = new Admin_Faculty();
            Af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Students As = new Admin_Students();
            As.Show();
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            Admin_Courses Ac = new Admin_Courses();
            Ac.Show();
        }

        private void buttonlogout_Click(object sender, EventArgs e) /// Logout button
        {
            this.Hide();
            Administrator_LogIn Adl = new Administrator_LogIn();
            Adl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_accounts Aac = new Admin_accounts();
            Aac.Show();
        }
    }
}
