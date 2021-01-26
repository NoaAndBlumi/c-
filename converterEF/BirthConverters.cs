using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converterEF
{
   public class BirthConverters
    {

        public static Dal.Birth ToDalBirth(Dto.BirthDto b)
        {
            Dal.Birth en = new Dal.Birth();
            en.BirthId = b.BirthId;
            en.UserId = b.UserId;
            en.BirthDateOfBaby = b.BirthDateOfBaby;
            en.BoyOrGirl = b.BoyOrGirl;
            en.NumOfBabies = b.NumOfBabies;

            return en;
        }
    }
}
