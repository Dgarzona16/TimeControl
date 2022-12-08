namespace test.Forms
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_Register = new MetroFramework.Controls.MetroGrid();
            this.LBL_employee = new MetroFramework.Controls.MetroLabel();
            this.LBL_depto = new MetroFramework.Controls.MetroLabel();
            this.DT_Date = new MetroFramework.Controls.MetroDateTime();
            this.TXT_Hours = new MetroFramework.Controls.MetroTextBox();
            this.BTN_addEmployee = new MetroFramework.Controls.MetroButton();
            this.BTN_addDepto = new MetroFramework.Controls.MetroButton();
            this.BTN_TotalHours = new MetroFramework.Controls.MetroButton();
            this.BTN_SendRecord = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Register)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Register
            // 
            this.DGV_Register.AllowUserToResizeRows = false;
            this.DGV_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Register.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_Register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Register.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_Register.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Register.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Register.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Register.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Register.EnableHeadersVisualStyles = false;
            this.DGV_Register.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGV_Register.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_Register.Location = new System.Drawing.Point(5, 28);
            this.DGV_Register.Name = "DGV_Register";
            this.DGV_Register.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Register.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_Register.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Register.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Register.Size = new System.Drawing.Size(672, 327);
            this.DGV_Register.Style = MetroFramework.MetroColorStyle.Orange;
            this.DGV_Register.TabIndex = 9;
            // 
            // LBL_employee
            // 
            this.LBL_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_employee.Location = new System.Drawing.Point(683, 45);
            this.LBL_employee.Name = "LBL_employee";
            this.LBL_employee.Size = new System.Drawing.Size(248, 58);
            this.LBL_employee.TabIndex = 10;
            this.LBL_employee.Text = "Employee";
            this.LBL_employee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_depto
            // 
            this.LBL_depto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_depto.Location = new System.Drawing.Point(683, 122);
            this.LBL_depto.Name = "LBL_depto";
            this.LBL_depto.Size = new System.Drawing.Size(248, 58);
            this.LBL_depto.TabIndex = 11;
            this.LBL_depto.Text = "Depto";
            this.LBL_depto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DT_Date
            // 
            this.DT_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DT_Date.FontWeight = MetroFramework.MetroDateTimeWeight.Bold;
            this.DT_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Date.Location = new System.Drawing.Point(697, 210);
            this.DT_Date.MinimumSize = new System.Drawing.Size(0, 29);
            this.DT_Date.Name = "DT_Date";
            this.DT_Date.Size = new System.Drawing.Size(200, 29);
            this.DT_Date.Style = MetroFramework.MetroColorStyle.Orange;
            this.DT_Date.TabIndex = 12;
            // 
            // TXT_Hours
            // 
            this.TXT_Hours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TXT_Hours.CustomButton.Image = null;
            this.TXT_Hours.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.TXT_Hours.CustomButton.Name = "";
            this.TXT_Hours.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXT_Hours.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_Hours.CustomButton.TabIndex = 1;
            this.TXT_Hours.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_Hours.CustomButton.UseSelectable = true;
            this.TXT_Hours.CustomButton.Visible = false;
            this.TXT_Hours.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TXT_Hours.Lines = new string[] {
        "Hours"};
            this.TXT_Hours.Location = new System.Drawing.Point(699, 272);
            this.TXT_Hours.MaxLength = 32767;
            this.TXT_Hours.Name = "TXT_Hours";
            this.TXT_Hours.PasswordChar = '\0';
            this.TXT_Hours.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_Hours.SelectedText = "";
            this.TXT_Hours.SelectionLength = 0;
            this.TXT_Hours.SelectionStart = 0;
            this.TXT_Hours.ShortcutsEnabled = true;
            this.TXT_Hours.Size = new System.Drawing.Size(200, 23);
            this.TXT_Hours.Style = MetroFramework.MetroColorStyle.Orange;
            this.TXT_Hours.TabIndex = 13;
            this.TXT_Hours.Text = "Hours";
            this.TXT_Hours.UseSelectable = true;
            this.TXT_Hours.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_Hours.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXT_Hours.Enter += new System.EventHandler(this.TXT_Hours_Enter);
            this.TXT_Hours.Leave += new System.EventHandler(this.TXT_Hours_Leave);
            // 
            // BTN_addEmployee
            // 
            this.BTN_addEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_addEmployee.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_addEmployee.Location = new System.Drawing.Point(23, 386);
            this.BTN_addEmployee.Name = "BTN_addEmployee";
            this.BTN_addEmployee.Size = new System.Drawing.Size(123, 55);
            this.BTN_addEmployee.TabIndex = 14;
            this.BTN_addEmployee.Text = "Add Employee";
            this.BTN_addEmployee.UseSelectable = true;
            this.BTN_addEmployee.Click += new System.EventHandler(this.BTN_addEmployee_Click);
            // 
            // BTN_addDepto
            // 
            this.BTN_addDepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_addDepto.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_addDepto.Location = new System.Drawing.Point(193, 386);
            this.BTN_addDepto.Name = "BTN_addDepto";
            this.BTN_addDepto.Size = new System.Drawing.Size(123, 55);
            this.BTN_addDepto.TabIndex = 15;
            this.BTN_addDepto.Text = "Add Depto";
            this.BTN_addDepto.UseSelectable = true;
            this.BTN_addDepto.Click += new System.EventHandler(this.BTN_addDepto_Click);
            // 
            // BTN_TotalHours
            // 
            this.BTN_TotalHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_TotalHours.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_TotalHours.Location = new System.Drawing.Point(554, 386);
            this.BTN_TotalHours.Name = "BTN_TotalHours";
            this.BTN_TotalHours.Size = new System.Drawing.Size(123, 55);
            this.BTN_TotalHours.TabIndex = 16;
            this.BTN_TotalHours.Text = "Total Hours";
            this.BTN_TotalHours.UseSelectable = true;
            this.BTN_TotalHours.Click += new System.EventHandler(this.BTN_CalcTotalHours_Click);
            // 
            // BTN_SendRecord
            // 
            this.BTN_SendRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SendRecord.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_SendRecord.Location = new System.Drawing.Point(785, 386);
            this.BTN_SendRecord.Name = "BTN_SendRecord";
            this.BTN_SendRecord.Size = new System.Drawing.Size(123, 55);
            this.BTN_SendRecord.TabIndex = 17;
            this.BTN_SendRecord.Text = "Register";
            this.BTN_SendRecord.UseSelectable = true;
            this.BTN_SendRecord.Click += new System.EventHandler(this.BTN_SendRecord_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(946, 464);
            this.Controls.Add(this.BTN_SendRecord);
            this.Controls.Add(this.BTN_TotalHours);
            this.Controls.Add(this.BTN_addDepto);
            this.Controls.Add(this.BTN_addEmployee);
            this.Controls.Add(this.TXT_Hours);
            this.Controls.Add(this.DT_Date);
            this.Controls.Add(this.LBL_depto);
            this.Controls.Add(this.LBL_employee);
            this.Controls.Add(this.DGV_Register);
            this.Name = "Main";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Register)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private MetroFramework.Controls.MetroGrid DGV_Register;
        private MetroFramework.Controls.MetroLabel LBL_employee;
        private MetroFramework.Controls.MetroLabel LBL_depto;
        private MetroFramework.Controls.MetroDateTime DT_Date;
        private MetroFramework.Controls.MetroTextBox TXT_Hours;
        private MetroFramework.Controls.MetroButton BTN_addEmployee;
        private MetroFramework.Controls.MetroButton BTN_addDepto;
        private MetroFramework.Controls.MetroButton BTN_TotalHours;
        private MetroFramework.Controls.MetroButton BTN_SendRecord;
    }
}

