namespace InventorySystem.Forms.Manager
{
    partial class StaffForm
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
        private void InitializeComponent() {
            panel1 = new Panel();
            button4 = new Button();
            btnStockHistory = new Button();
            btnStockIn = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 38, 75);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnStockHistory);
            panel1.Controls.Add(btnStockIn);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold);
            panel1.ForeColor = Color.WhiteSmoke;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 681);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(68, 92, 120);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(3, 276);
            button4.Name = "button4";
            button4.Size = new Size(237, 34);
            button4.TabIndex = 5;
            button4.Text = "Stock History";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnStockHistory_Click;
            // 
            // btnStockHistory
            // 
            btnStockHistory.FlatAppearance.BorderSize = 0;
            btnStockHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(68, 92, 120);
            btnStockHistory.FlatStyle = FlatStyle.Flat;
            btnStockHistory.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold);
            btnStockHistory.ForeColor = Color.WhiteSmoke;
            btnStockHistory.Location = new Point(3, 236);
            btnStockHistory.Name = "btnStockHistory";
            btnStockHistory.Size = new Size(237, 34);
            btnStockHistory.TabIndex = 4;
            btnStockHistory.Text = "Stock Out";
            btnStockHistory.UseVisualStyleBackColor = true;
            btnStockHistory.Click += btnStockOut_Click;
            // 
            // btnStockIn
            // 
            btnStockIn.FlatAppearance.BorderSize = 0;
            btnStockIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(68, 92, 120);
            btnStockIn.FlatStyle = FlatStyle.Flat;
            btnStockIn.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold);
            btnStockIn.ForeColor = Color.WhiteSmoke;
            btnStockIn.Location = new Point(3, 196);
            btnStockIn.Name = "btnStockIn";
            btnStockIn.Size = new Size(237, 34);
            btnStockIn.TabIndex = 3;
            btnStockIn.Text = "Stock In";
            btnStockIn.UseVisualStyleBackColor = true;
            btnStockIn.Click += btnStockIn_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(68, 92, 120);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.WhiteSmoke;
            btnDashboard.Location = new Point(3, 156);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(237, 34);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 1;
            label1.Text = "Staff Form";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(245, 248, 253);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(240, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1024, 681);
            panelContainer.TabIndex = 2;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Name = "StaffForm";
            Text = "StaffForm";
            Load += StaffForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button btnStockHistory;
        private Button btnStockIn;
        private Button btnDashboard;
        private Label label1;
        private Panel panelContainer;
    }
}
