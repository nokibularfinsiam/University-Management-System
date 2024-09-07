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
    public partial class Student_grade : Form
    {
        public Student_grade()
        {
            InitializeComponent();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonCourses_Click(object sender, EventArgs e)
        {
            Student_courses Sc = new Student_courses();
            Sc.Show();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Student_profile Sp = new Student_profile();
            Sp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_financ Sf = new Student_financ();
            Sf.Show();
        }
    }
}
