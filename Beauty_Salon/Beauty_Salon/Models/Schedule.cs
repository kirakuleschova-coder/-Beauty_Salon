namespace BeautySalon.Web.Models;

public class Schedule
{
    public int Id { get; set; }
    public string DayOfWeek { get; set; } = string.Empty; // Понедельник...Воскресенье
    public string WorkingHours { get; set; } = string.Empty; // "09:00 – 20:00"
    public bool IsDayOff { get; set; }
}