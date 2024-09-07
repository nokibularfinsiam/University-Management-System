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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;

namespace University_Management_System
{
    public partial class Student_Admission_Form : Form
    {

        public static string sname, Fname, Mname, gender, religion, bloodGrp, email, password, contactNo, country, dob, sscGpa, sscGrp, hscGpa, hscGrrp, program, PreAdd, PermAdd; 
       
        public Student_Admission_Form()
        {
            InitializeComponent();
        }

        private void Student_Admission_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'university_manageDataSet4.StudentInfo' table. You can move, or remove it, as needed.
            //this.studentInfoTableAdapter.Fill(this.university_manageDataSet4.StudentInfo);
            label7.BackColor= Color.Transparent;
            label8.BackColor= Color.Transparent; 
            label9.BackColor= Color.Transparent;
            label10.BackColor= Color.Transparent;
            label16.BackColor= Color.Transparent;
            label17.BackColor= Color.Transparent;
            label18.BackColor= Color.Transparent;
            UpPicbutton.BackColor= Color.Transparent;
            label21.BackColor= Color.Transparent;
            label19.BackColor= Color.Transparent;
            label20.BackColor= Color.Transparent;
            label11.BackColor= Color.Transparent;
            label12.BackColor= Color.Transparent;
            label13.BackColor= Color.Transparent;
            label14.BackColor= Color.Transparent;
            label23.BackColor= Color.Transparent;
            //textBoxsStudentName.BackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String imageLocation = " ";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                conn.Open();
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.gpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
                { 
                        imageLocation = dialog.FileName;

                    Upload_Pic.ImageLocation = imageLocation;

                }
            }
            catch(Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContactBox_TextChanged(object sender, EventArgs e)
        {
            string number = ContactBox.Text;
            if ((number.Length == 11) && (number.StartsWith("01")) && number.All(char.IsDigit))
            {
                labelRight1.Visible = true;
                labelWrong1.Visible = false;
            }
            else
            {
                labelRight1.Visible = false;
                labelWrong1.Visible = true;
            }
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            string email = EmailBox.Text;
            if (email.Contains("@") && email.EndsWith(".com"))
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

        private void comboBoxProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            string program = comboBoxProgram.Text;
            if(program == null)
            
            { label21.Visible = true; }

            else
            
            { label21.Visible = false; }
        }

        private void PresentAddressBox_TextChanged(object sender, EventArgs e)
        {
            string preAdd = PresentAddressBox.Text;
            if (preAdd == null)

            { label15.Visible = true; }

            else

            { label15.Visible = false; }
        }

        private void PermanentAddBox_TextChanged(object sender, EventArgs e)
        {
            string perAdd = PermanentAddBox.Text;
            if (perAdd == null)

            { label22.Visible = true; }

            else

            { label22.Visible = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void HSCBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxsStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CpassBox_TextChanged(object sender, EventArgs e)
        {
            if (passBox.Text  == CpassBox.Text)
            {
                labelRight3.Visible = true;
                labelwrong3.Visible = false;

            }
            else
            {
                labelRight3.Visible = false;
                labelwrong3.Visible = true;
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e) ///// Reset button
        {
            this.textBoxsStudentName.Text = " ";
            this.FatherNameBox.Text = " ";
            this.MotherNameBox.Text = " ";
            this.radioButtonMale.Checked = false;
            this.radioButtonFemale.Checked = false;
            this.comboBoxReligion.SelectedIndex = -1;
            this.comboBoxBlood.SelectedIndex = -1;
            this.ContactBox.Text = " ";
            this.EmailBox.Text = " ";
            this.comboBoxCountry.SelectedIndex = -1;
            this.passBox.Text = " ";
            this.CpassBox.Text = " ";
            this.passBox.UseSystemPasswordChar = false;
            this.CpassBox.UseSystemPasswordChar = false;
            this.SSCBox.Text = " ";
            this.comboBoxSSC.SelectedIndex = -1;
            this.HSCBox.Text = " ";
            this.comboBoxHSC.SelectedIndex = -1;
            this.comboBoxProgram.SelectedIndex = -1;
            this.PresentAddressBox.Text = " ";
            this.PermanentAddBox.Text = " ";
            labelRight1.Visible = false;
            labelRight2.Visible = false;
            labelRight3.Visible = false;
            labelWrong1.Visible = false;
            labelWrong2.Visible = false;
            labelwrong3.Visible = false;
            label15.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            this.Upload_Pic.Image = null;
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Upload_Pic_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passBox.UseSystemPasswordChar = false;
                CpassBox.UseSystemPasswordChar = false;
            }

            else
            {
                passBox.UseSystemPasswordChar = true;
                CpassBox.UseSystemPasswordChar = true;
            }
        }

        private void Submit_Click(object sender, EventArgs e) /////Submit button
        {
            string sname = textBoxsStudentName.Text;
            string Fname = FatherNameBox.Text.ToString();
            string Mname = MotherNameBox.Text;
            string gender = string.Empty;
            if (radioButtonMale.Checked)
            {
                gender = "Male";
            }
            else if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            object religion = comboBoxReligion.SelectedItem;
            object bloodGrp = comboBoxBlood.SelectedItem;
            string email = EmailBox.Text;
            string password = passBox.Text;
            string contactNo = ContactBox.Text;
            object country = comboBoxCountry.SelectedItem;
            string dob = dateTimePickerDoB.Text;
            string sscGpa = SSCBox.Text;
            object sscGrp = comboBoxSSC.SelectedItem;
            string hscGpa = HSCBox.Text;
            object hscGrrp = comboBoxHSC.SelectedItem;
            object program = comboBoxProgram.SelectedItem;
            string preAdd = PresentAddressBox.Text;
            string permAdd = PermanentAddBox.Text;
            string img = Upload_Pic.Image.ToString();


            SqlConnection conn = null;
            try
            {

                if (textBoxsStudentName.Text != null &&
                FatherNameBox.Text != null &&
                MotherNameBox.Text != null &&
                (radioButtonMale.Checked || radioButtonFemale.Checked) &&
                comboBoxReligion.SelectedItem != null &&
                comboBoxBlood.SelectedItem != null &&
                ContactBox.Text != null &&
                labelRight1.Visible == true &&
                EmailBox.Text != null &&
                labelRight2.Visible == true &&
                comboBoxCountry.SelectedItem != null &&
                passBox.Text != null &&
                CpassBox.Text != null &&
                dateTimePickerDoB.Checked &&
                SSCBox.Text != null &&
                comboBoxSSC.SelectedItem != null &&
                HSCBox.Text != null &&
                comboBoxHSC.SelectedItem != null &&
                comboBoxProgram.Text != null &&
                comboBoxProgram.SelectedItem != null &&
                PresentAddressBox.Text != null &&
                PermanentAddBox.Text != null &&
                Upload_Pic.Image != null)
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-5903S8A\SQLEXPRESS;Initial Catalog=University manage;Integrated Security=True");
                    conn.Open();


                    string query = "insert into StudentInfo(StudentName, FathersName, MothersName, Gender, Religion, BloodGroup, Email, Password, ContactInfo, Country, DOB, SSCGPA, SSCGroup, HSCGPA, HSCGroup, Program, PresentAdd, PermanentAdd, Image ) VALUES ('" + this.textBoxsStudentName.Text + "', '" + Fname + "', '" + Mname + "', '" + gender + "', '" + religion + "', '" + bloodGrp + "', '" + email + "', '" + password + "', '" + contactNo + "', '" + country + "', '" + dob + "', '" + sscGpa + "', '" + sscGrp + "', '" + hscGpa + "', '" + hscGrrp + "', '" + program + "', '" + preAdd + "', '" + permAdd + "', '" + img + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration complete!");
                    this.Close();
                }
                else
                { MessageBox.Show("Please fill up all the informations!"); }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
