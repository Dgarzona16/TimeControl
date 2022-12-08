namespace test.Forms
{
    partial class createDepto
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
            this.BTN_accept = new MetroFramework.Controls.MetroButton();
            this.BTN_cancel = new MetroFramework.Controls.MetroButton();
            this.TXT_Job = new MetroFramework.Controls.MetroTextBox();
            this.LBL_DeptoJob = new MetroFramework.Controls.MetroLabel();
            this.LBL_Company = new MetroFramework.Controls.MetroLabel();
            this.TXT_Company = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // BTN_accept
            // 
            this.BTN_accept.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_accept.Location = new System.Drawing.Point(257, 232);
            this.BTN_accept.Name = "BTN_accept";
            this.BTN_accept.Size = new System.Drawing.Size(126, 62);
            this.BTN_accept.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_accept.TabIndex = 11;
            this.BTN_accept.Text = "Accept";
            this.BTN_accept.UseSelectable = true;
            this.BTN_accept.Click += new System.EventHandler(this.BTN_accept_Click);
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_cancel.Location = new System.Drawing.Point(27, 232);
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.Size = new System.Drawing.Size(126, 62);
            this.BTN_cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_cancel.TabIndex = 10;
            this.BTN_cancel.Text = "Cancel";
            this.BTN_cancel.UseSelectable = true;
            this.BTN_cancel.Click += new System.EventHandler(this.BTN_cancel_Click);
            // 
            // TXT_Job
            // 
            // 
            // 
            // 
            this.TXT_Job.CustomButton.Image = null;
            this.TXT_Job.CustomButton.Location = new System.Drawing.Point(335, 1);
            this.TXT_Job.CustomButton.Name = "";
            this.TXT_Job.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXT_Job.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_Job.CustomButton.TabIndex = 1;
            this.TXT_Job.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_Job.CustomButton.UseSelectable = true;
            this.TXT_Job.CustomButton.Visible = false;
            this.TXT_Job.Lines = new string[0];
            this.TXT_Job.Location = new System.Drawing.Point(26, 180);
            this.TXT_Job.MaxLength = 32767;
            this.TXT_Job.Name = "TXT_Job";
            this.TXT_Job.PasswordChar = '\0';
            this.TXT_Job.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_Job.SelectedText = "";
            this.TXT_Job.SelectionLength = 0;
            this.TXT_Job.SelectionStart = 0;
            this.TXT_Job.ShortcutsEnabled = true;
            this.TXT_Job.Size = new System.Drawing.Size(357, 23);
            this.TXT_Job.TabIndex = 9;
            this.TXT_Job.UseSelectable = true;
            this.TXT_Job.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_Job.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LBL_DeptoJob
            // 
            this.LBL_DeptoJob.AutoSize = true;
            this.LBL_DeptoJob.Location = new System.Drawing.Point(27, 158);
            this.LBL_DeptoJob.Name = "LBL_DeptoJob";
            this.LBL_DeptoJob.Size = new System.Drawing.Size(30, 19);
            this.LBL_DeptoJob.TabIndex = 8;
            this.LBL_DeptoJob.Text = "Job";
            // 
            // LBL_Company
            // 
            this.LBL_Company.AutoSize = true;
            this.LBL_Company.Location = new System.Drawing.Point(27, 83);
            this.LBL_Company.Name = "LBL_Company";
            this.LBL_Company.Size = new System.Drawing.Size(66, 19);
            this.LBL_Company.TabIndex = 7;
            this.LBL_Company.Text = "Company";
            // 
            // TXT_Company
            // 
            // 
            // 
            // 
            this.TXT_Company.CustomButton.Image = null;
            this.TXT_Company.CustomButton.Location = new System.Drawing.Point(336, 1);
            this.TXT_Company.CustomButton.Name = "";
            this.TXT_Company.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXT_Company.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_Company.CustomButton.TabIndex = 1;
            this.TXT_Company.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_Company.CustomButton.UseSelectable = true;
            this.TXT_Company.CustomButton.Visible = false;
            this.TXT_Company.Lines = new string[0];
            this.TXT_Company.Location = new System.Drawing.Point(26, 105);
            this.TXT_Company.MaxLength = 32767;
            this.TXT_Company.Name = "TXT_Company";
            this.TXT_Company.PasswordChar = '\0';
            this.TXT_Company.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_Company.SelectedText = "";
            this.TXT_Company.SelectionLength = 0;
            this.TXT_Company.SelectionStart = 0;
            this.TXT_Company.ShortcutsEnabled = true;
            this.TXT_Company.Size = new System.Drawing.Size(358, 23);
            this.TXT_Company.TabIndex = 6;
            this.TXT_Company.UseSelectable = true;
            this.TXT_Company.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_Company.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // createDepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 325);
            this.Controls.Add(this.BTN_accept);
            this.Controls.Add(this.BTN_cancel);
            this.Controls.Add(this.TXT_Job);
            this.Controls.Add(this.LBL_DeptoJob);
            this.Controls.Add(this.LBL_Company);
            this.Controls.Add(this.TXT_Company);
            this.Name = "createDepto";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "create Depto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BTN_accept;
        private MetroFramework.Controls.MetroButton BTN_cancel;
        private MetroFramework.Controls.MetroTextBox TXT_Job;
        private MetroFramework.Controls.MetroLabel LBL_DeptoJob;
        private MetroFramework.Controls.MetroLabel LBL_Company;
        private MetroFramework.Controls.MetroTextBox TXT_Company;
    }
}