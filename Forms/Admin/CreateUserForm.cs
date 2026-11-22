using InventorySystem.Exceptions;
using InventorySystem.Models;
using InventorySystem.Models.Enums;
using InventorySystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem.Forms.Admin {
    public partial class CreateUserForm : Form {

        private readonly UserService UserService = new UserService();
        
        public CreateUserForm() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isActive = cbxUserRole.Text == "True";
            
            User userForm = new User(
                txtUsername.Text,
                txtPassword.Text,
                txtFullName.Text,
                UserRole.Admin,
                true
            );

            try {
                UserService.SaveUser(userForm);
                MessageBox.Show("User successfully created", "User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (FailedCreateUserException) {
                MessageBox.Show(" Failed to create user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {

        }
    }
}
