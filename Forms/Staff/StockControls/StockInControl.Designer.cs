namespace InventorySystem.Forms.Staff
{
    partial class StockInControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            pnlPageHeader = new Panel();
            picPageIcon = new PictureBox();
            lblPageDescription = new Label();
            StaffPageTitle = new Label();
            panel1 = new Panel();
            btnSaveStock = new Button();
            btnClear = new Button();
            NumQuantity = new NumericUpDown();
            cmbProducts = new ComboBox();
            txtLocation = new TextBox();
            txtRefNo = new TextBox();
            rtxtRemarks = new RichTextBox();
            panel3 = new Panel();
            LblTotAvailProd = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvStockInLog = new DataGridView();
            panel4 = new Panel();
            label6 = new Label();
            err = new ErrorProvider(components);
            MovementID = new DataGridViewTextBoxColumn();
            ProductID = new DataGridViewTextBoxColumn();
            MovementType = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            StorageLocation = new DataGridViewTextBoxColumn();
            Reference = new DataGridViewTextBoxColumn();
            Remarks = new DataGridViewTextBoxColumn();
            pnlPageHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPageIcon).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumQuantity).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockInLog).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pnlPageHeader
            // 
            pnlPageHeader.BackColor = Color.FromArgb(245, 248, 253);
            pnlPageHeader.BorderStyle = BorderStyle.Fixed3D;
            pnlPageHeader.Controls.Add(picPageIcon);
            pnlPageHeader.Controls.Add(lblPageDescription);
            pnlPageHeader.Controls.Add(StaffPageTitle);
            pnlPageHeader.Location = new Point(20, 10);
            pnlPageHeader.Name = "pnlPageHeader";
            pnlPageHeader.Size = new Size(988, 83);
            pnlPageHeader.TabIndex = 2;
            // 
            // picPageIcon
            // 
            picPageIcon.BackColor = Color.Transparent;
            picPageIcon.Location = new Point(10, 13);
            picPageIcon.Name = "picPageIcon";
            picPageIcon.Size = new Size(64, 50);
            picPageIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picPageIcon.TabIndex = 2;
            picPageIcon.TabStop = false;
            // 
            // lblPageDescription
            // 
            lblPageDescription.BackColor = Color.Transparent;
            lblPageDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageDescription.ForeColor = Color.FromArgb(20, 45, 85);
            lblPageDescription.Location = new Point(88, 48);
            lblPageDescription.Name = "lblPageDescription";
            lblPageDescription.Size = new Size(600, 22);
            lblPageDescription.TabIndex = 1;
            lblPageDescription.Text = "Record incoming shipments, supplier deliveries, and new stock quantities.";
            lblPageDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StaffPageTitle
            // 
            StaffPageTitle.BackColor = Color.Transparent;
            StaffPageTitle.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StaffPageTitle.ForeColor = Color.FromArgb(10, 39, 93);
            StaffPageTitle.Location = new Point(88, 13);
            StaffPageTitle.Name = "StaffPageTitle";
            StaffPageTitle.Size = new Size(370, 32);
            StaffPageTitle.TabIndex = 1;
            StaffPageTitle.Text = "Stock In Control";
            StaffPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSaveStock);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(NumQuantity);
            panel1.Controls.Add(cmbProducts);
            panel1.Controls.Add(txtLocation);
            panel1.Controls.Add(txtRefNo);
            panel1.Controls.Add(rtxtRemarks);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 495);
            panel1.TabIndex = 3;
            // 
            // btnSaveStock
            // 
            btnSaveStock.BackColor = Color.FromArgb(10, 48, 104);
            btnSaveStock.Cursor = Cursors.Hand;
            btnSaveStock.FlatStyle = FlatStyle.Flat;
            btnSaveStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveStock.ForeColor = Color.White;
            btnSaveStock.Location = new Point(26, 423);
            btnSaveStock.Name = "btnSaveStock";
            btnSaveStock.Size = new Size(150, 34);
            btnSaveStock.TabIndex = 12;
            btnSaveStock.Text = "Save Stock In";
            btnSaveStock.UseVisualStyleBackColor = false;
            btnSaveStock.Click += btnSaveStock_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(10, 48, 104);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(182, 423);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // NumQuantity
            // 
            NumQuantity.Location = new Point(134, 150);
            NumQuantity.Name = "NumQuantity";
            NumQuantity.Size = new Size(199, 23);
            NumQuantity.TabIndex = 10;
            NumQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbProducts
            // 
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(134, 100);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(199, 23);
            cmbProducts.TabIndex = 9;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(134, 200);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(199, 23);
            txtLocation.TabIndex = 8;
            // 
            // txtRefNo
            // 
            txtRefNo.Location = new Point(134, 250);
            txtRefNo.Name = "txtRefNo";
            txtRefNo.Size = new Size(199, 23);
            txtRefNo.TabIndex = 7;
            // 
            // rtxtRemarks
            // 
            rtxtRemarks.Location = new Point(134, 300);
            rtxtRemarks.Name = "rtxtRemarks";
            rtxtRemarks.Size = new Size(199, 96);
            rtxtRemarks.TabIndex = 6;
            rtxtRemarks.Text = "";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(6, 38, 75);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(LblTotAvailProd);
            panel3.Location = new Point(-1, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(353, 55);
            panel3.TabIndex = 5;
            // 
            // LblTotAvailProd
            // 
            LblTotAvailProd.AutoSize = true;
            LblTotAvailProd.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTotAvailProd.ForeColor = Color.White;
            LblTotAvailProd.Location = new Point(26, 14);
            LblTotAvailProd.Name = "LblTotAvailProd";
            LblTotAvailProd.Size = new Size(173, 26);
            LblTotAvailProd.TabIndex = 7;
            LblTotAvailProd.Text = "New Stock Entry";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 300);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Remarks :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 250);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Reference No. :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 200);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 2;
            label3.Text = "Storage Location :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 150);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantity :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 100);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Product :";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvStockInLog);
            panel2.Location = new Point(408, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 495);
            panel2.TabIndex = 4;
            // 
            // dgvStockInLog
            // 
            dgvStockInLog.AllowUserToAddRows = false;
            dgvStockInLog.AllowUserToDeleteRows = false;
            dgvStockInLog.BackgroundColor = Color.White;
            dgvStockInLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockInLog.Columns.AddRange(new DataGridViewColumn[] { MovementID, ProductID, MovementType, Quantity, StorageLocation, Reference, Remarks });
            dgvStockInLog.GridColor = Color.FromArgb(215, 226, 242);
            dgvStockInLog.Location = new Point(-1, 54);
            dgvStockInLog.Name = "dgvStockInLog";
            dgvStockInLog.ReadOnly = true;
            dgvStockInLog.Size = new Size(586, 439);
            dgvStockInLog.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(6, 38, 75);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label6);
            panel4.Location = new Point(408, 138);
            panel4.Name = "panel4";
            panel4.Size = new Size(586, 55);
            panel4.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 14);
            label6.Name = "label6";
            label6.Size = new Size(180, 26);
            label6.TabIndex = 8;
            label6.Text = "Stock In Records";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // MovementID
            // 
            MovementID.HeaderText = "ID";
            MovementID.Name = "MovementID";
            MovementID.ReadOnly = true;
            // 
            // ProductID
            // 
            ProductID.HeaderText = "Product ID";
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            // 
            // MovementType
            // 
            MovementType.HeaderText = "Movement Type";
            MovementType.Name = "MovementType";
            MovementType.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // StorageLocation
            // 
            StorageLocation.HeaderText = "Location";
            StorageLocation.Name = "StorageLocation";
            StorageLocation.ReadOnly = true;
            // 
            // Reference
            // 
            Reference.HeaderText = "Reference";
            Reference.Name = "Reference";
            Reference.ReadOnly = true;
            // 
            // Remarks
            // 
            Remarks.HeaderText = "Remarks";
            Remarks.Name = "Remarks";
            Remarks.ReadOnly = true;
            // 
            // StockInControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 253);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlPageHeader);
            Name = "StockInControl";
            Size = new Size(1024, 681);
            Load += StockInControl_Load;
            pnlPageHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPageIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumQuantity).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockInLog).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPageHeader;
        private PictureBox picPageIcon;
        private Label lblPageDescription;
        private Label StaffPageTitle;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label LblTotAvailProd;
        private Label label6;
        private NumericUpDown NumQuantity;
        private ComboBox cmbProducts;
        private TextBox txtLocation;
        private TextBox txtRefNo;
        private RichTextBox rtxtRemarks;
        private DataGridView dgvStockInLog;
        private Button btnSaveStock;
        private Button btnClear;
        private ErrorProvider err;
        private DataGridViewTextBoxColumn MovementID;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn MovementType;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn StorageLocation;
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn Remarks;
    }
}
