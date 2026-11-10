using InventorySystem.Models.Enums;
using MySql.Data.MySqlClient;

namespace InventorySystem.Models {
    public class User {
        public int UserId;
        public string Username = string.Empty;
        public string Password = string.Empty;
        public string FullName = string.Empty;
        public UserRole UserRole = UserRole.Staff;
        public bool IsActive;
        public DateTime CreatedAt;

        public User()
        {

        }

        public User(int userId, string username, string password, string fullName, UserRole userRole, bool isActive, DateTime createdAt)
        {
            UserId = userId;
            Username = username;
            Password = password;
            FullName = fullName;
            UserRole = userRole;
            IsActive = isActive;
            CreatedAt = createdAt;
        }

        public static User FromReader(MySqlDataReader reader)
        {
            return new User(
                reader.GetInt32("UserId"),
                reader.GetString("Username"),
                reader.GetString("Password"),
                reader.GetString("FullName"),
                (UserRole) Enum.Parse(typeof(UserRole), reader.GetString("UserRole")),
                reader.GetBoolean("IsActive"),
                reader.GetDateTime("CreatedAt")
            );
        }
    }
}