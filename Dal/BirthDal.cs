using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
   public class BirthDal
    {
        public static long AddBirth(Birth birth)
        {
            try
            {
                using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
                {
                    var newBirth = db.Birth.Add(birth);
                    db.SaveChanges();
                    return newBirth.UserId;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
