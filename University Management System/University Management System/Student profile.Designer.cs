namespace University_Management_System
{
    partial class Student_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_profile));
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.studentInfoTableAdapter = new University_Management_System.University_manageDataSet4TableAdapters.StudentInfoTableAdapter();
            this.university_manageDataSet4 = new University_Management_System.University_manageDataSet4();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Upload_Pic = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label16pro = new System.Windows.Forms.Label();
            this.labeldob = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelSName = new System.Windows.Forms.Label();
            this.labelBG = new System.Windows.Forms.Label();
            this.labelMname = new System.Windows.Forms.Label();
            this.labelPermAdd = new System.Windows.Forms.Label();
            this.labelpreAdd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Upload_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProfile.BackgroundImage")));
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.Location = new System.Drawing.Point(16, 15);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(313, 57);
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            // 
            // buttonlogout
            // 
            this.buttonlogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonlogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonlogout.BackgroundImage")));
            this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogout.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonlogout.Location = new System.Drawing.Point(16, 98);
            this.buttonlogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(313, 57);
            this.buttonlogout.TabIndex = 4;
            this.buttonlogout.Text = "Logout";
            this.buttonlogout.UseVisualStyleBackColor = false;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // university_manageDataSet4
            // 
            this.university_manageDataSet4.DataSetName = "University_manageDataSet4";
            this.university_manageDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.university_manageDataSet4;
            // 
            // Upload_Pic
            // 
            this.Upload_Pic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Upload_Pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Upload_Pic.BackgroundImage")));
            this.Upload_Pic.Location = new System.Drawing.Point(1013, 15);
            this.Upload_Pic.Margin = new System.Windows.Forms.Padding(4);
            this.Upload_Pic.Name = "Upload_Pic";
            this.Upload_Pic.Size = new System.Drawing.Size(275, 257);
            this.Upload_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Upload_Pic.TabIndex = 102;
            this.Upload_Pic.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(1280, 743);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 48);
            this.button2.TabIndex = 101;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label16pro
            // 
            this.label16pro.AutoSize = true;
            this.label16pro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16pro.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16pro.Location = new System.Drawing.Point(361, 233);
            this.label16pro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16pro.Name = "label16pro";
            this.label16pro.Size = new System.Drawing.Size(103, 28);
            this.label16pro.TabIndex = 95;
            this.label16pro.Text = "Program :";
            // 
            // labeldob
            // 
            this.labeldob.AutoSize = true;
            this.labeldob.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeldob.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldob.Location = new System.Drawing.Point(361, 291);
            this.labeldob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldob.Name = "labeldob";
            this.labeldob.Size = new System.Drawing.Size(145, 28);
            this.labeldob.TabIndex = 91;
            this.labeldob.Text = "Date of Birth :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-171, 675);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 33);
            this.label10.TabIndex = 83;
            this.label10.Text = "Country :";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelemail.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(362, 352);
            this.labelemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(161, 28);
            this.labelemail.TabIndex = 81;
            this.labelemail.Text = "E-mail address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-171, 525);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 33);
            this.label8.TabIndex = 79;
            this.label8.Text = "Contract No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-171, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 33);
            this.label6.TabIndex = 77;
            this.label6.Text = "Religion :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-171, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 33);
            this.label5.TabIndex = 76;
            this.label5.Text = "Gender :";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFname.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFname.Location = new System.Drawing.Point(362, 74);
            this.labelFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(160, 28);
            this.labelFname.TabIndex = 72;
            this.labelFname.Text = "Father\'s Name :";
            // 
            // labelSName
            // 
            this.labelSName.AutoSize = true;
            this.labelSName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSName.Location = new System.Drawing.Point(361, 15);
            this.labelSName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSName.Name = "labelSName";
            this.labelSName.Size = new System.Drawing.Size(160, 28);
            this.labelSName.TabIndex = 71;
            this.labelSName.Text = "Student Name :";
            this.labelSName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelBG
            // 
            this.labelBG.AutoSize = true;
            this.labelBG.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBG.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBG.Location = new System.Drawing.Point(362, 183);
            this.labelBG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBG.Name = "labelBG";
            this.labelBG.Size = new System.Drawing.Size(142, 28);
            this.labelBG.TabIndex = 104;
            this.labelBG.Text = "Blood Group :";
            // 
            // labelMname
            // 
            this.labelMname.AutoSize = true;
            this.labelMname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMname.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMname.Location = new System.Drawing.Point(361, 127);
            this.labelMname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMname.Name = "labelMname";
            this.labelMname.Size = new System.Drawing.Size(171, 28);
            this.labelMname.TabIndex = 103;
            this.labelMname.Text = "Mother\'s Name :";
            // 
            // labelPermAdd
            // 
            this.labelPermAdd.AutoSize = true;
            this.labelPermAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPermAdd.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPermAdd.Location = new System.Drawing.Point(363, 469);
            this.labelPermAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPermAdd.Name = "labelPermAdd";
            this.labelPermAdd.Size = new System.Drawing.Size(210, 28);
            this.labelPermAdd.TabIndex = 108;
            this.labelPermAdd.Text = "Permanent Address :";
            // 
            // labelpreAdd
            // 
            this.labelpreAdd.AutoSize = true;
            this.labelpreAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelpreAdd.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpreAdd.Location = new System.Drawing.Point(362, 410);
            this.labelpreAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpreAdd.Name = "labelpreAdd";
            this.labelpreAdd.Size = new System.Drawing.Size(177, 28);
            this.labelpreAdd.TabIndex = 107;
            this.labelpreAdd.Text = "Present Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(852, 352);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 109;
            this.label1.Text = "Contract No :";
            // 
            // Student_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1301, 773);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPermAdd);
            this.Controls.Add(this.labelpreAdd);
            this.Controls.Add(this.labelBG);
            this.Controls.Add(this.labelMname);
            this.Controls.Add(this.Upload_Pic);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label16pro);
            this.Controls.Add(this.labeldob);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.labelSName);
            this.Controls.Add(this.buttonlogout);
            this.Controls.Add(this.buttonProfile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Student_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_profile";
            this.Load += new System.EventHandler(this.Student_profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Upload_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonlogout;
        private University_manageDataSet4TableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private University_manageDataSet4 university_manageDataSet4;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private System.Windows.Forms.PictureBox Upload_Pic;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16pro;
        private System.Windows.Forms.Label labeldob;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelSName;
        private System.Windows.Forms.Label labelBG;
        private System.Windows.Forms.Label labelMname;
        private System.Windows.Forms.Label labelPermAdd;
        private System.Windows.Forms.Label labelpreAdd;
        private System.Windows.Forms.Label label1;
    }
}