using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
   public class DaysBll
    {
        public static string GetDayById(int dayId)
        {
            return Dal.DaysDal.GetDay(dayId);
           
        }
    }
}
