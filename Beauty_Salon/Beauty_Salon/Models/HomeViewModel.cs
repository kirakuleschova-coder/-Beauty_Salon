using BeautySalon.Web.Models;
using System.Collections.Generic;

namespace SalonBagira.Models
{
    public class HomeViewModel
    {
        public Settings Settings { get; set; }
        public List<Master> Masters { get; set; }
        public List<Service> Services { get; set; }
        public List<Schedule> Schedules { get; set; }
    }
}