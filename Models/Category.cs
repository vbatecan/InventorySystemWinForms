using MySql.Data.MySqlClient;

namespace InventorySystem.Models {
    public class Category {
        public int CategoryId;
        public string CategoryName = string.Empty;
        public string? Description;
        public bool IsActive;

        public Category()
        {

        }

        public Category(int categoryId, string categoryName, string? description, bool isActive)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            Description = description;
            IsActive = isActive;
        }

        public static Category FromReader(MySqlDataReader reader)
        {
            return new Category(
                reader.GetInt32("CategoryId"),
                reader.GetString("CategoryName"),
                reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString("Description"),
                reader.GetBoolean("IsActive")
            );
        }
    }
}