using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Web.Models;

[Table("schedule")]
public class Schedule
{
    [Key][Column("id")] public int Id { get; set; }

    [Column("day_of_week")][Required, MaxLength(20)] public string DayOfWeek { get; set; } = "";

    [Column("open_time")] public TimeSpan OpenTime { get; set; }

    [Column("close_time")] public TimeSpan CloseTime { get; set; }

    [Column("is_day_off")] public bool IsDayOff { get; set; }
}