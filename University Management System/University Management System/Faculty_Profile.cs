﻿using System;
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
    public partial class Faculty_Profile : Form
    {
        public Faculty_Profile()
        {
            InitializeComponent();
        }

        private void buttonlogout_Click(object sender, EventArgs e) //// Logout Button
        {
            this.Hide();
            Faculty_LogIn fL = new Faculty_LogIn();
            fL.Show();
        }

        private void Faculty_Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
