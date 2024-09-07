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
    public partial class Admin_accounts : Form
    {
        public Admin_accounts()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) /// home button
        {
            Admin_home Ah = new Admin_home();
            Ah.Show();
        }

        private void buttonDep_Click(object sender, EventArgs e) /// depertment button
        {
            Admin_Employee Ad = new Admin_Employee();
            Ad.Show();
        }

        private void button3_Click(object sender, EventArgs e) /// Faculty Button
        {
            Admin_Faculty Af = new Admin_Faculty();
            Af.Show();
        }

        private void button4_Click(object sender, EventArgs e)  ///Student button
        {
            Admin_Students As = new Admin_Students();
            As.Show();
        }

        private void buttonCourses_Click(object sender, EventArgs e)  /// Courses
        {
            Admin_Courses Ac = new Admin_Courses();
            Ac.Show();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e) /// Student Semester Fees Pay button
        {
            SqlConnection conn = null;
            try
            {
                if (EmailBox.Text != null && SnameBox.Text != null &&
                    SemesterBox.Text != null && AmountBox1.Text != null && comboBoxdept.SelectedItem != null)
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                    conn.Open();
                    string query = "insert into StudentFees(Email, StudentName, Semester, Amount, Department) VALUES ('" + this.EmailBox.Text + "', '" + this.SnameBox.Text + "', '" + this.SemesterBox.Text + "', '" + this.AmountBox1.Text + "', '" + this.comboBoxdept.SelectedItem + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment Complete");
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

        private void Reset_Click(object sender, EventArgs e) /// Student Semester Fees texbox Reset button
        {
            this.EmailBox.Text = " ";
            this.SemesterBox.Text = " ";
            this.SnameBox.Text = " ";
            this.AmountBox1.Text = " ";
            this.comboBoxdept.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e) //// Teachers Salary Payment button
        {
            SqlConnection conn = null;
            try
            {
                if (IDBox.Text != null && TnameBox.Text != null &&
                    comboBoxMonth.SelectedItem != null && AmountBox.Text != null && comboBoxdept2.SelectedItem != null)
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                    conn.Open();
                    string query = "insert into TeacherSalary(Id, Name, Month, Amount, Department) VALUES ('" + this.IDBox.Text + "', '" + this.TnameBox.Text + "', '" + this.comboBoxMonth.SelectedItem + "', '" + this.AmountBox.Text + "', '" + this.comboBoxdept2.SelectedItem + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salary Payed");
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

        private void button8_Click(object sender, EventArgs e) //// Teachers Salary textbox Reset button
        {
            this.IDBox.Text = " ";
            this.TnameBox.Text = " ";
            this.AmountBox.Text = " ";
            this.comboBoxdept2.SelectedIndex = -1;
            this.comboBoxMonth.SelectedIndex = -1;
        }

        private void button6_Click(object sender, EventArgs e) /// Employee salary pay button
        {
            SqlConnection conn = null;
            try
            {
                if (empIDBox.Text != null && empNameBox.Text != null &&
                    comboBoxMonth2.SelectedItem != null && AmountBox2.Text != null && comboBoxStatus.SelectedItem != null)
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                    conn.Open();
                    string query = "insert into EmployeeSalary(Id, Name, Month, Amount, Status) VALUES ('" + this.empIDBox.Text + "', '" + this.empNameBox.Text + "', '" + this.comboBoxMonth2.SelectedItem + "', '" + this.AmountBox2.Text + "', '" + this.comboBoxStatus.SelectedItem + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salary Payed");
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

        private void button9_Click(object sender, EventArgs e) /// Employee salary textbox Reset button
        {
            this.empIDBox.Text = " ";
            this.empNameBox.Text = " ";
            this.AmountBox2.Text = " ";
            this.comboBoxStatus.SelectedIndex = -1;
            this.comboBoxMonth2.SelectedIndex = -1;
        }

        private void button10_Click(object sender, EventArgs e) // Account info button
        {
            Account_Info Ai = new Account_Info();
            Ai.Show();
        }

        private void AmountBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_accounts_Load(object sender, EventArgs e)
        {

        }
    }
}
