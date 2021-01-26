using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class ServiceVolunteerToBirthDto
    {

        public long ServiceId { get; set; }
        public long VolunteerId { get; set; }
        public long MotherId { get; set; }
        public long BirthId { get; set; }
        public System.DateTime DateItWas { get; set; }
        public TimeSpan BeginningTime { get; set; }
        public TimeSpan EndTTime { get; set; }
       
      
    }
}
