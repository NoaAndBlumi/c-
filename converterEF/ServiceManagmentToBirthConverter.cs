using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converterEF
{
   public class ServiceManagmentToBirthConverter
    {

        public static long ToDalServiceManagementToBirth(Dto.ServiceManagmentToBirthDto s)
        {
            Dal.ServiceManagementToBirth b = new Dal.ServiceManagementToBirth();
            b.ServiceId = s.ServiceId;
            b.BirthId = s.BirthId;
            b.EndTime = s.EndTime;
            b.ServiceManagementId = s.ServiceManagementId;
            b.StatusRequest = s.StatusRequest;
            b.BeginningTime = s.BeginningTime;
            b.BirthDateOfService = s.BirthDateOfService;
            return 1;
        }
      
    }
}
