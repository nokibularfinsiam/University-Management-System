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
    public partial class Account_Info : Form
    {
        public Account_Info()
        {
            InitializeComponent();
        }

        private void Account_Info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'university_manageDataSet27.EmployeeSalary' table. You can move, or remove it, as needed.
            this.employeeSalaryTableAdapter.Fill(this.university_manageDataSet27.EmployeeSalary);
            // TODO: This line of code loads data into the 'university_manageDataSet26.TeacherSalary' table. You can move, or remove it, as needed.
            this.teacherSalaryTableAdapter.Fill(this.university_manageDataSet26.TeacherSalary);
            // TODO: This line of code loads data into the 'university_manageDataSet25.StudentFees' table. You can move, or remove it, as needed.
            this.studentFeesTableAdapter2.Fill(this.university_manageDataSet25.StudentFees);
            // TODO: This line of code loads data into the 'university_manageDataSet24.StudentFees' table. You can move, or remove it, as needed.
            //this.studentFeesTableAdapter1.Fill(this.university_manageDataSet24.StudentFees);
            // TODO: This line of code loads data into the 'university_manageDataSet23.StudentFees' table. You can move, or remove it, as needed.
           // this.studentFeesTableAdapter.Fill(this.university_manageDataSet23.StudentFees);

        }

        private void button9_Click(object sender, EventArgs e) //// Search Student Fees info
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();
                string query = "select * from StudentFees where Email like '%" + this.SearchBoxS.Text + "%'";
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

        private void Spay_Click(object sender, EventArgs e) //// Student Payment view button
        {
            SearchBox1.Visible = true;
            SearchBoxS.Visible = true;
            dataGridView1.Visible = true;
            buttonSearch.Visible = false;
            textBoxSearch.Visible = false;
            dataGridView2.Visible = false;
            buttonSearch2.Visible = false;
            textBoxSearch2.Visible = false;
            dataGridView3.Visible = false;
        }

        private void TSDatagrid_Click(object sender, EventArgs e) /// Teacher salary view button
        {
            buttonSearch.Visible = true;
            textBoxSearch.Visible = true;
            dataGridView2.Visible = true;  
            SearchBox1.Visible = false;
            SearchBoxS.Visible = false;
            dataGridView1.Visible = false;
            buttonSearch2.Visible = false;
            textBoxSearch2.Visible = false;
            dataGridView3.Visible = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e) ///// search teacher salary button
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();
                string query = "select * from TeacherSalary where ID like '%" + this.textBoxSearch.Text + "%'";
                SqlCommand cm = new SqlCommand(query, conn);
                SqlDataAdapter Sd = new SqlDataAdapter(cm);
                DataTable Dtb = new DataTable();
                Sd.Fill(Dtb);
                dataGridView2.DataSource = Dtb;
                cm.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e) 
        {

        }

        private void button7_Click(object sender, EventArgs e)  //Employee Salary view button
        {
            buttonSearch2.Visible = true;
            textBoxSearch2.Visible = true;
            dataGridView3.Visible = true;
            buttonSearch.Visible = false;
            textBoxSearch.Visible = false;
            dataGridView2.Visible = false;
            SearchBox1.Visible = false;
            SearchBoxS.Visible = false;
            dataGridView1.Visible = false;
        }

        private void buttonSearch2_Click(object sender, EventArgs e) ///Search Employee Salary button
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();
                string query = "select * from EmployeeSalary where ID like '%" + this.textBoxSearch2.Text + "%'";
                SqlCommand cm = new SqlCommand(query, conn);
                SqlDataAdapter Sd = new SqlDataAdapter(cm);
                DataTable Dtb = new DataTable();
                Sd.Fill(Dtb);
                dataGridView3.DataSource = Dtb;
                cm.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
