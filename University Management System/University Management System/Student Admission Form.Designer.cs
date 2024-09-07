namespace University_Management_System
{
    partial class Student_Admission_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Admission_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FatherNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MotherNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ContactBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.comboBoxReligion = new System.Windows.Forms.ComboBox();
            this.comboBoxBlood = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.SSCBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerDoB = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.PresentAddressBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.PermanentAddBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Upload_Pic = new System.Windows.Forms.PictureBox();
            this.UpPicbutton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxSSC = new System.Windows.Forms.ComboBox();
            this.comboBoxHSC = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.HSCBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBoxProgram = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.labelWrong1 = new System.Windows.Forms.Label();
            this.labelWrong2 = new System.Windows.Forms.Label();
            this.labelRight1 = new System.Windows.Forms.Label();
            this.labelRight2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxsStudentName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.CpassBox = new System.Windows.Forms.TextBox();
            this.labelwrong3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.university_manageDataSet4 = new University_Management_System.University_manageDataSet4();
            this.studentInfoTableAdapter = new University_Management_System.University_manageDataSet4TableAdapters.StudentInfoTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelRight3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Upload_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(564, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admission Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name :";
            // 
            // FatherNameBox
            // 
            this.FatherNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FatherNameBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatherNameBox.Location = new System.Drawing.Point(235, 183);
            this.FatherNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.FatherNameBox.Name = "FatherNameBox";
            this.FatherNameBox.Size = new System.Drawing.Size(395, 40);
            this.FatherNameBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Father\'s Name :";
            // 
            // MotherNameBox
            // 
            this.MotherNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MotherNameBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherNameBox.Location = new System.Drawing.Point(235, 257);
            this.MotherNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.MotherNameBox.Name = "MotherNameBox";
            this.MotherNameBox.Size = new System.Drawing.Size(395, 40);
            this.MotherNameBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mother\'s Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 407);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 33);
            this.label6.TabIndex = 9;
            this.label6.Text = "Religion :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 479);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 33);
            this.label7.TabIndex = 11;
            this.label7.Text = "Blood Group :";
            // 
            // ContactBox
            // 
            this.ContactBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactBox.Location = new System.Drawing.Point(235, 551);
            this.ContactBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(395, 40);
            this.ContactBox.TabIndex = 14;
            this.ContactBox.TextChanged += new System.EventHandler(this.ContactBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 555);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 33);
            this.label8.TabIndex = 13;
            this.label8.Text = "Contract No :";
            // 
            // EmailBox
            // 
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(235, 629);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(395, 40);
            this.EmailBox.TabIndex = 16;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 633);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 33);
            this.label9.TabIndex = 15;
            this.label9.Text = "E-mail address :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 705);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 33);
            this.label10.TabIndex = 17;
            this.label10.Text = "Country :";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonMale.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(235, 332);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(85, 33);
            this.radioButtonMale.TabIndex = 19;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = false;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonFemale.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(403, 332);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(107, 33);
            this.radioButtonFemale.TabIndex = 20;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = false;
            // 
            // comboBoxReligion
            // 
            this.comboBoxReligion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReligion.FormattingEnabled = true;
            this.comboBoxReligion.Items.AddRange(new object[] {
            "",
            "Islam",
            "Hindu",
            "Christian",
            "Buddha",
            "Others"});
            this.comboBoxReligion.Location = new System.Drawing.Point(235, 407);
            this.comboBoxReligion.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxReligion.Name = "comboBoxReligion";
            this.comboBoxReligion.Size = new System.Drawing.Size(395, 37);
            this.comboBoxReligion.TabIndex = 21;
            // 
            // comboBoxBlood
            // 
            this.comboBoxBlood.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBlood.FormattingEnabled = true;
            this.comboBoxBlood.Items.AddRange(new object[] {
            "",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.comboBoxBlood.Location = new System.Drawing.Point(235, 479);
            this.comboBoxBlood.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBlood.Name = "comboBoxBlood";
            this.comboBoxBlood.Size = new System.Drawing.Size(395, 37);
            this.comboBoxBlood.TabIndex = 22;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Austrian Empire*",
            "Azerbaijan",
            "Baden*",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Bavaria*",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin (Dahomey)",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Brunswick and Lüneburg",
            "Bulgaria",
            "Burkina Faso (Upper Volta)",
            "Burma",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cayman Islands, The",
            "Central African Republic",
            "Central American Federation*",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo Free State, The",
            "Costa Rica",
            "Cote d’Ivoire (Ivory Coast)",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czechia",
            "Czechoslovakia",
            "Democratic Republic of the Congo",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Duchy of Parma, The*",
            "East Germany (German Democratic Republic)*",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Federal Government of Germany (1848-49)*",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia, The",
            "Georgia",
            "Germany",
            "Ghana",
            "Grand Duchy of Tuscany, The*",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Hanover*",
            "Hanseatic Republics*",
            "Hawaii*",
            "Hesse*",
            "Holy See",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kingdom of Serbia/Yugoslavia*",
            "Kiribati",
            "Korea",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Lew Chew (Loochoo)*",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mecklenburg-Schwerin*",
            "Mecklenburg-Strelitz*",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nassau*",
            "Nauru",
            "Nepal",
            "Netherlands, The",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North German Confederation*",
            "North German Union*",
            "North Macedonia",
            "Norway",
            "Oldenburg*",
            "Oman",
            "Orange Free State*",
            "Pakistan",
            "Palau",
            "Panama",
            "Papal States*",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Piedmont-Sardinia*",
            "Poland",
            "Portugal",
            "Qatar",
            "Republic of Genoa*",
            "Republic of Korea (South Korea)",
            "Republic of the Congo",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Schaumburg-Lippe*",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands, The",
            "Somalia",
            "South Africa",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Tajikistan",
            "Tanzania",
            "Texas*",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Two Sicilies*",
            "Uganda",
            "Ukraine",
            "Union of Soviet Socialist Republics*",
            "United Arab Emirates, The",
            "United Kingdom, The",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Württemberg*",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.comboBoxCountry.Location = new System.Drawing.Point(235, 704);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(395, 37);
            this.comboBoxCountry.TabIndex = 23;
            // 
            // SSCBox
            // 
            this.SSCBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SSCBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSCBox.Location = new System.Drawing.Point(860, 332);
            this.SSCBox.Margin = new System.Windows.Forms.Padding(4);
            this.SSCBox.Name = "SSCBox";
            this.SSCBox.Size = new System.Drawing.Size(93, 40);
            this.SSCBox.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(655, 336);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 33);
            this.label11.TabIndex = 28;
            this.label11.Text = "SSC GPA :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(655, 262);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 33);
            this.label12.TabIndex = 26;
            this.label12.Text = "Date of Birth :";
            // 
            // passBox
            // 
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBox.Location = new System.Drawing.Point(860, 114);
            this.passBox.Margin = new System.Windows.Forms.Padding(4);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(395, 40);
            this.passBox.TabIndex = 25;
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(655, 118);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 33);
            this.label13.TabIndex = 24;
            this.label13.Text = "Password :";
            // 
            // dateTimePickerDoB
            // 
            this.dateTimePickerDoB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDoB.Location = new System.Drawing.Point(860, 261);
            this.dateTimePickerDoB.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDoB.Name = "dateTimePickerDoB";
            this.dateTimePickerDoB.Size = new System.Drawing.Size(395, 36);
            this.dateTimePickerDoB.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(655, 486);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 33);
            this.label16.TabIndex = 33;
            this.label16.Text = "Program :";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Submit.Location = new System.Drawing.Point(1281, 773);
            this.Submit.Margin = new System.Windows.Forms.Padding(4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(191, 48);
            this.Submit.TabIndex = 37;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // PresentAddressBox
            // 
            this.PresentAddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PresentAddressBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentAddressBox.Location = new System.Drawing.Point(913, 554);
            this.PresentAddressBox.Margin = new System.Windows.Forms.Padding(4);
            this.PresentAddressBox.Multiline = true;
            this.PresentAddressBox.Name = "PresentAddressBox";
            this.PresentAddressBox.Size = new System.Drawing.Size(729, 72);
            this.PresentAddressBox.TabIndex = 39;
            this.PresentAddressBox.TextChanged += new System.EventHandler(this.PresentAddressBox_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(651, 557);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(210, 33);
            this.label18.TabIndex = 38;
            this.label18.Text = "Present Address :";
            // 
            // PermanentAddBox
            // 
            this.PermanentAddBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PermanentAddBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PermanentAddBox.Location = new System.Drawing.Point(913, 655);
            this.PermanentAddBox.Margin = new System.Windows.Forms.Padding(4);
            this.PermanentAddBox.Multiline = true;
            this.PermanentAddBox.Name = "PermanentAddBox";
            this.PermanentAddBox.Size = new System.Drawing.Size(729, 72);
            this.PermanentAddBox.TabIndex = 41;
            this.PermanentAddBox.TextChanged += new System.EventHandler(this.PermanentAddBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(651, 655);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(248, 33);
            this.label17.TabIndex = 42;
            this.label17.Text = "Permanent Address :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(1480, 773);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 48);
            this.button2.TabIndex = 43;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Upload_Pic
            // 
            this.Upload_Pic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Upload_Pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Upload_Pic.BackgroundImage")));
            this.Upload_Pic.Location = new System.Drawing.Point(1347, 60);
            this.Upload_Pic.Margin = new System.Windows.Forms.Padding(4);
            this.Upload_Pic.Name = "Upload_Pic";
            this.Upload_Pic.Size = new System.Drawing.Size(275, 257);
            this.Upload_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Upload_Pic.TabIndex = 44;
            this.Upload_Pic.TabStop = false;
            this.Upload_Pic.Click += new System.EventHandler(this.Upload_Pic_Click);
            // 
            // UpPicbutton
            // 
            this.UpPicbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpPicbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpPicbutton.BackgroundImage")));
            this.UpPicbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpPicbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpPicbutton.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpPicbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpPicbutton.Location = new System.Drawing.Point(1395, 325);
            this.UpPicbutton.Margin = new System.Windows.Forms.Padding(4);
            this.UpPicbutton.Name = "UpPicbutton";
            this.UpPicbutton.Size = new System.Drawing.Size(191, 41);
            this.UpPicbutton.TabIndex = 45;
            this.UpPicbutton.Text = "Upload Photo";
            this.UpPicbutton.UseVisualStyleBackColor = false;
            this.UpPicbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(963, 336);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 33);
            this.label19.TabIndex = 46;
            this.label19.Text = "Group :";
            // 
            // comboBoxSSC
            // 
            this.comboBoxSSC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSSC.FormattingEnabled = true;
            this.comboBoxSSC.Items.AddRange(new object[] {
            "",
            "Science",
            "Commerce",
            "Humanities",
            "A level"});
            this.comboBoxSSC.Location = new System.Drawing.Point(1060, 332);
            this.comboBoxSSC.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSSC.Name = "comboBoxSSC";
            this.comboBoxSSC.Size = new System.Drawing.Size(195, 37);
            this.comboBoxSSC.TabIndex = 47;
            // 
            // comboBoxHSC
            // 
            this.comboBoxHSC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHSC.FormattingEnabled = true;
            this.comboBoxHSC.Items.AddRange(new object[] {
            "",
            "Science",
            "Commerce",
            "Humanities",
            "O level"});
            this.comboBoxHSC.Location = new System.Drawing.Point(1060, 405);
            this.comboBoxHSC.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxHSC.Name = "comboBoxHSC";
            this.comboBoxHSC.Size = new System.Drawing.Size(195, 37);
            this.comboBoxHSC.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(963, 409);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 33);
            this.label14.TabIndex = 50;
            this.label14.Text = "Group :";
            // 
            // HSCBox
            // 
            this.HSCBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HSCBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSCBox.Location = new System.Drawing.Point(860, 405);
            this.HSCBox.Margin = new System.Windows.Forms.Padding(4);
            this.HSCBox.Name = "HSCBox";
            this.HSCBox.Size = new System.Drawing.Size(93, 40);
            this.HSCBox.TabIndex = 49;
            this.HSCBox.TextChanged += new System.EventHandler(this.HSCBox_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(655, 409);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 33);
            this.label20.TabIndex = 48;
            this.label20.Text = "HSC GPA :";
            // 
            // comboBoxProgram
            // 
            this.comboBoxProgram.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProgram.FormattingEnabled = true;
            this.comboBoxProgram.Items.AddRange(new object[] {
            "Bachelor of Architecture (BArch)",
            "BSc in Electrical and Electronic Engineering (EEE)",
            "BSc in Computer Engineering  (CoE)",
            "BSc in Industrial and Production Engineering (IPE)",
            "BSc in Computer Science and Engineering (CSE)",
            "Bachelor of Business Administration (BBA)",
            "Bachelor of Arts (BA) in Media and Comm.",
            "Bachelor of Arts (BA) in English",
            "Bachelor of Law (LLB)",
            "Bachelor of Social Science (BSS) in Economics"});
            this.comboBoxProgram.Location = new System.Drawing.Point(860, 486);
            this.comboBoxProgram.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProgram.Name = "comboBoxProgram";
            this.comboBoxProgram.Size = new System.Drawing.Size(395, 31);
            this.comboBoxProgram.TabIndex = 52;
            this.comboBoxProgram.SelectedIndexChanged += new System.EventHandler(this.comboBoxProgram_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label21.Location = new System.Drawing.Point(885, 491);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(151, 23);
            this.label21.TabIndex = 53;
            this.label21.Text = "You want to admit";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // labelWrong1
            // 
            this.labelWrong1.AutoSize = true;
            this.labelWrong1.BackColor = System.Drawing.Color.Red;
            this.labelWrong1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrong1.Location = new System.Drawing.Point(584, 560);
            this.labelWrong1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWrong1.Name = "labelWrong1";
            this.labelWrong1.Size = new System.Drawing.Size(34, 25);
            this.labelWrong1.TabIndex = 54;
            this.labelWrong1.Text = "❌";
            this.labelWrong1.Visible = false;
            // 
            // labelWrong2
            // 
            this.labelWrong2.AutoSize = true;
            this.labelWrong2.BackColor = System.Drawing.Color.Red;
            this.labelWrong2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrong2.Location = new System.Drawing.Point(584, 638);
            this.labelWrong2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWrong2.Name = "labelWrong2";
            this.labelWrong2.Size = new System.Drawing.Size(34, 25);
            this.labelWrong2.TabIndex = 55;
            this.labelWrong2.Text = "❌";
            this.labelWrong2.Visible = false;
            // 
            // labelRight1
            // 
            this.labelRight1.AutoSize = true;
            this.labelRight1.BackColor = System.Drawing.Color.LimeGreen;
            this.labelRight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRight1.Location = new System.Drawing.Point(584, 560);
            this.labelRight1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRight1.Name = "labelRight1";
            this.labelRight1.Size = new System.Drawing.Size(34, 25);
            this.labelRight1.TabIndex = 56;
            this.labelRight1.Text = "✔";
            this.labelRight1.Visible = false;
            // 
            // labelRight2
            // 
            this.labelRight2.AutoSize = true;
            this.labelRight2.BackColor = System.Drawing.Color.LimeGreen;
            this.labelRight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRight2.Location = new System.Drawing.Point(584, 638);
            this.labelRight2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRight2.Name = "labelRight2";
            this.labelRight2.Size = new System.Drawing.Size(34, 25);
            this.labelRight2.TabIndex = 57;
            this.labelRight2.Text = "✔";
            this.labelRight2.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(925, 565);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(369, 23);
            this.label15.TabIndex = 58;
            this.label15.Text = "City, District, Subdistrict, Union, Word, ZipCode";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(925, 666);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(369, 23);
            this.label22.TabIndex = 59;
            this.label22.Text = "City, District, Subdistrict, Union, Word, ZipCode";
            // 
            // textBoxsStudentName
            // 
            this.textBoxsStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxsStudentName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsStudentName.Location = new System.Drawing.Point(235, 114);
            this.textBoxsStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxsStudentName.Name = "textBoxsStudentName";
            this.textBoxsStudentName.Size = new System.Drawing.Size(395, 40);
            this.textBoxsStudentName.TabIndex = 60;
            this.textBoxsStudentName.TextChanged += new System.EventHandler(this.textBoxsStudentName_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(655, 191);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(179, 33);
            this.label23.TabIndex = 61;
            this.label23.Text = "Confirm Pass. :";
            // 
            // CpassBox
            // 
            this.CpassBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CpassBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpassBox.Location = new System.Drawing.Point(860, 187);
            this.CpassBox.Margin = new System.Windows.Forms.Padding(4);
            this.CpassBox.Name = "CpassBox";
            this.CpassBox.Size = new System.Drawing.Size(395, 40);
            this.CpassBox.TabIndex = 62;
            this.CpassBox.UseSystemPasswordChar = true;
            this.CpassBox.TextChanged += new System.EventHandler(this.CpassBox_TextChanged);
            // 
            // labelwrong3
            // 
            this.labelwrong3.AutoSize = true;
            this.labelwrong3.BackColor = System.Drawing.Color.Red;
            this.labelwrong3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwrong3.Location = new System.Drawing.Point(1207, 195);
            this.labelwrong3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelwrong3.Name = "labelwrong3";
            this.labelwrong3.Size = new System.Drawing.Size(34, 25);
            this.labelwrong3.TabIndex = 65;
            this.labelwrong3.Text = "❌";
            this.labelwrong3.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(1082, 773);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 48);
            this.button3.TabIndex = 67;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.university_manageDataSet4;
            // 
            // university_manageDataSet4
            // 
            this.university_manageDataSet4.DataSetName = "University_manageDataSet4";
            this.university_manageDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(1103, 161);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 20);
            this.checkBox1.TabIndex = 68;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelRight3
            // 
            this.labelRight3.AutoSize = true;
            this.labelRight3.BackColor = System.Drawing.Color.LimeGreen;
            this.labelRight3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRight3.Location = new System.Drawing.Point(1207, 194);
            this.labelRight3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRight3.Name = "labelRight3";
            this.labelRight3.Size = new System.Drawing.Size(34, 25);
            this.labelRight3.TabIndex = 69;
            this.labelRight3.Text = "✔";
            this.labelRight3.Visible = false;
            // 
            // Student_Admission_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1684, 836);
            this.Controls.Add(this.labelRight3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelwrong3);
            this.Controls.Add(this.CpassBox);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.textBoxsStudentName);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelRight2);
            this.Controls.Add(this.labelRight1);
            this.Controls.Add(this.labelWrong2);
            this.Controls.Add(this.labelWrong1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.comboBoxProgram);
            this.Controls.Add(this.comboBoxHSC);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.HSCBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.comboBoxSSC);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.UpPicbutton);
            this.Controls.Add(this.Upload_Pic);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.PermanentAddBox);
            this.Controls.Add(this.PresentAddressBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dateTimePickerDoB);
            this.Controls.Add(this.SSCBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.comboBoxBlood);
            this.Controls.Add(this.comboBoxReligion);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MotherNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FatherNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Student_Admission_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Student_Admission_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Upload_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FatherNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MotherNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ContactBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.ComboBox comboBoxReligion;
        private System.Windows.Forms.ComboBox comboBoxBlood;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.TextBox SSCBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox PresentAddressBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox PermanentAddBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox Upload_Pic;
        private System.Windows.Forms.Button UpPicbutton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBoxSSC;
        private System.Windows.Forms.ComboBox comboBoxHSC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox HSCBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBoxProgram;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelWrong1;
        private System.Windows.Forms.Label labelWrong2;
        private System.Windows.Forms.Label labelRight1;
        private System.Windows.Forms.Label labelRight2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxsStudentName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox CpassBox;
        private System.Windows.Forms.Label labelwrong3;
        private System.Windows.Forms.Button button3;
        private University_manageDataSet4 university_manageDataSet4;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private University_manageDataSet4TableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelRight3;
    }
}