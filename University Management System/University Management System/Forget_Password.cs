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
    public partial class Forget_Password : Form
    {
        public Forget_Password()
        {
            InitializeComponent();
        }

        private void GetPass_Click(object sender, EventArgs e)
        {

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();

                string query = "select * from StudentInfo where Email = '" + this.EmailBox.Text + "'AND ContactInfo = '" + this.ConoBox.Text + "'";
                SqlCommand cmd = new SqlCommand (query, conn); 
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    getpassbox.Text = reader.GetValue(7).ToString();

                }
                else
                {
                    MessageBox.Show("InValid Student");
                    getpassbox.Text = " ";
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
