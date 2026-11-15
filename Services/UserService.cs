using InventorySystem.Exceptions;
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

        public void SaveUser(User user)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Users (Username, Password, FullName, UserRole, IsActive) VALUES (@username, @password, @fullname, @userRole, @isActive)", conn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@fullname", user.FullName);
                cmd.Parameters.AddWithValue("@userRole", user.UserRole.ToString());
                cmd.Parameters.AddWithValue("@isActive", user.IsActive);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new FailedCreateUserException();
                }
            }
        }
    }
}