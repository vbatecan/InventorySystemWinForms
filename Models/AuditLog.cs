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
    }
}
