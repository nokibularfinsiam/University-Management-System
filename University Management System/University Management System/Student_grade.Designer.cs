namespace University_Management_System
{
    partial class Student_grade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_grade));
            this.buttonCourses = new System.Windows.Forms.Button();
            this.buttonlogout = new System.Windows.Forms.Button();
            this.buttongrade = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCourses
            // 
            this.buttonCourses.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCourses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCourses.BackgroundImage")));
            this.buttonCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCourses.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCourses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCourses.Location = new System.Drawing.Point(12, 79);
            this.buttonCourses.Name = "buttonCourses";
            this.buttonCourses.Size = new System.Drawing.Size(235, 46);
            this.buttonCourses.TabIndex = 20;
            this.buttonCourses.Text = "Courses";
            this.buttonCourses.UseVisualStyleBackColor = false;
            this.buttonCourses.Click += new System.EventHandler(this.buttonCourses_Click);
            // 
            // buttonlogout
            // 
            this.buttonlogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonlogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonlogout.BackgroundImage")));
            this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogout.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonlogout.Location = new System.Drawing.Point(12, 292);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(235, 46);
            this.buttonlogout.TabIndex = 19;
            this.buttonlogout.Text = "Back";
            this.buttonlogout.UseVisualStyleBackColor = false;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // buttongrade
            // 
            this.buttongrade.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttongrade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttongrade.BackgroundImage")));
            this.buttongrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttongrade.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttongrade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttongrade.Location = new System.Drawing.Point(12, 149);
            this.buttongrade.Name = "buttongrade";
            this.buttongrade.Size = new System.Drawing.Size(235, 46);
            this.buttongrade.TabIndex = 18;
            this.buttongrade.Text = "Grade Report";
            this.buttongrade.UseVisualStyleBackColor = false;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProfile.BackgroundImage")));
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProfile.Location = new System.Drawing.Point(12, 12);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(235, 46);
            this.buttonProfile.TabIndex = 16;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 46);
            this.button1.TabIndex = 53;
            this.button1.Text = "Financials";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(976, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCourses);
            this.Controls.Add(this.buttonlogout);
            this.Controls.Add(this.buttongrade);
            this.Controls.Add(this.buttonProfile);
            this.Name = "Student_grade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_grade";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCourses;
        private System.Windows.Forms.Button buttonlogout;
        private System.Windows.Forms.Button buttongrade;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button button1;
    }
}