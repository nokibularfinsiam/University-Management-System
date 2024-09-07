using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Management_System
{
    public partial class Student_profile : Form
    {

        public Student_profile()
        {
            InitializeComponent();;
         
        }

        private void buttonlogout_Click(object sender, EventArgs e) /// LogOut button
        {
            this.Hide();
            Student_LogIn Sl = new Student_LogIn();
            Sl.Show();
        }

        private void Student_profile_Load(object sender, EventArgs e) ////load
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
