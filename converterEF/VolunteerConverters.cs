using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converterEF
{
    public class VolunteerConverters
    {
        public static Dal.Volunteer ToDalVolunteer(Dto.volunteerDto v)
        {
             var u= UsersConverters.ToDalUsers(v.MyUser);
           
            Dal.Volunteer en = new Dal.Volunteer();
            en.UserId = v.UserId;

            //Dal.ServiceToVolunteer s = new Dal.ServiceToVolunteer();
            //s.UserId = v.UserId;
            //s.ServiseId = v.ServiseId;

            //Dal.DaysToVolunteer d = new Dal.DaysToVolunteer();
            //d.UserId = v.UserId;
            //d.DayId = v.DayId;
            //d.BeginningTime = v.BeginningTime;
            //d.EndTime = v.EndTime;
           
         
            return en;
      
        }
    }
}
