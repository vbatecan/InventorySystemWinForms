namespace InventorySystem.Forms.Manager {
    partial class ManagerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabDashboard = new TabPage();
            label3 = new Label();
            dgvLowStocks = new DataGridView();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            tabProducts = new TabPage();
            panel8 = new Panel();
            label12 = new Label();
            richTextBox2 = new RichTextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            txtIsActive = new TextBox();
            richTextBox1 = new RichTextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            panel7 = new Panel();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            tabStock = new TabPage();
            tabSuppliers = new TabPage();
            tabCategories = new TabPage();
            tabUnits = new TabPage();
            tabReports = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            btnDeactivate = new Button();
            dgvProducts = new DataGridView();
            txtSearch = new TextBox();
            cbxCategories = new ComboBox();
            cbxSuppliers = new ComboBox();
            btnAddProduct = new Button();
            cbxStatus = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStocks).BeginInit();
            tabProducts.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.WhiteSmoke;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 52);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1185, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 2;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1125, 18);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Manager";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(198, 32);
            label1.TabIndex = 0;
            label1.Text = "Inventory System";
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 629);
            panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDashboard);
            tabControl1.Controls.Add(tabProducts);
            tabControl1.Controls.Add(tabStock);
            tabControl1.Controls.Add(tabSuppliers);
            tabControl1.Controls.Add(tabCategories);
            tabControl1.Controls.Add(tabUnits);
            tabControl1.Controls.Add(tabReports);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1264, 629);
            tabControl1.TabIndex = 0;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(label3);
            tabDashboard.Controls.Add(dgvLowStocks);
            tabDashboard.Controls.Add(panel5);
            tabDashboard.Controls.Add(panel4);
            tabDashboard.Controls.Add(panel3);
            tabDashboard.Location = new Point(4, 30);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3);
            tabDashboard.Size = new Size(1256, 595);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(8, 109);
            label3.Name = "label3";
            label3.Size = new Size(145, 21);
            label3.TabIndex = 4;
            label3.Text = "Low Stock Products";
            // 
            // dgvLowStocks
            // 
            dgvLowStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStocks.Location = new Point(8, 133);
            dgvLowStocks.Name = "dgvLowStocks";
            dgvLowStocks.Size = new Size(1245, 465);
            dgvLowStocks.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Location = new Point(848, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(405, 100);
            panel5.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Location = new Point(428, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(414, 100);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Location = new Point(8, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 100);
            panel3.TabIndex = 0;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(panel8);
            tabProducts.Controls.Add(panel7);
            tabProducts.Controls.Add(panel6);
            tabProducts.Location = new Point(4, 30);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(1256, 595);
            tabProducts.TabIndex = 1;
            tabProducts.Text = "Products";
            tabProducts.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.WhiteSmoke;
            panel8.Controls.Add(label12);
            panel8.Controls.Add(richTextBox2);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(textBox6);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(textBox5);
            panel8.Controls.Add(txtIsActive);
            panel8.Controls.Add(richTextBox1);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(textBox4);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(textBox3);
            panel8.Controls.Add(label7);
            panel8.Controls.Add(textBox2);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(textBox1);
            panel8.Controls.Add(pictureBox3);
            panel8.Location = new Point(923, 109);
            panel8.Name = "panel8";
            panel8.Size = new Size(330, 483);
            panel8.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(4, 352);
            label12.Name = "label12";
            label12.Size = new Size(89, 21);
            label12.TabIndex = 16;
            label12.Text = "Description";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(4, 376);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(321, 104);
            richTextBox2.TabIndex = 15;
            richTextBox2.Text = "A4 Bond Paper";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 316);
            label11.Name = "label11";
            label11.Size = new Size(72, 21);
            label11.TabIndex = 14;
            label11.Text = "On Hand";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(104, 313);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(221, 29);
            textBox6.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 281);
            label10.Name = "label10";
            label10.Size = new Size(95, 21);
            label10.TabIndex = 12;
            label10.Text = "Selling Price";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(104, 278);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(221, 29);
            textBox5.TabIndex = 11;
            // 
            // txtIsActive
            // 
            txtIsActive.BorderStyle = BorderStyle.FixedSingle;
            txtIsActive.Location = new Point(130, 74);
            txtIsActive.Name = "txtIsActive";
            txtIsActive.Size = new Size(195, 29);
            txtIsActive.TabIndex = 10;
            txtIsActive.Text = "Active";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(130, 8);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(195, 60);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "A4 Bond Paper";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 246);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 8;
            label9.Text = "Cost Price";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(104, 243);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 29);
            textBox4.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 211);
            label8.Name = "label8";
            label8.Size = new Size(68, 21);
            label8.TabIndex = 6;
            label8.Text = "Supplier";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(104, 208);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 29);
            textBox3.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 176);
            label7.Name = "label7";
            label7.Size = new Size(39, 21);
            label7.TabIndex = 4;
            label7.Text = "Unit";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 29);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 141);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 2;
            label6.Text = "Category";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 29);
            textBox1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(122, 126);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.WhiteSmoke;
            panel7.Controls.Add(cbxStatus);
            panel7.Controls.Add(btnAddProduct);
            panel7.Controls.Add(cbxSuppliers);
            panel7.Controls.Add(cbxCategories);
            panel7.Controls.Add(txtSearch);
            panel7.Controls.Add(dgvProducts);
            panel7.Controls.Add(btnDeactivate);
            panel7.Controls.Add(btnEdit);
            panel7.Controls.Add(btnDelete);
            panel7.Location = new Point(3, 109);
            panel7.Name = "panel7";
            panel7.Size = new Size(914, 483);
            panel7.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(1250, 100);
            panel6.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(11, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 72);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 58);
            label5.Name = "label5";
            label5.Size = new Size(420, 21);
            label5.TabIndex = 1;
            label5.Text = "Manage product information, pricing, and inventory details.";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(89, 13);
            label4.Name = "label4";
            label4.Size = new Size(153, 45);
            label4.TabIndex = 0;
            label4.Text = "Products";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabStock
            // 
            tabStock.Location = new Point(4, 30);
            tabStock.Name = "tabStock";
            tabStock.Size = new Size(1256, 595);
            tabStock.TabIndex = 2;
            tabStock.Text = "Stock";
            tabStock.UseVisualStyleBackColor = true;
            // 
            // tabSuppliers
            // 
            tabSuppliers.Location = new Point(4, 30);
            tabSuppliers.Name = "tabSuppliers";
            tabSuppliers.Size = new Size(1256, 595);
            tabSuppliers.TabIndex = 3;
            tabSuppliers.Text = "Suppliers";
            tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // tabCategories
            // 
            tabCategories.Location = new Point(4, 30);
            tabCategories.Name = "tabCategories";
            tabCategories.Size = new Size(1256, 595);
            tabCategories.TabIndex = 4;
            tabCategories.Text = "Categories";
            tabCategories.UseVisualStyleBackColor = true;
            // 
            // tabUnits
            // 
            tabUnits.Location = new Point(4, 30);
            tabUnits.Name = "tabUnits";
            tabUnits.Size = new Size(1256, 595);
            tabUnits.TabIndex = 5;
            tabUnits.Text = "Units";
            tabUnits.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            tabReports.Location = new Point(4, 30);
            tabReports.Name = "tabReports";
            tabReports.Size = new Size(1256, 595);
            tabReports.TabIndex = 6;
            tabReports.Text = "Reports";
            tabReports.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Maroon;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(801, 442);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 36);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Navy;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(685, 442);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 36);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.Gainsboro;
            btnDeactivate.FlatAppearance.BorderColor = Color.Gray;
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.ForeColor = SystemColors.ActiveCaptionText;
            btnDeactivate.Location = new Point(569, 442);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(110, 36);
            btnDeactivate.TabIndex = 2;
            btnDeactivate.Text = "Deactivate";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = SystemColors.ButtonFace;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(5, 43);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(906, 393);
            dgvProducts.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(5, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by SKU, Product Name, or Description";
            txtSearch.Size = new Size(409, 29);
            txtSearch.TabIndex = 4;
            // 
            // cbxCategories
            // 
            cbxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategories.FlatStyle = FlatStyle.System;
            cbxCategories.FormattingEnabled = true;
            cbxCategories.Items.AddRange(new object[] { "All Categories" });
            cbxCategories.Location = new Point(420, 8);
            cbxCategories.Name = "cbxCategories";
            cbxCategories.Size = new Size(121, 29);
            cbxCategories.TabIndex = 5;
            // 
            // cbxSuppliers
            // 
            cbxSuppliers.FormattingEnabled = true;
            cbxSuppliers.Location = new Point(547, 8);
            cbxSuppliers.Name = "cbxSuppliers";
            cbxSuppliers.Size = new Size(121, 29);
            cbxSuppliers.TabIndex = 6;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.Navy;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.ForeColor = SystemColors.Control;
            btnAddProduct.Location = new Point(801, 5);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(110, 36);
            btnAddProduct.TabIndex = 7;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // cbxStatus
            // 
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Location = new Point(674, 8);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(121, 29);
            cbxStatus.TabIndex = 8;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "ManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            tabDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStocks).EndInit();
            tabProducts.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabDashboard;
        private TabPage tabProducts;
        private TabPage tabStock;
        private TabPage tabSuppliers;
        private TabPage tabCategories;
        private TabPage tabUnits;
        private TabPage tabReports;
        private Label label3;
        private DataGridView dgvLowStocks;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label6;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Label label9;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox2;
        private TextBox txtIsActive;
        private Label label10;
        private TextBox textBox5;
        private Label label12;
        private RichTextBox richTextBox2;
        private Label label11;
        private TextBox textBox6;
        private Button btnDeactivate;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAddProduct;
        private ComboBox cbxSuppliers;
        private ComboBox cbxCategories;
        private TextBox txtSearch;
        private DataGridView dgvProducts;
        private ComboBox cbxStatus;
    }
}