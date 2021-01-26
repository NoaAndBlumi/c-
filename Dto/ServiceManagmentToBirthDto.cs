using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class ServiceManagmentToBirthDto
    {
        public long ServiceManagementId { get; set; }
        public long BirthId { get; set; }
        public System.DateTime BirthDateOfService { get; set; }
        public System.TimeSpan BeginningTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public long ServiceId { get; set; }

        public int StatusRequest { get; set; }

        
    }
}
