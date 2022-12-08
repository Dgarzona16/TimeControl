using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.connectDB;
using test.Models;
using MetroFramework.Forms;
using MetroFramework;

namespace test.Forms
{
    public partial class EmployeeForm : MetroForm
    {
        private employeeSQL _employeeSQL = new employeeSQL();
        public Employee _employee = new Employee();
        public EmployeeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            DGV_employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            DGV_employee.DataSource =  _employeeSQL.SearchEmployee(TXT_employee.Text);

            if (DGV_employee.Rows.Count == 1)
            {
                if (DGV_employee.Rows[0].Cells[0].Value == null)
                {
                    MetroMessageBox.Show(Owner,"Employee not found \nPlease Insert a new Employee or try again with another Name");
                }
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            DGV_employee.DataSource = _employeeSQL.GetEmployee();
        }

        private void BTN_accept_Click(object sender, EventArgs e)
        {
            if (_employee.Name != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MetroMessageBox.Show(Owner,"Please select a Employee");
            }
        }

        private void DGV_employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = DGV_employee.Rows[index];
                _employee.Phone = selectedRow.Cells[2].Value.ToString();
                _employee.Name = selectedRow.Cells[1].Value.ToString();
                _employee.Id = Convert.ToInt32(selectedRow.Cells[0].Value);
                LBL_employee.Text = _employee.Name;
            }
            catch (Exception) { }
        }

        private void BTN_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TXT_employee_Enter(object sender, EventArgs e)
        {
            if (TXT_employee.Text == "Search Employee")
            {
                TXT_employee.Text = "";
            }
        }

        private void TXT_employee_Leave(object sender, EventArgs e)
        {
            if (TXT_employee.Text == "")
            {
                TXT_employee.Text = "Search Employee";
            }
        }

        private void BTN_addEmployee_Click(object sender, EventArgs e)
        {
            using (var form = new createEmployee())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DGV_employee.DataSource = _employeeSQL.GetEmployee();
                    _employee = form._employee;
                    LBL_employee.Text = _employee.Name;
                }
            }
        }
    }
}
