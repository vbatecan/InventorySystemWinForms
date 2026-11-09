using InventorySystem.Shared;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using User = InventorySystemWinForms.User;

namespace InventorySystem
{
    public partial class Login : Form
    {
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
            // Add email validation
            if (ValidationUtils.ValidateEmail(txtEmail.Text))
            {
                MessageBox.Show("Email format is not valid", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } else if (!ValidationUtils.ValidatePassword(txtPassword.Text).Equals("valid"))
            {
                MessageBox.Show(ValidationUtils.ValidatePassword(txtPassword.Text));
            }

            using (MySqlConnection conn = Connection.GetConnection())
            {
                var cmd = new MySqlCommand("SELECT id, email, password FROM users WHERE email = @email AND password = @password", conn);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var user = User.FromReader(reader);
                    if (user.Password == txtPassword.Text)
                    {
                        MessageBox.Show("Login successful", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
