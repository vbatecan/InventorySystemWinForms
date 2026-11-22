using InventorySystem.Exceptions;
using InventorySystem.Models;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;

namespace InventorySystem.Services {
    public class UnitsService {

        public List<Units> All()
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Units", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Units> units = new List<Units>();
                while (reader.Read()) {
                    units.Add(Units.FromReader(reader));
                }

                return units;
            }
        }

        public Units Get(short unitId)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Units WHERE UnitId = @unitId", conn);
                cmd.Parameters.AddWithValue("@unitId", unitId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    return Units.FromReader(reader);
                }

                throw new EntityNotFoundException($"Unit with id {unitId} is not found");
            }
        }

        public void Save(Units unit)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Units (UnitName, UnitSymbol, AllowsFraction) VALUES (@unitName, @unitSymbol, @allowsFraction)", conn);
                cmd.Parameters.AddWithValue("@unitName", unit.UnitName);
                cmd.Parameters.AddWithValue("@unitSymbol", unit.UnitSymbol);
                cmd.Parameters.AddWithValue("@allowsFraction", unit.AllowsFraction);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new OperationFailedException("Failed to create unit");
                }
            }
        }

        public void Update(Units unit)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("UPDATE Units SET UnitName = @unitName, UnitSymbol = @unitSymbol, AllowsFraction = @allowsFraction WHERE UnitId = @unitId", conn);
                cmd.Parameters.AddWithValue("@unitName", unit.UnitName);
                cmd.Parameters.AddWithValue("@unitSymbol", unit.UnitSymbol);
                cmd.Parameters.AddWithValue("@allowsFraction", unit.AllowsFraction);
                cmd.Parameters.AddWithValue("@unitId", unit.UnitId);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new EntityNotFoundException($"Unit with id {unit.UnitId} is not found");
                }
            }
        }

        public void Delete(short unitId)
        {
            using (MySqlConnection conn = Connection.GetConnection()) {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Units WHERE UnitId = @unitId", conn);
                cmd.Parameters.AddWithValue("@unitId", unitId);
                int result = cmd.ExecuteNonQuery();

                if (result <= 0) {
                    throw new EntityNotFoundException($"Unit with id {unitId} is not found");
                }
            }
        }
    }
}
