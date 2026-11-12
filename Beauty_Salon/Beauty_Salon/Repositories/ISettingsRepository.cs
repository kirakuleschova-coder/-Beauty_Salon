using BeautySalon.Web.Models;
using SalonBagira.Models;

namespace SalonBagira.Repositories
{
    public interface ISettingsRepository
    {
        Settings GetSettings();
    }
}