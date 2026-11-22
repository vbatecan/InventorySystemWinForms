#nullable disable

using InventorySystem.Exceptions;
using InventorySystem.Models;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.Services
{
    public class CategoryService
    {
        public List<Category> All()
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Categories", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Category> categories = new List<Category>();
                while (reader.Read())
                {
                    categories.Add(Category.FromReader(reader));
                }

                return categories;
            }
        }

        public Category Get(int categoryId)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Categories WHERE CategoryId = @categoryId", conn);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return Category.FromReader(reader);
                }

                throw new EntityNotFoundException("Category with id " + categoryId + " is not found");
            }
        }

        public void Save(Category category)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Categories (CategoryName, Description, IsActive) VALUES (@categoryName, @description, @isActive)", conn);
                cmd.Parameters.AddWithValue("@categoryName", category.CategoryName);

                if (string.IsNullOrEmpty(category.Description))
                {
                    cmd.Parameters.AddWithValue("@description", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@description", category.Description);
                }

                cmd.Parameters.AddWithValue("@isActive", category.IsActive);

                int result = cmd.ExecuteNonQuery();
                if (result <= 0)
                {
                    throw new OperationFailedException("Failed to create category");
                }
            }
        }

        public void Update(Category category)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE Categories SET CategoryName = @categoryName, Description = @description, IsActive = @isActive WHERE CategoryId = @categoryId", conn);
                cmd.Parameters.AddWithValue("@categoryName", category.CategoryName);

                if (string.IsNullOrEmpty(category.Description))
                {
                    cmd.Parameters.AddWithValue("@description", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@description", category.Description);
                }

                cmd.Parameters.AddWithValue("@isActive", category.IsActive);
                cmd.Parameters.AddWithValue("@categoryId", category.CategoryId);

                int result = cmd.ExecuteNonQuery();
                if (result <= 0)
                {
                    throw new EntityNotFoundException("Category with id " + category.CategoryId + " is not found");
                }
            }
        }

        public void Delete(int categoryId)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Categories WHERE CategoryId = @categoryId", conn);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);

                int result = cmd.ExecuteNonQuery();
                if (result <= 0)
                {
                    throw new EntityNotFoundException("Category with id " + categoryId + " is not found");
                }
            }
        }

        public DataTable SearchCategories(string searchTerm, string statusFilter)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                string query = "SELECT c.CategoryId, c.CategoryName, c.Description, c.IsActive, (SELECT COUNT(*) FROM Products p WHERE p.CategoryId = c.CategoryId) AS ProductCount FROM Categories c WHERE 1=1";
                MySqlCommand cmd = new MySqlCommand();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query + " AND (c.CategoryName LIKE @search OR c.Description LIKE @search)";
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                }

                if (statusFilter == "Active")
                {
                    query = query + " AND c.IsActive = 1";
                }
                else if (statusFilter == "Inactive")
                {
                    query = query + " AND c.IsActive = 0";
                }

                query = query + " ORDER BY c.CategoryId DESC";
                cmd.CommandText = query;
                cmd.Connection = conn;

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public bool CategoryNameExists(string categoryName, int excludeCategoryId = 0)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Categories WHERE CategoryName = @name";
                if (excludeCategoryId > 0)
                {
                    query = query + " AND CategoryId != @excludeId";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", categoryName);
                if (excludeCategoryId > 0)
                {
                    cmd.Parameters.AddWithValue("@excludeId", excludeCategoryId);
                }

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public bool HasAssociatedProducts(int categoryId)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Products WHERE CategoryId = @id", conn);
                cmd.Parameters.AddWithValue("@id", categoryId);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public void ToggleStatus(int categoryId, bool isActive)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE Categories SET IsActive = @isActive WHERE CategoryId = @id", conn);
                cmd.Parameters.AddWithValue("@isActive", isActive);
                cmd.Parameters.AddWithValue("@id", categoryId);

                int result = cmd.ExecuteNonQuery();
                if (result <= 0)
                {
                    throw new EntityNotFoundException("Category with id " + categoryId + " is not found");
                }
            }
        }
    }
}
