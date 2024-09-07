using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace University_Management_System
{
    public partial class Admin_Faculty : Form
    {
        public Admin_Faculty()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Students As = new Admin_Students();
            As.Show();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Admin_Faculty Af = new Admin_Faculty();
            Af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_home Ah = new Admin_home();
            Ah.Show();
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

        private void Admin_Faculty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'university_manageDataSet22.FacultyInfo' table. You can move, or remove it, as needed.
            this.facultyInfoTableAdapter3.Fill(this.university_manageDataSet22.FacultyInfo);
            // TODO: This line of code loads data into the 'university_manageDataSet8.FacultyInfo' table. You can move, or remove it, as needed.
            this.facultyInfoTableAdapter2.Fill(this.university_manageDataSet8.FacultyInfo);
            // TODO: This line of code loads data into the 'university_manageDataSet7.FacultyInfo' table. You can move, or remove it, as needed.
            this.facultyInfoTableAdapter1.Fill(this.university_manageDataSet7.FacultyInfo);
            // TODO: This line of code loads data into the 'university_manageDataSet6.FacultyInfo' table. You can move, or remove it, as needed.
            this.facultyInfoTableAdapter.Fill(this.university_manageDataSet6.FacultyInfo);

        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            string number = IDBox.Text;
            if (number.Length == 10)
            {
                labelRight1.Visible = true;
                labelWrong1.Visible = false;
            }
            else
            {
                labelRight1.Visible = false;
                labelWrong1.Visible = true;
            }

            if (number == null)
            {
                digit10.Visible = true;
            }
            else
            {
                digit10.Visible = false;
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string email = EmailBox.Text;
            if (email.Contains("@") && email.EndsWith(".com"))
            {
                labelRight3.Visible = true;
                labelWrong3.Visible = false;

            }
            else
            {
                labelRight3.Visible = false;
                labelWrong3.Visible = true;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string number = PhoneBox.Text;
            if ((number.Length == 11) && (number.StartsWith("01")) && number.All(char.IsDigit))
            {
                labelRight2.Visible = true;
                labelWrong2.Visible = false;
            }
            else
            {
                labelRight2.Visible = false;
                labelWrong2.Visible = true;
            }
        }

        private void Reset_Click(object sender, EventArgs e) //// Reset Button
        {
            this.IDBox.Text = " ";
            this.passBox.Text = " ";
            this.PhoneBox.Text = " ";
            this.comboBoxQua.SelectedIndex = -1;
            this.NameBox.Text = " ";
            this.EmailBox.Text = " ";
            this.comboBoxdept.SelectedIndex = -1;
            this.textBoxAdd.Text = " ";
            labelRight1.Visible = false;
            labelRight2.Visible = false;
            labelRight3.Visible = false;
            labelWrong1.Visible = false;
            labelWrong2.Visible = false;
            labelWrong3.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e) //// Insert Button
        {
            SqlConnection conn = null;
            try
            {
                if (NameBox.Text != null &&
                    IDBox.Text != null &&
                    passBox.Text != null &&
                    textBoxAdd.Text != null &&
                    PhoneBox.Text != null &&
                    comboBoxdept.SelectedItem != null &&
                    comboBoxQua.SelectedItem != null &&
                    labelRight1.Visible == true &&
                    labelRight2.Visible == true &&
                    labelRight3.Visible == true &&
                    EmailBox.Text != null)
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                    conn.Open();
                    string query = "insert into FacultyInfo(Name, ID, Password, Qualification, Department, PhoneNo, Email, Address) VALUES ('" + this.NameBox.Text + "', '" + this.IDBox.Text + "', '" + this.passBox.Text + "', '" + this.comboBoxQua.SelectedItem + "', '" + this.comboBoxdept.SelectedItem + "', '" + this.PhoneBox.Text + "', '" + this.EmailBox.Text + "', '" + this.textBoxAdd.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added New faculty successfully!");
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

        private void button10_Click(object sender, EventArgs e) //// Refresh button
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();

                SqlDataAdapter DA = new SqlDataAdapter();
                string query = "SELECT * from FacultyInfo";
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

        private void button7_Click(object sender, EventArgs e) //// Update button
        {

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=""University manage"";Integrated Security=True");
                conn.Open();
                string query = "UPDATE FacultyInfo SET Name = '" + this.NameBox.Text + "', Password = '" + this.passBox.Text + "', Qualification = '" + this.comboBoxQua.SelectedItem + "', Department = '" + this.comboBoxdept.SelectedItem + "', PhoneNo = '" + this.PhoneBox.Text + "', Email = '" + this.EmailBox.Text + "' , Address = '" + this.textBoxAdd.Text + "'  Where ID = '" + this.IDBox.Text + "'";
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

        private void button6_Click(object sender, EventArgs e) ///// Delete Button
        {

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();
                string query = "Delete FacultyInfo where ID='" + this.IDBox.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete information");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button9_Click(object sender, EventArgs e) //// Search button
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();
                string query = "select * from FacultyInfo where ID like '%" + this.searchBox.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter Sd = new SqlDataAdapter(cmd);
                DataTable Dt = new DataTable();
                Sd.Fill(Dt);
                dataGridView1.DataSource =Dt;
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
