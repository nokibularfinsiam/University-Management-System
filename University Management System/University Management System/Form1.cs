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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Administrator_Click(object sender, EventArgs e)
        {
            Administrator_LogIn admin = new Administrator_LogIn();
            admin.Show();
        }

        private void Student_Click(object sender, EventArgs e)
        {
            Student_LogIn student = new Student_LogIn();
            student.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
