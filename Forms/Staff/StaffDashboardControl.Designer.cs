namespace InventorySystem.Forms.Staff
{
    partial class StaffDashboardControl
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
            pnlPageHeader = new Panel();
            picPageIcon = new PictureBox();
            lblPageDescription = new Label();
            StaffPageTitle = new Label();
            TotAvailProd = new Panel();
            lblTotalProducts = new Label();
            TotAvailProdHeader = new Panel();
            LblTotAvailProd = new Label();
            LowStockProd = new Panel();
            LowStockProdHeader = new Panel();
            LSPLbl = new Label();
            lblLowStock = new Label();
            RecentTransaction = new Panel();
            lblTransactions = new Label();
            TransactLbl = new Label();
            RecentTransactionHeader = new Panel();
            dgvTransactions = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            MovementType = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            StorageLocation = new DataGridViewTextBoxColumn();
            ReferenceNo = new DataGridViewTextBoxColumn();
            CreatedBy = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pnlFilters = new Panel();
            cmbStockStats = new ComboBox();
            lblStockStatus = new Label();
            cmbProductCategory = new ComboBox();
            lblCategory = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnRefresh = new Button();
            btnSearch = new Button();
            pnlPageHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPageIcon).BeginInit();
            TotAvailProd.SuspendLayout();
            TotAvailProdHeader.SuspendLayout();
            LowStockProd.SuspendLayout();
            LowStockProdHeader.SuspendLayout();
            RecentTransaction.SuspendLayout();
            RecentTransactionHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlFilters.SuspendLayout();
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
            pnlPageHeader.TabIndex = 1;
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
            lblPageDescription.Text = "Monitor stock availability, track stock changes, and recent transactions";
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
            StaffPageTitle.Text = "Staff Dashboard";
            StaffPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TotAvailProd
            // 
            TotAvailProd.BackColor = Color.White;
            TotAvailProd.BorderStyle = BorderStyle.FixedSingle;
            TotAvailProd.Controls.Add(lblTotalProducts);
            TotAvailProd.Controls.Add(TotAvailProdHeader);
            TotAvailProd.Location = new Point(20, 127);
            TotAvailProd.Name = "TotAvailProd";
            TotAvailProd.Size = new Size(270, 97);
            TotAvailProd.TabIndex = 2;
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProducts.Location = new Point(102, 51);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(58, 30);
            lblTotalProducts.TabIndex = 1;
            lblTotalProducts.Text = "251";
            // 
            // TotAvailProdHeader
            // 
            TotAvailProdHeader.BackColor = Color.FromArgb(6, 38, 75);
            TotAvailProdHeader.Controls.Add(LblTotAvailProd);
            TotAvailProdHeader.Location = new Point(0, 0);
            TotAvailProdHeader.Name = "TotAvailProdHeader";
            TotAvailProdHeader.Size = new Size(270, 36);
            TotAvailProdHeader.TabIndex = 5;
            // 
            // LblTotAvailProd
            // 
            LblTotAvailProd.AutoSize = true;
            LblTotAvailProd.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTotAvailProd.ForeColor = Color.White;
            LblTotAvailProd.Location = new Point(35, 7);
            LblTotAvailProd.Name = "LblTotAvailProd";
            LblTotAvailProd.Size = new Size(200, 21);
            LblTotAvailProd.TabIndex = 0;
            LblTotAvailProd.Text = "Total Available Products";
            // 
            // LowStockProd
            // 
            LowStockProd.BackColor = Color.White;
            LowStockProd.BorderStyle = BorderStyle.FixedSingle;
            LowStockProd.Controls.Add(LowStockProdHeader);
            LowStockProd.Controls.Add(lblLowStock);
            LowStockProd.Location = new Point(382, 127);
            LowStockProd.Name = "LowStockProd";
            LowStockProd.Size = new Size(270, 97);
            LowStockProd.TabIndex = 3;
            // 
            // LowStockProdHeader
            // 
            LowStockProdHeader.BackColor = Color.FromArgb(6, 38, 75);
            LowStockProdHeader.Controls.Add(LSPLbl);
            LowStockProdHeader.Location = new Point(0, 0);
            LowStockProdHeader.Name = "LowStockProdHeader";
            LowStockProdHeader.Size = new Size(270, 36);
            LowStockProdHeader.TabIndex = 6;
            // 
            // LSPLbl
            // 
            LSPLbl.AutoSize = true;
            LSPLbl.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LSPLbl.ForeColor = Color.White;
            LSPLbl.Location = new Point(59, 7);
            LSPLbl.Name = "LSPLbl";
            LSPLbl.Size = new Size(161, 21);
            LSPLbl.TabIndex = 2;
            LSPLbl.Text = "Low Stock Products";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.Location = new Point(116, 51);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(43, 30);
            lblLowStock.TabIndex = 2;
            lblLowStock.Text = "18";
            // 
            // RecentTransaction
            // 
            RecentTransaction.BackColor = Color.White;
            RecentTransaction.BorderStyle = BorderStyle.FixedSingle;
            RecentTransaction.Controls.Add(lblTransactions);
            RecentTransaction.Location = new Point(738, 127);
            RecentTransaction.Name = "RecentTransaction";
            RecentTransaction.Size = new Size(270, 97);
            RecentTransaction.TabIndex = 4;
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.Location = new Point(114, 51);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(43, 30);
            lblTransactions.TabIndex = 3;
            lblTransactions.Text = "18";
            // 
            // TransactLbl
            // 
            TransactLbl.AutoSize = true;
            TransactLbl.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TransactLbl.ForeColor = Color.White;
            TransactLbl.Location = new Point(54, 7);
            TransactLbl.Name = "TransactLbl";
            TransactLbl.Size = new Size(172, 21);
            TransactLbl.TabIndex = 3;
            TransactLbl.Text = "Today's Transactions";
            // 
            // RecentTransactionHeader
            // 
            RecentTransactionHeader.BackColor = Color.FromArgb(6, 38, 75);
            RecentTransactionHeader.Controls.Add(TransactLbl);
            RecentTransactionHeader.Location = new Point(738, 127);
            RecentTransactionHeader.Name = "RecentTransactionHeader";
            RecentTransactionHeader.Size = new Size(270, 36);
            RecentTransactionHeader.TabIndex = 7;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Columns.AddRange(new DataGridViewColumn[] { ProductID, MovementType, Quantity, StorageLocation, ReferenceNo, CreatedBy });
            dgvTransactions.GridColor = Color.FromArgb(215, 226, 242);
            dgvTransactions.Location = new Point(0, 34);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.Size = new Size(988, 257);
            dgvTransactions.TabIndex = 8;
            dgvTransactions.CellContentClick += dataGridView1_CellContentClick;
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
            // ReferenceNo
            // 
            ReferenceNo.HeaderText = "Reference";
            ReferenceNo.Name = "ReferenceNo";
            ReferenceNo.ReadOnly = true;
            // 
            // CreatedBy
            // 
            CreatedBy.HeaderText = "Created By";
            CreatedBy.Name = "CreatedBy";
            CreatedBy.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvTransactions);
            panel1.Location = new Point(20, 327);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 291);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(6, 38, 75);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(20, 327);
            panel2.Name = "panel2";
            panel2.Size = new Size(988, 38);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 7);
            label2.Name = "label2";
            label2.Size = new Size(167, 21);
            label2.TabIndex = 1;
            label2.Text = "Recent Transactions";
            // 
            // pnlFilters
            // 
            pnlFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFilters.BackColor = Color.White;
            pnlFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlFilters.Controls.Add(cmbStockStats);
            pnlFilters.Controls.Add(lblStockStatus);
            pnlFilters.Controls.Add(cmbProductCategory);
            pnlFilters.Controls.Add(lblCategory);
            pnlFilters.Controls.Add(txtSearch);
            pnlFilters.Controls.Add(lblSearch);
            pnlFilters.Location = new Point(21, 264);
            pnlFilters.Margin = new Padding(0);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(8, 5, 8, 5);
            pnlFilters.Size = new Size(988, 57);
            pnlFilters.TabIndex = 10;
            // 
            // cmbStockStats
            // 
            cmbStockStats.BackColor = Color.White;
            cmbStockStats.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStockStats.FormattingEnabled = true;
            cmbStockStats.IntegralHeight = false;
            cmbStockStats.Location = new Point(745, 16);
            cmbStockStats.Name = "cmbStockStats";
            cmbStockStats.Size = new Size(175, 23);
            cmbStockStats.TabIndex = 2;
            // 
            // lblStockStatus
            // 
            lblStockStatus.BackColor = Color.Transparent;
            lblStockStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockStatus.Location = new Point(661, 16);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(100, 23);
            lblStockStatus.TabIndex = 2;
            lblStockStatus.Text = "Stock Status:";
            lblStockStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbProductCategory
            // 
            cmbProductCategory.BackColor = Color.White;
            cmbProductCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductCategory.ForeColor = Color.FromArgb(10, 30, 70);
            cmbProductCategory.FormattingEnabled = true;
            cmbProductCategory.IntegralHeight = false;
            cmbProductCategory.Location = new Point(474, 16);
            cmbProductCategory.Name = "cmbProductCategory";
            cmbProductCategory.Size = new Size(175, 23);
            cmbProductCategory.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(412, 16);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(75, 23);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = Color.FromArgb(30, 45, 70);
            txtSearch.Location = new Point(165, 16);
            txtSearch.MaxLength = 100;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter product name...";
            txtSearch.Size = new Size(211, 23);
            txtSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(53, 16);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(106, 23);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search Product:";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(10, 48, 104);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(858, 624);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 34);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(704, 624);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(148, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // StaffDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 253);
            Controls.Add(btnRefresh);
            Controls.Add(pnlFilters);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(RecentTransactionHeader);
            Controls.Add(RecentTransaction);
            Controls.Add(LowStockProd);
            Controls.Add(TotAvailProd);
            Controls.Add(pnlPageHeader);
            Name = "StaffDashboardControl";
            Size = new Size(1024, 681);
            Load += DashboardControl_Load;
            pnlPageHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPageIcon).EndInit();
            TotAvailProd.ResumeLayout(false);
            TotAvailProd.PerformLayout();
            TotAvailProdHeader.ResumeLayout(false);
            TotAvailProdHeader.PerformLayout();
            LowStockProd.ResumeLayout(false);
            LowStockProd.PerformLayout();
            LowStockProdHeader.ResumeLayout(false);
            LowStockProdHeader.PerformLayout();
            RecentTransaction.ResumeLayout(false);
            RecentTransaction.PerformLayout();
            RecentTransactionHeader.ResumeLayout(false);
            RecentTransactionHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlPageHeader;
        private PictureBox picPageIcon;
        private Label lblPageDescription;
        private Label StaffPageTitle;
        private Panel TotAvailProd;
        private Panel LowStockProd;
        private Panel RecentTransaction;
        private Label lblTotalProducts;
        private Label LblTotAvailProd;
        private Label lblLowStock;
        private Label LSPLbl;
        private Label TransactLbl;
        private Label lblTransactions;
        private Panel TotAvailProdHeader;
        private Panel LowStockProdHeader;
        private Panel RecentTransactionHeader;
        private DataGridView dgvTransactions;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel pnlFilters;
        private Button btnRefresh;
        private ComboBox cmbStockStats;
        private Label lblStockStatus;
        private ComboBox cmbProductCategory;
        private Label lblCategory;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn MovementType;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn StorageLocation;
        private DataGridViewTextBoxColumn ReferenceNo;
        private DataGridViewTextBoxColumn CreatedBy;
    }
}
