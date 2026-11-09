using InventorySystem.Models.Enums;
using MySql.Data.MySqlClient;

namespace InventorySystem.Models
{
    public class User
    {
        private int UserId;
        private string Username = string.Empty;
        private string Password = string.Empty;
        private string FullName = string.Empty;
        private UserRole UserRole = UserRole.Staff;
        private bool IsActive;
        private DateTime CreatedAt;

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

        public User FromMySqlReader(MySqlDataReader reader)
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
