using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ServiceManagmentToBirthDal
    {
        public static int UpdateRequest(long ServiceManagmentId)
        {
            try
            {
                using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
                {
                    var q2 = db.ServiceManagementToBirth.FirstOrDefault(w => w.ServiceManagementId == ServiceManagmentId);
                    if (q2 == null)
                        return 0;
                    else
                    {

                        q2.StatusRequest = 0;

                        return db.SaveChanges();

                    }
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<ServiceManagementToBirth> CheckActiveRequest(long BirthId)
        {
            using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
            {
                var selectByBirth =
                   from ServiceManagementToBirth in db.ServiceManagementToBirth

                   where ServiceManagementToBirth.BirthId == BirthId && ServiceManagementToBirth.StatusRequest == 1
                   select new { StatusRequest = ServiceManagementToBirth.StatusRequest };
                return (List<ServiceManagementToBirth>)selectByBirth;
            }


        }
        public static List<AllRequest_Result> GetAllReques()
        {
            using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
            {
                return db.AllRequest().ToList();
                              

            }
        }

        public static List<GetRequestByService_Result> GetByService(long ServiceId)
        {
            using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
            {
                return db.GetRequestByService(ServiceId).ToList();


            }
        }
    }
}
