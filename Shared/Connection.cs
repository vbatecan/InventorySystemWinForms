using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem.Shared
{
    internal class Connection
    {
        private static string connectionString = "server=localhost;user=root;password=;database=inventorysystem";

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
