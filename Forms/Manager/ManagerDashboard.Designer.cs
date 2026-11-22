namespace InventorySystem.Forms.Manager
{
    partial class ManagerDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblTitle = new Label();
            lblSubTitle = new Label();
            picTitle = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lblNumProduct = new Label();
            lblTotalProducts = new Label();
            picProducts = new PictureBox();
            panel3 = new Panel();
            lblNumStocks = new Label();
            lblTotalStock = new Label();
            picStock = new PictureBox();
            panel4 = new Panel();
            lblNumLowStock = new Label();
            lblLowStock = new Label();
            picLowStock = new PictureBox();
            panel5 = new Panel();
            lblNumMovement = new Label();
            lblTotalMovement = new Label();
            picMovements = new PictureBox();
            pnlInventoryOverview = new Panel();
            pnlInventoryOverviewSub = new Panel();
            picInventory = new PictureBox();
            lblInventoryOverview = new Label();
            pnlQuickActions = new Panel();
            picView = new PictureBox();
            picEdit = new PictureBox();
            picSearch = new PictureBox();
            picAdd = new PictureBox();
            btnViewReports = new Button();
            btnSearchInventory = new Button();
            btnEditProduct = new Button();
            btnAddProduct = new Button();
            pnlQuickActionsSub = new Panel();
            picActions = new PictureBox();
            lblQuickActions = new Label();
            pnlRecentActivity = new Panel();
            panel6 = new Panel();
            btnViewAll = new Button();
            pictureBox1 = new PictureBox();
            lblbRecentActivity = new Label();
            dgvRecentActivity = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            chartInventory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)picTitle).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProducts).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStock).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLowStock).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMovements).BeginInit();
            pnlInventoryOverview.SuspendLayout();
            pnlInventoryOverviewSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInventory).BeginInit();
            pnlQuickActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAdd).BeginInit();
            pnlQuickActionsSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picActions).BeginInit();
            pnlRecentActivity.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartInventory).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(10, 39, 93);
            lblTitle.Location = new Point(64, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(279, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manager Dashboard";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.ForeColor = Color.FromArgb(20, 45, 85);
            lblSubTitle.Location = new Point(69, 45);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(305, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Overview of inventory, products, and reports at a glance.";
            // 
            // picTitle
            // 
            picTitle.Location = new Point(11, 13);
            picTitle.Name = "picTitle";
            picTitle.Size = new Size(48, 52);
            picTitle.TabIndex = 2;
            picTitle.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(245, 248, 253);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(picTitle);
            panel1.Controls.Add(lblSubTitle);
            panel1.Location = new Point(8, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 78);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(220, 233, 252);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblNumProduct);
            panel2.Controls.Add(lblTotalProducts);
            panel2.Controls.Add(picProducts);
            panel2.Location = new Point(8, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 95);
            panel2.TabIndex = 4;
            // 
            // lblNumProduct
            // 
            lblNumProduct.AutoSize = true;
            lblNumProduct.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblNumProduct.ForeColor = Color.Black;
            lblNumProduct.Location = new Point(73, 38);
            lblNumProduct.Name = "lblNumProduct";
            lblNumProduct.Size = new Size(65, 37);
            lblNumProduct.TabIndex = 2;
            lblNumProduct.Text = "250";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalProducts.ForeColor = Color.Black;
            lblTotalProducts.Location = new Point(76, 19);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(123, 21);
            lblTotalProducts.TabIndex = 1;
            lblTotalProducts.Text = "Total Products ";
            // 
            // picProducts
            // 
            picProducts.Location = new Point(11, 20);
            picProducts.Name = "picProducts";
            picProducts.Size = new Size(50, 50);
            picProducts.TabIndex = 0;
            picProducts.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(220, 233, 252);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblNumStocks);
            panel3.Controls.Add(lblTotalStock);
            panel3.Controls.Add(picStock);
            panel3.Location = new Point(251, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 95);
            panel3.TabIndex = 5;
            // 
            // lblNumStocks
            // 
            lblNumStocks.AutoSize = true;
            lblNumStocks.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblNumStocks.ForeColor = Color.Black;
            lblNumStocks.Location = new Point(75, 38);
            lblNumStocks.Name = "lblNumStocks";
            lblNumStocks.Size = new Size(65, 37);
            lblNumStocks.TabIndex = 2;
            lblNumStocks.Text = "450";
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalStock.ForeColor = Color.Black;
            lblTotalStock.Location = new Point(75, 18);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(94, 21);
            lblTotalStock.TabIndex = 1;
            lblTotalStock.Text = "Total Stock";
            // 
            // picStock
            // 
            picStock.Location = new Point(12, 20);
            picStock.Name = "picStock";
            picStock.Size = new Size(50, 50);
            picStock.TabIndex = 0;
            picStock.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(220, 233, 252);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblNumLowStock);
            panel4.Controls.Add(lblLowStock);
            panel4.Controls.Add(picLowStock);
            panel4.Location = new Point(495, 93);
            panel4.Name = "panel4";
            panel4.Size = new Size(237, 95);
            panel4.TabIndex = 6;
            // 
            // lblNumLowStock
            // 
            lblNumLowStock.AutoSize = true;
            lblNumLowStock.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblNumLowStock.ForeColor = Color.Black;
            lblNumLowStock.Location = new Point(77, 37);
            lblNumLowStock.Name = "lblNumLowStock";
            lblNumLowStock.Size = new Size(49, 37);
            lblNumLowStock.TabIndex = 2;
            lblNumLowStock.Text = "28";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLowStock.ForeColor = Color.Black;
            lblLowStock.Location = new Point(77, 18);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(133, 21);
            lblLowStock.TabIndex = 1;
            lblLowStock.Text = "Low Stock Items";
            // 
            // picLowStock
            // 
            picLowStock.Location = new Point(12, 20);
            picLowStock.Name = "picLowStock";
            picLowStock.Size = new Size(50, 50);
            picLowStock.TabIndex = 0;
            picLowStock.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(220, 233, 252);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblNumMovement);
            panel5.Controls.Add(lblTotalMovement);
            panel5.Controls.Add(picMovements);
            panel5.Location = new Point(738, 93);
            panel5.Name = "panel5";
            panel5.Size = new Size(237, 95);
            panel5.TabIndex = 7;
            // 
            // lblNumMovement
            // 
            lblNumMovement.AutoSize = true;
            lblNumMovement.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblNumMovement.ForeColor = Color.Black;
            lblNumMovement.Location = new Point(79, 37);
            lblNumMovement.Name = "lblNumMovement";
            lblNumMovement.Size = new Size(65, 37);
            lblNumMovement.TabIndex = 2;
            lblNumMovement.Text = "700";
            // 
            // lblTotalMovement
            // 
            lblTotalMovement.AutoSize = true;
            lblTotalMovement.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalMovement.ForeColor = Color.Black;
            lblTotalMovement.Location = new Point(79, 18);
            lblTotalMovement.Name = "lblTotalMovement";
            lblTotalMovement.Size = new Size(135, 21);
            lblTotalMovement.TabIndex = 1;
            lblTotalMovement.Text = "Total Movement";
            // 
            // picMovements
            // 
            picMovements.Location = new Point(11, 20);
            picMovements.Name = "picMovements";
            picMovements.Size = new Size(50, 50);
            picMovements.TabIndex = 0;
            picMovements.TabStop = false;
            // 
            // pnlInventoryOverview
            // 
            pnlInventoryOverview.BackColor = Color.White;
            pnlInventoryOverview.BorderStyle = BorderStyle.FixedSingle;
            pnlInventoryOverview.Controls.Add(chartInventory);
            pnlInventoryOverview.Controls.Add(pnlInventoryOverviewSub);
            pnlInventoryOverview.Location = new Point(8, 194);
            pnlInventoryOverview.Name = "pnlInventoryOverview";
            pnlInventoryOverview.Size = new Size(567, 205);
            pnlInventoryOverview.TabIndex = 8;
            // 
            // pnlInventoryOverviewSub
            // 
            pnlInventoryOverviewSub.BackColor = Color.FromArgb(6, 38, 75);
            pnlInventoryOverviewSub.BorderStyle = BorderStyle.FixedSingle;
            pnlInventoryOverviewSub.Controls.Add(picInventory);
            pnlInventoryOverviewSub.Controls.Add(lblInventoryOverview);
            pnlInventoryOverviewSub.Location = new Point(0, 0);
            pnlInventoryOverviewSub.Name = "pnlInventoryOverviewSub";
            pnlInventoryOverviewSub.Size = new Size(567, 42);
            pnlInventoryOverviewSub.TabIndex = 1;
            // 
            // picInventory
            // 
            picInventory.Location = new Point(12, 6);
            picInventory.Name = "picInventory";
            picInventory.Size = new Size(34, 30);
            picInventory.TabIndex = 1;
            picInventory.TabStop = false;
            // 
            // lblInventoryOverview
            // 
            lblInventoryOverview.AutoSize = true;
            lblInventoryOverview.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryOverview.ForeColor = Color.White;
            lblInventoryOverview.Location = new Point(57, 10);
            lblInventoryOverview.Name = "lblInventoryOverview";
            lblInventoryOverview.Size = new Size(162, 21);
            lblInventoryOverview.TabIndex = 0;
            lblInventoryOverview.Text = "Inventory Overview";
            // 
            // pnlQuickActions
            // 
            pnlQuickActions.BorderStyle = BorderStyle.FixedSingle;
            pnlQuickActions.Controls.Add(picView);
            pnlQuickActions.Controls.Add(picEdit);
            pnlQuickActions.Controls.Add(picSearch);
            pnlQuickActions.Controls.Add(picAdd);
            pnlQuickActions.Controls.Add(btnViewReports);
            pnlQuickActions.Controls.Add(btnSearchInventory);
            pnlQuickActions.Controls.Add(btnEditProduct);
            pnlQuickActions.Controls.Add(btnAddProduct);
            pnlQuickActions.Controls.Add(pnlQuickActionsSub);
            pnlQuickActions.Location = new Point(584, 194);
            pnlQuickActions.Name = "pnlQuickActions";
            pnlQuickActions.Size = new Size(391, 205);
            pnlQuickActions.TabIndex = 9;
            // 
            // picView
            // 
            picView.Location = new Point(277, 130);
            picView.Name = "picView";
            picView.Size = new Size(30, 30);
            picView.TabIndex = 8;
            picView.TabStop = false;
            // 
            // picEdit
            // 
            picEdit.Location = new Point(90, 130);
            picEdit.Name = "picEdit";
            picEdit.Size = new Size(30, 30);
            picEdit.TabIndex = 7;
            picEdit.TabStop = false;
            // 
            // picSearch
            // 
            picSearch.Location = new Point(277, 55);
            picSearch.Name = "picSearch";
            picSearch.Size = new Size(30, 30);
            picSearch.TabIndex = 6;
            picSearch.TabStop = false;
            // 
            // picAdd
            // 
            picAdd.Location = new Point(90, 55);
            picAdd.Name = "picAdd";
            picAdd.Size = new Size(30, 30);
            picAdd.TabIndex = 5;
            picAdd.TabStop = false;
            // 
            // btnViewReports
            // 
            btnViewReports.BackColor = Color.White;
            btnViewReports.FlatStyle = FlatStyle.Flat;
            btnViewReports.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnViewReports.ForeColor = Color.FromArgb(10, 39, 93);
            btnViewReports.Location = new Point(198, 125);
            btnViewReports.Name = "btnViewReports";
            btnViewReports.Size = new Size(181, 70);
            btnViewReports.TabIndex = 4;
            btnViewReports.Text = "\r\nView Reports";
            btnViewReports.UseVisualStyleBackColor = false;
            // 
            // btnSearchInventory
            // 
            btnSearchInventory.BackColor = Color.White;
            btnSearchInventory.FlatStyle = FlatStyle.Flat;
            btnSearchInventory.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSearchInventory.ForeColor = Color.FromArgb(10, 39, 93);
            btnSearchInventory.Location = new Point(198, 50);
            btnSearchInventory.Name = "btnSearchInventory";
            btnSearchInventory.Size = new Size(181, 69);
            btnSearchInventory.TabIndex = 3;
            btnSearchInventory.Text = "\r\nSearch Inventory";
            btnSearchInventory.UseVisualStyleBackColor = false;
            // 
            // btnEditProduct
            // 
            btnEditProduct.BackColor = Color.White;
            btnEditProduct.FlatStyle = FlatStyle.Flat;
            btnEditProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnEditProduct.ForeColor = Color.FromArgb(10, 39, 93);
            btnEditProduct.Location = new Point(10, 125);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(182, 70);
            btnEditProduct.TabIndex = 2;
            btnEditProduct.Text = "\r\nEdit Product";
            btnEditProduct.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.White;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnAddProduct.ForeColor = Color.FromArgb(10, 39, 93);
            btnAddProduct.Location = new Point(11, 50);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(181, 69);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "\r\nAdd Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // pnlQuickActionsSub
            // 
            pnlQuickActionsSub.BackColor = Color.FromArgb(6, 38, 75);
            pnlQuickActionsSub.BorderStyle = BorderStyle.FixedSingle;
            pnlQuickActionsSub.Controls.Add(picActions);
            pnlQuickActionsSub.Controls.Add(lblQuickActions);
            pnlQuickActionsSub.Location = new Point(0, 0);
            pnlQuickActionsSub.Name = "pnlQuickActionsSub";
            pnlQuickActionsSub.Size = new Size(391, 42);
            pnlQuickActionsSub.TabIndex = 0;
            // 
            // picActions
            // 
            picActions.Location = new Point(15, 6);
            picActions.Name = "picActions";
            picActions.Size = new Size(34, 30);
            picActions.TabIndex = 1;
            picActions.TabStop = false;
            // 
            // lblQuickActions
            // 
            lblQuickActions.AutoSize = true;
            lblQuickActions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuickActions.ForeColor = Color.White;
            lblQuickActions.Location = new Point(60, 10);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Size = new Size(115, 21);
            lblQuickActions.TabIndex = 0;
            lblQuickActions.Text = "Quick Actions";
            // 
            // pnlRecentActivity
            // 
            pnlRecentActivity.BorderStyle = BorderStyle.FixedSingle;
            pnlRecentActivity.Controls.Add(panel6);
            pnlRecentActivity.Controls.Add(dgvRecentActivity);
            pnlRecentActivity.Location = new Point(8, 405);
            pnlRecentActivity.Name = "pnlRecentActivity";
            pnlRecentActivity.Size = new Size(967, 214);
            pnlRecentActivity.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(6, 38, 75);
            panel6.Controls.Add(btnViewAll);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(lblbRecentActivity);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(967, 44);
            panel6.TabIndex = 2;
            // 
            // btnViewAll
            // 
            btnViewAll.BackColor = Color.White;
            btnViewAll.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewAll.ForeColor = Color.FromArgb(0, 75, 190);
            btnViewAll.Location = new Point(843, 11);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(112, 23);
            btnViewAll.TabIndex = 2;
            btnViewAll.Text = "View All   -->";
            btnViewAll.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 30);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblbRecentActivity
            // 
            lblbRecentActivity.AutoSize = true;
            lblbRecentActivity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbRecentActivity.ForeColor = Color.White;
            lblbRecentActivity.Location = new Point(64, 11);
            lblbRecentActivity.Name = "lblbRecentActivity";
            lblbRecentActivity.Size = new Size(125, 21);
            lblbRecentActivity.TabIndex = 0;
            lblbRecentActivity.Text = "Recent Activity";
            // 
            // dgvRecentActivity
            // 
            dgvRecentActivity.AllowUserToAddRows = false;
            dgvRecentActivity.AllowUserToDeleteRows = false;
            dgvRecentActivity.BackgroundColor = Color.White;
            dgvRecentActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentActivity.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvRecentActivity.Location = new Point(3, 49);
            dgvRecentActivity.Name = "dgvRecentActivity";
            dgvRecentActivity.ReadOnly = true;
            dgvRecentActivity.RowHeadersVisible = false;
            dgvRecentActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentActivity.Size = new Size(959, 159);
            dgvRecentActivity.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Date & Time";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Action";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Details";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Performed By";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // chartInventory
            // 
            chartInventory.BorderlineColor = Color.Transparent;
            chartInventory.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            chartInventory.ChartAreas.Add(chartArea1);
            chartInventory.Dock = DockStyle.Bottom;
            legend1.Name = "Legend1";
            chartInventory.Legends.Add(legend1);
            chartInventory.Location = new Point(0, 43);
            chartInventory.Name = "chartInventory";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartInventory.Series.Add(series1);
            chartInventory.Size = new Size(565, 160);
            chartInventory.TabIndex = 2;
            // 
            // ManagerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 253);
            Controls.Add(pnlRecentActivity);
            Controls.Add(pnlQuickActions);
            Controls.Add(pnlInventoryOverview);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ManagerDashboard";
            Size = new Size(984, 636);
            ((System.ComponentModel.ISupportInitialize)picTitle).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProducts).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStock).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLowStock).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMovements).EndInit();
            pnlInventoryOverview.ResumeLayout(false);
            pnlInventoryOverviewSub.ResumeLayout(false);
            pnlInventoryOverviewSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picInventory).EndInit();
            pnlQuickActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picView).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAdd).EndInit();
            pnlQuickActionsSub.ResumeLayout(false);
            pnlQuickActionsSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picActions).EndInit();
            pnlRecentActivity.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivity).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblSubTitle;
        private PictureBox picTitle;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private PictureBox picProducts;
        private PictureBox picStock;
        private PictureBox picLowStock;
        private PictureBox picMovements;
        private Label lblTotalProducts;
        private Label lblTotalStock;
        private Label lblLowStock;
        private Label lblTotalMovement;
        private Label lblNumProduct;
        private Label lblNumStocks;
        private Label lblNumLowStock;
        private Label lblNumMovement;
        private Panel pnlInventoryOverview;
        private Label lblInventoryOverview;
        private Panel pnlInventoryOverviewSub;
        private PictureBox picInventory;
        private Panel pnlQuickActions;
        private Panel pnlQuickActionsSub;
        private PictureBox picActions;
        private Label lblQuickActions;
        private Button btnViewReports;
        private Button btnSearchInventory;
        private Button btnEditProduct;
        private Button btnAddProduct;
        private PictureBox picAdd;
        private PictureBox picView;
        private PictureBox picEdit;
        private PictureBox picSearch;
        private Panel pnlRecentActivity;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Label lblbRecentActivity;
        private DataGridView dgvRecentActivity;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnViewAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInventory;
    }
}
