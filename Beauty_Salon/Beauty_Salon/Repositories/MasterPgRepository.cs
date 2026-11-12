using BeautySalon.Web.Models;
using Npgsql;
using SalonBagira.Models;
using System.Collections.Generic;

namespace SalonBagira.Repositories
{
    public class MasterPgRepository : IMasterRepository
    {
        private const string ConnStr =
            "Host=localhost;Port=5432;Database=salon_bagira;Username=postgres;Password=postgres";

        public List<Master> GetActiveMasters()
        {
            var result = new List<Master>();

            using var conn = new NpgsqlConnection(ConnStr);
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "SELECT id, full_name, specialization, phone, schedule, is_active " +
                "FROM master WHERE is_active = TRUE ORDER BY full_name", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Master
                {
                    Id = reader.GetInt32(0),
                    FullName = reader.GetString(1),
                    Specialization = reader.GetString(2),
                    Phone = reader.IsDBNull(3) ? null : reader.GetString(3),
                    Schedule = reader.IsDBNull(4) ? null : reader.GetString(4),
                    IsActive = reader.GetBoolean(5)
                });
            }

            return result;
        }
    }
}