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
using test.connectDB;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace test.Forms
{
    public partial class TotalHours : MetroForm
    {
        private RegisterSQL _registerSQL = new RegisterSQL();
        private DataTable data = new DataTable();
        public TotalHours()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void TXT_employee_Enter(object sender, EventArgs e)
        {
            if (TXT_employee.Text == "Employee Phone")
            {
                TXT_employee.Text = "";
            }
        }

        private void TXT_employee_Leave(object sender, EventArgs e)
        {
            if (TXT_employee.Text == "")
            {
                TXT_employee.Text = "Employee Phone";
            }
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            data = _registerSQL.calcTime(TXT_employee.Text, DT_startDate.Value, DT_EndDate.Value);
            if (DGV_TotalHours.Rows.Count > 0)
            {
                DGV_TotalHours.Rows.Clear();
            }
            foreach (DataRow row in data.Rows)
            {
                DGV_TotalHours.Rows.Add(row["Employee"], row["Phone"], row["Company"], row["Job"], row["Time"]);
            }
        }

        private void BTN_export_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "Excel (*.xlsx)|*.xlsx";
                saveFile.FileName = $"{DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year}.xlsx";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    ExcelPackage excel = new ExcelPackage();
                    var workSheet = excel.Workbook.Worksheets.Add("Report");
                    workSheet.Cells.LoadFromDataTable(data, true);
                    excel.SaveAs(new System.IO.FileInfo(saveFile.FileName));
                    Close();
                }
            }
        }
    }
}
