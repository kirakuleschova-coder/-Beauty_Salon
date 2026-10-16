using BeautySalon.Web.Models;

namespace BeautySalon.Web.ViewModels;

public class HomeIndexViewModel
{
    public Settings Settings { get; set; } = new();
    public List<Schedule> Schedules { get; set; } = new();
    public List<Master> Masters { get; set; } = new();
    public List<Service> Services { get; set; } = new();
    public string? ErrorMessage { get; set; }
}