using BeautySalon.Web.Models;

namespace BeautySalon.Web.Services;

public interface ISalonService
{
    Task<Settings> GetSettingsAsync();
    Task<List<Schedule>> GetSchedulesAsync();
    Task<List<Master>> GetMastersAsync();
    Task<List<Service>> GetServicesAsync();
}
