namespace University_Management_System
{
    partial class Faculty_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faculty_Profile));
            this.buttonlogout = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.labelMname = new System.Windows.Forms.Label();
            this.Upload_Pic = new System.Windows.Forms.PictureBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.labelSName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Upload_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonlogout
            // 
            this.buttonlogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonlogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonlogout.BackgroundImage")));
            this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogout.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonlogout.Location = new System.Drawing.Point(13, 95);
            this.buttonlogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(313, 57);
            this.buttonlogout.TabIndex = 9;
            this.buttonlogout.Text = "Logout";
            this.buttonlogout.UseVisualStyleBackColor = false;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
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
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            // 
            // labelMname
            // 
            this.labelMname.AutoSize = true;
            this.labelMname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMname.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMname.Location = new System.Drawing.Point(343, 127);
            this.labelMname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMname.Name = "labelMname";
            this.labelMname.Size = new System.Drawing.Size(140, 28);
            this.labelMname.TabIndex = 116;
            this.labelMname.Text = "Department :";
            // 
            // Upload_Pic
            // 
            this.Upload_Pic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Upload_Pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Upload_Pic.BackgroundImage")));
            this.Upload_Pic.Location = new System.Drawing.Point(995, 15);
            this.Upload_Pic.Margin = new System.Windows.Forms.Padding(4);
            this.Upload_Pic.Name = "Upload_Pic";
            this.Upload_Pic.Size = new System.Drawing.Size(275, 257);
            this.Upload_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Upload_Pic.TabIndex = 115;
            this.Upload_Pic.TabStop = false;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelemail.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(344, 186);
            this.labelemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(161, 28);
            this.labelemail.TabIndex = 112;
            this.labelemail.Text = "E-mail address :";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFname.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFname.Location = new System.Drawing.Point(344, 74);
            this.labelFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(145, 28);
            this.labelFname.TabIndex = 111;
            this.labelFname.Text = "Qualification :";
            // 
            // labelSName
            // 
            this.labelSName.AutoSize = true;
            this.labelSName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSName.Location = new System.Drawing.Point(343, 15);
            this.labelSName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSName.Name = "labelSName";
            this.labelSName.Size = new System.Drawing.Size(80, 28);
            this.labelSName.TabIndex = 110;
            this.labelSName.Text = "Name :";
            // 
            // Faculty_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1301, 773);
            this.Controls.Add(this.labelMname);
            this.Controls.Add(this.Upload_Pic);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.labelSName);
            this.Controls.Add(this.buttonlogout);
            this.Controls.Add(this.buttonProfile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Faculty_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty_Profile";
            this.Load += new System.EventHandler(this.Faculty_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Upload_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonlogout;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Label labelMname;
        private System.Windows.Forms.PictureBox Upload_Pic;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label labelSName;
    }
}