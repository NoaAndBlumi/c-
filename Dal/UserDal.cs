using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class UserDal
    {
        public static List<Users> selectUser()
        {

            using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
            {
                return db.Users.ToList();
            }
        }

        public static Users selectUserById(long id)
        {

            using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
            {
                return db.Users.FirstOrDefault(w => w.UserId == id);
                
            }
        }

      

        public static int AddUser(Users u)
        {
            try
            {
                using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
                {

                    var q1 = db.Users.Add(u);
                    db.SaveChanges();
                    return (int)q1.UserId;
                }
            }
            catch
            {
                throw;
            }
        }

        public static int UpdatePassword(Users u,string pass)
        {
            using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
            {
                var q2 = db.Users.FirstOrDefault(w => w.UserId == u.UserId);
                if (q2 == null)
                    return 0;
                else
                {
                    q2.Password = pass;
                    return db.SaveChanges();
                }
            }
        }
        public static int UpdateUsers(Users u)
        {
            try
            {
                using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
                {
                    var q2 = db.Users.FirstOrDefault(w => w.UserId == u.UserId);
                    if (q2 == null)
                        return 0;
                    else
                    {
                        //  db.Users.Attach(u);
                        // db.Entry(u).State = EntityState.Modified;


                        q2.UserId = u.UserId;

                        q2.RoleId = u.RoleId;
                        q2.FirstName = u.FirstName;
                        q2.LastName = u.LastName;
                        q2.Password = u.Password;
                        q2.Email = u.Email;
                        q2.Phone = u.Phone;
                        q2.Address = u.Address;
                        q2.NumOfHouse = u.NumOfHouse;
                        q2.Locality = u.Locality;
                        q2.BirthDate = u.BirthDate;
                        q2.Active = u.Active;

                        return db.SaveChanges();

                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public static int DeleteUser(int id)
        {
            try
            {
                using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
                {
                    var q3 = db.Users.FirstOrDefault(w => w.UserId == id);
                    if (q3 == null)
                        return 0;
                    else
                    {
                        db.Users.Remove(q3);
                        db.SaveChanges();
                        return 1;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
      
        public static void UpdateUsersActive(long MotherId)
        {
            using (EZER_LAYOLEDETEntities db = new EZER_LAYOLEDETEntities())
            {
              var a=  db.Users.FirstOrDefault(w => w.UserId == MotherId);
                a.Active = 0;
                db.SaveChanges();

            }

            }
    }
}

