namespace test.Forms
{
    partial class DeptoForm
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
            this.DGV_depto = new MetroFramework.Controls.MetroGrid();
            this.LBL_Depto = new MetroFramework.Controls.MetroLabel();
            this.TXT_Depto = new MetroFramework.Controls.MetroTextBox();
            this.BTN_createDepto = new MetroFramework.Controls.MetroButton();
            this.BTN_search = new MetroFramework.Controls.MetroButton();
            this.BTN_Cancel = new MetroFramework.Controls.MetroButton();
            this.BTN_Accept = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_depto)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_depto
            // 
            this.DGV_depto.AllowUserToResizeRows = false;
            this.DGV_depto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_depto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_depto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_depto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_depto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_depto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_depto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_depto.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_depto.EnableHeadersVisualStyles = false;
            this.DGV_depto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGV_depto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV_depto.Location = new System.Drawing.Point(23, 63);
            this.DGV_depto.Name = "DGV_depto";
            this.DGV_depto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_depto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_depto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_depto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_depto.Size = new System.Drawing.Size(575, 378);
            this.DGV_depto.Style = MetroFramework.MetroColorStyle.Orange;
            this.DGV_depto.TabIndex = 0;
            this.DGV_depto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_depto_CellClick);
            // 
            // LBL_Depto
            // 
            this.LBL_Depto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Depto.Location = new System.Drawing.Point(617, 63);
            this.LBL_Depto.Name = "LBL_Depto";
            this.LBL_Depto.Size = new System.Drawing.Size(306, 50);
            this.LBL_Depto.TabIndex = 1;
            this.LBL_Depto.Text = "Company  - Job";
            this.LBL_Depto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_Depto
            // 
            this.TXT_Depto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TXT_Depto.CustomButton.Image = null;
            this.TXT_Depto.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.TXT_Depto.CustomButton.Name = "";
            this.TXT_Depto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXT_Depto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXT_Depto.CustomButton.TabIndex = 1;
            this.TXT_Depto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXT_Depto.CustomButton.UseSelectable = true;
            this.TXT_Depto.CustomButton.Visible = false;
            this.TXT_Depto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TXT_Depto.Lines = new string[] {
        "Search Job or Company"};
            this.TXT_Depto.Location = new System.Drawing.Point(617, 138);
            this.TXT_Depto.MaxLength = 32767;
            this.TXT_Depto.Name = "TXT_Depto";
            this.TXT_Depto.PasswordChar = '\0';
            this.TXT_Depto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXT_Depto.SelectedText = "";
            this.TXT_Depto.SelectionLength = 0;
            this.TXT_Depto.SelectionStart = 0;
            this.TXT_Depto.ShortcutsEnabled = true;
            this.TXT_Depto.Size = new System.Drawing.Size(306, 23);
            this.TXT_Depto.Style = MetroFramework.MetroColorStyle.Orange;
            this.TXT_Depto.TabIndex = 2;
            this.TXT_Depto.Text = "Search Job or Company";
            this.TXT_Depto.UseSelectable = true;
            this.TXT_Depto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXT_Depto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXT_Depto.Enter += new System.EventHandler(this.TXT_Depto_Enter);
            this.TXT_Depto.Leave += new System.EventHandler(this.TXT_Depto_Leave);
            // 
            // BTN_createDepto
            // 
            this.BTN_createDepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_createDepto.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_createDepto.Location = new System.Drawing.Point(617, 185);
            this.BTN_createDepto.Name = "BTN_createDepto";
            this.BTN_createDepto.Size = new System.Drawing.Size(108, 50);
            this.BTN_createDepto.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_createDepto.TabIndex = 3;
            this.BTN_createDepto.Text = "New Depto";
            this.BTN_createDepto.UseSelectable = true;
            this.BTN_createDepto.Click += new System.EventHandler(this.BTN_createDepto_Click);
            // 
            // BTN_search
            // 
            this.BTN_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_search.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_search.Location = new System.Drawing.Point(815, 185);
            this.BTN_search.Name = "BTN_search";
            this.BTN_search.Size = new System.Drawing.Size(108, 50);
            this.BTN_search.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_search.TabIndex = 4;
            this.BTN_search.Text = "Search";
            this.BTN_search.UseSelectable = true;
            this.BTN_search.Click += new System.EventHandler(this.BTN_search_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Cancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_Cancel.Location = new System.Drawing.Point(617, 391);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(108, 50);
            this.BTN_Cancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_Cancel.TabIndex = 5;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseSelectable = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Accept
            // 
            this.BTN_Accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Accept.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_Accept.Location = new System.Drawing.Point(815, 391);
            this.BTN_Accept.Name = "BTN_Accept";
            this.BTN_Accept.Size = new System.Drawing.Size(108, 50);
            this.BTN_Accept.Style = MetroFramework.MetroColorStyle.Orange;
            this.BTN_Accept.TabIndex = 6;
            this.BTN_Accept.Text = "Accept";
            this.BTN_Accept.UseSelectable = true;
            this.BTN_Accept.Click += new System.EventHandler(this.BTN_Accept_Click);
            // 
            // DeptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 464);
            this.Controls.Add(this.BTN_Accept);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_search);
            this.Controls.Add(this.BTN_createDepto);
            this.Controls.Add(this.TXT_Depto);
            this.Controls.Add(this.LBL_Depto);
            this.Controls.Add(this.DGV_depto);
            this.Name = "DeptoForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Depto";
            this.Load += new System.EventHandler(this.Depto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_depto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid DGV_depto;
        private MetroFramework.Controls.MetroLabel LBL_Depto;
        private MetroFramework.Controls.MetroTextBox TXT_Depto;
        private MetroFramework.Controls.MetroButton BTN_createDepto;
        private MetroFramework.Controls.MetroButton BTN_search;
        private MetroFramework.Controls.MetroButton BTN_Cancel;
        private MetroFramework.Controls.MetroButton BTN_Accept;
    }
}