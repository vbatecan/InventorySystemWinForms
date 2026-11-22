#nullable disable

using InventorySystem.Exceptions;
using InventorySystem.Models;
using InventorySystem.Models.Enums;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace InventorySystem.Services
{
    public class UserService
    {
        public User GetUser(string username)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Users WHERE Username = @username", conn);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return User.FromReader(reader);
                }

                throw new UserNotFoundException("User with username " + username + " is not found");
            }
        }

        public User GetById(int userId)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Users WHERE UserId = @userId", conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return User.FromReader(reader);
                }

                throw new EntityNotFoundException("User with id " + userId + " is not found");
            }
        }

        public void SaveUser(User user)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Users (Username, Password, FullName, UserRole, IsActive) VALUES (@username, @password, @fullname, @userRole, @isActive)", conn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@fullname", user.FullName);
                cmd.Parameters.AddWithValue("@userRole", user.UserRole.ToString());
                cmd.Parameters.AddWithValue("@isActive", user.IsActive);

                int result = cmd.ExecuteNonQuery();
                if (result <= 0)
                {
                    throw new FailedCreateUserException();
                }
            }
        }

        public void UpdateUser(User user, string newPassword)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                string query = "";
                if (!string.IsNullOrEmpty(newPassword))
                {
                    query = "UPDATE Users SET Username = @username, Password = @password, FullName = @fullname, UserRole = @userRole, IsActive = @isActive WHERE UserId = @userId";
                }
                else
                {
                    query = "UPDATE Users SET Username = @username, FullName = @fullname, UserRole = @userRole, IsActive = @isActive WHERE UserId = @userId";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@fullname", user.FullName);
                cmd.Parameters.AddWithValue("@userRole", user.UserRole.ToString());
                cmd.Parameters.AddWithValue("@isActive", user.IsActive);
                cmd.Parameters.AddWithValue("@userId", user.UserId);

                if (!string.IsNullOrEmpty(newPassword))
                {
                    cmd.Parameters.AddWithValue("@password", newPassword);
                }

                int result = cmd.ExecuteNonQuery();
                if (result <= 0)
                {
                    throw new EntityNotFoundException("User with id " + user.UserId + " is not found");
                }
            }
        }

        public bool UsernameExists(string username, int excludeUserId = 0)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                if (excludeUserId > 0)
                {
                    query = query + " AND UserId != @excludeId";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                if (excludeUserId > 0)
                {
                    cmd.Parameters.AddWithValue("@excludeId", excludeUserId);
                }

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public void ToggleUserStatus(int userId, bool isActive)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE Users SET IsActive = @isActive WHERE UserId = @userId", conn);
                cmd.Parameters.AddWithValue("@isActive", isActive);
                cmd.Parameters.AddWithValue("@userId", userId);

                int result = cmd.ExecuteNonQuery();
                if (result <= 0)
                {
                    throw new EntityNotFoundException("User with id " + userId + " is not found");
                }
            }
        }

        public DataTable SearchUsers(string searchTerm, string roleFilter, string statusFilter)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                string query = "SELECT UserId, Username, FullName, UserRole, IsActive, CreatedAt FROM Users WHERE 1=1";
                MySqlCommand cmd = new MySqlCommand();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query + " AND (Username LIKE @search OR FullName LIKE @search)";
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                }

                if (!string.IsNullOrEmpty(roleFilter) && roleFilter != "All Roles")
                {
                    query = query + " AND UserRole = @role";
                    cmd.Parameters.AddWithValue("@role", roleFilter);
                }

                if (statusFilter == "Active")
                {
                    query = query + " AND IsActive = 1";
                }
                else if (statusFilter == "Inactive")
                {
                    query = query + " AND IsActive = 0";
                }

                query = query + " ORDER BY UserId DESC";
                cmd.CommandText = query;
                cmd.Connection = conn;

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public int CountActiveAdmins()
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Users WHERE UserRole = 'Admin' AND IsActive = 1", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
