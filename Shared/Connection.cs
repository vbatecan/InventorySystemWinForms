using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem.Shared
{
    internal class Connection
    {
        private string connectionString = "server=localhost;user=root;password=;database=inventorysystem";

        public MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
