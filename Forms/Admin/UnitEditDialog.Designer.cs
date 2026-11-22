namespace InventorySystem.Forms.Admin
{
    partial class UnitEditDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblUnitName = new Label();
            txtUnitName = new TextBox();
            lblUnitSymbol = new Label();
            txtUnitSymbol = new TextBox();
            chkAllowsFraction = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblUnitName
            // 
            lblUnitName.AutoSize = true;
            lblUnitName.Location = new Point(24, 20);
            lblUnitName.Name = "lblUnitName";
            lblUnitName.Size = new Size(64, 15);
            lblUnitName.TabIndex = 0;
            lblUnitName.Text = "Unit Name";
            // 
            // txtUnitName
            // 
            txtUnitName.Location = new Point(24, 38);
            txtUnitName.Name = "txtUnitName";
            txtUnitName.Size = new Size(330, 23);
            txtUnitName.TabIndex = 1;
            // 
            // lblUnitSymbol
            // 
            lblUnitSymbol.AutoSize = true;
            lblUnitSymbol.Location = new Point(24, 75);
            lblUnitSymbol.Name = "lblUnitSymbol";
            lblUnitSymbol.Size = new Size(71, 15);
            lblUnitSymbol.TabIndex = 2;
            lblUnitSymbol.Text = "Unit Symbol";
            // 
            // txtUnitSymbol
            // 
            txtUnitSymbol.Location = new Point(24, 93);
            txtUnitSymbol.Name = "txtUnitSymbol";
            txtUnitSymbol.Size = new Size(160, 23);
            txtUnitSymbol.TabIndex = 3;
            // 
            // chkAllowsFraction
            // 
            chkAllowsFraction.AutoSize = true;
            chkAllowsFraction.Location = new Point(24, 130);
            chkAllowsFraction.Name = "chkAllowsFraction";
            chkAllowsFraction.Size = new Size(106, 19);
            chkAllowsFraction.TabIndex = 4;
            chkAllowsFraction.Text = "Allows Fraction";
            chkAllowsFraction.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(184, 170);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 30);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(274, 170);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 30);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // UnitEditDialog
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(380, 220);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkAllowsFraction);
            Controls.Add(txtUnitSymbol);
            Controls.Add(lblUnitSymbol);
            Controls.Add(txtUnitName);
            Controls.Add(lblUnitName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UnitEditDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Unit";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUnitName;
        private TextBox txtUnitName;
        private Label lblUnitSymbol;
        private TextBox txtUnitSymbol;
        private CheckBox chkAllowsFraction;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errorProvider;
    }
}
