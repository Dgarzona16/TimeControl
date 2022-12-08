namespace test.Forms
{
    partial class createEmployee
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
            this.TXT_name = new MetroFramework.Controls.MetroTextBox();
            this.LBL_employeeName = new MetroFramework.Controls.MetroLabel();
            this.LBL_employeeNumber = new MetroFramework.Controls.MetroLabel();
            this.TXT_number = new MetroFramework.Controls.MetroTextBox();
            this.BTN_cancel = new MetroFramework.Controls.MetroButton();
            this.BTN_accept = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TXT_name
            // 
            // 
            // 
            // 
            this.TXT_name.CustomButton.Image = null;
            this.TXT_name.CustomButton.Location = new System.Drawing.Point(336, 1);
            this.TXT_name.CustomButton.Name = "";
            this.TXT_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXT_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_name.CustomButton.TabIndex = 1;
            this.TXT_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_name.CustomButton.UseSelectable = true;
            this.TXT_name.CustomButton.Visible = false;
            this.TXT_name.Lines = new string[0];
            this.TXT_name.Location = new System.Drawing.Point(23, 115);
            this.TXT_name.MaxLength = 32767;
            this.TXT_name.Name = "TXT_name";
            this.TXT_name.PasswordChar = '\0';
            this.TXT_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_name.SelectedText = "";
            this.TXT_name.SelectionLength = 0;
            this.TXT_name.SelectionStart = 0;
            this.TXT_name.ShortcutsEnabled = true;
            this.TXT_name.Size = new System.Drawing.Size(358, 23);
            this.TXT_name.TabIndex = 0;
            this.TXT_name.UseSelectable = true;
            this.TXT_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LBL_employeeName
            // 
            this.LBL_employeeName.AutoSize = true;
            this.LBL_employeeName.Location = new System.Drawing.Point(24, 93);
            this.LBL_employeeName.Name = "LBL_employeeName";
            this.LBL_employeeName.Size = new System.Drawing.Size(45, 19);
            this.LBL_employeeName.TabIndex = 1;
            this.LBL_employeeName.Text = "Name";
            // 
            // LBL_employeeNumber
            // 
            this.LBL_employeeNumber.AutoSize = true;
            this.LBL_employeeNumber.Location = new System.Drawing.Point(24, 168);
            this.LBL_employeeNumber.Name = "LBL_employeeNumber";
            this.LBL_employeeNumber.Size = new System.Drawing.Size(46, 19);
            this.LBL_employeeNumber.TabIndex = 2;
            this.LBL_employeeNumber.Text = "Phone";
            // 
            // TXT_number
            // 
            // 
            // 
            // 
            this.TXT_number.CustomButton.Image = null;
            this.TXT_number.CustomButton.Location = new System.Drawing.Point(335, 1);
            this.TXT_number.CustomButton.Name = "";
            this.TXT_number.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXT_number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_number.CustomButton.TabIndex = 1;
            this.TXT_number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_number.CustomButton.UseSelectable = true;
            this.TXT_number.CustomButton.Visible = false;
            this.TXT_number.Lines = new string[0];
            this.TXT_number.Location = new System.Drawing.Point(23, 190);
            this.TXT_number.MaxLength = 32767;
            this.TXT_number.Name = "TXT_number";
            this.TXT_number.PasswordChar = '\0';
            this.TXT_number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_number.SelectedText = "";
            this.TXT_number.SelectionLength = 0;
            this.TXT_number.SelectionStart = 0;
            this.TXT_number.ShortcutsEnabled = true;
            this.TXT_number.Size = new System.Drawing.Size(357, 23);
            this.TXT_number.TabIndex = 3;
            this.TXT_number.UseSelectable = true;
            this.TXT_number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_cancel.Location = new System.Drawing.Point(24, 242);
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.Size = new System.Drawing.Size(126, 62);
            this.BTN_cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_cancel.TabIndex = 4;
            this.BTN_cancel.Text = "Cancel";
            this.BTN_cancel.UseSelectable = true;
            this.BTN_cancel.Click += new System.EventHandler(this.BTN_cancel_Click);
            // 
            // BTN_accept
            // 
            this.BTN_accept.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_accept.Location = new System.Drawing.Point(254, 242);
            this.BTN_accept.Name = "BTN_accept";
            this.BTN_accept.Size = new System.Drawing.Size(126, 62);
            this.BTN_accept.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_accept.TabIndex = 5;
            this.BTN_accept.Text = "Accept";
            this.BTN_accept.UseSelectable = true;
            this.BTN_accept.Click += new System.EventHandler(this.BTN_accept_Click);
            // 
            // createEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 325);
            this.Controls.Add(this.BTN_accept);
            this.Controls.Add(this.BTN_cancel);
            this.Controls.Add(this.TXT_number);
            this.Controls.Add(this.LBL_employeeNumber);
            this.Controls.Add(this.LBL_employeeName);
            this.Controls.Add(this.TXT_name);
            this.Name = "createEmployee";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "create Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TXT_name;
        private MetroFramework.Controls.MetroLabel LBL_employeeName;
        private MetroFramework.Controls.MetroLabel LBL_employeeNumber;
        private MetroFramework.Controls.MetroTextBox TXT_number;
        private MetroFramework.Controls.MetroButton BTN_cancel;
        private MetroFramework.Controls.MetroButton BTN_accept;
    }
}