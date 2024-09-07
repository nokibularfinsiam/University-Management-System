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
    public partial class Admin_Employee : Form
    {
        public Admin_Employee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_home Ah = new Admin_home();
            Ah.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCourses_Click(object sender, EventArgs e)
        {
            Admin_Courses Ac = new Admin_Courses();
            Ac.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_accounts Aac = new Admin_accounts();
            Aac.Show();
        }

        private void Admin_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'university_manageDataSet28.EmployeeInfo' table. You can move, or remove it, as needed.
            this.employeeInfoTableAdapter.Fill(this.university_manageDataSet28.EmployeeInfo);

        }

        private void Reset_Click(object sender, EventArgs e) /// Reset button
        {
            this.IDBox.Text = " ";
            this.PhoneBox.Text = " ";
            this.comboBoxQua.SelectedIndex = -1;
            this.NameBox.Text = " ";
            this.EmailBox.Text = " ";
            this.comboBoxStatus.SelectedIndex = -1;
            this.textBoxAdd.Text = " ";
        }

        private void button8_Click(object sender, EventArgs e) /// Insert button
        {
            SqlConnection conn = null;
            try
            {
                if (NameBox.Text != null &&
                    IDBox.Text != null &&
                    textBoxAdd.Text != null &&
                    PhoneBox.Text != null &&
                    comboBoxStatus.SelectedItem != null &&
                    EmailBox.Text != null)
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                    conn.Open();
                    string query = "insert into EmployeeInfo(Name, ID, Qualification, Status, PhoneNo, Email, Address) VALUES ('" + this.NameBox.Text + "', '" + this.IDBox.Text + "',  '" + this.comboBoxQua.SelectedItem + "', '" + this.comboBoxStatus.SelectedItem + "', '" + this.PhoneBox.Text + "', '" + this.EmailBox.Text + "', '" + this.textBoxAdd.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added New Employee successfully!");
                }
                else
                {
                    MessageBox.Show("Please fill up all the informations!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e) //// Update button
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=""University manage"";Integrated Security=True");
                conn.Open();
                string query = "UPDATE EmployeeInfo SET Name = '" + this.NameBox.Text + "', Qualification = '" + this.comboBoxQua.SelectedItem + "', Status = '" + this.comboBoxStatus.SelectedItem + "', PhoneNo = '" + this.PhoneBox.Text + "', Email = '" + this.EmailBox.Text + "' , Address = '" + this.textBoxAdd.Text + "'  Where ID = '" + this.IDBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update info successfully!");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e) /// Refresh button
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();

                SqlDataAdapter DA = new SqlDataAdapter();
                string query = "SELECT * from EmployeeInfo";
                DA.SelectCommand = new SqlCommand(query, conn);

                DataTable Dt = new DataTable();
                DA.Fill(Dt);
                dataGridView1.DataSource = Dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e) //// Delete button
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();
                string query = "Delete from EmployeeInfo where ID='" + this.IDBox.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete information");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e) /// Search button
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();
                string query = "select * from EmployeeInfo where ID like '%" + this.searchBox.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter Sd = new SqlDataAdapter(cmd);
                DataTable Dt = new DataTable();
                Sd.Fill(Dt);
                dataGridView1.DataSource = Dt;
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
