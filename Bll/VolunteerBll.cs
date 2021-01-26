using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class VolunteerBll
    {
        public static int AddVolunteer(Dto.user volunteerDto)
        {
            var user = converterEF.UsersConverters.ToDalUsers(volunteerDto);
            return Dal.VolunteerDal.AddVolunteer(user);
         
        }
    }
}
