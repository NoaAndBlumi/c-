using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class ServiceManagmentToBirthBll
    {
        public static List<Dal.AllRequest_Result> GetAllReques()
        {

            List<Dal.AllRequest_Result> allRequest = Dal.ServiceManagmentToBirthDal.GetAllReques();
            return allRequest;
            

        }
        public static List<Dal.GetRequestByService_Result> GetByService(long ServiceId)
        {
            return Dal.ServiceManagmentToBirthDal.GetByService(ServiceId);
        }

    }
}
