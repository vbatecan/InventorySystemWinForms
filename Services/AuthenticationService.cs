using InventorySystem.Models;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;

namespace InventorySystem.Services {
    public class AuthenticationService {

        public User? Login(string username, string password)
        {
            MySqlConnection conn = Connection.Instance;

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username = ? AND password = ?", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows) {
                return User.FromReader(reader);
            }

            return null;
        }
    }
}