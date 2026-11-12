using BeautySalon.Web.Models;
using SalonBagira.Models;
using System.Collections.Generic;

namespace SalonBagira.Repositories
{
    public interface IServiceRepository
    {
        List<Service> GetActiveServices();
    }
}