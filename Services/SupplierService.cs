using InventorySystem.Exceptions;
using InventorySystem.Models;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;

namespace InventorySystem.Services {
    public class SupplierService {

        public List<Supplier> All()
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Suppliers", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Supplier> suppliers = new List<Supplier>();
                while (reader.Read()) {
                    suppliers.Add(Supplier.FromReader(reader));
                }

                return suppliers;
            }
        }

        public Supplier Get(int supplierId)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Suppliers WHERE SupplierId = @supplierId", conn);
                cmd.Parameters.AddWithValue("@supplierId", supplierId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    return Supplier.FromReader(reader);
                }

                throw new EntityNotFoundException($"Supplier with id {supplierId} is not found");
            }
        }

        public void Save(Supplier supplier)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Suppliers (SupplierName, ContactPerson, Phone, Email, Address, IsActive) VALUES (@supplierName, @contactPerson, @phone, @email, @address, @isActive)", conn);
                cmd.Parameters.AddWithValue("@supplierName", supplier.SupplierName);
                cmd.Parameters.AddWithValue("@contactPerson", supplier.ContactPerson ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@phone", supplier.Phone ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@email", supplier.Email ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@address", supplier.Address ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@isActive", supplier.IsActive);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new OperationFailedException("Failed to create supplier");
                }
            }
        }

        public void Update(Supplier supplier)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("UPDATE Suppliers SET SupplierName = @supplierName, ContactPerson = @contactPerson, Phone = @phone, Email = @email, Address = @address, IsActive = @isActive WHERE SupplierId = @supplierId", conn);
                cmd.Parameters.AddWithValue("@supplierName", supplier.SupplierName);
                cmd.Parameters.AddWithValue("@contactPerson", supplier.ContactPerson ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@phone", supplier.Phone ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@email", supplier.Email ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@address", supplier.Address ?? (object) DBNull.Value);
                cmd.Parameters.AddWithValue("@isActive", supplier.IsActive);
                cmd.Parameters.AddWithValue("@supplierId", supplier.SupplierId);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new EntityNotFoundException($"Supplier with id {supplier.SupplierId} is not found");
                }
            }
        }

        public void Delete(int supplierId)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Suppliers WHERE SupplierId = @supplierId", conn);
                cmd.Parameters.AddWithValue("@supplierId", supplierId);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new EntityNotFoundException($"Supplier with id {supplierId} is not found");
                }
            }
        }
    }
}
