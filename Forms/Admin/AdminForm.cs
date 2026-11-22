using InventorySystem.Shared;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem.Forms.Superadmin
{
    public partial class AdminForm : Form {
        public AdminForm() {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e) {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.Show();
        }

        private void SuperAdminForm_Load(object sender, EventArgs e) {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users LIMIT 100", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvUsers.DataSource = table;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtSearch.Text)) {
                errorProvider.SetError(txtSearch, "Please enter a search term.");
                return;
            }
            errorProvider.SetError(txtSearch, "");

            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username LIKE @search LIMIT 100", conn);
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvUsers.DataSource = table;
            }
        }
    }
}
