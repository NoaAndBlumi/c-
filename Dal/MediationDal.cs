using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal
{
    public class MediationDal
    {
        //private static List<T> selectByService;
        //private static List<Days> selectByDay;

        public static List<SelectVolunteerByServiceNew_Result> selectvolunteerByService(long MotherId)
        {
            using (var db = new EZER_LAYOLEDETEntities())
            {
                return db.SelectVolunteerByServiceNew(MotherId).ToList();
            }

        }
        public static List<GetRequestByDay_Result> GetRequestByDay(long DayId)
        {
            using (var db = new EZER_LAYOLEDETEntities())
            {
                return db.GetRequestByDay(DayId).ToList();
            }

        }
        public static List<SelectVolunteerByServiceAndDayNew_Result> SelectVolunteerByServiceAndDay(long MotherId)
        {
            using (var db = new EZER_LAYOLEDETEntities())
            {

                return db.SelectVolunteerByServiceAndDayNew(MotherId).ToList();

            }
        }
        public static List<VolunteerApproval_Result> VolunteerApproval(long ServiceManagmentId, long VolunteerId)
        {
            using (var db = new EZER_LAYOLEDETEntities())
            {

                return db.VolunteerApproval(ServiceManagmentId, VolunteerId).ToList();

            }
        }
        public static List<selectMotherByServiceAndDay_Result> selectMotherByServiceAndDay(long VolunteerId)
        {
            using (var db = new EZER_LAYOLEDETEntities())
            {

                return db.selectMotherByServiceAndDay(VolunteerId).ToList();

            }
        }
        public static long UserId;
        public static long PostServiceAndDayVolunteer(List<ServiceAndDaysToVolunteer> d)
        {

            using (var db = new EZER_LAYOLEDETEntities())
            {
                foreach (var item in d)
                {
                    db.ServiceAndDaysToVolunteer.Add(item);
                    db.SaveChanges();
                    UserId = item.UserId;

                }
                return UserId;

            }
        }

        public static int GetStatusRequest(long ServiceManagmentId)
        {
            using (var db = new EZER_LAYOLEDETEntities())
            {
                var a = db.ServiceManagementToBirth.FirstOrDefault(w => w.ServiceManagementId == ServiceManagmentId);
                return a.StatusRequest;


            }
        }
        public static List<SelectVolunteerByServiceNew_Result> SelectByService(long VolunteerId)
        {
            using (var db = new EZER_LAYOLEDETEntities())
            {

                return db.SelectVolunteerByServiceNew(VolunteerId).ToList();

            }
        }

    }
}
