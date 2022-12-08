namespace test.Forms
{
    partial class EmployeeForm
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
            this.BTN_accept = new MetroFramework.Controls.MetroButton();
            this.BTN_cancel = new MetroFramework.Controls.MetroButton();
            this.TXT_employee = new MetroFramework.Controls.MetroTextBox();
            this.LBL_employee = new MetroFramework.Controls.MetroLabel();
            this.BTN_addEmployee = new MetroFramework.Controls.MetroButton();
            this.BTN_search = new MetroFramework.Controls.MetroButton();
            this.DGV_employee = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_accept
            // 
            this.BTN_accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_accept.AutoSize = true;
            this.BTN_accept.Location = new System.Drawing.Point(613, 471);
            this.BTN_accept.Name = "BTN_accept";
            this.BTN_accept.Size = new System.Drawing.Size(132, 51);
            this.BTN_accept.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_accept.TabIndex = 3;
            this.BTN_accept.Text = "Accept";
            this.BTN_accept.UseSelectable = true;
            this.BTN_accept.Click += new System.EventHandler(this.BTN_accept_Click);
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_cancel.AutoSize = true;
            this.BTN_cancel.Location = new System.Drawing.Point(415, 471);
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.Size = new System.Drawing.Size(132, 51);
            this.BTN_cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_cancel.TabIndex = 4;
            this.BTN_cancel.Text = "Cancel";
            this.BTN_cancel.UseSelectable = true;
            this.BTN_cancel.Click += new System.EventHandler(this.BTN_cancel_Click);
            // 
            // TXT_employee
            // 
            this.TXT_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TXT_employee.CustomButton.Image = null;
            this.TXT_employee.CustomButton.Location = new System.Drawing.Point(326, 1);
            this.TXT_employee.CustomButton.Name = "";
            this.TXT_employee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXT_employee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_employee.CustomButton.TabIndex = 1;
            this.TXT_employee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_employee.CustomButton.UseSelectable = true;
            this.TXT_employee.CustomButton.Visible = false;
            this.TXT_employee.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TXT_employee.Lines = new string[] {
        "Search Employee"};
            this.TXT_employee.Location = new System.Drawing.Point(406, 165);
            this.TXT_employee.MaxLength = 32767;
            this.TXT_employee.Name = "TXT_employee";
            this.TXT_employee.PasswordChar = '\0';
            this.TXT_employee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_employee.SelectedText = "";
            this.TXT_employee.SelectionLength = 0;
            this.TXT_employee.SelectionStart = 0;
            this.TXT_employee.ShortcutsEnabled = true;
            this.TXT_employee.Size = new System.Drawing.Size(348, 23);
            this.TXT_employee.Style = MetroFramework.MetroColorStyle.Orange;
            this.TXT_employee.TabIndex = 5;
            this.TXT_employee.Text = "Search Employee";
            this.TXT_employee.UseSelectable = true;
            this.TXT_employee.UseStyleColors = true;
            this.TXT_employee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_employee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXT_employee.Enter += new System.EventHandler(this.TXT_employee_Enter);
            this.TXT_employee.Leave += new System.EventHandler(this.TXT_employee_Leave);
            // 
            // LBL_employee
            // 
            this.LBL_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_employee.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LBL_employee.Location = new System.Drawing.Point(406, 111);
            this.LBL_employee.Name = "LBL_employee";
            this.LBL_employee.Size = new System.Drawing.Size(348, 30);
            this.LBL_employee.TabIndex = 6;
            this.LBL_employee.Text = "Employee Name";
            this.LBL_employee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_employee.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // BTN_addEmployee
            // 
            this.BTN_addEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_addEmployee.AutoSize = true;
            this.BTN_addEmployee.Location = new System.Drawing.Point(415, 229);
            this.BTN_addEmployee.Name = "BTN_addEmployee";
            this.BTN_addEmployee.Size = new System.Drawing.Size(132, 51);
            this.BTN_addEmployee.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_addEmployee.TabIndex = 7;
            this.BTN_addEmployee.Text = "Create New Employee";
            this.BTN_addEmployee.UseSelectable = true;
            this.BTN_addEmployee.Click += new System.EventHandler(this.BTN_addEmployee_Click);
            // 
            // BTN_search
            // 
            this.BTN_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_search.AutoSize = true;
            this.BTN_search.Location = new System.Drawing.Point(613, 229);
            this.BTN_search.Name = "BTN_search";
            this.BTN_search.Size = new System.Drawing.Size(132, 51);
            this.BTN_search.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_search.TabIndex = 8;
            this.BTN_search.Text = "Search";
            this.BTN_search.UseSelectable = true;
            this.BTN_search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // DGV_employee
            // 
            this.DGV_employee.AllowUserToResizeRows = false;
            this.DGV_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_employee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_employee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_employee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_employee.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_employee.EnableHeadersVisualStyles = false;
            this.DGV_employee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGV_employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_employee.Location = new System.Drawing.Point(7, 87);
            this.DGV_employee.Name = "DGV_employee";
            this.DGV_employee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_employee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_employee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_employee.Size = new System.Drawing.Size(378, 435);
            this.DGV_employee.Style = MetroFramework.MetroColorStyle.Orange;
            this.DGV_employee.TabIndex = 9;
            this.DGV_employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_employee_CellClick);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 545);
            this.Controls.Add(this.DGV_employee);
            this.Controls.Add(this.BTN_search);
            this.Controls.Add(this.BTN_addEmployee);
            this.Controls.Add(this.LBL_employee);
            this.Controls.Add(this.TXT_employee);
            this.Controls.Add(this.BTN_cancel);
            this.Controls.Add(this.BTN_accept);
            this.Name = "EmployeeForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton BTN_accept;
        private MetroFramework.Controls.MetroButton BTN_cancel;
        private MetroFramework.Controls.MetroTextBox TXT_employee;
        private MetroFramework.Controls.MetroLabel LBL_employee;
        private MetroFramework.Controls.MetroButton BTN_addEmployee;
        private MetroFramework.Controls.MetroButton BTN_search;
        private MetroFramework.Controls.MetroGrid DGV_employee;
    }
}