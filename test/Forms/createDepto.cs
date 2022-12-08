using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using test.Models;
using test.connectDB;

namespace test.Forms
{
    public partial class createDepto : MetroForm
    {
        public Depto _depto = new Depto();
        private DeptoSQL _deptoSQL = new DeptoSQL();
        public createDepto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.Resizable = false;
        }

        private void BTN_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BTN_accept_Click(object sender, EventArgs e)
        {
            if ((TXT_Company.Text == "") || (TXT_Job.Text == ""))
            {
                MetroMessageBox.Show(this, "Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _depto.Name = TXT_Company.Text.ToUpper();
            _depto.Job = TXT_Job.Text.ToUpper();
            _depto.Id = _deptoSQL.CreateDepto(_depto.Name, _depto.Job);
            DialogResult = DialogResult.OK;
        }
    }
}
