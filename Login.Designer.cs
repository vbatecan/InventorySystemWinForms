namespace InventorySystem {
    partial class Login {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            btnMinimize = new System.Windows.Forms.PictureBox();
            btnClose = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            btnLogin = new System.Windows.Forms.Button();
            txtPassword = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize) btnClose).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int) ((byte) 120)), ((int) ((byte) 17)), ((int) ((byte) 69)));
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnClose);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(482, 32);
            panel1.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            btnMinimize.Image = global::InventorySystem.Properties.Resources.minimize;
            btnMinimize.Location = new System.Drawing.Point(418, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new System.Drawing.Size(32, 32);
            btnMinimize.TabIndex = 1;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            btnClose.Image = global::InventorySystem.Properties.Resources.close;
            btnClose.Location = new System.Drawing.Point(450, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(32, 32);
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label3);
            panel2.Location = new System.Drawing.Point(66, 159);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(351, 307);
            panel2.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(((int) ((byte) 120)), ((int) ((byte) 17)), ((int) ((byte) 17)));
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) 0));
            btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnLogin.Location = new System.Drawing.Point(27, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(294, 53);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Sign in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtPassword.Location = new System.Drawing.Point(27, 161);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(294, 29);
            txtPassword.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(27, 121);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 21);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtEmail.Location = new System.Drawing.Point(27, 58);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(294, 29);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(27, 27);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(111, 21);
            label3.TabIndex = 0;
            label3.Text = "Email Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) 0));
            label1.Location = new System.Drawing.Point(157, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 45);
            label1.TabIndex = 2;
            label1.Text = "Sign in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) 0));
            label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            label2.Location = new System.Drawing.Point(151, 112);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(124, 21);
            label2.TabIndex = 3;
            label2.Text = "It\'s fast and easy";
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(482, 520);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize) btnClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox btnMinimize;
        private PictureBox btnClose;
        private System.Windows.Forms.Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private Label label3;
        private Button btnLogin;
    }
}
