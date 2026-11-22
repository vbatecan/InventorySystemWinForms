using InventorySystem.Exceptions;
using InventorySystem.Models;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;

namespace InventorySystem.Services {
    public class ProductService {

        public List<Product> All()
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Products", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Product> products = new List<Product>();
                while (reader.Read()) {
                    products.Add(Product.FromReader(reader));
                }

                return products;
            }
        }

        public Product Get(long productId)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Products WHERE ProductId = @productId", conn);
                cmd.Parameters.AddWithValue("@productId", productId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    return Product.FromReader(reader);
                }

                throw new EntityNotFoundException($"Product with id {productId} is not found");
            }
        }

        public Product GetByName(string productName)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new("SELECT * FROM Products WHERE ProductName = @productName", conn);
                cmd.Parameters.AddWithValue("@productName", productName);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    return Product.FromReader(reader);
                }
                
                throw new EntityNotFoundException($"Product with name {productName} is not found");
            }
        }

        public List<Product> GetAllByProductId(List<int> productIds)
        {
            List<Product> products = new();
            
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new("SELECT * FROM Products WHERE ProductId IN @productIds", conn);
                cmd.Parameters.AddWithValue("@productIds", productIds);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    products.Add(Product.FromReader(reader));
                }
            }

            return products;
        }

        public void Save(Product product)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Products (Sku, ProductName, Description, CategoryId, UnitId, SupplierId, CostPrice, SellingPrice, ReorderLevel, IsActive) VALUES (@sku, @productName, @description, @categoryId, @unitId, @supplierId, @costPrice, @sellingPrice, @reorderLevel, @isActive)", conn);
                cmd.Parameters.AddWithValue("@sku", product.Sku);
                cmd.Parameters.AddWithValue("@productName", product.ProductName);
                cmd.Parameters.AddWithValue("@description", product.Description ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@categoryId", product.CategoryId);
                cmd.Parameters.AddWithValue("@unitId", product.UnitId);
                cmd.Parameters.AddWithValue("@supplierId", product.SupplierId ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@costPrice", product.CostPrice);
                cmd.Parameters.AddWithValue("@sellingPrice", product.SellingPrice);
                cmd.Parameters.AddWithValue("@reorderLevel", product.ReorderLevel);
                cmd.Parameters.AddWithValue("@isActive", product.IsActive);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new OperationFailedException("Failed to create product");
                }
            }
        }

        public void Update(Product product)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("UPDATE Products SET Sku = @sku, ProductName = @productName, Description = @description, CategoryId = @categoryId, UnitId = @unitId, SupplierId = @supplierId, CostPrice = @costPrice, SellingPrice = @sellingPrice, ReorderLevel = @reorderLevel, IsActive = @isActive WHERE ProductId = @productId", conn);
                cmd.Parameters.AddWithValue("@sku", product.Sku);
                cmd.Parameters.AddWithValue("@productName", product.ProductName);
                cmd.Parameters.AddWithValue("@description", product.Description ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@categoryId", product.CategoryId);
                cmd.Parameters.AddWithValue("@unitId", product.UnitId);
                cmd.Parameters.AddWithValue("@supplierId", product.SupplierId ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@costPrice", product.CostPrice);
                cmd.Parameters.AddWithValue("@sellingPrice", product.SellingPrice);
                cmd.Parameters.AddWithValue("@reorderLevel", product.ReorderLevel);
                cmd.Parameters.AddWithValue("@isActive", product.IsActive);
                cmd.Parameters.AddWithValue("@productId", product.ProductId);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new EntityNotFoundException($"Product with id {product.ProductId} is not found");
                }
            }
        }

        public void Delete(long productId)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Products WHERE ProductId = @productId", conn);
                cmd.Parameters.AddWithValue("@productId", productId);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new EntityNotFoundException($"Product with id {productId} is not found");
                }
            }
        }

        public int Count()
        {
            MySqlConnection conn = Connection.GetConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Products", conn);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
