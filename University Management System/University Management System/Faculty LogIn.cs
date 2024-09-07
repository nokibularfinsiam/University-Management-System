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
    public partial class Faculty_LogIn : Form
    {
        public Faculty_LogIn()
        {
            InitializeComponent();
        }

        private void Faculty_LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) ///// Faculty login
        {
            SqlConnection conn = null;
            try
            {

                string query = "select * from FacultyInfo where ID = '" + this.textBoxID.Text + "' and Password = '" + this.textBoxpass.Text +"'";
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=""University manage"";Integrated Security=True");
                conn.Open();
                SqlCommand smd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(smd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Login Successfully");
                    new Faculty_Profile().Show();
                }

                else 
                {
                    MessageBox.Show("Invalid, Please try Again!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, please try again" + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxpass.UseSystemPasswordChar = false;
            }

            else
            {
                textBoxpass.UseSystemPasswordChar = true;
            }
        }
    }
}
