using MySql.Data.MySqlClient;

namespace InventorySystem.Models {
    public class Supplier {
        public int SupplierId;
        public string SupplierName = string.Empty;
        public string? ContactPerson;
        public string? Phone;
        public string? Email;
        public string? Address;
        public bool IsActive;

        public Supplier()
        {

        }

        public Supplier(int supplierId, string supplierName, string? contactPerson, string? phone, string? email, string? address, bool isActive)
        {
            SupplierId = supplierId;
            SupplierName = supplierName;
            ContactPerson = contactPerson;
            Phone = phone;
            Email = email;
            Address = address;
            IsActive = isActive;
        }

        public static Supplier FromReader(MySqlDataReader reader)
        {
            return new Supplier(
                reader.GetInt32("SupplierId"),
                reader.GetString("SupplierName"),
                reader.IsDBNull(reader.GetOrdinal("ContactPerson")) ? null : reader.GetString("ContactPerson"),
                reader.IsDBNull(reader.GetOrdinal("Phone")) ? null : reader.GetString("Phone"),
                reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString("Email"),
                reader.IsDBNull(reader.GetOrdinal("Address")) ? null : reader.GetString("Address"),
                reader.GetBoolean("IsActive")
            );
        }
    }
}
