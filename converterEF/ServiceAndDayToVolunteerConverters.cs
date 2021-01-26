using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converterEF
{
    public class ServiceAndDayToVolunteerConverters
    {
        public static List<Dal.ServiceAndDaysToVolunteer> ToDalServiceAndDayToVolunteer(List<Dto.ServiceAndDayToVolunteerDto> s)
        {
            List<Dal.ServiceAndDaysToVolunteer> b = new List<Dal.ServiceAndDaysToVolunteer>();

         
            foreach (var item in s)
            {
                Dal.ServiceAndDaysToVolunteer w = new Dal.ServiceAndDaysToVolunteer();
                {
                    w.ServiceAndDaysToVolunteerId = item.ServiceAndDaysToVolunteerId;
                    w.ServiceId = item.ServiceId;
                    w.EndTime = item.EndTime;
                    w.UserId = item.UserId;
                    w.BeginningTime = item.BeginningTime;
                    w.DayId = item.DayId;
                    b.Add(w);

                }
            }

            return b;
        }
    }
}
