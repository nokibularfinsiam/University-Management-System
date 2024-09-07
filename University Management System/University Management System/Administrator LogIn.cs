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
    public partial class Administrator_LogIn : Form
    {
        public Administrator_LogIn()
        {
            InitializeComponent();
        }

        private void Administrator_LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) /// Admin LogIn
        {
            SqlConnection conn = null;
            try
            {

                string query = "select * from AdIDpass where ID = '" + this.textBoxID.Text + "' and Password = '" + this.textBoxPass.Text + "'";
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=""University manage"";Integrated Security=True");
                conn.Open();
                SqlCommand smd = new SqlCommand(query, conn);
                SqlDataAdapter sda = new SqlDataAdapter(smd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Successfullly Login");
                    new Admin_home().Show();

                }
                else
                {
                    MessageBox.Show("Invalid, Please try Again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, please try again\n" + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPass.UseSystemPasswordChar = false;
            }

            else
            {
                textBoxPass.UseSystemPasswordChar = true;
            }
        }
    }
}
