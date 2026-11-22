using InventorySystem.Exceptions;
using InventorySystem.Models;
using InventorySystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem.Forms.Staff {
    public partial class StockOutControl : UserControl {

        private readonly ProductService ProductService = new();
        private readonly StockMovementService stockMovementService = new();

        public StockOutControl()
        {
            InitializeComponent();
        }

        private void LoadComboBox()
        {
            var products = ProductService.All();
            cmbStockOutProducts.Items.Clear();
            products.ForEach(product => { cmbStockOutProducts.Items.Add(product.ProductName); });
        }

        private void btnStockOutClear_Click(object sender, EventArgs e)
        {
            cmbStockOutProducts.SelectedIndex = -1;
            txtStockOutLocation.Clear();
            txtStockOutRefNo.Clear();
            rtxtStockOutRemarks.Clear();
        }

        private void btnSaveStockOut_Click(object sender, EventArgs e)
        {
            if (cmbStockOutProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProduct = ProductService.All()[cmbStockOutProducts.SelectedIndex];
            decimal quantity = NumStockOutQuantity.Value;
            string storageLocation = txtStockOutLocation.Text;
            string referenceNo = txtStockOutRefNo.Text;
            string remarks = rtxtStockOutRemarks.Text;

            try {
                stockMovementService.StockOut(
                    selectedProduct.ProductId,
                    quantity,
                    storageLocation,
                    referenceNo,
                    remarks
                );
            }
            catch (OperationFailedException error) {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void StockOutControl_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }
    }
}