using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem.Shared
{
    public class Connection
    {
        private static readonly string CONNECTION_STRING = "server=localhost;user=root;password=;database=inventorysystem";
        private static MySqlConnection? _instance;

        public static MySqlConnection Instance => _instance;

        private Connection()
        {
            try {
                _instance = new MySqlConnection(CONNECTION_STRING);
            }
            catch (MySqlException e) {
                MessageBox.Show("Connection Error. Please double check the host, username, and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
