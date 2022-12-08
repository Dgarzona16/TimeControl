using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Models;
using test.connectDB;
using MetroFramework.Forms;
using MetroFramework;

namespace test.Forms
{
    public partial class Main : MetroForm
    {
        private RegisterSQL _registerSQL = new RegisterSQL();
        private Employee _employee = new Employee();
        private Depto _depto = new Depto();
        private Register _register = new Register();
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            DGV_Register.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BTN_addEmployee_Click(object sender, EventArgs e)
        {
            using (var addEmployee = new EmployeeForm())
            {
                addEmployee.ShowDialog();

                if (addEmployee.DialogResult == DialogResult.OK)
                {
                    _employee = addEmployee._employee;
                    LBL_employee.Text = _employee.Name;
                }
            }
        }

        private void BTN_addDepto_Click(object sender, EventArgs e)
        {
            using (var addDepto = new DeptoForm())
            {
                addDepto.ShowDialog();

                if (addDepto.DialogResult == DialogResult.OK)
                {
                    _depto = addDepto._depto;
                    LBL_depto.Text = _depto.Name + " - " + _depto.Job;
                }
            }
        }

        private void BTN_CalcTotalHours_Click(object sender, EventArgs e)
        {
            using (var calcTotalHours = new TotalHours())
            {
                calcTotalHours.ShowDialog();

                if (calcTotalHours.DialogResult == DialogResult.OK)
                {
                }
            }
        }

        private void TXT_Hours_Enter(object sender, EventArgs e)
        {
            if (TXT_Hours.Text == "Hours")
            {
                TXT_Hours.Text = "";
            }
        }

        private void TXT_Hours_Leave(object sender, EventArgs e)
        {
            if (TXT_Hours.Text == "")
            {
                TXT_Hours.Text = "Hours";
            }
            
        }

        private void BTN_SendRecord_Click(object sender, EventArgs e)
        {
            decimal time = 0;
            if(!decimal.TryParse(TXT_Hours.Text, out time))
            {
                MetroMessageBox.Show(this, "Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _register.Name = _employee.Id;
            _register.Depto = _depto.Id;
            _register.Date = DT_Date.Value;
            _register.Time = time;
            if (_registerSQL.AddRegister(_register))
            {
                MetroMessageBox.Show(this, "Record added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_Register.DataSource = _registerSQL.GetRegister();
                //ResetForm();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DGV_Register.DataSource = _registerSQL.GetRegister();
        }

        private void ResetForm()
        {
            LBL_employee.Text = "Employee";
            LBL_depto.Text = "Depto";
            TXT_Hours.Text = "Hours";
            DT_Date.Value = DateTime.Now;

            _employee = new Employee();
            _depto = new Depto();
            _register = new Register();
        }
    }
}
