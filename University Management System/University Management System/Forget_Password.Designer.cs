namespace University_Management_System
{
    partial class Forget_Password
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
            this.GetPass = new System.Windows.Forms.Button();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.ConoBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.getpassbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetPass
            // 
            this.GetPass.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetPass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GetPass.Location = new System.Drawing.Point(283, 243);
            this.GetPass.Margin = new System.Windows.Forms.Padding(4);
            this.GetPass.Name = "GetPass";
            this.GetPass.Size = new System.Drawing.Size(364, 48);
            this.GetPass.TabIndex = 15;
            this.GetPass.Text = "Get Password";
            this.GetPass.UseVisualStyleBackColor = false;
            this.GetPass.Click += new System.EventHandler(this.GetPass_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(283, 84);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(363, 44);
            this.EmailBox.TabIndex = 14;
            // 
            // ConoBox
            // 
            this.ConoBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConoBox.Location = new System.Drawing.Point(283, 158);
            this.ConoBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConoBox.Name = "ConoBox";
            this.ConoBox.Size = new System.Drawing.Size(363, 44);
            this.ConoBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(105, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contact No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(105, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "E-mail :";
            // 
            // getpassbox
            // 
            this.getpassbox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getpassbox.Location = new System.Drawing.Point(283, 334);
            this.getpassbox.Margin = new System.Windows.Forms.Padding(4);
            this.getpassbox.Name = "getpassbox";
            this.getpassbox.Size = new System.Drawing.Size(363, 44);
            this.getpassbox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(98, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password is :";
            // 
            // Forget_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getpassbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetPass);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.ConoBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "Forget_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forget_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetPass;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox ConoBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox getpassbox;
        private System.Windows.Forms.Label label1;
    }
}