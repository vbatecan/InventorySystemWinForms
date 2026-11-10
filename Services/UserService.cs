using InventorySystem.Interfaces;
using InventorySystem.Models;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace InventorySystem.Services {
    public class UserService : IUser {
        public User GetUser(int userId)
        {
            MySqlConnection conn = Connection.Instance;
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE Username = ?", conn);
            cmd.Parameters.AddWithValue("UserId", userId);
            MySqlDataReader reader = cmd.ExecuteReader();

            User? user = User.FromReader(reader);
            if (user == null) {
                throw new UserNotFoundException();
            }

            return user;
        }

        public User GetUser(string username)
        {
            MySqlConnection conn = Connection.Instance;
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE Username = ?", conn);
            cmd.Parameters.AddWithValue("Username", username);
            Task<DbDataReader> reader = cmd.ExecuteReaderAsync();
        }
    }
}