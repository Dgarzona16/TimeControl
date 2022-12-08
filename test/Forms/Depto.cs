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
    public partial class DeptoForm : MetroForm
    {
        public Depto _depto = new Depto();
        private DeptoSQL _deptoSQL = new DeptoSQL();
        public DeptoForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            DGV_depto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Depto_Load(object sender, EventArgs e)
        {
            DGV_depto.DataSource = _deptoSQL.GetDepto();
        }

        private void TXT_Depto_Enter(object sender, EventArgs e)
        {
            if (TXT_Depto.Text == "Search Job or Company")
            {
                TXT_Depto.Text = "";
            }
        }

        private void TXT_Depto_Leave(object sender, EventArgs e)
        {
            if (TXT_Depto.Text == "")
            {
                TXT_Depto.Text = "Search Job or Company";
            }
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BTN_Accept_Click(object sender, EventArgs e)
        {
            if (_depto.Job == null)
            {
                MetroMessageBox.Show(Owner, "Please Select a Job");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void BTN_search_Click(object sender, EventArgs e)
        {
            DGV_depto.DataSource = _deptoSQL.SearchDepto(TXT_Depto.Text);
        }

        private void BTN_createDepto_Click(object sender, EventArgs e)
        {
            using (var createDepto = new createDepto())
            {
                if (createDepto.ShowDialog() == DialogResult.OK)
                {
                    DGV_depto.DataSource = _deptoSQL.GetDepto();
                    _depto = createDepto._depto;
                    LBL_Depto.Text = _depto.Name + " - " + _depto.Job;
                }
            }
        }

        private void DGV_depto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dex = e.RowIndex;
                DataGridViewRow row = DGV_depto.Rows[dex];
                _depto.Id = Convert.ToInt32(row.Cells[0].Value);
                _depto.Name = row.Cells[1].Value.ToString();
                _depto.Job = row.Cells[2].Value.ToString();
                LBL_Depto.Text = _depto.Name + " - " + _depto.Job;
            }
            catch (Exception)
            {
            }
        }
    }
}
