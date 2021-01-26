using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
  public  class ServiceAndDayToVolunteerDto
    {
        public long UserId { get; set; }
        public long DayId { get; set; }
        public TimeSpan BeginningTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public long ServiceId { get; set; }
        public long ServiceAndDaysToVolunteerId { get; set; }

    }
}
