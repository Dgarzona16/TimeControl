using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using test.Models;
using test.connectDB;
using MetroFramework;

namespace test.Forms
{
    public partial class createEmployee : MetroForm
    {
        private employeeSQL _employeeSQL = new employeeSQL();
        public Employee _employee = new Employee();
        public createEmployee()
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
            if ((TXT_name.Text == "") || (TXT_number.Text == ""))
            {
                MetroMessageBox.Show(this, "Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _employee.Name = TXT_name.Text.ToUpper();
            _employee.Phone = TXT_number.Text;
            _employee.Id = _employeeSQL.CreateEmployee(_employee.Name, _employee.Phone);
            if (_employee.Id == -1)
            {
                MetroMessageBox.Show(this, "this employee already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
