using InventorySystem.Exceptions;
using InventorySystem.Models;
using InventorySystem.Models.Enums;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;

namespace InventorySystem.Services {
    public class StockMovementService {

        public int CountByCreatedAtRange(DateTime start, DateTime end)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new("SELECT * FROM StockMovements WHERE CreatedAt >= @startDate AND CreatedAt < @endDate", conn);
                cmd.Parameters.AddWithValue("@startDate", start);
                cmd.Parameters.AddWithValue("@endDate", end);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public List<StockMovement> All(int page = 0, int size = 25)
        {
            List<StockMovement> movements = new();
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new("SELECT * FROM StockMovements LIMIT @page, @size", conn);
                cmd.Parameters.AddWithValue("@page", page);
                cmd.Parameters.AddWithValue("@size", size);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    movements.Add(StockMovement.FromReader(reader));
                }
            }

            return movements;
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
        
        public List<StockMovement> Find(string searchTerm, int page = 0, int size = 25)
        {
            List<StockMovement> movements = new();
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new("SELECT * FROM StockMovements WHERE ReferenceNo LIKE @searchTerm OR Remarks LIKE @searchTerm LIMIT @page, @size", conn);
                cmd.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");
                cmd.Parameters.AddWithValue("@page", page);
                cmd.Parameters.AddWithValue("@size", size);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    movements.Add(StockMovement.FromReader(reader));
                }
            }

            return movements;
        }

        public List<StockMovement> Find(string searchTerm, MovementType movementType, int page = 0, int size = 25)
        {
            List<StockMovement> movements = new();
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new(
                    "SELECT * FROM StockMovements WHERE (ReferenceNo LIKE @searchTerm OR Remarks LIKE @searchTerm) AND MovementType = @movementType LIMIT @page, @size",
                    conn
                );
                cmd.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");
                cmd.Parameters.AddWithValue("@movementType", movementType.ToString());
                cmd.Parameters.AddWithValue("@page", page);
                cmd.Parameters.AddWithValue("@size", size);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    movements.Add(StockMovement.FromReader(reader));
                }
            }

            return movements;
        }
    }
}
