using MySql.Data.MySqlClient;

namespace InventorySystem.Models {
    public class Units {
        public int UnitId;
        public string UnitName = string.Empty;
        public string UnitSymbol = string.Empty;
        public bool AllowsFraction;

        public Units()
        {

        }

        public Units(int unitId, string unitName, string unitSymbol, bool allowsFraction)
        {
            UnitId = unitId;
            UnitName = unitName;
            UnitSymbol = unitSymbol;
            AllowsFraction = allowsFraction;
        }

        public static Units FromReader(MySqlDataReader reader)
        {
            return new Units(
                reader.GetInt16("UnitId"),
                reader.GetString("UnitName"),
                reader.GetString("UnitSymbol"),
                reader.GetBoolean("AllowsFraction")
            );
        }
    }
}