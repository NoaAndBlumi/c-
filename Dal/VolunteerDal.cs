using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class VolunteerDal
    {
        public static int AddVolunteer(Users userToAdd)
        {
            try
            {
                using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
                {


                    var user = db.Users.Add(userToAdd);
                    var volunteerToAdd = new Volunteer
                    {
                        UserId = user.UserId
                    };
                    var volunteer = db.Volunteer.Add(volunteerToAdd);

                    //var Day = db.DaysToVolunteer.Add(v.DaysToVolunteer);
                    //var Service = db.ServiceToVolunteer.Add(v.ServiceToVolunteer);
                    db.SaveChanges();
                    return (int)user.UserId;
                }
            }
            catch
            {
                throw;
            }
        }
        //public static void AddServiceAndDayToVolunteer(long UserId, List<ServiceAndDaysToVolunteer> d)
        //{
        //    foreach (var item in d)
        //    {
        //        using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
        //        {
                    
        //            var user = db.Users.Add(userToAdd);
        //            var volunteerToAdd = new Volunteer
        //            {
        //                UserId = user.UserId
        //            };
        //            var volunteer = db.Volunteer.Add(volunteerToAdd);

        //            //var Day = db.DaysToVolunteer.Add(v.DaysToVolunteer);
        //            //var Service = db.ServiceToVolunteer.Add(v.ServiceToVolunteer);
        //            db.SaveChanges();
                   
        //        }
        //    }
        //    foreach (var item in s)
        //    {

        //    }
       // }
    }
}
