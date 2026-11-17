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
        private void InitializeComponent()
        {
            pnlPageHeader = new Panel();
            picPageIcon = new PictureBox();
            lblPageDescription = new Label();
            StaffPageTitle = new Label();
            pnlPageHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPageIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlPageHeader
            // 
            pnlPageHeader.BackColor = Color.FromArgb(245, 248, 253);
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
            // StockOutControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 253);
            Controls.Add(pnlPageHeader);
            Name = "StockOutControl";
            Size = new Size(1024, 681);
            pnlPageHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPageIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPageHeader;
        private PictureBox picPageIcon;
        private Label lblPageDescription;
        private Label StaffPageTitle;
    }
}
