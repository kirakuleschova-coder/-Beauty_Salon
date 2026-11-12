using BeautySalon.Web.Models;

namespace BeautySalon.Web.Repositories
{
    public class SchedulePgRepository
    {
    }
}
фusing BeautySalon.Web.Models;
using Npgsql;
using SalonBagira.Models;
using System;
using System.Collections.Generic;

namespace SalonBagira.Repositories
{
    public class SchedulePgRepository : IScheduleRepository
    {
        private const string ConnStr =
            "Host=localhost;Port=5432;Database=salon_bagira;Username=postgres;Password=postgres";

        public List<Schedule> GetSchedule()
        {
            var result = new List<Schedule>();

            using var conn = new NpgsqlConnection(ConnStr);
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "SELECT id, day_of_week, open_time, close_time, is_day_off " +
                "FROM schedule ORDER BY id", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Schedule
                {
                    Id = reader.GetInt32(0),
                    DayOfWeek = reader.GetString(1),
                    OpenTime = reader.GetTimeSpan(2),
                    CloseTime = reader.GetTimeSpan(3),
                    IsDayOff = reader.GetBoolean(4)
                });
            }

            return result;
        }
    }
}