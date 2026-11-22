#nullable disable

using InventorySystem.Models;
using InventorySystem.Models.Enums;
using InventorySystem.Services;
using System;
using System.Windows.Forms;

namespace InventorySystem.Forms.Admin
{
    public partial class UserEditDialog : Form
    {
        private UserService userService = new UserService();
        private User editingUser = null;

        public UserEditDialog()
        {
            InitializeComponent();
            Text = "Create User";

            cbxUserRole.Items.Add("Admin");
            cbxUserRole.Items.Add("Manager");
            cbxUserRole.Items.Add("Staff");
            cbxUserRole.SelectedIndex = 2; // Default to Staff

            chkIsActive.Checked = true;
        }

        public UserEditDialog(User user)
        {
            InitializeComponent();
            Text = "Edit User";

            cbxUserRole.Items.Add("Admin");
            cbxUserRole.Items.Add("Manager");
            cbxUserRole.Items.Add("Staff");

            editingUser = user;

            txtUsername.Text = user.Username;
            txtFullName.Text = user.FullName;
            cbxUserRole.Text = user.UserRole.ToString();
            chkIsActive.Checked = user.IsActive;

            lblPassword.Text = "New Password (leave blank to keep)";
            lblConfirmPassword.Text = "Confirm New Password";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            string username = txtUsername.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string selectedRole = cbxUserRole.Text;

            int currentUserId = 0;
            if (editingUser != null)
            {
                currentUserId = editingUser.UserId;
            }

            if (username == "")
            {
                errorProvider.SetError(txtUsername, "Username is required.");
                return;
            }

            if (userService.UsernameExists(username, currentUserId))
            {
                errorProvider.SetError(txtUsername, "Username already exists.");
                return;
            }

            if (fullName == "")
            {
                errorProvider.SetError(txtFullName, "Full name is required.");
                return;
            }

            if (editingUser == null && password == "")
            {
                errorProvider.SetError(txtPassword, "Password is required.");
                return;
            }

            if (password != "")
            {
                if (password.Length < 8)
                {
                    errorProvider.SetError(txtPassword, "Password must be at least 8 characters.");
                    return;
                }

                if (password != confirmPassword)
                {
                    errorProvider.SetError(txtConfirmPassword, "Passwords do not match.");
                    return;
                }
            }

            if (selectedRole == "")
            {
                errorProvider.SetError(cbxUserRole, "Please select a role.");
                return;
            }

            UserRole role = UserRole.Staff;
            if (selectedRole == "Admin")
            {
                role = UserRole.Admin;
            }
            else if (selectedRole == "Manager")
            {
                role = UserRole.Manager;
            }

            try
            {
                if (editingUser == null)
                {
                    User newUser = new User(
                        username,
                        password,
                        fullName,
                        role,
                        chkIsActive.Checked
                    );

                    userService.SaveUser(newUser);
                    MessageBox.Show("User created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    editingUser.Username = username;
                    editingUser.FullName = fullName;
                    editingUser.UserRole = role;
                    editingUser.IsActive = chkIsActive.Checked;

                    userService.UpdateUser(editingUser, password);
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
