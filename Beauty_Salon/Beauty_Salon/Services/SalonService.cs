using BeautySalon.Web.Data;
using BeautySalon.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace BeautySalon.Web.Services;

public class SalonService : ISalonService
{
    private readonly AppDbContext _db;

    public SalonService(AppDbContext db) => _db = db;

    public async Task<Settings> GetSettingsAsync() =>
        await _db.Settings.FirstOrDefaultAsync() ?? new Settings();

    public async Task<List<Schedule>> GetSchedulesAsync() =>
        await _db.Schedules.OrderBy(s => s.Id).ToListAsync();

    public async Task<List<Master>> GetMastersAsync() =>
        await _db.Masters.Where(m => m.IsActive).ToListAsync();

    public async Task<List<Service>> GetServicesAsync() =>
        await _db.Services.Where(s => s.IsActive).ToListAsync();
}
