using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
   public class BirthBll
    {
        public static long AddBirth(Dto.BirthDto b)
        {
            try
            {
                return Dal.BirthDal.AddBirth(converterEF.BirthConverters.ToDalBirth(b));

            }
            catch
            {
                throw;
            }
        }

        
    }
}
