using System;

namespace BeautySalon.Web.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
        public bool IsDayOff { get; set; }
    }
}