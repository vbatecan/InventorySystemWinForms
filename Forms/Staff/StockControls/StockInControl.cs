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

        private readonly StockMovementService StockMovementService = new ();
        private ProductService ProductService = new();

        public StockInControl() {
            InitializeComponent();
        }

        private void LoadStockInRecords() {
            List<StockMovement> stockMovements = StockMovementService.All();
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
            List<Product> products = ProductService.All();
            cmbProducts.Items.Clear();
            for (int i = 0; i < products.Count; i++) {
                cmbProducts.Items.Add(products[i].ProductName);
            }
        }

        private void btnSaveStock_Click(object sender, EventArgs e) {
            if (cmbProducts.SelectedIndex == -1) {
                MessageBox.Show(@"Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProduct = ProductService.GetByName(cmbProducts.SelectedItem.ToString());
            decimal quantity = NumQuantity.Value;
            string storageLocation = txtLocation.Text;
            string referenceNo = txtRefNo.Text;
            string remarks = rtxtRemarks.Text;

            try {
                StockMovementService.StockIn(
                    selectedProduct.ProductId,
                    quantity,
                    storageLocation,
                    referenceNo,
                    remarks
                );
                LoadStockInRecords();
                btnClear_Click(sender, e);
                MessageBox.Show(@"Stock in recorded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show($@"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
