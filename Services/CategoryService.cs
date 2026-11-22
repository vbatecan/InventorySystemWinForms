using InventorySystem.Exceptions;
using InventorySystem.Models;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;

namespace InventorySystem.Services {
    public class CategoryService {

        public List<Category> All()
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Categories", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Category> categories = new List<Category>();
                while (reader.Read()) {
                    categories.Add(Category.FromReader(reader));
                }

                return categories;
            }
        }

        public Category Get(int categoryId)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Categories WHERE CategoryId = @categoryId", conn);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    return Category.FromReader(reader);
                }

                throw new EntityNotFoundException($"Category with id {categoryId} is not found");
            }
        }

        public void Save(Category category)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Categories (CategoryName, Description, IsActive) VALUES (@categoryName, @description, @isActive)", conn);
                cmd.Parameters.AddWithValue("@categoryName", category.CategoryName);
                cmd.Parameters.AddWithValue("@description", category.Description ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@isActive", category.IsActive);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new OperationFailedException("Failed to create category");
                }
            }
        }

        public void Update(Category category)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("UPDATE Categories SET CategoryName = @categoryName, Description = @description, IsActive = @isActive WHERE CategoryId = @categoryId", conn);
                cmd.Parameters.AddWithValue("@categoryName", category.CategoryName);
                cmd.Parameters.AddWithValue("@description", category.Description ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@isActive", category.IsActive);
                cmd.Parameters.AddWithValue("@categoryId", category.CategoryId);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new EntityNotFoundException($"Category with id {category.CategoryId} is not found");
                }
            }
        }

        public void Delete(int categoryId)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Categories WHERE CategoryId = @categoryId", conn);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new EntityNotFoundException($"Category with id {categoryId} is not found");
                }
            }
        }
    }
}
