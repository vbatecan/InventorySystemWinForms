using InventorySystem.Exceptions;
using InventorySystem.Models;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;

namespace InventorySystem.Services {
    public class StockService {

        public List<StockMovement> All(int page = 0, int size = 25)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM StockMovements LIMIT @offset, @size", conn);
                cmd.Parameters.AddWithValue("@offset", page * size);
                cmd.Parameters.AddWithValue("@size", size);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<StockMovement> stockMovements = new List<StockMovement>();
                while (reader.Read()) {
                    stockMovements.Add(StockMovement.FromReader(reader));
                }

                return stockMovements;
            }
        }

        public StockMovement Get(long movementId)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM StockMovements WHERE MovementId = @movementId", conn);
                cmd.Parameters.AddWithValue("@movementId", movementId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    return StockMovement.FromReader(reader);
                }

                throw new EntityNotFoundException($"Stock movement with id {movementId} is not found");
            }
        }

        public void Create(StockMovement movement)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO StockMovements (ProductId, MovementType, Quantity, StorageLocation, ReferenceNo, Remarks, CreatedBy) VALUES (@productId, @movementType, @quantity, @storageLocation, @referenceNo, @remarks, @createdBy)", conn);
                cmd.Parameters.AddWithValue("@productId", movement.ProductId);
                cmd.Parameters.AddWithValue("@movementType", movement.MovementType.ToString());
                cmd.Parameters.AddWithValue("@quantity", movement.Quantity);
                cmd.Parameters.AddWithValue("@storageLocation", movement.StorageLocation ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@referenceNo", movement.ReferenceNo ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@remarks", movement.Remarks ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@createdBy", movement.CreatedBy ?? (object) DBNull.Value);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new OperationFailedException("Failed to create stock movement");
                }
            }
        }
    }
}