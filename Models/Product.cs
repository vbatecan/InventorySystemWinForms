using MySql.Data.MySqlClient;

namespace InventorySystem.Models {
    public class Product {
        public long ProductId;
        public string Sku = string.Empty;
        public string ProductName = string.Empty;
        public string? Description;
        public int CategoryId;
        public short UnitId;
        public int? SupplierId;
        public decimal CostPrice;
        public decimal SellingPrice;
        public decimal ReorderLevel;
        public bool IsActive;
        public DateTime CreatedAt;
        public DateTime UpdatedAt;

        public Product()
        {

        }

        public Product(long productId, string sku, string productName, string? description, int categoryId, short unitId, int? supplierId, decimal costPrice,
            decimal sellingPrice, decimal reorderLevel, bool isActive, DateTime createdAt, DateTime updatedAt)
        {
            ProductId = productId;
            Sku = sku;
            ProductName = productName;
            Description = description;
            CategoryId = categoryId;
            UnitId = unitId;
            SupplierId = supplierId;
            CostPrice = costPrice;
            SellingPrice = sellingPrice;
            ReorderLevel = reorderLevel;
            IsActive = isActive;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public static Product FromReader(MySqlDataReader reader)
        {
            return new Product(
                reader.GetInt64("ProductId"),
                reader.GetString("Sku"),
                reader.GetString("ProductName"),
                reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString("Description"),
                reader.GetInt32("CategoryId"),
                reader.GetInt16("UnitId"),
                reader.IsDBNull(reader.GetOrdinal("SupplierId")) ? null : reader.GetInt32("SupplierId"),
                reader.GetDecimal("CostPrice"),
                reader.GetDecimal("SellingPrice"),
                reader.GetDecimal("ReorderLevel"),
                reader.GetBoolean("IsActive"),
                reader.GetDateTime("CreatedAt"),
                reader.GetDateTime("UpdatedAt")
            );
        }
    }
}