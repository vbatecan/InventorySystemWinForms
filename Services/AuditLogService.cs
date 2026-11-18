using InventorySystem.Exceptions;
using InventorySystem.Models;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;

namespace InventorySystem.Services {
    public class AuditLogService {

        public List<AuditLog> All(int page = 1, int size = 25)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM AuditLogs LIMIT @page, @size", conn);
                cmd.Parameters.AddWithValue("@page", page);
                cmd.Parameters.AddWithValue("@size", size);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<AuditLog> auditLogs = new List<AuditLog>();
                while (reader.Read()) {
                    auditLogs.Add(AuditLog.FromReader(reader));
                }

                return auditLogs;
            }
        }

        public AuditLog Get(long auditId)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM AuditLogs WHERE AuditId = @auditId", conn);
                cmd.Parameters.AddWithValue("@auditId", auditId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    return AuditLog.FromReader(reader);
                }

                throw new EntityNotFoundException($"Audit log with id {auditId} is not found");
            }
        }
    }
}
