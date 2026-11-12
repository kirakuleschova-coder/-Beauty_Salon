using BeautySalon.Web.Models;
using SalonBagira.Models;
using System.Collections.Generic;

namespace SalonBagira.Repositories
{
    public interface IScheduleRepository
    {
        List<Schedule> GetSchedule();
    }
}