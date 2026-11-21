namespace InventorySystem.Forms.Manager
{
    partial class InventoryReports
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pnlPageHeader = new Panel();
            picPageIcon = new PictureBox();
            lblPageTitle = new Label();
            lblPageDescription = new Label();
            pnlReportFilters = new Panel();
            lblReportType = new Label();
            cmbReportType = new ComboBox();
            lblDateFrom = new Label();
            dtpDateFrom = new DateTimePicker();
            lblDateTo = new Label();
            dtpDateTo = new DateTimePicker();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            btnGenerateReport = new Button();
            btnExportExcel = new Button();
            btnExportPDF = new Button();
            pnlTotalProducts = new Panel();
            pnlStockIn = new Panel();
            pnlStockOut = new Panel();
            pnlLowStock = new Panel();
            lblTotalProductsCount = new Label();
            lblTotalProductsTitle = new Label();
            lblStockInTitle = new Label();
            lblStockInCount = new Label();
            lblStockOutTitle = new Label();
            lblStockOutCount = new Label();
            lblLowStockTitle = new Label();
            lblLowStockCount = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pnlReportDetails = new Panel();
            pnlReportDetailsHeader = new Panel();
            lblReportDetailsTitle = new Label();
            dgvReportDetails = new DataGridView();
            colSKU = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colOpeningStock = new DataGridViewTextBoxColumn();
            colStockIn = new DataGridViewTextBoxColumn();
            colStockOut = new DataGridViewTextBoxColumn();
            colCurrentStock = new DataGridViewTextBoxColumn();
            colStockStatus = new DataGridViewTextBoxColumn();
            pnlStockDistribution = new Panel();
            pnlDistributionHeader = new Panel();
            lblDistributionTitle = new Label();
            chartStockDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlPageHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPageIcon).BeginInit();
            pnlReportFilters.SuspendLayout();
            pnlTotalProducts.SuspendLayout();
            pnlStockIn.SuspendLayout();
            pnlStockOut.SuspendLayout();
            pnlLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlReportDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportDetails).BeginInit();
            pnlStockDistribution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStockDistribution).BeginInit();
            SuspendLayout();
            // 
            // pnlPageHeader
            // 
            pnlPageHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPageHeader.Controls.Add(picPageIcon);
            pnlPageHeader.Location = new Point(20, 10);
            pnlPageHeader.Name = "pnlPageHeader";
            pnlPageHeader.Size = new Size(1347, 76);
            pnlPageHeader.TabIndex = 0;
            // 
            // picPageIcon
            // 
            picPageIcon.BackColor = Color.Transparent;
            picPageIcon.Image = Properties.Resources.d0923d12_291a_4add_8757_401a699f535a;
            picPageIcon.Location = new Point(4, 3);
            picPageIcon.Name = "picPageIcon";
            picPageIcon.Size = new Size(64, 64);
            picPageIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picPageIcon.TabIndex = 1;
            picPageIcon.TabStop = false;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.BackColor = Color.Transparent;
            lblPageTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(10, 39, 93);
            lblPageTitle.Location = new Point(88, 13);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(251, 37);
            lblPageTitle.TabIndex = 2;
            lblPageTitle.Text = "Inventory Reports";
            lblPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPageDescription
            // 
            lblPageDescription.AutoSize = true;
            lblPageDescription.BackColor = Color.Transparent;
            lblPageDescription.ForeColor = Color.FromArgb(20, 45, 85);
            lblPageDescription.Location = new Point(88, 48);
            lblPageDescription.Name = "lblPageDescription";
            lblPageDescription.Size = new Size(252, 15);
            lblPageDescription.TabIndex = 3;
            lblPageDescription.Text = "Generate, review, and export inventory reports.";
            lblPageDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlReportFilters
            // 
            pnlReportFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlReportFilters.BackColor = Color.FromArgb(220, 233, 252);
            pnlReportFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlReportFilters.Controls.Add(btnExportPDF);
            pnlReportFilters.Controls.Add(btnExportExcel);
            pnlReportFilters.Controls.Add(btnGenerateReport);
            pnlReportFilters.Controls.Add(cmbCategory);
            pnlReportFilters.Controls.Add(lblCategory);
            pnlReportFilters.Controls.Add(dtpDateTo);
            pnlReportFilters.Controls.Add(lblDateTo);
            pnlReportFilters.Controls.Add(dtpDateFrom);
            pnlReportFilters.Controls.Add(lblDateFrom);
            pnlReportFilters.Controls.Add(cmbReportType);
            pnlReportFilters.Controls.Add(lblReportType);
            pnlReportFilters.Location = new Point(20, 95);
            pnlReportFilters.Name = "pnlReportFilters";
            pnlReportFilters.Padding = new Padding(8, 5, 8, 5);
            pnlReportFilters.Size = new Size(1347, 85);
            pnlReportFilters.TabIndex = 4;
            // 
            // lblReportType
            // 
            lblReportType.AutoSize = true;
            lblReportType.BackColor = Color.Transparent;
            lblReportType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportType.Location = new Point(15, 12);
            lblReportType.Name = "lblReportType";
            lblReportType.Size = new Size(78, 15);
            lblReportType.TabIndex = 5;
            lblReportType.Text = "Report Type:";
            lblReportType.TextAlign = ContentAlignment.MiddleLeft;
            lblReportType.Click += lblReportType_Click;
            // 
            // cmbReportType
            // 
            cmbReportType.BackColor = Color.White;
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.ForeColor = Color.FromArgb(10, 30, 70);
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Inventory Summary", "", "Stock Movement", "", "Low Stock Report", "", "Out of Stock Report" });
            cmbReportType.Location = new Point(120, 10);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(185, 23);
            cmbReportType.TabIndex = 5;
            // 
            // lblDateFrom
            // 
            lblDateFrom.AutoSize = true;
            lblDateFrom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateFrom.Location = new Point(330, 12);
            lblDateFrom.Name = "lblDateFrom";
            lblDateFrom.Size = new Size(69, 15);
            lblDateFrom.TabIndex = 5;
            lblDateFrom.Text = "Date From:";
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.CalendarForeColor = Color.FromArgb(10, 30, 70);
            dtpDateFrom.CalendarMonthBackground = Color.White;
            dtpDateFrom.CustomFormat = "MMM dd, yyyy";
            dtpDateFrom.Format = DateTimePickerFormat.Custom;
            dtpDateFrom.Location = new Point(410, 10);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(145, 23);
            dtpDateFrom.TabIndex = 5;
            // 
            // lblDateTo
            // 
            lblDateTo.AutoSize = true;
            lblDateTo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTo.Location = new Point(570, 12);
            lblDateTo.Name = "lblDateTo";
            lblDateTo.Size = new Size(53, 15);
            lblDateTo.TabIndex = 5;
            lblDateTo.Text = "Date To:";
            // 
            // dtpDateTo
            // 
            dtpDateTo.CalendarForeColor = Color.FromArgb(10, 30, 70);
            dtpDateTo.CalendarMonthBackground = Color.White;
            dtpDateTo.CustomFormat = "MMM dd, yyyy";
            dtpDateTo.Format = DateTimePickerFormat.Custom;
            dtpDateTo.Location = new Point(635, 10);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(145, 23);
            dtpDateTo.TabIndex = 6;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(800, 12);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(60, 15);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "All Categories", "", "Accessories", "", "Electronics", "", "Storage", "Furniture" });
            cmbCategory.Location = new Point(880, 10);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(160, 23);
            cmbCategory.TabIndex = 5;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.FromArgb(15, 75, 145);
            btnGenerateReport.Cursor = Cursors.Hand;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(15, 48);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(170, 28);
            btnGenerateReport.TabIndex = 7;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.FromArgb(15, 75, 145);
            btnExportExcel.Cursor = Cursors.Hand;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(195, 48);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(145, 28);
            btnExportExcel.TabIndex = 8;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.FromArgb(15, 75, 145);
            btnExportPDF.Cursor = Cursors.Hand;
            btnExportPDF.FlatStyle = FlatStyle.Flat;
            btnExportPDF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportPDF.ForeColor = Color.White;
            btnExportPDF.Location = new Point(350, 48);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(135, 28);
            btnExportPDF.TabIndex = 9;
            btnExportPDF.Text = "Export PDF";
            btnExportPDF.UseVisualStyleBackColor = false;
            // 
            // pnlTotalProducts
            // 
            pnlTotalProducts.BackColor = Color.White;
            pnlTotalProducts.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalProducts.Controls.Add(pictureBox1);
            pnlTotalProducts.Controls.Add(lblTotalProductsTitle);
            pnlTotalProducts.Controls.Add(lblTotalProductsCount);
            pnlTotalProducts.Location = new Point(20, 195);
            pnlTotalProducts.Name = "pnlTotalProducts";
            pnlTotalProducts.Padding = new Padding(8);
            pnlTotalProducts.Size = new Size(318, 110);
            pnlTotalProducts.TabIndex = 5;
            // 
            // pnlStockIn
            // 
            pnlStockIn.BackColor = Color.White;
            pnlStockIn.BorderStyle = BorderStyle.FixedSingle;
            pnlStockIn.Controls.Add(pictureBox4);
            pnlStockIn.Controls.Add(lblStockInTitle);
            pnlStockIn.Controls.Add(lblStockInCount);
            pnlStockIn.Location = new Point(363, 195);
            pnlStockIn.Name = "pnlStockIn";
            pnlStockIn.Padding = new Padding(8);
            pnlStockIn.Size = new Size(318, 110);
            pnlStockIn.TabIndex = 6;
            // 
            // pnlStockOut
            // 
            pnlStockOut.BackColor = Color.White;
            pnlStockOut.BorderStyle = BorderStyle.FixedSingle;
            pnlStockOut.Controls.Add(pictureBox3);
            pnlStockOut.Controls.Add(lblStockOutTitle);
            pnlStockOut.Controls.Add(lblStockOutCount);
            pnlStockOut.Location = new Point(706, 195);
            pnlStockOut.Name = "pnlStockOut";
            pnlStockOut.Padding = new Padding(8);
            pnlStockOut.Size = new Size(318, 110);
            pnlStockOut.TabIndex = 7;
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = Color.White;
            pnlLowStock.BorderStyle = BorderStyle.FixedSingle;
            pnlLowStock.Controls.Add(pictureBox2);
            pnlLowStock.Controls.Add(lblLowStockTitle);
            pnlLowStock.Controls.Add(lblLowStockCount);
            pnlLowStock.Location = new Point(1049, 195);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Padding = new Padding(8);
            pnlLowStock.Size = new Size(318, 110);
            pnlLowStock.TabIndex = 8;
            // 
            // lblTotalProductsCount
            // 
            lblTotalProductsCount.AutoSize = true;
            lblTotalProductsCount.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProductsCount.Location = new Point(133, 43);
            lblTotalProductsCount.Name = "lblTotalProductsCount";
            lblTotalProductsCount.Size = new Size(65, 37);
            lblTotalProductsCount.TabIndex = 9;
            lblTotalProductsCount.Text = "120";
            // 
            // lblTotalProductsTitle
            // 
            lblTotalProductsTitle.AutoSize = true;
            lblTotalProductsTitle.BackColor = Color.Transparent;
            lblTotalProductsTitle.ForeColor = Color.FromArgb(10, 35, 85);
            lblTotalProductsTitle.Location = new Point(120, 80);
            lblTotalProductsTitle.Name = "lblTotalProductsTitle";
            lblTotalProductsTitle.Size = new Size(83, 15);
            lblTotalProductsTitle.TabIndex = 10;
            lblTotalProductsTitle.Text = "Total Products";
            lblTotalProductsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStockInTitle
            // 
            lblStockInTitle.AutoSize = true;
            lblStockInTitle.BackColor = Color.Transparent;
            lblStockInTitle.ForeColor = Color.FromArgb(10, 35, 85);
            lblStockInTitle.Location = new Point(130, 80);
            lblStockInTitle.Name = "lblStockInTitle";
            lblStockInTitle.Size = new Size(49, 15);
            lblStockInTitle.TabIndex = 12;
            lblStockInTitle.Text = "Stock In";
            lblStockInTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblStockInTitle.Click += lblStockInTitle_Click;
            // 
            // lblStockInCount
            // 
            lblStockInCount.AutoSize = true;
            lblStockInCount.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockInCount.Location = new Point(130, 43);
            lblStockInCount.Name = "lblStockInCount";
            lblStockInCount.Size = new Size(49, 37);
            lblStockInCount.TabIndex = 11;
            lblStockInCount.Text = "45";
            // 
            // lblStockOutTitle
            // 
            lblStockOutTitle.AutoSize = true;
            lblStockOutTitle.BackColor = Color.Transparent;
            lblStockOutTitle.ForeColor = Color.FromArgb(10, 35, 85);
            lblStockOutTitle.Location = new Point(125, 85);
            lblStockOutTitle.Name = "lblStockOutTitle";
            lblStockOutTitle.Size = new Size(59, 15);
            lblStockOutTitle.TabIndex = 14;
            lblStockOutTitle.Text = "Stock Out";
            lblStockOutTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblStockOutTitle.Click += lblStockOutTitle_Click;
            // 
            // lblStockOutCount
            // 
            lblStockOutCount.AutoSize = true;
            lblStockOutCount.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockOutCount.Location = new Point(132, 51);
            lblStockOutCount.Name = "lblStockOutCount";
            lblStockOutCount.Size = new Size(49, 37);
            lblStockOutCount.TabIndex = 13;
            lblStockOutCount.Text = "28";
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.AutoSize = true;
            lblLowStockTitle.BackColor = Color.Transparent;
            lblLowStockTitle.ForeColor = Color.FromArgb(10, 35, 85);
            lblLowStockTitle.Location = new Point(125, 85);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(61, 15);
            lblLowStockTitle.TabIndex = 16;
            lblLowStockTitle.Text = "Low Stock";
            lblLowStockTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLowStockCount
            // 
            lblLowStockCount.AutoSize = true;
            lblLowStockCount.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockCount.Location = new Point(128, 51);
            lblLowStockCount.Name = "lblLowStockCount";
            lblLowStockCount.Size = new Size(49, 37);
            lblLowStockCount.TabIndex = 15;
            lblLowStockCount.Text = "18";
            lblLowStockCount.Click += lblLowStockCount_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.O3L53QbMUaqEe6s3iy5BuqEy1L46DytZKtucqEbKXfwEVZX0QPqaW0y7wrpiMMGUbflrOYDEV8KS_QtWRByOY_Wpyhii4WTbPhg_z1a79WqUIaUlbvPCKZDjRwqiE236hvtrNhPEZ0ifvhkQZd9W5sVcMhRLwGJhW0qbEbIJoonJrIS_b5WC0ZFF0cTclPw6;
            pictureBox1.Location = new Point(143, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.sAMclt4v2zviK9CBJ9yP3o6XTb7pi2VIP_BehaEejKQYhgeVp4lWjNZ1HEp8hUYeVgMluK2n3_JGzwKizwm4XFt2EYbGPkdGDThk0CMgsiw0ymIgrs_oj5AwLEEXwJ32mm5QGVLGRtN4EShxQXAo4EzhhmG0loL2110fBf03xkKdbebDlLRvebeYOyZCbfXl;
            pictureBox2.Location = new Point(128, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources._08zsf0_j21mhTSL6wjmBEZyqmaOh0JYcRIrbfiAM854kwCeEZIMyyLApI_Kav4QIiwOR4yyrSKfpUVKB6dc2_xaeRG1zijN_4fCFf6z07Dann4MU3sXAJNHzwes9Xab_P5XhxzTgFZLpeQEIfmNlIUbEcGgIt4b_1ec2Gv1oe85vIEkI09NCOifcFQ5oBUwU;
            pictureBox3.Location = new Point(139, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.U4PBa6Apck09PUjDqghEfT4aBc2RHXycuscwvxPnjRa2eggbsXFL1ql8zc43coOOXRO__dx8SwOgexxviwPcqXx63qx9Du5UlIf6uHE9SSqFD81JWuAbkflBipRn8As2lraCYImn5__WF_W7e5teI_9iQKcQ9f48IdQ6rUL5mjz7pvzJh9lvlNYjs3oYx5pj;
            pictureBox4.Location = new Point(130, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pnlReportDetails
            // 
            pnlReportDetails.BackColor = Color.White;
            pnlReportDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlReportDetails.Controls.Add(dgvReportDetails);
            pnlReportDetails.Controls.Add(lblReportDetailsTitle);
            pnlReportDetails.Controls.Add(pnlReportDetailsHeader);
            pnlReportDetails.Location = new Point(20, 325);
            pnlReportDetails.Name = "pnlReportDetails";
            pnlReportDetails.Size = new Size(895, 420);
            pnlReportDetails.TabIndex = 9;
            // 
            // pnlReportDetailsHeader
            // 
            pnlReportDetailsHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlReportDetailsHeader.BackColor = Color.FromArgb(10, 55, 105);
            pnlReportDetailsHeader.Location = new Point(0, 0);
            pnlReportDetailsHeader.Name = "pnlReportDetailsHeader";
            pnlReportDetailsHeader.Size = new Size(893, 42);
            pnlReportDetailsHeader.TabIndex = 10;
            // 
            // lblReportDetailsTitle
            // 
            lblReportDetailsTitle.AutoSize = true;
            lblReportDetailsTitle.BackColor = Color.FromArgb(10, 55, 105);
            lblReportDetailsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportDetailsTitle.ForeColor = Color.White;
            lblReportDetailsTitle.Location = new Point(48, 5);
            lblReportDetailsTitle.Name = "lblReportDetailsTitle";
            lblReportDetailsTitle.Size = new Size(118, 21);
            lblReportDetailsTitle.TabIndex = 11;
            lblReportDetailsTitle.Text = "Report Details";
            lblReportDetailsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvReportDetails
            // 
            dgvReportDetails.AllowUserToAddRows = false;
            dgvReportDetails.AllowUserToDeleteRows = false;
            dgvReportDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportDetails.BackgroundColor = Color.WhiteSmoke;
            dgvReportDetails.BorderStyle = BorderStyle.None;
            dgvReportDetails.ColumnHeadersHeight = 38;
            dgvReportDetails.Columns.AddRange(new DataGridViewColumn[] { colSKU, colProductName, colCategory, colOpeningStock, colStockIn, colStockOut, colCurrentStock, colStockStatus });
            dgvReportDetails.GridColor = Color.FromArgb(215, 226, 242);
            dgvReportDetails.Location = new Point(3, 44);
            dgvReportDetails.MultiSelect = false;
            dgvReportDetails.Name = "dgvReportDetails";
            dgvReportDetails.ReadOnly = true;
            dgvReportDetails.RowHeadersVisible = false;
            dgvReportDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportDetails.Size = new Size(891, 375);
            dgvReportDetails.TabIndex = 12;
            // 
            // colSKU
            // 
            colSKU.HeaderText = "SKU";
            colSKU.Name = "colSKU";
            colSKU.ReadOnly = true;
            colSKU.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colProductName
            // 
            colProductName.HeaderText = "Product Name";
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colOpeningStock
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colOpeningStock.DefaultCellStyle = dataGridViewCellStyle6;
            colOpeningStock.HeaderText = "Opening Stock";
            colOpeningStock.Name = "colOpeningStock";
            colOpeningStock.ReadOnly = true;
            colOpeningStock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStockIn
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStockIn.DefaultCellStyle = dataGridViewCellStyle7;
            colStockIn.HeaderText = "Stock In";
            colStockIn.Name = "colStockIn";
            colStockIn.ReadOnly = true;
            colStockIn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStockOut
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStockOut.DefaultCellStyle = dataGridViewCellStyle8;
            colStockOut.HeaderText = "Stock Out";
            colStockOut.Name = "colStockOut";
            colStockOut.ReadOnly = true;
            colStockOut.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCurrentStock
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colCurrentStock.DefaultCellStyle = dataGridViewCellStyle9;
            colCurrentStock.HeaderText = "Current Stock";
            colCurrentStock.Name = "colCurrentStock";
            colCurrentStock.ReadOnly = true;
            colCurrentStock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStockStatus
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colStockStatus.DefaultCellStyle = dataGridViewCellStyle10;
            colStockStatus.HeaderText = "Stock Status";
            colStockStatus.Name = "colStockStatus";
            colStockStatus.ReadOnly = true;
            colStockStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlStockDistribution
            // 
            pnlStockDistribution.BackColor = Color.White;
            pnlStockDistribution.BorderStyle = BorderStyle.FixedSingle;
            pnlStockDistribution.Controls.Add(chartStockDistribution);
            pnlStockDistribution.Controls.Add(lblDistributionTitle);
            pnlStockDistribution.Controls.Add(pnlDistributionHeader);
            pnlStockDistribution.Location = new Point(925, 325);
            pnlStockDistribution.Name = "pnlStockDistribution";
            pnlStockDistribution.Size = new Size(442, 420);
            pnlStockDistribution.TabIndex = 10;
            // 
            // pnlDistributionHeader
            // 
            pnlDistributionHeader.BackColor = Color.FromArgb(10, 55, 105);
            pnlDistributionHeader.Location = new Point(0, 0);
            pnlDistributionHeader.Name = "pnlDistributionHeader";
            pnlDistributionHeader.Size = new Size(440, 42);
            pnlDistributionHeader.TabIndex = 0;
            // 
            // lblDistributionTitle
            // 
            lblDistributionTitle.AutoSize = true;
            lblDistributionTitle.BackColor = Color.FromArgb(10, 55, 105);
            lblDistributionTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDistributionTitle.ForeColor = Color.White;
            lblDistributionTitle.Location = new Point(45, 5);
            lblDistributionTitle.Name = "lblDistributionTitle";
            lblDistributionTitle.Size = new Size(148, 21);
            lblDistributionTitle.TabIndex = 1;
            lblDistributionTitle.Text = "Stock Distribution";
            // 
            // chartStockDistribution
            // 
            chartStockDistribution.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chartStockDistribution.BorderlineWidth = 0;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.BorderColor = Color.White;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            chartStockDistribution.ChartAreas.Add(chartArea2);
            legend2.Alignment = StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            chartStockDistribution.Legends.Add(legend2);
            chartStockDistribution.Location = new Point(10, 50);
            chartStockDistribution.Name = "chartStockDistribution";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Category Distribution";
            chartStockDistribution.Series.Add(series2);
            chartStockDistribution.Size = new Size(420, 340);
            chartStockDistribution.TabIndex = 2;
            chartStockDistribution.Text = "chart1";
            // 
            // InventoryReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 253);
            Controls.Add(pnlStockDistribution);
            Controls.Add(pnlReportDetails);
            Controls.Add(pnlLowStock);
            Controls.Add(pnlStockOut);
            Controls.Add(pnlStockIn);
            Controls.Add(pnlTotalProducts);
            Controls.Add(pnlReportFilters);
            Controls.Add(lblPageDescription);
            Controls.Add(lblPageTitle);
            Controls.Add(pnlPageHeader);
            ForeColor = Color.FromArgb(10, 30, 70);
            Name = "InventoryReports";
            Size = new Size(1387, 808);
            pnlPageHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPageIcon).EndInit();
            pnlReportFilters.ResumeLayout(false);
            pnlReportFilters.PerformLayout();
            pnlTotalProducts.ResumeLayout(false);
            pnlTotalProducts.PerformLayout();
            pnlStockIn.ResumeLayout(false);
            pnlStockIn.PerformLayout();
            pnlStockOut.ResumeLayout(false);
            pnlStockOut.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlReportDetails.ResumeLayout(false);
            pnlReportDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportDetails).EndInit();
            pnlStockDistribution.ResumeLayout(false);
            pnlStockDistribution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartStockDistribution).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlPageHeader;
        private PictureBox picPageIcon;
        private Label lblPageTitle;
        private Label lblPageDescription;
        private Panel pnlReportFilters;
        private Label lblReportType;
        private ComboBox cmbReportType;
        private Label lblCategory;
        private DateTimePicker dtpDateTo;
        private Label lblDateTo;
        private DateTimePicker dtpDateFrom;
        private Label lblDateFrom;
        private Button btnExportExcel;
        private Button btnGenerateReport;
        private ComboBox cmbCategory;
        private Button btnExportPDF;
        private Panel pnlTotalProducts;
        private Panel pnlStockIn;
        private Panel pnlStockOut;
        private Panel pnlLowStock;
        private PictureBox pictureBox1;
        private Label lblTotalProductsTitle;
        private Label lblTotalProductsCount;
        private PictureBox pictureBox4;
        private Label lblStockInTitle;
        private Label lblStockInCount;
        private PictureBox pictureBox3;
        private Label lblStockOutTitle;
        private Label lblStockOutCount;
        private PictureBox pictureBox2;
        private Label lblLowStockTitle;
        private Label lblLowStockCount;
        private Panel pnlReportDetails;
        private DataGridView dgvReportDetails;
        private Label lblReportDetailsTitle;
        private Panel pnlReportDetailsHeader;
        private DataGridViewTextBoxColumn colSKU;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colOpeningStock;
        private DataGridViewTextBoxColumn colStockIn;
        private DataGridViewTextBoxColumn colStockOut;
        private DataGridViewTextBoxColumn colCurrentStock;
        private DataGridViewTextBoxColumn colStockStatus;
        private Panel pnlStockDistribution;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStockDistribution;
        private Label lblDistributionTitle;
        private Panel pnlDistributionHeader;
    }
}
