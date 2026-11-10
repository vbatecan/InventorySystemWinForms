namespace InventorySystem.Forms.Manager
{
    partial class managerform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            btnDashoboard = new Button();
            btnProductManagement = new Button();
            btnInventoryManagement = new Button();
            btnInventoryReports = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 38, 75);
            panel1.Controls.Add(btnInventoryReports);
            panel1.Controls.Add(btnInventoryManagement);
            panel1.Controls.Add(btnProductManagement);
            panel1.Controls.Add(btnDashoboard);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 664);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 30);
            label1.TabIndex = 1;
            label1.Text = "INVENTORY SYSTEM";
            // 
            // btnDashoboard
            // 
            btnDashoboard.ForeColor = Color.Black;
            btnDashoboard.Location = new Point(-7, 126);
            btnDashoboard.Name = "btnDashoboard";
            btnDashoboard.Size = new Size(253, 34);
            btnDashoboard.TabIndex = 2;
            btnDashoboard.Text = "Dashboard";
            btnDashoboard.UseVisualStyleBackColor = true;
            btnDashoboard.Click += button1_Click;
            // 
            // btnProductManagement
            // 
            btnProductManagement.Location = new Point(-7, 166);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(253, 34);
            btnProductManagement.TabIndex = 3;
            btnProductManagement.Text = "Product Management";
            btnProductManagement.UseVisualStyleBackColor = true;
            // 
            // btnInventoryManagement
            // 
            btnInventoryManagement.Location = new Point(-7, 206);
            btnInventoryManagement.Name = "btnInventoryManagement";
            btnInventoryManagement.Size = new Size(253, 34);
            btnInventoryManagement.TabIndex = 4;
            btnInventoryManagement.Text = "Inventory Management";
            btnInventoryManagement.UseVisualStyleBackColor = true;
            // 
            // btnInventoryReports
            // 
            btnInventoryReports.Location = new Point(-7, 246);
            btnInventoryReports.Name = "btnInventoryReports";
            btnInventoryReports.Size = new Size(253, 34);
            btnInventoryReports.TabIndex = 5;
            btnInventoryReports.Text = "Inventory Reports";
            btnInventoryReports.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 61, 117);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(240, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1018, 75);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(240, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(1018, 589);
            panel3.TabIndex = 2;
            // 
            // managerform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1258, 664);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "managerform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager Form";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnInventoryReports;
        private Button btnInventoryManagement;
        private Button btnProductManagement;
        private Button btnDashoboard;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
    }
}