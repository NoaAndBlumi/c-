using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
  public  class DaysDal
    {
        public static string GetDay(int id)
        {
            using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
            {
                var d= db.Days.FirstOrDefault(w => w.DayId == id);
                return d.Describe;
            }
        }
    }
}
