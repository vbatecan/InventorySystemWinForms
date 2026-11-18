namespace InventorySystem.Forms.Staff
{
    partial class StockHistoryControl
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
            label1 = new Label();
            pnlPageHeader = new Panel();
            picPageIcon = new PictureBox();
            lblPageDescription = new Label();
            StaffPageTitle = new Label();
            panel1 = new Panel();
            textBox2 = new TextBox();
            btnSearch = new Button();
            btnStockOutClear = new Button();
            label2 = new Label();
            label3 = new Label();
            Movement = new ComboBox();
            ProductSearch = new TextBox();
            MovementType = new Label();
            Search = new Label();
            ProdCategory = new ComboBox();
            Category = new Label();
            dgvTransactionLedger = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            cbxCreatedBy = new ComboBox();
            pnlPageHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPageIcon).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionLedger).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(432, 53);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 1;
            label1.Text = "Stock History Test";
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
            pnlPageHeader.TabIndex = 3;
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
            lblPageDescription.Text = "Search, filter, and review historical inventory transactions and movement logs.";
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
            StaffPageTitle.Text = "Stock History";
            StaffPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cbxCreatedBy);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnStockOutClear);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Movement);
            panel1.Controls.Add(ProductSearch);
            panel1.Controls.Add(MovementType);
            panel1.Controls.Add(Search);
            panel1.Controls.Add(ProdCategory);
            panel1.Controls.Add(Category);
            panel1.Location = new Point(20, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 125);
            panel1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(465, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(10, 48, 104);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(638, 66);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(136, 30);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnStockOutClear
            // 
            btnStockOutClear.BackColor = Color.FromArgb(10, 48, 104);
            btnStockOutClear.Cursor = Cursors.Hand;
            btnStockOutClear.FlatStyle = FlatStyle.Flat;
            btnStockOutClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockOutClear.ForeColor = Color.White;
            btnStockOutClear.Location = new Point(794, 66);
            btnStockOutClear.Name = "btnStockOutClear";
            btnStockOutClear.Size = new Size(136, 30);
            btnStockOutClear.TabIndex = 15;
            btnStockOutClear.Text = "Clear";
            btnStockOutClear.UseVisualStyleBackColor = false;
            btnStockOutClear.Click += btnStockOutClear_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 71);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 14;
            label2.Text = "Created by :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(384, 71);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 12;
            label3.Text = "Created at :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Movement
            // 
            Movement.BackColor = Color.White;
            Movement.DropDownStyle = ComboBoxStyle.DropDownList;
            Movement.FormattingEnabled = true;
            Movement.IntegralHeight = false;
            Movement.Location = new Point(794, 27);
            Movement.Name = "Movement";
            Movement.Size = new Size(136, 23);
            Movement.TabIndex = 5;
            // 
            // ProductSearch
            // 
            ProductSearch.ForeColor = Color.FromArgb(30, 45, 70);
            ProductSearch.Location = new Point(156, 27);
            ProductSearch.MaxLength = 100;
            ProductSearch.Name = "ProductSearch";
            ProductSearch.PlaceholderText = "Enter product name...";
            ProductSearch.Size = new Size(211, 23);
            ProductSearch.TabIndex = 9;
            // 
            // MovementType
            // 
            MovementType.BackColor = Color.Transparent;
            MovementType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MovementType.Location = new Point(638, 27);
            MovementType.Name = "MovementType";
            MovementType.Size = new Size(136, 23);
            MovementType.TabIndex = 6;
            MovementType.Text = "Movement Type :";
            MovementType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Search
            // 
            Search.BackColor = Color.Transparent;
            Search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.Location = new Point(58, 27);
            Search.Name = "Search";
            Search.Size = new Size(120, 23);
            Search.TabIndex = 10;
            Search.Text = "Search Product:";
            Search.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProdCategory
            // 
            ProdCategory.BackColor = Color.White;
            ProdCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            ProdCategory.ForeColor = Color.FromArgb(10, 30, 70);
            ProdCategory.FormattingEnabled = true;
            ProdCategory.IntegralHeight = false;
            ProdCategory.Location = new Point(465, 27);
            ProdCategory.Name = "ProdCategory";
            ProdCategory.Size = new Size(156, 23);
            ProdCategory.TabIndex = 7;
            // 
            // Category
            // 
            Category.BackColor = Color.Transparent;
            Category.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Category.Location = new Point(384, 27);
            Category.Name = "Category";
            Category.Size = new Size(75, 23);
            Category.TabIndex = 8;
            Category.Text = "Category:";
            Category.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvTransactionLedger
            // 
            dgvTransactionLedger.AllowUserToAddRows = false;
            dgvTransactionLedger.AllowUserToDeleteRows = false;
            dgvTransactionLedger.BackgroundColor = Color.White;
            dgvTransactionLedger.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactionLedger.GridColor = Color.FromArgb(215, 226, 242);
            dgvTransactionLedger.Location = new Point(0, 50);
            dgvTransactionLedger.Name = "dgvTransactionLedger";
            dgvTransactionLedger.ReadOnly = true;
            dgvTransactionLedger.Size = new Size(988, 324);
            dgvTransactionLedger.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvTransactionLedger);
            panel2.Location = new Point(20, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(988, 374);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(10, 39, 93);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(988, 50);
            panel3.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 11);
            label6.Name = "label6";
            label6.Size = new Size(200, 26);
            label6.TabIndex = 9;
            label6.Text = "Transaction Ledger";
            // 
            // cbxCreatedBy
            // 
            cbxCreatedBy.FormattingEnabled = true;
            cbxCreatedBy.Location = new Point(156, 72);
            cbxCreatedBy.Name = "cbxCreatedBy";
            cbxCreatedBy.Size = new Size(211, 23);
            cbxCreatedBy.TabIndex = 18;
            // 
            // StockHistoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 253);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlPageHeader);
            Controls.Add(label1);
            Name = "StockHistoryControl";
            Size = new Size(1024, 681);
            pnlPageHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPageIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactionLedger).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel pnlPageHeader;
        private PictureBox picPageIcon;
        private Label lblPageDescription;
        private Label StaffPageTitle;
        private Panel panel1;
        private ComboBox Movement;
        private TextBox ProductSearch;
        private Label MovementType;
        private Label Search;
        private ComboBox ProdCategory;
        private Label Category;
        private Label label2;
        private Label label3;
        private DataGridView dgvTransactionLedger;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox2;
        private Button btnSearch;
        private Button btnStockOutClear;
        private Label label6;
        private ComboBox cbxCreatedBy;
    }
}
