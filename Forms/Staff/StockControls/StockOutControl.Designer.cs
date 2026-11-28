namespace InventorySystem.Forms.Staff
{
    partial class StockOutControl
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
            panel4 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            dgvStockOutLog = new DataGridView();
            panel1 = new Panel();
            ProdAvail = new Label();
            label7 = new Label();
            btnSaveStockOut = new Button();
            btnStockOutClear = new Button();
            NumStockOutQuantity = new NumericUpDown();
            cmbStockOutProducts = new ComboBox();
            txtStockOutLocation = new TextBox();
            txtStockOutRefNo = new TextBox();
            rtxtStockOutRemarks = new RichTextBox();
            panel3 = new Panel();
            LblTotAvailProd = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlPageHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPageIcon).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStockOutLog).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumStockOutQuantity).BeginInit();
            panel3.SuspendLayout();
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
            lblPageDescription.Text = "Process outgoing stock releases, item dispatches, and inventory deductions.";
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
            StaffPageTitle.Text = "Stock Out Control";
            StaffPageTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(6, 38, 75);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label6);
            panel4.Location = new Point(408, 138);
            panel4.Name = "panel4";
            panel4.Size = new Size(586, 55);
            panel4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 14);
            label6.Name = "label6";
            label6.Size = new Size(196, 26);
            label6.TabIndex = 8;
            label6.Text = "Stock Out Records";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvStockOutLog);
            panel2.Location = new Point(408, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 495);
            panel2.TabIndex = 8;
            // 
            // dgvStockOutLog
            // 
            dgvStockOutLog.AllowUserToAddRows = false;
            dgvStockOutLog.AllowUserToDeleteRows = false;
            dgvStockOutLog.BackgroundColor = Color.White;
            dgvStockOutLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockOutLog.GridColor = Color.FromArgb(215, 226, 242);
            dgvStockOutLog.Location = new Point(-1, 54);
            dgvStockOutLog.Name = "dgvStockOutLog";
            dgvStockOutLog.ReadOnly = true;
            dgvStockOutLog.Size = new Size(586, 439);
            dgvStockOutLog.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ProdAvail);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnSaveStockOut);
            panel1.Controls.Add(btnStockOutClear);
            panel1.Controls.Add(NumStockOutQuantity);
            panel1.Controls.Add(cmbStockOutProducts);
            panel1.Controls.Add(txtStockOutLocation);
            panel1.Controls.Add(txtStockOutRefNo);
            panel1.Controls.Add(rtxtStockOutRemarks);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 495);
            panel1.TabIndex = 7;
            // 
            // ProdAvail
            // 
            ProdAvail.AutoSize = true;
            ProdAvail.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProdAvail.ForeColor = Color.FromArgb(255, 192, 128);
            ProdAvail.Location = new Point(198, 117);
            ProdAvail.Name = "ProdAvail";
            ProdAvail.Size = new Size(23, 16);
            ProdAvail.TabIndex = 14;
            ProdAvail.Text = "18";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 192, 128);
            label7.Location = new Point(133, 117);
            label7.Name = "label7";
            label7.Size = new Size(69, 16);
            label7.TabIndex = 13;
            label7.Text = "Available :";
            // 
            // btnSaveStockOut
            // 
            btnSaveStockOut.BackColor = Color.FromArgb(10, 48, 104);
            btnSaveStockOut.Cursor = Cursors.Hand;
            btnSaveStockOut.FlatStyle = FlatStyle.Flat;
            btnSaveStockOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveStockOut.ForeColor = Color.White;
            btnSaveStockOut.Location = new Point(26, 423);
            btnSaveStockOut.Name = "btnSaveStockOut";
            btnSaveStockOut.Size = new Size(150, 34);
            btnSaveStockOut.TabIndex = 12;
            btnSaveStockOut.Text = "Save Stock Out";
            btnSaveStockOut.UseVisualStyleBackColor = false;
            btnSaveStockOut.Click += btnSaveStockOut_Click;
            // 
            // btnStockOutClear
            // 
            btnStockOutClear.BackColor = Color.FromArgb(10, 48, 104);
            btnStockOutClear.Cursor = Cursors.Hand;
            btnStockOutClear.FlatStyle = FlatStyle.Flat;
            btnStockOutClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockOutClear.ForeColor = Color.White;
            btnStockOutClear.Location = new Point(182, 423);
            btnStockOutClear.Name = "btnStockOutClear";
            btnStockOutClear.Size = new Size(150, 34);
            btnStockOutClear.TabIndex = 11;
            btnStockOutClear.Text = "Clear";
            btnStockOutClear.UseVisualStyleBackColor = false;
            btnStockOutClear.Click += btnStockOutClear_Click;
            // 
            // NumStockOutQuantity
            // 
            NumStockOutQuantity.Location = new Point(134, 150);
            NumStockOutQuantity.Name = "NumStockOutQuantity";
            NumStockOutQuantity.Size = new Size(199, 23);
            NumStockOutQuantity.TabIndex = 10;
            // 
            // cmbStockOutProducts
            // 
            cmbStockOutProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStockOutProducts.FormattingEnabled = true;
            cmbStockOutProducts.Location = new Point(134, 90);
            cmbStockOutProducts.Name = "cmbStockOutProducts";
            cmbStockOutProducts.Size = new Size(199, 23);
            cmbStockOutProducts.TabIndex = 9;
            // 
            // txtStockOutLocation
            // 
            txtStockOutLocation.Location = new Point(134, 200);
            txtStockOutLocation.Name = "txtStockOutLocation";
            txtStockOutLocation.Size = new Size(199, 23);
            txtStockOutLocation.TabIndex = 8;
            // 
            // txtStockOutRefNo
            // 
            txtStockOutRefNo.Location = new Point(134, 250);
            txtStockOutRefNo.Name = "txtStockOutRefNo";
            txtStockOutRefNo.Size = new Size(199, 23);
            txtStockOutRefNo.TabIndex = 7;
            // 
            // rtxtStockOutRemarks
            // 
            rtxtStockOutRemarks.Location = new Point(134, 300);
            rtxtStockOutRemarks.Name = "rtxtStockOutRemarks";
            rtxtStockOutRemarks.Size = new Size(199, 96);
            rtxtStockOutRemarks.TabIndex = 6;
            rtxtStockOutRemarks.Text = "";
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
            LblTotAvailProd.Size = new Size(165, 26);
            LblTotAvailProd.TabIndex = 7;
            LblTotAvailProd.Text = "Stock Out Entry";
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
            label1.Location = new Point(26, 90);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Product :";
            // 
            // StockOutControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 253);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlPageHeader);
            Name = "StockOutControl";
            Size = new Size(1024, 681);
            Load += StockOutControl_Load;
            pnlPageHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPageIcon).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStockOutLog).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumStockOutQuantity).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPageHeader;
        private PictureBox picPageIcon;
        private Label lblPageDescription;
        private Label StaffPageTitle;
        private Panel panel4;
        private Label label6;
        private Panel panel2;
        private DataGridView dgvStockOutLog;
        private Panel panel1;
        private Button btnSaveStockOut;
        private Button btnStockOutClear;
        private NumericUpDown NumStockOutQuantity;
        private ComboBox cmbStockOutProducts;
        private TextBox txtStockOutLocation;
        private TextBox txtStockOutRefNo;
        private RichTextBox rtxtStockOutRemarks;
        private Panel panel3;
        private Label LblTotAvailProd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label ProdAvail;
    }
}
