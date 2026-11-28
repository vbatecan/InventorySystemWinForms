using InventorySystem.Exceptions;
using InventorySystem.Forms.Manager;
using InventorySystem.Forms.Admin;
using InventorySystem.Models;
using InventorySystem.Models.Enums;
using InventorySystem.Services;
using InventorySystem.Shared;

namespace InventorySystem
{
    
    public partial class Login : Form {

        private readonly AuthenticationService authService = new AuthenticationService();
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidationUtils.ValidateEmail(txtUsername.Text))
            {
                MessageBox.Show(@"Email format is not valid", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } else if (!ValidationUtils.ValidatePassword(txtPassword.Text).Equals("valid"))
            {
                MessageBox.Show(ValidationUtils.ValidatePassword(txtPassword.Text));
            }

            try {

                User user = authService.Login(txtUsername.Text, txtPassword.Text);

                switch (user.UserRole) {
                    case UserRole.Admin:
                        AdminForm superAdminForm = new();
                        superAdminForm.Show();
                        break;
                    case UserRole.Staff:
                        StaffForm staffForm = new();
                        staffForm.Show();
                        break;
                    case UserRole.Manager:
                        ManagerForm managerForm = new();
                        managerForm.Show();
                        break;
                    default:
                        MessageBox.Show("Invalid user role");
                        break;
                }

                Hide();
            } catch (InvalidLoginDetailsException) {
                MessageBox.Show(@"Username or password is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
