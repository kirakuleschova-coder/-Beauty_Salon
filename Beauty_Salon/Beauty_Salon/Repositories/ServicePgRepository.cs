using BeautySalon.Web.Models;
using Npgsql;
using SalonBagira.Models;
using System.Collections.Generic;

namespace SalonBagira.Repositories
{
    public class ServicePgRepository : IServiceRepository
    {
        private const string ConnStr =
            "Host=localhost;Port=5432;Database=salon_bagira;Username=postgres;Password=postgres";

        public List<Service> GetActiveServices()
        {
            var result = new List<Service>();

            using var conn = new NpgsqlConnection(ConnStr);
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "SELECT id, name, category, price, duration, description, is_active " +
                "FROM service WHERE is_active = TRUE ORDER BY category, name", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Service
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Category = reader.GetString(2),
                    Price = reader.GetDecimal(3),
                    Duration = reader.GetInt32(4),
                    Description = reader.IsDBNull(5) ? null : reader.GetString(5),
                    IsActive = reader.GetBoolean(6)
                });
            }

            return result;
        }
    }
}