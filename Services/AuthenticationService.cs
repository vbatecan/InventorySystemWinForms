using InventorySystem.Models;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;
using System.Security.Authentication;

namespace InventorySystem.Services {
    public class AuthenticationService {

        public User Login(string username, string password)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Users WHERE username = @username AND password = @password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    return User.FromReader(reader);
                }

                throw new InvalidCredentialException("Username or password is invalid.");
            }
        }
    }
}