namespace InventorySystem.Forms.Manager
{
    partial class InventoryMonitoring
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pnlPageHeader = new Panel();
            picPageIcon = new PictureBox();
            lblPageDescription = new Label();
            lblPageTitle = new Label();
            pnlFilters = new Panel();
            btnRefresh = new Button();
            cmbStockStatus = new ComboBox();
            lblStockStatus = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            btnSearch = new Button();
            txtSearchProduct = new TextBox();
            lblSearch = new Label();
            pnlInventoryList = new Panel();
            dgvInventory = new DataGridView();
            colSKU = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colCurrentStock = new DataGridViewTextBoxColumn();
            colReorderLevel = new DataGridViewTextBoxColumn();
            colStockStatus = new DataGridViewTextBoxColumn();
            colLastUpdated = new DataGridViewTextBoxColumn();
            lblInventoryTitle = new Label();
            pnlInventoryHeader = new Panel();
            pnlStockSummary = new Panel();
            pnlOutOfStock = new Panel();
            lblOutOfStockTitle = new Label();
            lblOutOfStockCount = new Label();
            pictureBox3 = new PictureBox();
            pnlInStock = new Panel();
            lblInStockTitle = new Label();
            lblInStockCount = new Label();
            pictureBox4 = new PictureBox();
            pnlLowStock = new Panel();
            lblLowStockTitle = new Label();
            lblLowStockCount = new Label();
            pictureBox2 = new PictureBox();
            lblSummaryTitle = new Label();
            pnlSummaryHeader = new Panel();
            pnlTotalProducts = new Panel();
            lblTotalProductsTitle = new Label();
            lblTotalProductsCount = new Label();
            pictureBox1 = new PictureBox();
            pnlStockTrend = new Panel();
            chartStockTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pictureBox5 = new PictureBox();
            lblTrendTitle = new Label();
            pnlTrendHeader = new Panel();
            pnlAlerts = new Panel();
            btnViewAllNotifications = new Button();
            pnlAlert4 = new Panel();
            lblAlertTime4 = new Label();
            lblAlert4 = new Label();
            picAlert4 = new PictureBox();
            pnlAlert3 = new Panel();
            label2 = new Label();
            lblAlert3 = new Label();
            picAlert3 = new PictureBox();
            pnlAlert2 = new Panel();
            lblAlertTime2 = new Label();
            lblAlert2 = new Label();
            picAlert2 = new PictureBox();
            pnlAlert1 = new Panel();
            lblAlertTime1 = new Label();
            lblAlert1 = new Label();
            picAlert1 = new PictureBox();
            pictureBox6 = new PictureBox();
            lblAlertsTitle = new Label();
            pnlAlertsHeader = new Panel();
            pnlPageHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPageIcon).BeginInit();
            pnlFilters.SuspendLayout();
            pnlInventoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            pnlStockSummary.SuspendLayout();
            pnlOutOfStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlInStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlTotalProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlStockTrend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStockTrend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnlAlerts.SuspendLayout();
            pnlAlert4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAlert4).BeginInit();
            pnlAlert3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAlert3).BeginInit();
            pnlAlert2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAlert2).BeginInit();
            pnlAlert1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAlert1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pnlPageHeader
            // 
            pnlPageHeader.BackColor = Color.FromArgb(245, 248, 253);
            pnlPageHeader.Controls.Add(picPageIcon);
            pnlPageHeader.Controls.Add(lblPageDescription);
            pnlPageHeader.Controls.Add(lblPageTitle);
            pnlPageHeader.Location = new Point(20, 10);
            pnlPageHeader.Name = "pnlPageHeader";
            pnlPageHeader.Size = new Size(1347, 76);
            pnlPageHeader.TabIndex = 0;
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
            lblPageDescription.Text = "Monitor stock levels, track changes, and manage inventory in real-time.";
            lblPageDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPageTitle
            // 
            lblPageTitle.BackColor = Color.Transparent;
            lblPageTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(10, 39, 93);
            lblPageTitle.Location = new Point(88, 13);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(370, 32);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Inventory Monitoring";
            lblPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlFilters
            // 
            pnlFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFilters.BackColor = Color.FromArgb(220, 233, 252);
            pnlFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlFilters.Controls.Add(btnRefresh);
            pnlFilters.Controls.Add(cmbStockStatus);
            pnlFilters.Controls.Add(lblStockStatus);
            pnlFilters.Controls.Add(cmbCategory);
            pnlFilters.Controls.Add(lblCategory);
            pnlFilters.Controls.Add(btnSearch);
            pnlFilters.Controls.Add(txtSearchProduct);
            pnlFilters.Controls.Add(lblSearch);
            pnlFilters.Location = new Point(20, 90);
            pnlFilters.Margin = new Padding(0);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(8, 5, 8, 5);
            pnlFilters.Size = new Size(1347, 70);
            pnlFilters.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(10, 48, 104);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1170, 9);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 34);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "↻ Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.BackColor = Color.White;
            cmbStockStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStockStatus.FormattingEnabled = true;
            cmbStockStatus.IntegralHeight = false;
            cmbStockStatus.Location = new Point(884, 16);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(175, 23);
            cmbStockStatus.TabIndex = 2;
            // 
            // lblStockStatus
            // 
            lblStockStatus.BackColor = Color.Transparent;
            lblStockStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockStatus.Location = new Point(778, 16);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(100, 23);
            lblStockStatus.TabIndex = 2;
            lblStockStatus.Text = "Stock Status:";
            lblStockStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.White;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.ForeColor = Color.FromArgb(10, 30, 70);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.IntegralHeight = false;
            cmbCategory.Location = new Point(584, 16);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(175, 23);
            cmbCategory.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(503, 16);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(75, 23);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(400, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 32);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.ForeColor = Color.FromArgb(30, 45, 70);
            txtSearchProduct.Location = new Point(149, 16);
            txtSearchProduct.MaxLength = 100;
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.PlaceholderText = "Enter product name...";
            txtSearchProduct.Size = new Size(245, 23);
            txtSearchProduct.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(23, 16);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(120, 23);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search Product:";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlInventoryList
            // 
            pnlInventoryList.BackColor = Color.White;
            pnlInventoryList.BorderStyle = BorderStyle.FixedSingle;
            pnlInventoryList.Controls.Add(dgvInventory);
            pnlInventoryList.Controls.Add(lblInventoryTitle);
            pnlInventoryList.Controls.Add(pnlInventoryHeader);
            pnlInventoryList.Location = new Point(20, 165);
            pnlInventoryList.Margin = new Padding(0);
            pnlInventoryList.Name = "pnlInventoryList";
            pnlInventoryList.Size = new Size(945, 290);
            pnlInventoryList.TabIndex = 2;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(230, 239, 252);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(10, 30, 70);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 239, 252);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(10, 30, 70);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.ColumnHeadersHeight = 38;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInventory.ColumnHeadersVisible = false;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { colSKU, colProductName, colCategory, colCurrentStock, colReorderLevel, colStockStatus, colLastUpdated });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(10, 30, 70);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(65, 145, 225);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle5;
            dgvInventory.GridColor = Color.FromArgb(215, 226, 242);
            dgvInventory.Location = new Point(0, 42);
            dgvInventory.MultiSelect = false;
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(940, 243);
            dgvInventory.TabIndex = 2;
            // 
            // colSKU
            // 
            colSKU.FillWeight = 0.173996866F;
            colSKU.HeaderText = "SKU";
            colSKU.Name = "colSKU";
            colSKU.ReadOnly = true;
            colSKU.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colProductName
            // 
            colProductName.FillWeight = 2.14904261F;
            colProductName.HeaderText = "Product Name";
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCategory
            // 
            colCategory.FillWeight = 4.32758045F;
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCurrentStock
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCurrentStock.DefaultCellStyle = dataGridViewCellStyle2;
            colCurrentStock.FillWeight = 9.505529F;
            colCurrentStock.HeaderText = "Current Stock";
            colCurrentStock.Name = "colCurrentStock";
            colCurrentStock.ReadOnly = true;
            colCurrentStock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colReorderLevel
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colReorderLevel.DefaultCellStyle = dataGridViewCellStyle3;
            colReorderLevel.FillWeight = 22.7769814F;
            colReorderLevel.HeaderText = "Reorder Level";
            colReorderLevel.Name = "colReorderLevel";
            colReorderLevel.ReadOnly = true;
            colReorderLevel.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStockStatus
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStockStatus.DefaultCellStyle = dataGridViewCellStyle4;
            colStockStatus.FillWeight = 67.66586F;
            colStockStatus.HeaderText = "Stock Status";
            colStockStatus.Name = "colStockStatus";
            colStockStatus.ReadOnly = true;
            colStockStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colLastUpdated
            // 
            colLastUpdated.FillWeight = 593.4012F;
            colLastUpdated.HeaderText = "Last Updated";
            colLastUpdated.Name = "colLastUpdated";
            colLastUpdated.ReadOnly = true;
            colLastUpdated.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // lblInventoryTitle
            // 
            lblInventoryTitle.BackColor = Color.FromArgb(10, 55, 105);
            lblInventoryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryTitle.ForeColor = Color.White;
            lblInventoryTitle.Location = new Point(48, 5);
            lblInventoryTitle.Name = "lblInventoryTitle";
            lblInventoryTitle.Size = new Size(250, 32);
            lblInventoryTitle.TabIndex = 1;
            lblInventoryTitle.Text = "Inventory List";
            // 
            // pnlInventoryHeader
            // 
            pnlInventoryHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlInventoryHeader.BackColor = Color.FromArgb(10, 55, 105);
            pnlInventoryHeader.Location = new Point(0, 0);
            pnlInventoryHeader.Name = "pnlInventoryHeader";
            pnlInventoryHeader.Size = new Size(943, 42);
            pnlInventoryHeader.TabIndex = 0;
            // 
            // pnlStockSummary
            // 
            pnlStockSummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlStockSummary.BackColor = Color.White;
            pnlStockSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlStockSummary.Controls.Add(pnlOutOfStock);
            pnlStockSummary.Controls.Add(pnlInStock);
            pnlStockSummary.Controls.Add(pnlLowStock);
            pnlStockSummary.Controls.Add(lblSummaryTitle);
            pnlStockSummary.Controls.Add(pnlSummaryHeader);
            pnlStockSummary.Controls.Add(pnlTotalProducts);
            pnlStockSummary.Location = new Point(975, 165);
            pnlStockSummary.Name = "pnlStockSummary";
            pnlStockSummary.Padding = new Padding(5);
            pnlStockSummary.Size = new Size(412, 290);
            pnlStockSummary.TabIndex = 3;
            // 
            // pnlOutOfStock
            // 
            pnlOutOfStock.BackColor = Color.FromArgb(245, 248, 255);
            pnlOutOfStock.BorderStyle = BorderStyle.FixedSingle;
            pnlOutOfStock.Controls.Add(lblOutOfStockTitle);
            pnlOutOfStock.Controls.Add(lblOutOfStockCount);
            pnlOutOfStock.Controls.Add(pictureBox3);
            pnlOutOfStock.Location = new Point(218, 165);
            pnlOutOfStock.Name = "pnlOutOfStock";
            pnlOutOfStock.Padding = new Padding(5);
            pnlOutOfStock.Size = new Size(178, 106);
            pnlOutOfStock.TabIndex = 4;
            pnlOutOfStock.Paint += pnlOutOfStock_Paint;
            // 
            // lblOutOfStockTitle
            // 
            lblOutOfStockTitle.AutoSize = true;
            lblOutOfStockTitle.Location = new Point(45, 84);
            lblOutOfStockTitle.Name = "lblOutOfStockTitle";
            lblOutOfStockTitle.Size = new Size(73, 15);
            lblOutOfStockTitle.TabIndex = 6;
            lblOutOfStockTitle.Text = "Out of Stock";
            // 
            // lblOutOfStockCount
            // 
            lblOutOfStockCount.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold);
            lblOutOfStockCount.ForeColor = Color.FromArgb(10, 35, 85);
            lblOutOfStockCount.Location = new Point(60, 47);
            lblOutOfStockCount.Name = "lblOutOfStockCount";
            lblOutOfStockCount.Size = new Size(38, 37);
            lblOutOfStockCount.TabIndex = 9;
            lblOutOfStockCount.Text = "0";
            lblOutOfStockCount.TextAlign = ContentAlignment.MiddleCenter;
            lblOutOfStockCount.Click += lblOutOfStockCount_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Location = new Point(60, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pnlInStock
            // 
            pnlInStock.BackColor = Color.FromArgb(245, 248, 255);
            pnlInStock.BorderStyle = BorderStyle.FixedSingle;
            pnlInStock.Controls.Add(lblInStockTitle);
            pnlInStock.Controls.Add(lblInStockCount);
            pnlInStock.Controls.Add(pictureBox4);
            pnlInStock.Location = new Point(218, 55);
            pnlInStock.Name = "pnlInStock";
            pnlInStock.Size = new Size(178, 104);
            pnlInStock.TabIndex = 4;
            // 
            // lblInStockTitle
            // 
            lblInStockTitle.AutoSize = true;
            lblInStockTitle.Location = new Point(55, 82);
            lblInStockTitle.Name = "lblInStockTitle";
            lblInStockTitle.Size = new Size(49, 15);
            lblInStockTitle.TabIndex = 8;
            lblInStockTitle.Text = "In Stock";
            // 
            // lblInStockCount
            // 
            lblInStockCount.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold);
            lblInStockCount.ForeColor = Color.FromArgb(10, 35, 85);
            lblInStockCount.Location = new Point(62, 46);
            lblInStockCount.Name = "lblInStockCount";
            lblInStockCount.Size = new Size(38, 36);
            lblInStockCount.TabIndex = 5;
            lblInStockCount.Text = "0";
            lblInStockCount.TextAlign = ContentAlignment.MiddleCenter;
            lblInStockCount.Click += lblInStockCount_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Location = new Point(61, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = Color.FromArgb(245, 248, 255);
            pnlLowStock.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStock.Controls.Add(lblLowStockTitle);
            pnlLowStock.Controls.Add(lblLowStockCount);
            pnlLowStock.Controls.Add(pictureBox2);
            pnlLowStock.Location = new Point(15, 165);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Padding = new Padding(5);
            pnlLowStock.Size = new Size(178, 106);
            pnlLowStock.TabIndex = 4;
            pnlLowStock.Paint += panel4_Paint;
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.AutoSize = true;
            lblLowStockTitle.Location = new Point(54, 84);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(61, 15);
            lblLowStockTitle.TabIndex = 7;
            lblLowStockTitle.Text = "Low Stock";
            // 
            // lblLowStockCount
            // 
            lblLowStockCount.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold);
            lblLowStockCount.ForeColor = Color.FromArgb(10, 35, 85);
            lblLowStockCount.Location = new Point(64, 47);
            lblLowStockCount.Name = "lblLowStockCount";
            lblLowStockCount.Size = new Size(38, 37);
            lblLowStockCount.TabIndex = 8;
            lblLowStockCount.Text = "0";
            lblLowStockCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(63, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.BackColor = Color.FromArgb(10, 55, 105);
            lblSummaryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummaryTitle.ForeColor = Color.White;
            lblSummaryTitle.Location = new Point(45, 5);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(250, 32);
            lblSummaryTitle.TabIndex = 4;
            lblSummaryTitle.Text = "Stock Summary";
            lblSummaryTitle.Click += lblSummaryTitle_Click;
            // 
            // pnlSummaryHeader
            // 
            pnlSummaryHeader.BackColor = Color.FromArgb(10, 55, 105);
            pnlSummaryHeader.Location = new Point(0, 0);
            pnlSummaryHeader.Name = "pnlSummaryHeader";
            pnlSummaryHeader.Size = new Size(390, 42);
            pnlSummaryHeader.TabIndex = 0;
            // 
            // pnlTotalProducts
            // 
            pnlTotalProducts.BackColor = Color.FromArgb(245, 248, 255);
            pnlTotalProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalProducts.Controls.Add(lblTotalProductsTitle);
            pnlTotalProducts.Controls.Add(lblTotalProductsCount);
            pnlTotalProducts.Controls.Add(pictureBox1);
            pnlTotalProducts.Location = new Point(15, 55);
            pnlTotalProducts.Name = "pnlTotalProducts";
            pnlTotalProducts.Padding = new Padding(5);
            pnlTotalProducts.Size = new Size(178, 104);
            pnlTotalProducts.TabIndex = 3;
            // 
            // lblTotalProductsTitle
            // 
            lblTotalProductsTitle.AutoSize = true;
            lblTotalProductsTitle.Location = new Point(41, 82);
            lblTotalProductsTitle.Name = "lblTotalProductsTitle";
            lblTotalProductsTitle.Size = new Size(83, 15);
            lblTotalProductsTitle.TabIndex = 5;
            lblTotalProductsTitle.Text = "Total Products";
            // 
            // lblTotalProductsCount
            // 
            lblTotalProductsCount.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProductsCount.ForeColor = Color.FromArgb(10, 35, 85);
            lblTotalProductsCount.Location = new Point(63, 45);
            lblTotalProductsCount.Name = "lblTotalProductsCount";
            lblTotalProductsCount.Size = new Size(44, 37);
            lblTotalProductsCount.TabIndex = 4;
            lblTotalProductsCount.Text = "0";
            lblTotalProductsCount.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalProductsCount.Click += lblTotalProductsCount_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(66, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pnlStockTrend
            // 
            pnlStockTrend.BackColor = Color.White;
            pnlStockTrend.BorderStyle = BorderStyle.FixedSingle;
            pnlStockTrend.Controls.Add(chartStockTrend);
            pnlStockTrend.Controls.Add(pictureBox5);
            pnlStockTrend.Controls.Add(lblTrendTitle);
            pnlStockTrend.Controls.Add(pnlTrendHeader);
            pnlStockTrend.Location = new Point(20, 475);
            pnlStockTrend.Margin = new Padding(0);
            pnlStockTrend.Name = "pnlStockTrend";
            pnlStockTrend.Size = new Size(895, 270);
            pnlStockTrend.TabIndex = 4;
            // 
            // chartStockTrend
            // 
            chartStockTrend.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chartStockTrend.BorderlineWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea1.AxisX.LabelStyle.ForeColor = Color.FromArgb(10, 30, 70);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea1.AxisY.LabelStyle.ForeColor = Color.FromArgb(10, 30, 70);
            chartArea1.AxisY.MajorGrid.LineColor = Color.FromArgb(220, 230, 245);
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartStockTrend.ChartAreas.Add(chartArea1);
            legend1.Alignment = StringAlignment.Center;
            legend1.BackColor = Color.White;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            chartStockTrend.Legends.Add(legend1);
            chartStockTrend.Location = new Point(10, 47);
            chartStockTrend.Name = "chartStockTrend";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = Color.FromArgb(0, 55, 170);
            series1.Legend = "Legend1";
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Total Stock";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = Color.FromArgb(65, 160, 255);
            series2.Legend = "Legend1";
            series2.MarkerSize = 7;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Low Stock Items";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartStockTrend.Series.Add(series1);
            chartStockTrend.Series.Add(series2);
            chartStockTrend.Size = new Size(873, 213);
            chartStockTrend.TabIndex = 3;
            chartStockTrend.Text = "chart1";
            chartStockTrend.Click += chartStockTrend_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(10, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 28);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // lblTrendTitle
            // 
            lblTrendTitle.BackColor = Color.FromArgb(10, 55, 105);
            lblTrendTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrendTitle.ForeColor = Color.White;
            lblTrendTitle.Location = new Point(48, 5);
            lblTrendTitle.Name = "lblTrendTitle";
            lblTrendTitle.Size = new Size(250, 32);
            lblTrendTitle.TabIndex = 1;
            lblTrendTitle.Text = "Stock Trend";
            // 
            // pnlTrendHeader
            // 
            pnlTrendHeader.BackColor = Color.FromArgb(10, 55, 105);
            pnlTrendHeader.Location = new Point(0, 0);
            pnlTrendHeader.Name = "pnlTrendHeader";
            pnlTrendHeader.Size = new Size(893, 42);
            pnlTrendHeader.TabIndex = 0;
            // 
            // pnlAlerts
            // 
            pnlAlerts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlAlerts.BackColor = Color.White;
            pnlAlerts.BorderStyle = BorderStyle.FixedSingle;
            pnlAlerts.Controls.Add(btnViewAllNotifications);
            pnlAlerts.Controls.Add(pnlAlert4);
            pnlAlerts.Controls.Add(pnlAlert3);
            pnlAlerts.Controls.Add(pnlAlert2);
            pnlAlerts.Controls.Add(pnlAlert1);
            pnlAlerts.Controls.Add(pictureBox6);
            pnlAlerts.Controls.Add(lblAlertsTitle);
            pnlAlerts.Controls.Add(pnlAlertsHeader);
            pnlAlerts.Location = new Point(925, 475);
            pnlAlerts.Name = "pnlAlerts";
            pnlAlerts.Size = new Size(442, 270);
            pnlAlerts.TabIndex = 5;
            // 
            // btnViewAllNotifications
            // 
            btnViewAllNotifications.Cursor = Cursors.Hand;
            btnViewAllNotifications.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewAllNotifications.ForeColor = Color.FromArgb(0, 75, 190);
            btnViewAllNotifications.Location = new Point(265, 232);
            btnViewAllNotifications.Name = "btnViewAllNotifications";
            btnViewAllNotifications.Size = new Size(155, 28);
            btnViewAllNotifications.TabIndex = 6;
            btnViewAllNotifications.Text = "View All Notifications →";
            btnViewAllNotifications.TextAlign = ContentAlignment.MiddleRight;
            btnViewAllNotifications.UseVisualStyleBackColor = true;
            // 
            // pnlAlert4
            // 
            pnlAlert4.Controls.Add(lblAlertTime4);
            pnlAlert4.Controls.Add(lblAlert4);
            pnlAlert4.Controls.Add(picAlert4);
            pnlAlert4.Location = new Point(10, 182);
            pnlAlert4.Name = "pnlAlert4";
            pnlAlert4.Size = new Size(420, 43);
            pnlAlert4.TabIndex = 6;
            // 
            // lblAlertTime4
            // 
            lblAlertTime4.AutoSize = true;
            lblAlertTime4.BackColor = Color.Transparent;
            lblAlertTime4.ForeColor = Color.FromArgb(90, 110, 150);
            lblAlertTime4.Location = new Point(349, 14);
            lblAlertTime4.Name = "lblAlertTime4";
            lblAlertTime4.Size = new Size(56, 15);
            lblAlertTime4.TabIndex = 7;
            lblAlertTime4.Text = "07:20 AM";
            // 
            // lblAlert4
            // 
            lblAlert4.BackColor = Color.Transparent;
            lblAlert4.Location = new Point(55, 15);
            lblAlert4.Name = "lblAlert4";
            lblAlert4.Size = new Size(285, 14);
            lblAlert4.TabIndex = 7;
            lblAlert4.Text = "New stock added: Laptop Stand (20 pcs).";
            // 
            // picAlert4
            // 
            picAlert4.BackColor = Color.FromArgb(65, 160, 255);
            picAlert4.Location = new Point(8, 15);
            picAlert4.Name = "picAlert4";
            picAlert4.Size = new Size(12, 12);
            picAlert4.SizeMode = PictureBoxSizeMode.CenterImage;
            picAlert4.TabIndex = 7;
            picAlert4.TabStop = false;
            // 
            // pnlAlert3
            // 
            pnlAlert3.Controls.Add(label2);
            pnlAlert3.Controls.Add(lblAlert3);
            pnlAlert3.Controls.Add(picAlert3);
            pnlAlert3.Location = new Point(10, 138);
            pnlAlert3.Name = "pnlAlert3";
            pnlAlert3.Size = new Size(420, 43);
            pnlAlert3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(90, 110, 150);
            label2.Location = new Point(349, 14);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "07:35 AM";
            // 
            // lblAlert3
            // 
            lblAlert3.BackColor = Color.Transparent;
            lblAlert3.Location = new Point(55, 14);
            lblAlert3.Name = "lblAlert3";
            lblAlert3.Size = new Size(285, 14);
            lblAlert3.TabIndex = 6;
            lblAlert3.Text = "External SSD 1TB is running low.";
            // 
            // picAlert3
            // 
            picAlert3.BackColor = Color.FromArgb(255, 165, 35);
            picAlert3.Location = new Point(8, 14);
            picAlert3.Name = "picAlert3";
            picAlert3.Size = new Size(12, 12);
            picAlert3.SizeMode = PictureBoxSizeMode.CenterImage;
            picAlert3.TabIndex = 6;
            picAlert3.TabStop = false;
            // 
            // pnlAlert2
            // 
            pnlAlert2.Controls.Add(lblAlertTime2);
            pnlAlert2.Controls.Add(lblAlert2);
            pnlAlert2.Controls.Add(picAlert2);
            pnlAlert2.Location = new Point(10, 94);
            pnlAlert2.Name = "pnlAlert2";
            pnlAlert2.Size = new Size(420, 43);
            pnlAlert2.TabIndex = 4;
            // 
            // lblAlertTime2
            // 
            lblAlertTime2.AutoSize = true;
            lblAlertTime2.BackColor = Color.Transparent;
            lblAlertTime2.ForeColor = Color.FromArgb(90, 110, 150);
            lblAlertTime2.Location = new Point(349, 13);
            lblAlertTime2.Name = "lblAlertTime2";
            lblAlertTime2.Size = new Size(56, 15);
            lblAlertTime2.TabIndex = 5;
            lblAlertTime2.Text = "07:55 AM";
            // 
            // lblAlert2
            // 
            lblAlert2.BackColor = Color.Transparent;
            lblAlert2.Location = new Point(58, 14);
            lblAlert2.Name = "lblAlert2";
            lblAlert2.Size = new Size(285, 14);
            lblAlert2.TabIndex = 5;
            lblAlert2.Text = "USB-C Cable is out of stock.";
            // 
            // picAlert2
            // 
            picAlert2.BackColor = Color.FromArgb(235, 55, 55);
            picAlert2.Location = new Point(8, 16);
            picAlert2.Name = "picAlert2";
            picAlert2.Size = new Size(12, 12);
            picAlert2.SizeMode = PictureBoxSizeMode.CenterImage;
            picAlert2.TabIndex = 5;
            picAlert2.TabStop = false;
            // 
            // pnlAlert1
            // 
            pnlAlert1.Controls.Add(lblAlertTime1);
            pnlAlert1.Controls.Add(lblAlert1);
            pnlAlert1.Controls.Add(picAlert1);
            pnlAlert1.Location = new Point(10, 50);
            pnlAlert1.Name = "pnlAlert1";
            pnlAlert1.Size = new Size(420, 43);
            pnlAlert1.TabIndex = 3;
            // 
            // lblAlertTime1
            // 
            lblAlertTime1.AutoSize = true;
            lblAlertTime1.BackColor = Color.Transparent;
            lblAlertTime1.ForeColor = Color.FromArgb(90, 110, 150);
            lblAlertTime1.Location = new Point(349, 13);
            lblAlertTime1.Name = "lblAlertTime1";
            lblAlertTime1.Size = new Size(56, 15);
            lblAlertTime1.TabIndex = 4;
            lblAlertTime1.Text = "08:30 AM";
            // 
            // lblAlert1
            // 
            lblAlert1.BackColor = Color.Transparent;
            lblAlert1.Location = new Point(58, 14);
            lblAlert1.Name = "lblAlert1";
            lblAlert1.Size = new Size(285, 14);
            lblAlert1.TabIndex = 4;
            lblAlert1.Text = "Bluetooth Keyboard is running low.";
            // 
            // picAlert1
            // 
            picAlert1.BackColor = Color.FromArgb(255, 165, 35);
            picAlert1.Location = new Point(8, 13);
            picAlert1.Name = "picAlert1";
            picAlert1.Size = new Size(12, 12);
            picAlert1.SizeMode = PictureBoxSizeMode.CenterImage;
            picAlert1.TabIndex = 4;
            picAlert1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(10, 7);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(28, 28);
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // lblAlertsTitle
            // 
            lblAlertsTitle.BackColor = Color.FromArgb(10, 55, 105);
            lblAlertsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlertsTitle.ForeColor = Color.White;
            lblAlertsTitle.Location = new Point(45, 5);
            lblAlertsTitle.Name = "lblAlertsTitle";
            lblAlertsTitle.Size = new Size(231, 32);
            lblAlertsTitle.TabIndex = 1;
            lblAlertsTitle.Text = "Alerts and Notifications";
            // 
            // pnlAlertsHeader
            // 
            pnlAlertsHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlAlertsHeader.BackColor = Color.FromArgb(10, 55, 105);
            pnlAlertsHeader.Location = new Point(0, 0);
            pnlAlertsHeader.Name = "pnlAlertsHeader";
            pnlAlertsHeader.Size = new Size(440, 42);
            pnlAlertsHeader.TabIndex = 0;
            // 
            // InventoryMonitoring
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(245, 248, 253);
            Controls.Add(pnlAlerts);
            Controls.Add(pnlStockTrend);
            Controls.Add(pnlStockSummary);
            Controls.Add(pnlInventoryList);
            Controls.Add(pnlFilters);
            Controls.Add(pnlPageHeader);
            ForeColor = Color.FromArgb(10, 30, 70);
            MinimumSize = new Size(1000, 650);
            Name = "InventoryMonitoring";
            Size = new Size(1387, 808);
            Load += InventoryMonitoring_Load;
            pnlPageHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPageIcon).EndInit();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            pnlInventoryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            pnlStockSummary.ResumeLayout(false);
            pnlOutOfStock.ResumeLayout(false);
            pnlOutOfStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlInStock.ResumeLayout(false);
            pnlInStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlTotalProducts.ResumeLayout(false);
            pnlTotalProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlStockTrend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartStockTrend).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pnlAlerts.ResumeLayout(false);
            pnlAlert4.ResumeLayout(false);
            pnlAlert4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAlert4).EndInit();
            pnlAlert3.ResumeLayout(false);
            pnlAlert3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAlert3).EndInit();
            pnlAlert2.ResumeLayout(false);
            pnlAlert2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAlert2).EndInit();
            pnlAlert1.ResumeLayout(false);
            pnlAlert1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAlert1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPageHeader;
        private Label lblPageDescription;
        private Label lblPageTitle;
        private PictureBox picPageIcon;
        private Panel pnlFilters;
        private TextBox txtSearchProduct;
        private Label lblSearch;
        private Button btnRefresh;
        private ComboBox cmbStockStatus;
        private Label lblStockStatus;
        private ComboBox cmbCategory;
        private Label lblCategory;
        private Button btnSearch;
        private Panel pnlInventoryList;
        private Label lblInventoryTitle;
        private Panel pnlInventoryHeader;
        private DataGridView dgvInventory;
        private DataGridViewTextBoxColumn colSKU;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colCurrentStock;
        private DataGridViewTextBoxColumn colReorderLevel;
        private DataGridViewTextBoxColumn colStockStatus;
        private DataGridViewTextBoxColumn colLastUpdated;
        private Panel pnlStockSummary;
        private Panel pnlSummaryHeader;
        private Label lblSummaryTitle;
        private Panel pnlTotalProducts;
        private Panel pnlInStock;
        private Panel pnlOutOfStock;
        private Panel pnlLowStock;
        private Label lblOutOfStockCount;
        private PictureBox pictureBox3;
        private Label lblInStockCount;
        private PictureBox pictureBox4;
        private Label lblLowStockCount;
        private PictureBox pictureBox2;
        private Label lblTotalProductsCount;
        private PictureBox pictureBox1;
        private Label lblOutOfStockTitle;
        private Label lblInStockTitle;
        private Label lblLowStockTitle;
        private Label lblTotalProductsTitle;
        private Panel pnlStockTrend;
        private Panel pnlTrendHeader;
        private PictureBox pictureBox5;
        private Label lblTrendTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStockTrend;
        private Panel pnlAlerts;
        private Panel pnlAlert1;
        private PictureBox picAlert1;
        private PictureBox pictureBox6;
        private Label lblAlertsTitle;
        private Panel pnlAlertsHeader;
        private Panel pnlAlert2;
        private PictureBox picAlert2;
        private Label lblAlertTime1;
        private Label lblAlert1;
        private Label lblAlertTime2;
        private Label lblAlert2;
        private Button btnViewAllNotifications;
        private Panel pnlAlert4;
        private Label lblAlertTime4;
        private Label lblAlert4;
        private PictureBox picAlert4;
        private Panel pnlAlert3;
        private Label label2;
        private Label lblAlert3;
        private PictureBox picAlert3;
    }
}
