namespace BeautySalon.Web.Models;

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Duration { get; set; } // в минутах
    public string Description { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}