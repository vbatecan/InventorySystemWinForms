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
    }
}
