using InventorySystem.Models.Enums;
using MySql.Data.MySqlClient;

namespace InventorySystem.Models {
    public class StockMovement {
        public long MovementId;
        public long ProductId;
        public MovementType MovementType;
        public decimal Quantity;
        public string? StorageLocation;
        public string? ReferenceNo;
        public string? Remarks;
        public int? CreatedBy;
        public DateTime CreatedAt;

        public StockMovement()
        {

        }

        public StockMovement(long movementId, long productId, MovementType movementType, decimal quantity, string? storageLocation, string? referenceNo, string? remarks, int? createdBy, DateTime createdAt)
        {
            MovementId = movementId;
            ProductId = productId;
            MovementType = movementType;
            Quantity = quantity;
            StorageLocation = storageLocation;
            ReferenceNo = referenceNo;
            Remarks = remarks;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
        }

        public static StockMovement FromReader(MySqlDataReader reader)
        {
            return new StockMovement(
                reader.GetInt64("MovementId"),
                reader.GetInt64("ProductId"),
                (MovementType) Enum.Parse(typeof(MovementType), reader.GetString("MovementType")),
                reader.GetDecimal("Quantity"),
                reader.IsDBNull(reader.GetOrdinal("StorageLocation")) ? null : reader.GetString("StorageLocation"),
                reader.IsDBNull(reader.GetOrdinal("ReferenceNo")) ? null : reader.GetString("ReferenceNo"),
                reader.IsDBNull(reader.GetOrdinal("Remarks")) ? null : reader.GetString("Remarks"),
                reader.IsDBNull(reader.GetOrdinal("CreatedBy")) ? null : reader.GetInt32("CreatedBy"),
                reader.GetDateTime("CreatedAt")
            );
        }
    }
}
