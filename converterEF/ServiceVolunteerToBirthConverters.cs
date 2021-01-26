using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converterEF
{
    public class ServiceVolunteerToBirthConverters
    {
        public static Dal.ServiceVolunteerToBirth ToDalServiceVolunteerToBirth(long birthId,long serviceId,long motherId,long volunteerId,TimeSpan beginningTime,TimeSpan endTime,DateTime dateItWas)
        {
            var service = new Dal.ServiceVolunteerToBirth
            {
                ServiceId = serviceId,
                BirthId = birthId,
                MotherId = motherId,
                VolunteerId = volunteerId,
                BeginningTime = beginningTime,
                EndTime = endTime,
                DateItWas = dateItWas

            };

            return service;


            //Dal.ServiceVolunteerToBirth b = new Dal.ServiceVolunteerToBirth();
            //b.BirthId = s.BirthId;
            //b.MotherId = s.MotherId;
            //b.ServiceId = s.ServiceId;
            //b.VolunteerId = s.VolunteerId;
            //b.BeginningTime = s.BeginningTime;
            //b.EndTTime = s.EndTTime;
            //b.DateItWas = s.DateItWas;
            //return 1;
        }
    }
}
