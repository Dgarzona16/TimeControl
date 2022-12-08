namespace test.Forms
{
    partial class TotalHours
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_TotalHours = new MetroFramework.Controls.MetroGrid();
            this.TXT_employee = new MetroFramework.Controls.MetroTextBox();
            this.DT_startDate = new MetroFramework.Controls.MetroDateTime();
            this.LBL_startDate = new MetroFramework.Controls.MetroLabel();
            this.LBL_endDate = new MetroFramework.Controls.MetroLabel();
            this.DT_EndDate = new MetroFramework.Controls.MetroDateTime();
            this.BTN_export = new MetroFramework.Controls.MetroButton();
            this.BTN_Search = new MetroFramework.Controls.MetroButton();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TotalHours)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_TotalHours
            // 
            this.DGV_TotalHours.AllowUserToResizeRows = false;
            this.DGV_TotalHours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_TotalHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_TotalHours.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_TotalHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_TotalHours.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_TotalHours.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TotalHours.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TotalHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TotalHours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee,
            this.Phone,
            this.Company,
            this.Job,
            this.Time});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_TotalHours.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_TotalHours.EnableHeadersVisualStyles = false;
            this.DGV_TotalHours.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGV_TotalHours.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_TotalHours.Location = new System.Drawing.Point(23, 78);
            this.DGV_TotalHours.Name = "DGV_TotalHours";
            this.DGV_TotalHours.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TotalHours.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_TotalHours.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_TotalHours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TotalHours.Size = new System.Drawing.Size(709, 363);
            this.DGV_TotalHours.Style = MetroFramework.MetroColorStyle.Orange;
            this.DGV_TotalHours.TabIndex = 0;
            // 
            // TXT_employee
            // 
            this.TXT_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TXT_employee.CustomButton.Image = null;
            this.TXT_employee.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.TXT_employee.CustomButton.Name = "";
            this.TXT_employee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXT_employee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_employee.CustomButton.TabIndex = 1;
            this.TXT_employee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_employee.CustomButton.UseSelectable = true;
            this.TXT_employee.CustomButton.Visible = false;
            this.TXT_employee.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TXT_employee.Lines = new string[] {
        "Employee Phone"};
            this.TXT_employee.Location = new System.Drawing.Point(739, 78);
            this.TXT_employee.MaxLength = 32767;
            this.TXT_employee.Name = "TXT_employee";
            this.TXT_employee.PasswordChar = '\0';
            this.TXT_employee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_employee.SelectedText = "";
            this.TXT_employee.SelectionLength = 0;
            this.TXT_employee.SelectionStart = 0;
            this.TXT_employee.ShortcutsEnabled = true;
            this.TXT_employee.Size = new System.Drawing.Size(200, 23);
            this.TXT_employee.TabIndex = 1;
            this.TXT_employee.Text = "Employee Phone";
            this.TXT_employee.UseSelectable = true;
            this.TXT_employee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_employee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXT_employee.Enter += new System.EventHandler(this.TXT_employee_Enter);
            this.TXT_employee.Leave += new System.EventHandler(this.TXT_employee_Leave);
            // 
            // DT_startDate
            // 
            this.DT_startDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_startDate.Location = new System.Drawing.Point(739, 139);
            this.DT_startDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DT_startDate.Name = "DT_startDate";
            this.DT_startDate.Size = new System.Drawing.Size(200, 29);
            this.DT_startDate.Style = MetroFramework.MetroColorStyle.Orange;
            this.DT_startDate.TabIndex = 2;
            // 
            // LBL_startDate
            // 
            this.LBL_startDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_startDate.AutoSize = true;
            this.LBL_startDate.Location = new System.Drawing.Point(739, 114);
            this.LBL_startDate.Name = "LBL_startDate";
            this.LBL_startDate.Size = new System.Drawing.Size(68, 19);
            this.LBL_startDate.TabIndex = 3;
            this.LBL_startDate.Text = "Start Date";
            // 
            // LBL_endDate
            // 
            this.LBL_endDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_endDate.AutoSize = true;
            this.LBL_endDate.Location = new System.Drawing.Point(739, 183);
            this.LBL_endDate.Name = "LBL_endDate";
            this.LBL_endDate.Size = new System.Drawing.Size(62, 19);
            this.LBL_endDate.TabIndex = 5;
            this.LBL_endDate.Text = "End Date";
            // 
            // DT_EndDate
            // 
            this.DT_EndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_EndDate.Location = new System.Drawing.Point(739, 208);
            this.DT_EndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DT_EndDate.Name = "DT_EndDate";
            this.DT_EndDate.Size = new System.Drawing.Size(200, 29);
            this.DT_EndDate.Style = MetroFramework.MetroColorStyle.Orange;
            this.DT_EndDate.TabIndex = 4;
            // 
            // BTN_export
            // 
            this.BTN_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_export.Location = new System.Drawing.Point(739, 399);
            this.BTN_export.Name = "BTN_export";
            this.BTN_export.Size = new System.Drawing.Size(200, 42);
            this.BTN_export.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_export.TabIndex = 6;
            this.BTN_export.Text = "Export to excel";
            this.BTN_export.UseSelectable = true;
            this.BTN_export.Click += new System.EventHandler(this.BTN_export_Click);
            // 
            // BTN_Search
            // 
            this.BTN_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Search.Location = new System.Drawing.Point(739, 339);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(200, 42);
            this.BTN_Search.Style = MetroFramework.MetroColorStyle.Green;
            this.BTN_Search.TabIndex = 7;
            this.BTN_Search.Text = "Get Total Time";
            this.BTN_Search.UseSelectable = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Employee";
            this.Employee.Name = "Employee";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // Job
            // 
            this.Job.HeaderText = "Job";
            this.Job.Name = "Job";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // TotalHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 464);
            this.Controls.Add(this.BTN_Search);
            this.Controls.Add(this.BTN_export);
            this.Controls.Add(this.LBL_endDate);
            this.Controls.Add(this.DT_EndDate);
            this.Controls.Add(this.LBL_startDate);
            this.Controls.Add(this.DT_startDate);
            this.Controls.Add(this.TXT_employee);
            this.Controls.Add(this.DGV_TotalHours);
            this.Name = "TotalHours";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Total Time";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TotalHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid DGV_TotalHours;
        private MetroFramework.Controls.MetroTextBox TXT_employee;
        private MetroFramework.Controls.MetroDateTime DT_startDate;
        private MetroFramework.Controls.MetroLabel LBL_startDate;
        private MetroFramework.Controls.MetroLabel LBL_endDate;
        private MetroFramework.Controls.MetroDateTime DT_EndDate;
        private MetroFramework.Controls.MetroButton BTN_export;
        private MetroFramework.Controls.MetroButton BTN_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}