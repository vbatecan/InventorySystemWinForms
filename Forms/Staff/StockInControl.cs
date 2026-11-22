using InventorySystem.Models;
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

        private StockService stockService = new StockService();
        private ProductService productService = new ProductService();

        public StockInControl() {
            InitializeComponent();
        }

        private void LoadStockInRecords() {
            List<StockMovement> stockMovements = stockService.All();
            dgvStockInLog.Rows.Clear();

            stockMovements.ForEach(stockMovement => {
                dgvStockInLog.Rows.Add(
                    stockMovement.MovementId,
                    stockMovement.ProductId,
                    stockMovement.MovementType.ToString(),
                    stockMovement.Quantity,
                    stockMovement.StorageLocation,
                    stockMovement.ReferenceNo,
                    stockMovement.Remarks);
            });

        }

        private void ImportProductsToProductSelection() {
            List<Product> products = productService.All();
            cmbProducts.Items.Clear();
            for (int i = 0; i < products.Count; i++) {
                cmbProducts.Items.Add(products[i].ProductName);
            }
        }

        private void btnSaveStock_Click(object sender, EventArgs e) {

        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtLocation.Clear();
            txtRefNo.Clear();
            rtxtRemarks.Clear();
            cmbProducts.SelectedIndex = 0;
        }

        private void StockInControl_Load(object sender, EventArgs e) {
            ImportProductsToProductSelection();
            LoadStockInRecords();
        }
    }
}
