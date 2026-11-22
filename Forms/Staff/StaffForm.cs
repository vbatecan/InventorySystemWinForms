using InventorySystem.Forms.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem.Forms.Manager
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            LoadUserControl(new StaffDashboardControl());
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new StaffDashboardControl());
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new StockInControl());
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new StockOutControl());
        }

        private void btnStockHistory_Click(object sender, EventArgs e)
        {
            LoadUserControl(new StockHistoryControl());
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
