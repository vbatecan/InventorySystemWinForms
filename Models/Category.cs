using MySql.Data.MySqlClient;

namespace InventorySystem.Models {
    public class Category {
        private int CategoryId;
        private string Name = string.Empty;
        private string Description = string.Empty;
        private bool IsActive = true;

        public Category()
        {

        }

        public Category(int categoryId, string name, string description, bool isActive, DateTime createdAt)
        {
            CategoryId = categoryId;
            Name = name;
            Description = description;
            IsActive = isActive;
        }

        public Category FromMySqlReader(MySqlDataReader reader)
        {
            return new Category(
                reader.GetInt32("CategoryId"),
                reader.GetString("Name"),
                reader.GetString("Description"),
                reader.GetBoolean("IsActive"),
                reader.GetDateTime("CreatedAt")
            );
        }
    }
}