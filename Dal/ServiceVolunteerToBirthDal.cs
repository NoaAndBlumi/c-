using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
   public class ServiceVolunteerToBirthDal
    {
        public static void AddServiceVolunteerToBirth(ServiceVolunteerToBirth s)
        {
            try
            {
                using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
                {

                    var q1 = db.ServiceVolunteerToBirth.Add(s);
                    db.SaveChanges();
                   // return q1.MotherId;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
