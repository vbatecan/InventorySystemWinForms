namespace InventorySystem.Forms.Admin
{
    partial class AdminForm
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
            tabControlAdmin = new TabControl();
            tabUsers = new TabPage();
            dgvUsers = new DataGridView();
            panelUserToolbar = new Panel();
            btnToggleUserStatus = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            btnSearchUser = new Button();
            cbxStatusFilter = new ComboBox();
            cbxRoleFilter = new ComboBox();
            txtSearchUser = new TextBox();
            tabCategories = new TabPage();
            dgvCategories = new DataGridView();
            panelCategoryToolbar = new Panel();
            btnDeleteCategory = new Button();
            btnToggleCategoryStatus = new Button();
            btnEditCategory = new Button();
            btnAddCategory = new Button();
            btnSearchCategory = new Button();
            cbxCategoryStatusFilter = new ComboBox();
            txtSearchCategory = new TextBox();
            tabUnits = new TabPage();
            dgvUnits = new DataGridView();
            panelUnitToolbar = new Panel();
            btnDeleteUnit = new Button();
            btnEditUnit = new Button();
            btnAddUnit = new Button();
            btnSearchUnit = new Button();
            txtSearchUnit = new TextBox();
            tabControlAdmin.SuspendLayout();
            tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panelUserToolbar.SuspendLayout();
            tabCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            panelCategoryToolbar.SuspendLayout();
            tabUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUnits).BeginInit();
            panelUnitToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAdmin
            // 
            tabControlAdmin.Controls.Add(tabUsers);
            tabControlAdmin.Controls.Add(tabCategories);
            tabControlAdmin.Controls.Add(tabUnits);
            tabControlAdmin.Dock = DockStyle.Fill;
            tabControlAdmin.Location = new Point(0, 0);
            tabControlAdmin.Name = "tabControlAdmin";
            tabControlAdmin.SelectedIndex = 0;
            tabControlAdmin.Size = new Size(960, 560);
            tabControlAdmin.TabIndex = 0;
            // 
            // tabUsers
            // 
            tabUsers.Controls.Add(dgvUsers);
            tabUsers.Controls.Add(panelUserToolbar);
            tabUsers.Location = new Point(4, 24);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(3);
            tabUsers.Size = new Size(952, 532);
            tabUsers.TabIndex = 0;
            tabUsers.Text = "User Management";
            tabUsers.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(3, 51);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(946, 478);
            dgvUsers.TabIndex = 1;
            // 
            // panelUserToolbar
            // 
            panelUserToolbar.Controls.Add(btnToggleUserStatus);
            panelUserToolbar.Controls.Add(btnEditUser);
            panelUserToolbar.Controls.Add(btnAddUser);
            panelUserToolbar.Controls.Add(btnSearchUser);
            panelUserToolbar.Controls.Add(cbxStatusFilter);
            panelUserToolbar.Controls.Add(cbxRoleFilter);
            panelUserToolbar.Controls.Add(txtSearchUser);
            panelUserToolbar.Dock = DockStyle.Top;
            panelUserToolbar.Location = new Point(3, 3);
            panelUserToolbar.Name = "panelUserToolbar";
            panelUserToolbar.Size = new Size(946, 48);
            panelUserToolbar.TabIndex = 0;
            // 
            // btnToggleUserStatus
            // 
            btnToggleUserStatus.Location = new Point(782, 10);
            btnToggleUserStatus.Name = "btnToggleUserStatus";
            btnToggleUserStatus.Size = new Size(110, 28);
            btnToggleUserStatus.TabIndex = 6;
            btnToggleUserStatus.Text = "Toggle Status";
            btnToggleUserStatus.UseVisualStyleBackColor = true;
            btnToggleUserStatus.Click += btnToggleUserStatus_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(696, 10);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(80, 28);
            btnEditUser.TabIndex = 5;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(590, 10);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(100, 28);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "+ Create User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnSearchUser
            // 
            btnSearchUser.Location = new Point(480, 10);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(75, 28);
            btnSearchUser.TabIndex = 3;
            btnSearchUser.Text = "Search";
            btnSearchUser.UseVisualStyleBackColor = true;
            btnSearchUser.Click += btnSearchUser_Click;
            // 
            // cbxStatusFilter
            // 
            cbxStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatusFilter.FormattingEnabled = true;
            cbxStatusFilter.Items.AddRange(new object[] { "All Status", "Active", "Inactive" });
            cbxStatusFilter.Location = new Point(364, 13);
            cbxStatusFilter.Name = "cbxStatusFilter";
            cbxStatusFilter.Size = new Size(110, 23);
            cbxStatusFilter.TabIndex = 2;
            cbxStatusFilter.SelectedIndexChanged += cbxStatusFilter_SelectedIndexChanged;
            // 
            // cbxRoleFilter
            // 
            cbxRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRoleFilter.FormattingEnabled = true;
            cbxRoleFilter.Items.AddRange(new object[] { "All Roles", "Admin", "Manager", "Staff" });
            cbxRoleFilter.Location = new Point(238, 13);
            cbxRoleFilter.Name = "cbxRoleFilter";
            cbxRoleFilter.Size = new Size(120, 23);
            cbxRoleFilter.TabIndex = 1;
            cbxRoleFilter.SelectedIndexChanged += cbxRoleFilter_SelectedIndexChanged;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(8, 13);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.PlaceholderText = "Search username or full name...";
            txtSearchUser.Size = new Size(224, 23);
            txtSearchUser.TabIndex = 0;
            txtSearchUser.KeyDown += txtSearchUser_KeyDown;
            // 
            // tabCategories
            // 
            tabCategories.Controls.Add(dgvCategories);
            tabCategories.Controls.Add(panelCategoryToolbar);
            tabCategories.Location = new Point(4, 24);
            tabCategories.Name = "tabCategories";
            tabCategories.Padding = new Padding(3);
            tabCategories.Size = new Size(952, 532);
            tabCategories.TabIndex = 1;
            tabCategories.Text = "Category Management";
            tabCategories.UseVisualStyleBackColor = true;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.Location = new Point(3, 51);
            dgvCategories.MultiSelect = false;
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(946, 478);
            dgvCategories.TabIndex = 1;
            // 
            // panelCategoryToolbar
            // 
            panelCategoryToolbar.Controls.Add(btnDeleteCategory);
            panelCategoryToolbar.Controls.Add(btnToggleCategoryStatus);
            panelCategoryToolbar.Controls.Add(btnEditCategory);
            panelCategoryToolbar.Controls.Add(btnAddCategory);
            panelCategoryToolbar.Controls.Add(btnSearchCategory);
            panelCategoryToolbar.Controls.Add(cbxCategoryStatusFilter);
            panelCategoryToolbar.Controls.Add(txtSearchCategory);
            panelCategoryToolbar.Dock = DockStyle.Top;
            panelCategoryToolbar.Location = new Point(3, 3);
            panelCategoryToolbar.Name = "panelCategoryToolbar";
            panelCategoryToolbar.Size = new Size(946, 48);
            panelCategoryToolbar.TabIndex = 0;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(828, 10);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(75, 28);
            btnDeleteCategory.TabIndex = 6;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnToggleCategoryStatus
            // 
            btnToggleCategoryStatus.Location = new Point(712, 10);
            btnToggleCategoryStatus.Name = "btnToggleCategoryStatus";
            btnToggleCategoryStatus.Size = new Size(110, 28);
            btnToggleCategoryStatus.TabIndex = 5;
            btnToggleCategoryStatus.Text = "Toggle Status";
            btnToggleCategoryStatus.UseVisualStyleBackColor = true;
            btnToggleCategoryStatus.Click += btnToggleCategoryStatus_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(626, 10);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(80, 28);
            btnEditCategory.TabIndex = 4;
            btnEditCategory.Text = "Edit";
            btnEditCategory.UseVisualStyleBackColor = true;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(510, 10);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(110, 28);
            btnAddCategory.TabIndex = 3;
            btnAddCategory.Text = "+ Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnSearchCategory
            // 
            btnSearchCategory.Location = new Point(410, 10);
            btnSearchCategory.Name = "btnSearchCategory";
            btnSearchCategory.Size = new Size(75, 28);
            btnSearchCategory.TabIndex = 2;
            btnSearchCategory.Text = "Search";
            btnSearchCategory.UseVisualStyleBackColor = true;
            btnSearchCategory.Click += btnSearchCategory_Click;
            // 
            // cbxCategoryStatusFilter
            // 
            cbxCategoryStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoryStatusFilter.FormattingEnabled = true;
            cbxCategoryStatusFilter.Items.AddRange(new object[] { "All Status", "Active", "Inactive" });
            cbxCategoryStatusFilter.Location = new Point(274, 13);
            cbxCategoryStatusFilter.Name = "cbxCategoryStatusFilter";
            cbxCategoryStatusFilter.Size = new Size(120, 23);
            cbxCategoryStatusFilter.TabIndex = 1;
            cbxCategoryStatusFilter.SelectedIndexChanged += cbxCategoryStatusFilter_SelectedIndexChanged;
            // 
            // txtSearchCategory
            // 
            txtSearchCategory.Location = new Point(8, 13);
            txtSearchCategory.Name = "txtSearchCategory";
            txtSearchCategory.PlaceholderText = "Search category name or description...";
            txtSearchCategory.Size = new Size(250, 23);
            txtSearchCategory.TabIndex = 0;
            txtSearchCategory.KeyDown += txtSearchCategory_KeyDown;
            // 
            // tabUnits
            // 
            tabUnits.Controls.Add(dgvUnits);
            tabUnits.Controls.Add(panelUnitToolbar);
            tabUnits.Location = new Point(4, 24);
            tabUnits.Name = "tabUnits";
            tabUnits.Padding = new Padding(3);
            tabUnits.Size = new Size(952, 532);
            tabUnits.TabIndex = 2;
            tabUnits.Text = "Unit Management";
            tabUnits.UseVisualStyleBackColor = true;
            // 
            // dgvUnits
            // 
            dgvUnits.AllowUserToAddRows = false;
            dgvUnits.AllowUserToDeleteRows = false;
            dgvUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnits.Dock = DockStyle.Fill;
            dgvUnits.Location = new Point(3, 51);
            dgvUnits.MultiSelect = false;
            dgvUnits.Name = "dgvUnits";
            dgvUnits.ReadOnly = true;
            dgvUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnits.Size = new Size(946, 478);
            dgvUnits.TabIndex = 1;
            // 
            // panelUnitToolbar
            // 
            panelUnitToolbar.Controls.Add(btnDeleteUnit);
            panelUnitToolbar.Controls.Add(btnEditUnit);
            panelUnitToolbar.Controls.Add(btnAddUnit);
            panelUnitToolbar.Controls.Add(btnSearchUnit);
            panelUnitToolbar.Controls.Add(txtSearchUnit);
            panelUnitToolbar.Dock = DockStyle.Top;
            panelUnitToolbar.Location = new Point(3, 3);
            panelUnitToolbar.Name = "panelUnitToolbar";
            panelUnitToolbar.Size = new Size(946, 48);
            panelUnitToolbar.TabIndex = 0;
            // 
            // btnDeleteUnit
            // 
            btnDeleteUnit.Location = new Point(620, 10);
            btnDeleteUnit.Name = "btnDeleteUnit";
            btnDeleteUnit.Size = new Size(75, 28);
            btnDeleteUnit.TabIndex = 4;
            btnDeleteUnit.Text = "Delete";
            btnDeleteUnit.UseVisualStyleBackColor = true;
            btnDeleteUnit.Click += btnDeleteUnit_Click;
            // 
            // btnEditUnit
            // 
            btnEditUnit.Location = new Point(534, 10);
            btnEditUnit.Name = "btnEditUnit";
            btnEditUnit.Size = new Size(80, 28);
            btnEditUnit.TabIndex = 3;
            btnEditUnit.Text = "Edit";
            btnEditUnit.UseVisualStyleBackColor = true;
            btnEditUnit.Click += btnEditUnit_Click;
            // 
            // btnAddUnit
            // 
            btnAddUnit.Location = new Point(428, 10);
            btnAddUnit.Name = "btnAddUnit";
            btnAddUnit.Size = new Size(100, 28);
            btnAddUnit.TabIndex = 2;
            btnAddUnit.Text = "+ Add Unit";
            btnAddUnit.UseVisualStyleBackColor = true;
            btnAddUnit.Click += btnAddUnit_Click;
            // 
            // btnSearchUnit
            // 
            btnSearchUnit.Location = new Point(274, 10);
            btnSearchUnit.Name = "btnSearchUnit";
            btnSearchUnit.Size = new Size(75, 28);
            btnSearchUnit.TabIndex = 1;
            btnSearchUnit.Text = "Search";
            btnSearchUnit.UseVisualStyleBackColor = true;
            btnSearchUnit.Click += btnSearchUnit_Click;
            // 
            // txtSearchUnit
            // 
            txtSearchUnit.Location = new Point(8, 13);
            txtSearchUnit.Name = "txtSearchUnit";
            txtSearchUnit.PlaceholderText = "Search unit name or symbol...";
            txtSearchUnit.Size = new Size(250, 23);
            txtSearchUnit.TabIndex = 0;
            txtSearchUnit.KeyDown += txtSearchUnit_KeyDown;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 560);
            Controls.Add(tabControlAdmin);
            MinimumSize = new Size(800, 480);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminForm_Load;
            tabControlAdmin.ResumeLayout(false);
            tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panelUserToolbar.ResumeLayout(false);
            panelUserToolbar.PerformLayout();
            tabCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            panelCategoryToolbar.ResumeLayout(false);
            panelCategoryToolbar.PerformLayout();
            tabUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUnits).EndInit();
            panelUnitToolbar.ResumeLayout(false);
            panelUnitToolbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAdmin;
        private TabPage tabUsers;
        private Panel panelUserToolbar;
        private TextBox txtSearchUser;
        private ComboBox cbxRoleFilter;
        private ComboBox cbxStatusFilter;
        private Button btnSearchUser;
        private Button btnAddUser;
        private Button btnEditUser;
        private Button btnToggleUserStatus;
        private DataGridView dgvUsers;
        private TabPage tabCategories;
        private Panel panelCategoryToolbar;
        private TextBox txtSearchCategory;
        private ComboBox cbxCategoryStatusFilter;
        private Button btnSearchCategory;
        private Button btnAddCategory;
        private Button btnEditCategory;
        private Button btnToggleCategoryStatus;
        private Button btnDeleteCategory;
        private DataGridView dgvCategories;
        private TabPage tabUnits;
        private Panel panelUnitToolbar;
        private TextBox txtSearchUnit;
        private Button btnSearchUnit;
        private Button btnAddUnit;
        private Button btnEditUnit;
        private Button btnDeleteUnit;
        private DataGridView dgvUnits;
    }
}
