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
    public partial class DashboardControl : UserControl {

        private ProductService ProductService = new ProductService();
        private StockService StockService = new StockService();
        
        public DashboardControl() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            int rowCount = ProductService.Count();
            lblTotalProducts.Text = rowCount.ToString();
        }
    }
}
