namespace BeautySalon.Web.Models;

public class Master
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Specialization { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Schedule { get; set; } = string.Empty;
    public string PhotoPath { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}