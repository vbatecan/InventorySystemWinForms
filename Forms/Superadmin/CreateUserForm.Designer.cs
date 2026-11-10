namespace InventorySystem.Forms.Superadmin {
    partial class CreateUserForm {
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
            components = new System.ComponentModel.Container();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtFullName = new TextBox();
            cbxUserRole = new ComboBox();
            cbxActive = new ComboBox();
            label5 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(33, 82);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(301, 23);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 64);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 116);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(33, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(301, 23);
            txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 221);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 7;
            label3.Text = "User Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 169);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(33, 187);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(301, 23);
            txtFullName.TabIndex = 4;
            // 
            // cbxUserRole
            // 
            cbxUserRole.FlatStyle = FlatStyle.System;
            cbxUserRole.FormattingEnabled = true;
            cbxUserRole.Items.AddRange(new object[] { "Manager", "Staff", "Admin" });
            cbxUserRole.Location = new Point(33, 239);
            cbxUserRole.Name = "cbxUserRole";
            cbxUserRole.Size = new Size(143, 23);
            cbxUserRole.TabIndex = 8;
            // 
            // cbxActive
            // 
            cbxActive.FormattingEnabled = true;
            cbxActive.Items.AddRange(new object[] { "True", "False" });
            cbxActive.Location = new Point(189, 239);
            cbxActive.Name = "cbxActive";
            cbxActive.Size = new Size(145, 23);
            cbxActive.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 221);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 9;
            label5.Text = "IsActive";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(259, 268);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 33);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(174, 268);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(79, 33);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 339);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cbxActive);
            Controls.Add(label5);
            Controls.Add(cbxUserRole);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtFullName);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(500, 700);
            MinimumSize = new Size(400, 300);
            Name = "CreateUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateUserForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
        private TextBox txtFullName;
        private ComboBox cbxUserRole;
        private ComboBox cbxActive;
        private Label label5;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
    }
}