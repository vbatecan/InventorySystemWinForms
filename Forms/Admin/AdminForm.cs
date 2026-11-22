#nullable disable

using InventorySystem.Models;
using InventorySystem.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace InventorySystem.Forms.Admin
{
    public partial class AdminForm : Form
    {
        private UserService userService = new UserService();
        private CategoryService categoryService = new CategoryService();
        private UnitsService unitsService = new UnitsService();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            cbxRoleFilter.SelectedIndex = 0;
            cbxStatusFilter.SelectedIndex = 0;
            cbxCategoryStatusFilter.SelectedIndex = 0;

            LoadUsers();
            LoadCategories();
            LoadUnits();
        }

        // ==========================================
        // USER MANAGEMENT
        // ==========================================

        private void LoadUsers()
        {
            try
            {
                string search = txtSearchUser.Text.Trim();
                string role = cbxRoleFilter.Text;
                string status = cbxStatusFilter.Text;

                DataTable table = userService.SearchUsers(search, role, status);
                dgvUsers.DataSource = table;

                if (dgvUsers.Columns.Contains("UserId"))
                {
                    dgvUsers.Columns["UserId"].HeaderText = "User ID";
                    dgvUsers.Columns["UserId"].Width = 70;
                }

                if (dgvUsers.Columns.Contains("Username"))
                {
                    dgvUsers.Columns["Username"].HeaderText = "Username";
                }

                if (dgvUsers.Columns.Contains("FullName"))
                {
                    dgvUsers.Columns["FullName"].HeaderText = "Full Name";
                }

                if (dgvUsers.Columns.Contains("UserRole"))
                {
                    dgvUsers.Columns["UserRole"].HeaderText = "Role";
                    dgvUsers.Columns["UserRole"].Width = 90;
                }

                if (dgvUsers.Columns.Contains("IsActive"))
                {
                    dgvUsers.Columns["IsActive"].HeaderText = "Active";
                    dgvUsers.Columns["IsActive"].Width = 70;
                }

                if (dgvUsers.Columns.Contains("CreatedAt"))
                {
                    dgvUsers.Columns["CreatedAt"].HeaderText = "Created At";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void txtSearchUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadUsers();
            }
        }

        private void cbxRoleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void cbxStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserEditDialog dialog = new UserEditDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to edit.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserId"].Value);
                User user = userService.GetById(userId);

                UserEditDialog dialog = new UserEditDialog(user);
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToggleUserStatus_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserId"].Value);
                string username = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();
                string role = dgvUsers.CurrentRow.Cells["UserRole"].Value.ToString();
                bool currentStatus = Convert.ToBoolean(dgvUsers.CurrentRow.Cells["IsActive"].Value);

                if (currentStatus == true && role == "Admin" && userService.CountActiveAdmins() <= 1)
                {
                    MessageBox.Show("Cannot deactivate the only active Admin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string action = "activate";
                if (currentStatus == true)
                {
                    action = "deactivate";
                }

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to " + action + " user " + username + "?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    userService.ToggleUserStatus(userId, !currentStatus);
                    LoadUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update user status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // CATEGORY MANAGEMENT
        // ==========================================

        private void LoadCategories()
        {
            try
            {
                string search = txtSearchCategory.Text.Trim();
                string status = cbxCategoryStatusFilter.Text;

                DataTable table = categoryService.SearchCategories(search, status);
                dgvCategories.DataSource = table;

                if (dgvCategories.Columns.Contains("CategoryId"))
                {
                    dgvCategories.Columns["CategoryId"].HeaderText = "Category ID";
                    dgvCategories.Columns["CategoryId"].Width = 90;
                }

                if (dgvCategories.Columns.Contains("CategoryName"))
                {
                    dgvCategories.Columns["CategoryName"].HeaderText = "Category Name";
                }

                if (dgvCategories.Columns.Contains("Description"))
                {
                    dgvCategories.Columns["Description"].HeaderText = "Description";
                }

                if (dgvCategories.Columns.Contains("IsActive"))
                {
                    dgvCategories.Columns["IsActive"].HeaderText = "Active";
                    dgvCategories.Columns["IsActive"].Width = 70;
                }

                if (dgvCategories.Columns.Contains("ProductCount"))
                {
                    dgvCategories.Columns["ProductCount"].HeaderText = "Products Count";
                    dgvCategories.Columns["ProductCount"].Width = 110;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void txtSearchCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadCategories();
            }
        }

        private void cbxCategoryStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryEditDialog dialog = new CategoryEditDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadCategories();
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
            {
                MessageBox.Show("Please select a category to edit.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int categoryId = Convert.ToInt32(dgvCategories.CurrentRow.Cells["CategoryId"].Value);
                Category category = categoryService.Get(categoryId);

                CategoryEditDialog dialog = new CategoryEditDialog(category);
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnToggleCategoryStatus_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
            {
                MessageBox.Show("Please select a category.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int categoryId = Convert.ToInt32(dgvCategories.CurrentRow.Cells["CategoryId"].Value);
                string categoryName = dgvCategories.CurrentRow.Cells["CategoryName"].Value.ToString();
                bool currentStatus = Convert.ToBoolean(dgvCategories.CurrentRow.Cells["IsActive"].Value);

                string action = "activate";
                if (currentStatus == true)
                {
                    action = "deactivate";
                }

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to " + action + " category " + categoryName + "?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    categoryService.ToggleStatus(categoryId, !currentStatus);
                    LoadCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update category status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategories.CurrentRow == null)
            {
                MessageBox.Show("Please select a category to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int categoryId = Convert.ToInt32(dgvCategories.CurrentRow.Cells["CategoryId"].Value);
                string categoryName = dgvCategories.CurrentRow.Cells["CategoryName"].Value.ToString();

                if (categoryService.HasAssociatedProducts(categoryId))
                {
                    MessageBox.Show(
                        "Category " + categoryName + " has products. Please deactivate it instead of deleting.",
                        "Cannot Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete category " + categoryName + "?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    categoryService.Delete(categoryId);
                    LoadCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // UNIT MANAGEMENT
        // ==========================================

        private void LoadUnits()
        {
            try
            {
                string search = txtSearchUnit.Text.Trim();

                DataTable table = unitsService.SearchUnits(search);
                dgvUnits.DataSource = table;

                if (dgvUnits.Columns.Contains("UnitId"))
                {
                    dgvUnits.Columns["UnitId"].HeaderText = "Unit ID";
                    dgvUnits.Columns["UnitId"].Width = 80;
                }

                if (dgvUnits.Columns.Contains("UnitName"))
                {
                    dgvUnits.Columns["UnitName"].HeaderText = "Unit Name";
                }

                if (dgvUnits.Columns.Contains("UnitSymbol"))
                {
                    dgvUnits.Columns["UnitSymbol"].HeaderText = "Symbol";
                    dgvUnits.Columns["UnitSymbol"].Width = 100;
                }

                if (dgvUnits.Columns.Contains("AllowsFraction"))
                {
                    dgvUnits.Columns["AllowsFraction"].HeaderText = "Allows Fraction";
                    dgvUnits.Columns["AllowsFraction"].Width = 120;
                }

                if (dgvUnits.Columns.Contains("ProductCount"))
                {
                    dgvUnits.Columns["ProductCount"].HeaderText = "Products Count";
                    dgvUnits.Columns["ProductCount"].Width = 110;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading units: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchUnit_Click(object sender, EventArgs e)
        {
            LoadUnits();
        }

        private void txtSearchUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadUnits();
            }
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            UnitEditDialog dialog = new UnitEditDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadUnits();
            }
        }

        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            if (dgvUnits.CurrentRow == null)
            {
                MessageBox.Show("Please select a unit to edit.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                short unitId = Convert.ToInt16(dgvUnits.CurrentRow.Cells["UnitId"].Value);
                Units unit = unitsService.Get(unitId);

                UnitEditDialog dialog = new UnitEditDialog(unit);
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadUnits();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load unit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            if (dgvUnits.CurrentRow == null)
            {
                MessageBox.Show("Please select a unit to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                short unitId = Convert.ToInt16(dgvUnits.CurrentRow.Cells["UnitId"].Value);
                string unitName = dgvUnits.CurrentRow.Cells["UnitName"].Value.ToString();

                if (unitsService.HasAssociatedProducts(unitId))
                {
                    MessageBox.Show(
                        "Unit " + unitName + " is used by products and cannot be deleted.",
                        "Cannot Delete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete unit " + unitName + "?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    unitsService.Delete(unitId);
                    LoadUnits();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete unit: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
