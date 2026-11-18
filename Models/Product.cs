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
    }
}