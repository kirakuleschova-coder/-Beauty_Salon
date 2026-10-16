namespace BeautySalon.Web.Models;

public class Settings
{
    public int Id { get; set; }
    public string SalonName { get; set; } = "Салон красоты Багира";
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string LogoPath { get; set; } = string.Empty;
    public string BackgroundImagePath { get; set; } = string.Empty;
}