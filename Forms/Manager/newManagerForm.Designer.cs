namespace InventorySystem.Forms.Manager
{
    partial class newManagerForm
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
            pnlHeader = new Panel();
            pnlSideBar = new Panel();
            pnlContent = new Panel();
            btnDashboard = new Button();
            btnProductManagement = new Button();
            btnInventoryMonitoring = new Button();
            btnInventoryReports = new Button();
            btnLogout = new Button();
            lblTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(6, 38, 75);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1264, 45);
            pnlHeader.TabIndex = 0;
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(6, 38, 75);
            pnlSideBar.Controls.Add(btnInventoryReports);
            pnlSideBar.Controls.Add(btnInventoryMonitoring);
            pnlSideBar.Controls.Add(btnProductManagement);
            pnlSideBar.Controls.Add(btnDashboard);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 45);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(280, 636);
            pnlSideBar.TabIndex = 1;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(280, 45);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(5);
            pnlContent.Size = new Size(984, 636);
            pnlContent.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Franklin Gothic Demi Cond", 15.75F);
            btnDashboard.ForeColor = Color.WhiteSmoke;
            btnDashboard.Location = new Point(-9, 156);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(301, 34);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProductManagement
            // 
            btnProductManagement.FlatAppearance.BorderSize = 0;
            btnProductManagement.FlatStyle = FlatStyle.Flat;
            btnProductManagement.Font = new Font("Franklin Gothic Demi Cond", 15.75F);
            btnProductManagement.ForeColor = Color.WhiteSmoke;
            btnProductManagement.Location = new Point(-9, 209);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(301, 34);
            btnProductManagement.TabIndex = 1;
            btnProductManagement.Text = "Product Management";
            btnProductManagement.UseVisualStyleBackColor = true;
            // 
            // btnInventoryMonitoring
            // 
            btnInventoryMonitoring.FlatAppearance.BorderSize = 0;
            btnInventoryMonitoring.FlatStyle = FlatStyle.Flat;
            btnInventoryMonitoring.Font = new Font("Franklin Gothic Demi Cond", 15.75F);
            btnInventoryMonitoring.ForeColor = Color.WhiteSmoke;
            btnInventoryMonitoring.Location = new Point(-9, 260);
            btnInventoryMonitoring.Name = "btnInventoryMonitoring";
            btnInventoryMonitoring.Size = new Size(301, 34);
            btnInventoryMonitoring.TabIndex = 2;
            btnInventoryMonitoring.Text = "Inventory Monitoring";
            btnInventoryMonitoring.UseVisualStyleBackColor = true;
            // 
            // btnInventoryReports
            // 
            btnInventoryReports.FlatAppearance.BorderSize = 0;
            btnInventoryReports.FlatStyle = FlatStyle.Flat;
            btnInventoryReports.Font = new Font("Franklin Gothic Demi Cond", 15.75F);
            btnInventoryReports.ForeColor = Color.WhiteSmoke;
            btnInventoryReports.Location = new Point(-9, 311);
            btnInventoryReports.Name = "btnInventoryReports";
            btnInventoryReports.Size = new Size(301, 34);
            btnInventoryReports.TabIndex = 3;
            btnInventoryReports.Text = "Inventory Reports";
            btnInventoryReports.UseVisualStyleBackColor = true;
            btnInventoryReports.Click += btnInventoryReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1171, 10);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(80, 27);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Transparent;
            lblTitle.Location = new Point(12, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 30);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Manager";
            // 
            // newManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlContent);
            Controls.Add(pnlSideBar);
            Controls.Add(pnlHeader);
            Name = "newManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager Form";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlSideBar;
        private Panel pnlContent;
        private Button btnLogout;
        private Button btnInventoryReports;
        private Button btnInventoryMonitoring;
        private Button btnProductManagement;
        private Button btnDashboard;
        private Label lblTitle;
    }
}