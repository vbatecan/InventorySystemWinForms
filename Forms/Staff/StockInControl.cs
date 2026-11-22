using InventorySystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem.Forms.Staff
{
    public partial class StockInControl : UserControl {

        private StockService StockService = new StockService();
        
        public StockInControl() {
            InitializeComponent();
        }

        private void btnSaveStock_Click(object sender, EventArgs e) {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLocation.Clear();
            txtRefNo.Clear();
            rtxtRemarks.Clear();
            cmbProducts.SelectedIndex = 0;
        }
    }
}
