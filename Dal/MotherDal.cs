using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class MotherDal
    {
        public static long AddMother(Mother mother, Birth birth, Kosher kosher1 = null, Kosher kosher2 = null, Kosher kosher3 = null)
        {
            try
            {
                using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
                {
                    var user = db.Users.Add(mother.Users);
                    //var newKosher1 = db.Kosher.Add(kosher1);
                    //var newKosher2 = db.Kosher.Add(kosher2);
                    //var newKosher3 = db.Kosher.Add(kosher3);

                    var newMother = db.Mother.Add(mother);

                    //db.SaveChanges();
                    var newBirth = db.Birth.Add(birth);
                    newMother.Birth.Add(newBirth);


                    //newMother.Users = user;
                    //newMother.UserId = user.UserId;
                    //newMother.Kosher1 = newKosher1.KosherId;
                    //newMother.Kosher2 = newKosher2.KosherId;
                    //newMother.Kosher3 = newKosher3.KosherId;
                    //newMother.Kosher = newKosher1;
                    //newMother.Kosher4 = newKosher2;
                    //newMother.Kosher5 = newKosher3;


                    db.SaveChanges();

                    return newMother.UserId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
        public static List<Birth> CheckTimeOfBirth()
        {
            using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
            {
                return db.Birth.ToList();
            }
        }
        public static void ChangeUserActiveAndStatusRequest(long MotherId)
        {
            List<ServiceManagementToBirth> b = new List<ServiceManagementToBirth>();
            using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
            {
                var a = db.Users.FirstOrDefault(w => w.UserId == MotherId);
                a.Active = 0;
                var c = db.Birth.FirstOrDefault(w => w.UserId == MotherId);
                var e = c.BirthId;

                b = db.ServiceManagementToBirth.Where(w => w.BirthId == e).ToList();
                foreach (var item in b)
                {
                    item.StatusRequest = 0;
                }

            }
        }
        public static int GetNumOfMothers()
        {
            using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
            {
               return db.Mother.Count();

            }
        }
    }
}
