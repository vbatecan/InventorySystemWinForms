namespace InventorySystem.Forms.Manager
{
    partial class ProductManagement
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
            panel1 = new Panel();
            lblSubtitle = new Label();
            lblProductManagement = new Label();
            pictureBox1 = new PictureBox();
            pnlProductDetails = new Panel();
            lblDescription = new Label();
            lblProductName = new Label();
            txtDescription = new TextBox();
            txtProductName = new TextBox();
            txtSku = new TextBox();
            lblSKU = new Label();
            pnlSubField = new Panel();
            picFormField = new PictureBox();
            lblFormReference = new Label();
            lblCategory = new Label();
            lblUnit = new Label();
            lblSupplier = new Label();
            cmbCategory = new ComboBox();
            cmbUnit = new ComboBox();
            cmbSupplier = new ComboBox();
            lblCostPrice = new Label();
            lblSellingPrice = new Label();
            lblReorderLevel = new Label();
            txtCostPrice = new TextBox();
            txtSellingPrice = new TextBox();
            txtReorderLevel = new TextBox();
            chkIsActive = new CheckBox();
            lblIsActive = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDeactivate = new Button();
            btnSearch = new Button();
            pnlProductList = new Panel();
            pnlSubProduct = new Panel();
            pictureBox2 = new PictureBox();
            lblProductList = new Label();
            dataGridView1 = new DataGridView();
            btnEditing = new Button();
            btnDelete = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlProductDetails.SuspendLayout();
            pnlSubField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFormField).BeginInit();
            pnlProductList.SuspendLayout();
            pnlSubProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSubtitle);
            panel1.Controls.Add(lblProductManagement);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(9, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 78);
            panel1.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(20, 45, 85);
            lblSubtitle.Location = new Point(72, 43);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(320, 15);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Manage your products and control the details of each item.";
            // 
            // lblProductManagement
            // 
            lblProductManagement.AutoSize = true;
            lblProductManagement.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductManagement.ForeColor = Color.FromArgb(10, 39, 93);
            lblProductManagement.Location = new Point(66, 9);
            lblProductManagement.Name = "lblProductManagement";
            lblProductManagement.Size = new Size(297, 37);
            lblProductManagement.TabIndex = 1;
            lblProductManagement.Text = "Product Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 52);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlProductDetails
            // 
            pnlProductDetails.BackColor = Color.White;
            pnlProductDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlProductDetails.Controls.Add(btnSearch);
            pnlProductDetails.Controls.Add(btnDeactivate);
            pnlProductDetails.Controls.Add(btnEdit);
            pnlProductDetails.Controls.Add(btnAdd);
            pnlProductDetails.Controls.Add(chkIsActive);
            pnlProductDetails.Controls.Add(txtReorderLevel);
            pnlProductDetails.Controls.Add(txtSellingPrice);
            pnlProductDetails.Controls.Add(txtCostPrice);
            pnlProductDetails.Controls.Add(lblIsActive);
            pnlProductDetails.Controls.Add(lblReorderLevel);
            pnlProductDetails.Controls.Add(lblSellingPrice);
            pnlProductDetails.Controls.Add(lblCostPrice);
            pnlProductDetails.Controls.Add(cmbSupplier);
            pnlProductDetails.Controls.Add(cmbUnit);
            pnlProductDetails.Controls.Add(cmbCategory);
            pnlProductDetails.Controls.Add(lblSupplier);
            pnlProductDetails.Controls.Add(lblUnit);
            pnlProductDetails.Controls.Add(lblCategory);
            pnlProductDetails.Controls.Add(lblDescription);
            pnlProductDetails.Controls.Add(lblProductName);
            pnlProductDetails.Controls.Add(txtDescription);
            pnlProductDetails.Controls.Add(txtProductName);
            pnlProductDetails.Controls.Add(txtSku);
            pnlProductDetails.Controls.Add(lblSKU);
            pnlProductDetails.Controls.Add(pnlSubField);
            pnlProductDetails.Location = new Point(9, 94);
            pnlProductDetails.Name = "pnlProductDetails";
            pnlProductDetails.Size = new Size(967, 269);
            pnlProductDetails.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDescription.Location = new Point(17, 165);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(76, 17);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblProductName.Location = new Point(17, 112);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(96, 17);
            lblProductName.TabIndex = 5;
            lblProductName.Text = "Product Name";
            // 
            // txtDescription
            // 
            txtDescription.ForeColor = SystemColors.ControlDarkDark;
            txtDescription.Location = new Point(17, 185);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(209, 53);
            txtDescription.TabIndex = 4;
            txtDescription.Text = "Enter Description...";
            // 
            // txtProductName
            // 
            txtProductName.ForeColor = SystemColors.ControlDarkDark;
            txtProductName.Location = new Point(17, 131);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(209, 23);
            txtProductName.TabIndex = 3;
            txtProductName.Text = "Enter Product Name...";
            // 
            // txtSku
            // 
            txtSku.ForeColor = SystemColors.ControlDarkDark;
            txtSku.Location = new Point(17, 78);
            txtSku.Name = "txtSku";
            txtSku.Size = new Size(209, 23);
            txtSku.TabIndex = 2;
            txtSku.Text = "Enter SKU...";
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSKU.Location = new Point(17, 59);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(32, 17);
            lblSKU.TabIndex = 1;
            lblSKU.Text = "SKU";
            // 
            // pnlSubField
            // 
            pnlSubField.BackColor = Color.FromArgb(6, 38, 75);
            pnlSubField.Controls.Add(picFormField);
            pnlSubField.Controls.Add(lblFormReference);
            pnlSubField.Location = new Point(-1, -1);
            pnlSubField.Name = "pnlSubField";
            pnlSubField.Size = new Size(967, 42);
            pnlSubField.TabIndex = 0;
            // 
            // picFormField
            // 
            picFormField.Location = new Point(12, 6);
            picFormField.Name = "picFormField";
            picFormField.Size = new Size(34, 30);
            picFormField.TabIndex = 1;
            picFormField.TabStop = false;
            // 
            // lblFormReference
            // 
            lblFormReference.AutoSize = true;
            lblFormReference.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormReference.ForeColor = Color.White;
            lblFormReference.Location = new Point(57, 10);
            lblFormReference.Name = "lblFormReference";
            lblFormReference.Size = new Size(170, 21);
            lblFormReference.TabIndex = 0;
            lblFormReference.Text = "Form Field Reference";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblCategory.Location = new Point(284, 59);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(64, 17);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblUnit.Location = new Point(284, 112);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(33, 17);
            lblUnit.TabIndex = 8;
            lblUnit.Text = "Unit";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSupplier.Location = new Point(284, 165);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(57, 17);
            lblSupplier.TabIndex = 9;
            lblSupplier.Text = "Supplier";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(284, 79);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(209, 23);
            cmbCategory.TabIndex = 10;
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(284, 131);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(209, 23);
            cmbUnit.TabIndex = 11;
            // 
            // cmbSupplier
            // 
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(284, 185);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(209, 23);
            cmbSupplier.TabIndex = 12;
            // 
            // lblCostPrice
            // 
            lblCostPrice.AutoSize = true;
            lblCostPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblCostPrice.Location = new Point(555, 59);
            lblCostPrice.Name = "lblCostPrice";
            lblCostPrice.Size = new Size(68, 17);
            lblCostPrice.TabIndex = 13;
            lblCostPrice.Text = "Cost Price";
            // 
            // lblSellingPrice
            // 
            lblSellingPrice.AutoSize = true;
            lblSellingPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSellingPrice.Location = new Point(555, 112);
            lblSellingPrice.Name = "lblSellingPrice";
            lblSellingPrice.Size = new Size(80, 17);
            lblSellingPrice.TabIndex = 14;
            lblSellingPrice.Text = "Selling Price";
            // 
            // lblReorderLevel
            // 
            lblReorderLevel.AutoSize = true;
            lblReorderLevel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblReorderLevel.Location = new Point(555, 165);
            lblReorderLevel.Name = "lblReorderLevel";
            lblReorderLevel.Size = new Size(90, 17);
            lblReorderLevel.TabIndex = 15;
            lblReorderLevel.Text = "Reorder Level";
            // 
            // txtCostPrice
            // 
            txtCostPrice.ForeColor = SystemColors.ControlDarkDark;
            txtCostPrice.Location = new Point(555, 78);
            txtCostPrice.Name = "txtCostPrice";
            txtCostPrice.Size = new Size(209, 23);
            txtCostPrice.TabIndex = 17;
            txtCostPrice.Text = "Enter Cost Price...";
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.ForeColor = SystemColors.ControlDarkDark;
            txtSellingPrice.Location = new Point(555, 131);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(209, 23);
            txtSellingPrice.TabIndex = 18;
            txtSellingPrice.Text = "Enter Selling Price...";
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.ForeColor = SystemColors.ControlDarkDark;
            txtReorderLevel.Location = new Point(555, 185);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(209, 23);
            txtReorderLevel.TabIndex = 19;
            txtReorderLevel.Text = "Enter Reorder Level...";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Location = new Point(811, 187);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(59, 19);
            chkIsActive.TabIndex = 20;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblIsActive.Location = new Point(806, 165);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(55, 17);
            lblIsActive.TabIndex = 16;
            lblIsActive.Text = "IsActive";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(15, 75, 145);
            btnAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(425, 227);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 28);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(15, 75, 145);
            btnEdit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(555, 227);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 28);
            btnEdit.TabIndex = 22;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.FromArgb(15, 75, 145);
            btnDeactivate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDeactivate.ForeColor = Color.White;
            btnDeactivate.Location = new Point(685, 227);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(124, 28);
            btnDeactivate.TabIndex = 23;
            btnDeactivate.Text = "Deactivate";
            btnDeactivate.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(15, 75, 145);
            btnSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(815, 227);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 28);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // pnlProductList
            // 
            pnlProductList.BackColor = Color.White;
            pnlProductList.BorderStyle = BorderStyle.FixedSingle;
            pnlProductList.Controls.Add(dataGridView1);
            pnlProductList.Controls.Add(pnlSubProduct);
            pnlProductList.Location = new Point(9, 380);
            pnlProductList.Name = "pnlProductList";
            pnlProductList.Size = new Size(967, 243);
            pnlProductList.TabIndex = 2;
            // 
            // pnlSubProduct
            // 
            pnlSubProduct.BackColor = Color.FromArgb(6, 38, 75);
            pnlSubProduct.BorderStyle = BorderStyle.FixedSingle;
            pnlSubProduct.Controls.Add(btnDelete);
            pnlSubProduct.Controls.Add(btnEditing);
            pnlSubProduct.Controls.Add(lblProductList);
            pnlSubProduct.Controls.Add(pictureBox2);
            pnlSubProduct.Location = new Point(-1, 0);
            pnlSubProduct.Name = "pnlSubProduct";
            pnlSubProduct.Size = new Size(967, 42);
            pnlSubProduct.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(11, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 30);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // lblProductList
            // 
            lblProductList.AutoSize = true;
            lblProductList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductList.ForeColor = Color.White;
            lblProductList.Location = new Point(56, 8);
            lblProductList.Name = "lblProductList";
            lblProductList.Size = new Size(100, 21);
            lblProductList.TabIndex = 1;
            lblProductList.Text = "Product List";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Location = new Point(3, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(959, 193);
            dataGridView1.TabIndex = 1;
            // 
            // btnEditing
            // 
            btnEditing.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEditing.ForeColor = Color.FromArgb(0, 75, 190);
            btnEditing.Location = new Point(861, 9);
            btnEditing.Name = "btnEditing";
            btnEditing.Size = new Size(88, 23);
            btnEditing.TabIndex = 2;
            btnEditing.Text = "Edit";
            btnEditing.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(0, 75, 190);
            btnDelete.Location = new Point(757, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "SKU";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Product Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Description";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Category";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Unit";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Supplier";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Cost Price";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Selling Price";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Reorder Level";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "Status";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 253);
            Controls.Add(pnlProductList);
            Controls.Add(pnlProductDetails);
            Controls.Add(panel1);
            Name = "ProductManagement";
            Size = new Size(984, 636);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlProductDetails.ResumeLayout(false);
            pnlProductDetails.PerformLayout();
            pnlSubField.ResumeLayout(false);
            pnlSubField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFormField).EndInit();
            pnlProductList.ResumeLayout(false);
            pnlSubProduct.ResumeLayout(false);
            pnlSubProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblProductManagement;
        private Label lblSubtitle;
        private Panel pnlProductDetails;
        private Panel pnlSubField;
        private Label lblFormReference;
        private PictureBox picFormField;
        private Label lblSKU;
        private TextBox txtSku;
        private TextBox txtDescription;
        private TextBox txtProductName;
        private Label lblDescription;
        private Label lblProductName;
        private ComboBox cmbSupplier;
        private ComboBox cmbUnit;
        private ComboBox cmbCategory;
        private Label lblSupplier;
        private Label lblUnit;
        private Label lblCategory;
        private CheckBox chkIsActive;
        private TextBox txtReorderLevel;
        private TextBox txtSellingPrice;
        private TextBox txtCostPrice;
        private Label lblReorderLevel;
        private Label lblSellingPrice;
        private Label lblCostPrice;
        private Button btnDeactivate;
        private Button btnEdit;
        private Button btnAdd;
        private Label lblIsActive;
        private Button btnSearch;
        private Panel pnlProductList;
        private DataGridView dataGridView1;
        private Panel pnlSubProduct;
        private Label lblProductList;
        private PictureBox pictureBox2;
        private Button btnEditing;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}
