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
    }
}
