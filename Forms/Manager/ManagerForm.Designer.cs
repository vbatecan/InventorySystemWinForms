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
<<<<<<< HEAD
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(122, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1344, 401);
            dataGridView1.TabIndex = 0;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 740);
            Controls.Add(dataGridView1);
            Name = "ManagerForm";
            Text = "ManagerForm";
            Load += ManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
=======
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 38, 75);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
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
            // button1
            // 
            button1.Location = new Point(3, 126);
            button1.Name = "button1";
            button1.Size = new Size(237, 34);
            button1.TabIndex = 2;
            button1.Text = "M";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 166);
            button2.Name = "button2";
            button2.Size = new Size(237, 34);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(51, 232);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(51, 286);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // managerform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1258, 664);
            Controls.Add(panel1);
            Name = "managerform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manager Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
>>>>>>> f899c949ece026dc06e8f2de582d279c3cc692fc
            ResumeLayout(false);
        }

        #endregion

<<<<<<< HEAD
        private DataGridView dataGridView1;
=======
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
>>>>>>> f899c949ece026dc06e8f2de582d279c3cc692fc
    }
}