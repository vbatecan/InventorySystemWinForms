using InventorySystem.Exceptions;
using InventorySystem.Models.Enums;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;

namespace InventorySystem.Services {
    public class TransactionService {

        public void StockIn(long productId, decimal quantity, string? storageLocation = null, string? referenceNo = null, string? remarks = null, int? createdBy = null)
        {
            RecordMovement(MovementType.In, productId, quantity, storageLocation, referenceNo, remarks, createdBy);
        }

        public void StockOut(long productId, decimal quantity, string? storageLocation = null, string? referenceNo = null, string? remarks = null, int? createdBy = null)
        {
            RecordMovement(MovementType.Out, productId, quantity, storageLocation, referenceNo, remarks, createdBy);
        }

        public void AdjustIn(long productId, decimal quantity, string? storageLocation = null, string? referenceNo = null, string? remarks = null, int? createdBy = null)
        {
            RecordMovement(MovementType.AdjustIn, productId, quantity, storageLocation, referenceNo, remarks, createdBy);
        }

        public void AdjustOut(long productId, decimal quantity, string? storageLocation = null, string? referenceNo = null, string? remarks = null, int? createdBy = null)
        {
            RecordMovement(MovementType.AdjustOut, productId, quantity, storageLocation, referenceNo, remarks, createdBy);
        }

        public decimal GetStockLevel(long productId)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand(@"
                    SELECT
                        COALESCE(SUM(CASE WHEN MovementType IN ('In', 'AdjustIn') THEN Quantity ELSE 0 END), 0)
                        - COALESCE(SUM(CASE WHEN MovementType IN ('Out', 'AdjustOut') THEN Quantity ELSE 0 END), 0)
                    FROM StockMovements
                    WHERE ProductId = @productId", conn);
                cmd.Parameters.AddWithValue("@productId", productId);

                return (decimal) cmd.ExecuteScalar();
            }
        }

        private void RecordMovement(MovementType movementType, long productId, decimal quantity, string? storageLocation, string? referenceNo, string? remarks, int? createdBy)
        {
            if (quantity <= 0) {
                throw new OperationFailedException("Quantity must be greater than zero");
            }

            using (MySqlConnection conn = Connection.GetConnection()) {
                using (MySqlTransaction transaction = conn.BeginTransaction()) {
                    try {
                        long movementId = InsertMovement(conn, transaction, movementType, productId, quantity, storageLocation, referenceNo, remarks, createdBy);
                        InsertAuditLog(conn, transaction, movementType, movementId, productId, quantity, createdBy);
                        transaction.Commit();
                    } catch {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        private long InsertMovement(MySqlConnection conn, MySqlTransaction transaction, MovementType movementType, long productId, decimal quantity, string? storageLocation, string? referenceNo, string? remarks, int? createdBy)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO StockMovements (ProductId, MovementType, Quantity, StorageLocation, ReferenceNo, Remarks, CreatedBy) VALUES (@productId, @movementType, @quantity, @storageLocation, @referenceNo, @remarks, @createdBy)", conn, transaction);
            cmd.Parameters.AddWithValue("@productId", productId);
            cmd.Parameters.AddWithValue("@movementType", movementType.ToString());
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@storageLocation", storageLocation ?? (object) DBNull.Value);
            cmd.Parameters.AddWithValue("@referenceNo", referenceNo ?? (object) DBNull.Value);
            cmd.Parameters.AddWithValue("@remarks", remarks ?? (object) DBNull.Value);
            cmd.Parameters.AddWithValue("@createdBy", createdBy ?? (object) DBNull.Value);

            int result = cmd.ExecuteNonQuery();
            if (result <= 0) {
                throw new OperationFailedException("Failed to create stock movement");
            }

            return cmd.LastInsertedId;
        }

        private void InsertAuditLog(MySqlConnection conn, MySqlTransaction transaction, MovementType movementType, long movementId, long productId, decimal quantity, int? createdBy)
        {
            string newData = $"{{\"MovementId\":{movementId},\"ProductId\":{productId},\"MovementType\":\"{movementType}\",\"Quantity\":{quantity}}}";

            MySqlCommand cmd = new MySqlCommand("INSERT INTO AuditLogs (ActorUserId, ActionType, EntityName, EntityId, NewData) VALUES (@actorUserId, @actionType, @entityName, @entityId, @newData)", conn, transaction);
            cmd.Parameters.AddWithValue("@actorUserId", createdBy ?? (object) DBNull.Value);
            cmd.Parameters.AddWithValue("@actionType", movementType.ToString());
            cmd.Parameters.AddWithValue("@entityName", "StockMovement");
            cmd.Parameters.AddWithValue("@entityId", movementId);
            cmd.Parameters.AddWithValue("@newData", newData);

            int result = cmd.ExecuteNonQuery();
            if (result <= 0) {
                throw new OperationFailedException("Failed to create audit log");
            }
        }
    }
}
