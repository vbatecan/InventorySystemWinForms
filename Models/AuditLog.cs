using MySql.Data.MySqlClient;

namespace InventorySystem.Models {
    public class AuditLog {
        public long AuditId;
        public int? ActorUserId;
        public string ActionType = string.Empty;
        public string EntityName = string.Empty;
        public long? EntityId;
        public string? OldData;
        public string? NewData;
        public DateTime LoggedAt;

        public AuditLog()
        {

        }

        public AuditLog(long auditId, int? actorUserId, string actionType, string entityName, long? entityId, string? oldData, string? newData, DateTime loggedAt)
        {
            AuditId = auditId;
            ActorUserId = actorUserId;
            ActionType = actionType;
            EntityName = entityName;
            EntityId = entityId;
            OldData = oldData;
            NewData = newData;
            LoggedAt = loggedAt;
        }

        public static AuditLog FromReader(MySqlDataReader reader)
        {
            return new AuditLog(
                reader.GetInt64("AuditId"),
                reader.IsDBNull(reader.GetOrdinal("ActorUserId")) ? null : reader.GetInt32("ActorUserId"),
                reader.GetString("ActionType"),
                reader.GetString("EntityName"),
                reader.IsDBNull(reader.GetOrdinal("EntityId")) ? null : reader.GetInt64("EntityId"),
                reader.IsDBNull(reader.GetOrdinal("OldData")) ? null : reader.GetString("OldData"),
                reader.IsDBNull(reader.GetOrdinal("NewData")) ? null : reader.GetString("NewData"),
                reader.GetDateTime("LoggedAt")
            );
        }
    }
}
