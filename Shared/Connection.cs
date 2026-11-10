using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace InventorySystem.Shared
{
    public class Connection
    {
        private static readonly string CONNECTION_STRING = "server=localhost;user=root;password=;database=ccp";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(CONNECTION_STRING);
            conn.Open();

            return conn;
        }
    }
}
