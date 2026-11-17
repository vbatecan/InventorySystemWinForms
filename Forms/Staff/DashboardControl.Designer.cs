namespace InventorySystem.Forms.Staff
{
    partial class DashboardControl
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
        private void InitializeComponent()
        {
            pnlPageHeader = new Panel();
            StaffPageTitle = new Label();
            lblPageDescription = new Label();
            picPageIcon = new PictureBox();
            TotAvailProd = new Panel();
            LowStockProd = new Panel();
            RecentTransaction = new Panel();
            LblTotAvailProd = new Label();
            AvailStocks = new Label();
            LSPLbl = new Label();
            LowStock = new Label();
            TransactLbl = new Label();
            Transactions = new Label();
            TotAvailProdHeader = new Panel();
            LowStockProdHeader = new Panel();
            RecentTransactionHeader = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pnlFilters = new Panel();
            RefreshBtn = new Button();
            StockStats = new ComboBox();
            lblStockStatus = new Label();
            ProdCategory = new ComboBox();
            lblCategory = new Label();
            Searchbtn = new Button();
            SearchProd = new TextBox();
            lblSearch = new Label();
            pnlPageHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPageIcon).BeginInit();
            TotAvailProd.SuspendLayout();
            LowStockProd.SuspendLayout();
            RecentTransaction.SuspendLayout();
            TotAvailProdHeader.SuspendLayout();
            LowStockProdHeader.SuspendLayout();
            RecentTransactionHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // TotAvailProd
            // 
            TotAvailProd.BackColor = Color.White;
            TotAvailProd.BorderStyle = BorderStyle.FixedSingle;
            TotAvailProd.Controls.Add(AvailStocks);
            TotAvailProd.Controls.Add(TotAvailProdHeader);
            TotAvailProd.Location = new Point(20, 127);
            TotAvailProd.Name = "TotAvailProd";
            TotAvailProd.Size = new Size(270, 97);
            TotAvailProd.TabIndex = 2;
            // 
            // LowStockProd
            // 
            LowStockProd.BackColor = Color.White;
            LowStockProd.BorderStyle = BorderStyle.FixedSingle;
            LowStockProd.Controls.Add(LowStockProdHeader);
            LowStockProd.Controls.Add(LowStock);
            LowStockProd.Location = new Point(382, 127);
            LowStockProd.Name = "LowStockProd";
            LowStockProd.Size = new Size(270, 97);
            LowStockProd.TabIndex = 3;
            // 
            // RecentTransaction
            // 
            RecentTransaction.BackColor = Color.White;
            RecentTransaction.BorderStyle = BorderStyle.FixedSingle;
            RecentTransaction.Controls.Add(Transactions);
            RecentTransaction.Location = new Point(738, 127);
            RecentTransaction.Name = "RecentTransaction";
            RecentTransaction.Size = new Size(270, 97);
            RecentTransaction.TabIndex = 4;
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
            // AvailStocks
            // 
            AvailStocks.AutoSize = true;
            AvailStocks.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AvailStocks.Location = new Point(102, 51);
            AvailStocks.Name = "AvailStocks";
            AvailStocks.Size = new Size(58, 30);
            AvailStocks.TabIndex = 1;
            AvailStocks.Text = "251";
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
            // LowStock
            // 
            LowStock.AutoSize = true;
            LowStock.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LowStock.Location = new Point(116, 51);
            LowStock.Name = "LowStock";
            LowStock.Size = new Size(43, 30);
            LowStock.TabIndex = 2;
            LowStock.Text = "18";
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
            // Transactions
            // 
            Transactions.AutoSize = true;
            Transactions.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Transactions.Location = new Point(114, 51);
            Transactions.Name = "Transactions";
            Transactions.Size = new Size(43, 30);
            Transactions.TabIndex = 3;
            Transactions.Text = "18";
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
            // LowStockProdHeader
            // 
            LowStockProdHeader.BackColor = Color.FromArgb(6, 38, 75);
            LowStockProdHeader.Controls.Add(LSPLbl);
            LowStockProdHeader.Location = new Point(0, 0);
            LowStockProdHeader.Name = "LowStockProdHeader";
            LowStockProdHeader.Size = new Size(270, 36);
            LowStockProdHeader.TabIndex = 6;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(215, 226, 242);
            dataGridView1.Location = new Point(0, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(988, 257);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
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
            pnlFilters.BackColor = Color.Transparent;
            pnlFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlFilters.Controls.Add(StockStats);
            pnlFilters.Controls.Add(lblStockStatus);
            pnlFilters.Controls.Add(ProdCategory);
            pnlFilters.Controls.Add(lblCategory);
            pnlFilters.Controls.Add(SearchProd);
            pnlFilters.Controls.Add(lblSearch);
            pnlFilters.Location = new Point(21, 264);
            pnlFilters.Margin = new Padding(0);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(8, 5, 8, 5);
            pnlFilters.Size = new Size(988, 57);
            pnlFilters.TabIndex = 10;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = Color.FromArgb(10, 48, 104);
            RefreshBtn.Cursor = Cursors.Hand;
            RefreshBtn.FlatStyle = FlatStyle.Flat;
            RefreshBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RefreshBtn.ForeColor = Color.White;
            RefreshBtn.Location = new Point(858, 624);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(150, 34);
            RefreshBtn.TabIndex = 2;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = false;
            // 
            // StockStats
            // 
            StockStats.BackColor = Color.White;
            StockStats.DropDownStyle = ComboBoxStyle.DropDownList;
            StockStats.FormattingEnabled = true;
            StockStats.IntegralHeight = false;
            StockStats.Location = new Point(745, 16);
            StockStats.Name = "StockStats";
            StockStats.Size = new Size(175, 23);
            StockStats.TabIndex = 2;
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
            // ProdCategory
            // 
            ProdCategory.BackColor = Color.White;
            ProdCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            ProdCategory.ForeColor = Color.FromArgb(10, 30, 70);
            ProdCategory.FormattingEnabled = true;
            ProdCategory.IntegralHeight = false;
            ProdCategory.Location = new Point(474, 16);
            ProdCategory.Name = "ProdCategory";
            ProdCategory.Size = new Size(175, 23);
            ProdCategory.TabIndex = 2;
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
            // Searchbtn
            // 
            Searchbtn.Cursor = Cursors.Hand;
            Searchbtn.FlatStyle = FlatStyle.Flat;
            Searchbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Searchbtn.Location = new Point(704, 624);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(148, 34);
            Searchbtn.TabIndex = 2;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = false;
            // 
            // SearchProd
            // 
            SearchProd.ForeColor = Color.FromArgb(30, 45, 70);
            SearchProd.Location = new Point(179, 16);
            SearchProd.MaxLength = 100;
            SearchProd.Name = "SearchProd";
            SearchProd.PlaceholderText = "Enter product name...";
            SearchProd.Size = new Size(211, 23);
            SearchProd.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(81, 16);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(120, 23);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search Product:";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 253);
            Controls.Add(RefreshBtn);
            Controls.Add(pnlFilters);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Searchbtn);
            Controls.Add(RecentTransactionHeader);
            Controls.Add(RecentTransaction);
            Controls.Add(LowStockProd);
            Controls.Add(TotAvailProd);
            Controls.Add(pnlPageHeader);
            Name = "DashboardControl";
            Size = new Size(1024, 681);
            pnlPageHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPageIcon).EndInit();
            TotAvailProd.ResumeLayout(false);
            TotAvailProd.PerformLayout();
            LowStockProd.ResumeLayout(false);
            LowStockProd.PerformLayout();
            RecentTransaction.ResumeLayout(false);
            RecentTransaction.PerformLayout();
            TotAvailProdHeader.ResumeLayout(false);
            TotAvailProdHeader.PerformLayout();
            LowStockProdHeader.ResumeLayout(false);
            LowStockProdHeader.PerformLayout();
            RecentTransactionHeader.ResumeLayout(false);
            RecentTransactionHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label AvailStocks;
        private Label LblTotAvailProd;
        private Label LowStock;
        private Label LSPLbl;
        private Label TransactLbl;
        private Label Transactions;
        private Panel TotAvailProdHeader;
        private Panel LowStockProdHeader;
        private Panel RecentTransactionHeader;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Panel pnlFilters;
        private Button RefreshBtn;
        private ComboBox StockStats;
        private Label lblStockStatus;
        private ComboBox ProdCategory;
        private Label lblCategory;
        private Button Searchbtn;
        private TextBox SearchProd;
        private Label lblSearch;
    }
}
