#nullable disable

using InventorySystem.Exceptions;
using InventorySystem.Models;
using InventorySystem.Shared;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.Services
{
    public class UnitsService
    {
        public List<Units> All()
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Units", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                List<Units> units = new List<Units>();
                while (reader.Read())
                {
                    units.Add(Units.FromReader(reader));
                }

                return units;
            }
        }

        public Units Get(short unitId)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Units WHERE UnitId = @unitId", conn);
                cmd.Parameters.AddWithValue("@unitId", unitId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return Units.FromReader(reader);
                }

                throw new EntityNotFoundException("Unit with id " + unitId + " is not found");
            }
        }

        public void Save(Units unit)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Units (UnitName, UnitSymbol, AllowsFraction) VALUES (@unitName, @unitSymbol, @allowsFraction)", conn);
                cmd.Parameters.AddWithValue("@unitName", unit.UnitName);
                cmd.Parameters.AddWithValue("@unitSymbol", unit.UnitSymbol);
                cmd.Parameters.AddWithValue("@allowsFraction", unit.AllowsFraction);

                int result = cmd.ExecuteNonQuery();
                if (result <= 0)
                {
                    throw new OperationFailedException("Failed to create unit");
                }
            }
        }

        public void Update(Units unit)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE Units SET UnitName = @unitName, UnitSymbol = @unitSymbol, AllowsFraction = @allowsFraction WHERE UnitId = @unitId", conn);
                cmd.Parameters.AddWithValue("@unitName", unit.UnitName);
                cmd.Parameters.AddWithValue("@unitSymbol", unit.UnitSymbol);
                cmd.Parameters.AddWithValue("@allowsFraction", unit.AllowsFraction);
                cmd.Parameters.AddWithValue("@unitId", unit.UnitId);

                int result = cmd.ExecuteNonQuery();
                if (result <= 0)
                {
                    throw new EntityNotFoundException("Unit with id " + unit.UnitId + " is not found");
                }
            }
        }

        public void Delete(short unitId)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Units WHERE UnitId = @unitId", conn);
                cmd.Parameters.AddWithValue("@unitId", unitId);

                int result = cmd.ExecuteNonQuery();
                if (result <= 0)
                {
                    throw new EntityNotFoundException("Unit with id " + unitId + " is not found");
                }
            }
        }

        public DataTable SearchUnits(string searchTerm)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                string query = "SELECT u.UnitId, u.UnitName, u.UnitSymbol, u.AllowsFraction, (SELECT COUNT(*) FROM Products p WHERE p.UnitId = u.UnitId) AS ProductCount FROM Units u WHERE 1=1";
                MySqlCommand cmd = new MySqlCommand();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query + " AND (u.UnitName LIKE @search OR u.UnitSymbol LIKE @search)";
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                }

                query = query + " ORDER BY u.UnitId DESC";
                cmd.CommandText = query;
                cmd.Connection = conn;

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public bool UnitNameExists(string unitName, short excludeUnitId = 0)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Units WHERE UnitName = @name";
                if (excludeUnitId > 0)
                {
                    query = query + " AND UnitId != @excludeId";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", unitName);
                if (excludeUnitId > 0)
                {
                    cmd.Parameters.AddWithValue("@excludeId", excludeUnitId);
                }

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public bool UnitSymbolExists(string unitSymbol, short excludeUnitId = 0)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Units WHERE UnitSymbol = @symbol";
                if (excludeUnitId > 0)
                {
                    query = query + " AND UnitId != @excludeId";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@symbol", unitSymbol);
                if (excludeUnitId > 0)
                {
                    cmd.Parameters.AddWithValue("@excludeId", excludeUnitId);
                }

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public bool HasAssociatedProducts(short unitId)
        {
            using (MySqlConnection conn = Connection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Products WHERE UnitId = @id", conn);
                cmd.Parameters.AddWithValue("@id", unitId);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
