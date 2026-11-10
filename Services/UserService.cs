using InventorySystem.Models;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;

namespace InventorySystem.Services {
    public class UserService {
        public User GetUser(string username)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE Username = ?", conn);
                cmd.Parameters.AddWithValue("Username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    return User.FromReader(reader);
                }

                throw new UserNotFoundException($"User with username {username} is not found");
            }
        }
    }
}