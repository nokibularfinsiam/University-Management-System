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
    public partial class Admin_Courses : Form
    {
        public Admin_Courses()
        {
            InitializeComponent();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_home Ah = new Admin_home();
            Ah.Show();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_accounts Aac = new Admin_accounts();
            Aac.Show();
        }

        private void Admin_Courses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'university_manageDataSet29.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter13.Fill(this.university_manageDataSet29.Courses);
            // TODO: This line of code loads data into the 'university_manageDataSet21.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter12.Fill(this.university_manageDataSet21.Courses);
            // TODO: This line of code loads data into the 'university_manageDataSet20.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter11.Fill(this.university_manageDataSet20.Courses);
            // TODO: This line of code loads data into the 'university_manageDataSet19.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter10.Fill(this.university_manageDataSet19.Courses);
            // TODO: This line of code loads data into the 'university_manageDataSet18.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter9.Fill(this.university_manageDataSet18.Courses);
            // TODO: This line of code loads data into the 'university_manageDataSet17.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter8.Fill(this.university_manageDataSet17.Courses);
            // TODO: This line of code loads data into the 'university_manageDataSet16.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter7.Fill(this.university_manageDataSet16.Courses);


        }

        private void Reset_Click(object sender, EventArgs e) ////Reset button
        {
            this.CourseNameBox.Text = " ";
            this.CreditBox.Text = " ";
            this.SectionBox.Text = " ";
            this.comboBoxdept.SelectedIndex = -1;
            this.CcodeBox.Text = " ";
            this.TeacherBox.Text = " ";
        }

        private void button8_Click(object sender, EventArgs e) ///Insert button
        {
            SqlConnection conn = null;
            try
            {
                if (CourseNameBox != null && 
                    CreditBox.Text != null &&
                    SectionBox.Text != null &&
                    comboBoxdept.SelectedItem != null &&
                    CcodeBox.Text != null &&
                    TeacherBox.Text != null)
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                    conn.Open();
                    string query = "insert into Courses(CourseName, Credit, Section, CourseCode, Teachers, Department) VALUES ('" + this.CourseNameBox.Text + "', '" + this.CreditBox.Text + "', '" + this.SectionBox.Text + "', '" + this.CcodeBox.Text + "', '" + this.TeacherBox.Text + "', '" + this.comboBoxdept.SelectedItem +"')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Courses successfully!");
                }
                else
                {
                    MessageBox.Show("Please fill up all the informations!");
                    conn.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e) /////Delete button
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();
                string query = "Delete Courses where CourseName='" + this.CourseNameBox.Text + "'  ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete information");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e) ///Search button
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();
                string query = "select * from Courses where CourseName like '%" + this.searchBox.Text + "%'";
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

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();

                SqlDataAdapter DA = new SqlDataAdapter();
                string Select = "SELECT * from Courses";
                DA.SelectCommand = new SqlCommand(Select, conn);

                DataTable Dt = new DataTable();
                DA.Fill(Dt);
                dataGridView1.DataSource = Dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
