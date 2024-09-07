namespace University_Management_System
{
    partial class Account_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Info));
            this.SearchBox1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentFeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.university_manageDataSet24 = new University_Management_System.University_manageDataSet24();
            this.SearchBoxS = new System.Windows.Forms.TextBox();
            this.Spay = new System.Windows.Forms.Button();
            this.TSDatagrid = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.university_manageDataSet23 = new University_Management_System.University_manageDataSet23();
            this.studentFeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentFeesTableAdapter = new University_Management_System.University_manageDataSet23TableAdapters.StudentFeesTableAdapter();
            this.studentFeesTableAdapter1 = new University_Management_System.University_manageDataSet24TableAdapters.StudentFeesTableAdapter();
            this.university_manageDataSet25 = new University_Management_System.University_manageDataSet25();
            this.studentFeesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentFeesTableAdapter2 = new University_Management_System.University_manageDataSet25TableAdapters.StudentFeesTableAdapter();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.university_manageDataSet26 = new University_Management_System.University_manageDataSet26();
            this.teacherSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherSalaryTableAdapter = new University_Management_System.University_manageDataSet26TableAdapters.TeacherSalaryTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch2 = new System.Windows.Forms.Button();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.university_manageDataSet27 = new University_Management_System.University_manageDataSet27();
            this.employeeSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSalaryTableAdapter = new University_Management_System.University_manageDataSet27TableAdapters.EmployeeSalaryTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox1
            // 
            this.SearchBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SearchBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBox1.Location = new System.Drawing.Point(1000, 112);
            this.SearchBox1.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox1.Name = "SearchBox1";
            this.SearchBox1.Size = new System.Drawing.Size(183, 40);
            this.SearchBox1.TabIndex = 80;
            this.SearchBox1.Text = "Search";
            this.SearchBox1.UseVisualStyleBackColor = false;
            this.SearchBox1.Visible = false;
            this.SearchBox1.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emailDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentFeesBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(205, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(978, 601);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.Visible = false;
            // 
            // studentFeesBindingSource1
            // 
            this.studentFeesBindingSource1.DataMember = "StudentFees";
            this.studentFeesBindingSource1.DataSource = this.university_manageDataSet24;
            // 
            // university_manageDataSet24
            // 
            this.university_manageDataSet24.DataSetName = "University_manageDataSet24";
            this.university_manageDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SearchBoxS
            // 
            this.SearchBoxS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBoxS.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBoxS.Location = new System.Drawing.Point(504, 116);
            this.SearchBoxS.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBoxS.Name = "SearchBoxS";
            this.SearchBoxS.Size = new System.Drawing.Size(488, 36);
            this.SearchBoxS.TabIndex = 78;
            this.SearchBoxS.Visible = false;
            // 
            // Spay
            // 
            this.Spay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Spay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Spay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Spay.Location = new System.Drawing.Point(13, 13);
            this.Spay.Margin = new System.Windows.Forms.Padding(4);
            this.Spay.Name = "Spay";
            this.Spay.Size = new System.Drawing.Size(183, 43);
            this.Spay.TabIndex = 90;
            this.Spay.Text = "Student payment";
            this.Spay.UseVisualStyleBackColor = false;
            this.Spay.Click += new System.EventHandler(this.Spay_Click);
            // 
            // TSDatagrid
            // 
            this.TSDatagrid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TSDatagrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSDatagrid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSDatagrid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TSDatagrid.Location = new System.Drawing.Point(204, 13);
            this.TSDatagrid.Margin = new System.Windows.Forms.Padding(4);
            this.TSDatagrid.Name = "TSDatagrid";
            this.TSDatagrid.Size = new System.Drawing.Size(183, 43);
            this.TSDatagrid.TabIndex = 89;
            this.TSDatagrid.Text = "Teachers Salary";
            this.TSDatagrid.UseVisualStyleBackColor = false;
            this.TSDatagrid.Click += new System.EventHandler(this.TSDatagrid_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(395, 13);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(183, 43);
            this.button7.TabIndex = 88;
            this.button7.Text = "Employee Salary";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // university_manageDataSet23
            // 
            this.university_manageDataSet23.DataSetName = "University_manageDataSet23";
            this.university_manageDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentFeesBindingSource
            // 
            this.studentFeesBindingSource.DataMember = "StudentFees";
            this.studentFeesBindingSource.DataSource = this.university_manageDataSet23;
            // 
            // studentFeesTableAdapter
            // 
            this.studentFeesTableAdapter.ClearBeforeFill = true;
            // 
            // studentFeesTableAdapter1
            // 
            this.studentFeesTableAdapter1.ClearBeforeFill = true;
            // 
            // university_manageDataSet25
            // 
            this.university_manageDataSet25.DataSetName = "University_manageDataSet25";
            this.university_manageDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentFeesBindingSource2
            // 
            this.studentFeesBindingSource2.DataMember = "StudentFees";
            this.studentFeesBindingSource2.DataSource = this.university_manageDataSet25;
            // 
            // studentFeesTableAdapter2
            // 
            this.studentFeesTableAdapter2.ClearBeforeFill = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn1,
            this.departmentDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.teacherSalaryBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(204, 160);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(978, 601);
            this.dataGridView2.TabIndex = 92;
            this.dataGridView2.Visible = false;
            // 
            // university_manageDataSet26
            // 
            this.university_manageDataSet26.DataSetName = "University_manageDataSet26";
            this.university_manageDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherSalaryBindingSource
            // 
            this.teacherSalaryBindingSource.DataMember = "TeacherSalary";
            this.teacherSalaryBindingSource.DataSource = this.university_manageDataSet26;
            // 
            // teacherSalaryTableAdapter
            // 
            this.teacherSalaryTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn1
            // 
            this.departmentDataGridViewTextBoxColumn1.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn1.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn1.Name = "departmentDataGridViewTextBoxColumn1";
            this.departmentDataGridViewTextBoxColumn1.Width = 125;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(1000, 114);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(183, 40);
            this.buttonSearch.TabIndex = 94;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Visible = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(504, 117);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(488, 36);
            this.textBoxSearch.TabIndex = 93;
            this.textBoxSearch.Visible = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonSearch2
            // 
            this.buttonSearch2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch2.Location = new System.Drawing.Point(1000, 115);
            this.buttonSearch2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch2.Name = "buttonSearch2";
            this.buttonSearch2.Size = new System.Drawing.Size(183, 40);
            this.buttonSearch2.TabIndex = 96;
            this.buttonSearch2.Text = "Search";
            this.buttonSearch2.UseVisualStyleBackColor = false;
            this.buttonSearch2.Visible = false;
            this.buttonSearch2.Click += new System.EventHandler(this.buttonSearch2_Click);
            // 
            // textBoxSearch2
            // 
            this.textBoxSearch2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch2.Location = new System.Drawing.Point(504, 118);
            this.textBoxSearch2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(488, 36);
            this.textBoxSearch2.TabIndex = 95;
            this.textBoxSearch2.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.monthDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn2,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.employeeSalaryBindingSource;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView3.Location = new System.Drawing.Point(205, 159);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(978, 601);
            this.dataGridView3.TabIndex = 97;
            this.dataGridView3.Visible = false;
            // 
            // university_manageDataSet27
            // 
            this.university_manageDataSet27.DataSetName = "University_manageDataSet27";
            this.university_manageDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeSalaryBindingSource
            // 
            this.employeeSalaryBindingSource.DataMember = "EmployeeSalary";
            this.employeeSalaryBindingSource.DataSource = this.university_manageDataSet27;
            // 
            // employeeSalaryTableAdapter
            // 
            this.employeeSalaryTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // monthDataGridViewTextBoxColumn1
            // 
            this.monthDataGridViewTextBoxColumn1.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn1.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.monthDataGridViewTextBoxColumn1.Name = "monthDataGridViewTextBoxColumn1";
            this.monthDataGridViewTextBoxColumn1.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn2
            // 
            this.amountDataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn2.Name = "amountDataGridViewTextBoxColumn2";
            this.amountDataGridViewTextBoxColumn2.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // Account_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1382, 773);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.buttonSearch2);
            this.Controls.Add(this.textBoxSearch2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Spay);
            this.Controls.Add(this.TSDatagrid);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.SearchBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBoxS);
            this.Name = "Account_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account_Info";
            this.Load += new System.EventHandler(this.Account_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentFeesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.university_manageDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchBoxS;
        private System.Windows.Forms.Button Spay;
        private System.Windows.Forms.Button TSDatagrid;
        private System.Windows.Forms.Button button7;
        private University_manageDataSet23 university_manageDataSet23;
        private System.Windows.Forms.BindingSource studentFeesBindingSource;
        private University_manageDataSet23TableAdapters.StudentFeesTableAdapter studentFeesTableAdapter;
        private University_manageDataSet24 university_manageDataSet24;
        private System.Windows.Forms.BindingSource studentFeesBindingSource1;
        private University_manageDataSet24TableAdapters.StudentFeesTableAdapter studentFeesTableAdapter1;
        private University_manageDataSet25 university_manageDataSet25;
        private System.Windows.Forms.BindingSource studentFeesBindingSource2;
        private University_manageDataSet25TableAdapters.StudentFeesTableAdapter studentFeesTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private University_manageDataSet26 university_manageDataSet26;
        private System.Windows.Forms.BindingSource teacherSalaryBindingSource;
        private University_manageDataSet26TableAdapters.TeacherSalaryTableAdapter teacherSalaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch2;
        private System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private University_manageDataSet27 university_manageDataSet27;
        private System.Windows.Forms.BindingSource employeeSalaryBindingSource;
        private University_manageDataSet27TableAdapters.EmployeeSalaryTableAdapter employeeSalaryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}