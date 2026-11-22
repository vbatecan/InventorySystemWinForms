#nullable disable

using InventorySystem.Models;
using InventorySystem.Services;
using System;
using System.Windows.Forms;

namespace InventorySystem.Forms.Admin
{
    public partial class CategoryEditDialog : Form
    {
        private CategoryService categoryService = new CategoryService();
        private Category editingCategory = null;

        public CategoryEditDialog()
        {
            InitializeComponent();
            Text = "Add Category";
            chkIsActive.Checked = true;
        }

        public CategoryEditDialog(Category category)
        {
            InitializeComponent();
            Text = "Edit Category";

            editingCategory = category;

            txtCategoryName.Text = category.CategoryName;
            if (category.Description != null)
            {
                txtDescription.Text = category.Description;
            }
            else
            {
                txtDescription.Text = "";
            }

            chkIsActive.Checked = category.IsActive;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            string categoryName = txtCategoryName.Text.Trim();
            string description = txtDescription.Text.Trim();

            int currentCategoryId = 0;
            if (editingCategory != null)
            {
                currentCategoryId = editingCategory.CategoryId;
            }

            if (categoryName == "")
            {
                errorProvider.SetError(txtCategoryName, "Category name is required.");
                return;
            }

            if (categoryService.CategoryNameExists(categoryName, currentCategoryId))
            {
                errorProvider.SetError(txtCategoryName, "Category name already exists.");
                return;
            }

            try
            {
                if (editingCategory == null)
                {
                    Category newCat = new Category();
                    newCat.CategoryName = categoryName;
                    newCat.Description = description;
                    newCat.IsActive = chkIsActive.Checked;

                    categoryService.Save(newCat);
                    MessageBox.Show("Category created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    editingCategory.CategoryName = categoryName;
                    editingCategory.Description = description;
                    editingCategory.IsActive = chkIsActive.Checked;

                    categoryService.Update(editingCategory);
                    MessageBox.Show("Category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
