using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Bll
{
    public class MotherBll
    {
        public static int AddMother(Dto.MotherDto motherDto)
        {
            var user = new Dal.Users
            {
                UserId = motherDto.UserId,
                FirstName = motherDto.firstName,
                LastName = motherDto.lastName,
                Email = motherDto.email,
                Password = motherDto.password,
                Active = motherDto.Active,
                BirthDate = motherDto.BirthDate,
                Locality = motherDto.Locality,
                Address = motherDto.Address,
                NumOfHouse = motherDto.NumOfHouse,
                Phone = motherDto.Phone,
                RoleId = motherDto.RoleId
            };

            //var userId = Dal.UserDal.AddUser(user);

            var mother = new Dal.Mother
            {
                UserId = user.UserId,
                Users = user,
                NumOfChildren = motherDto.NumOfChildren,
            };

            //var nuser = Dal.UserDal.AddUser(converterEF.UsersConverters.ToDalUsers(motherDto.));
            //var birth = Dal.BirthDal.AddBirth(converterEF.BirthConverters.ToDalBirth(motherDto.UserId));
            var nBirth = new Dal.Birth
            {
                BirthId = motherDto.BirthId,
                UserId = motherDto.UserId,
                BirthDateOfBaby = motherDto.BirthDateOfBaby,
                BoyOrGirl = motherDto.BoyOrGirl,
                NumOfBabies = motherDto.NumOfBabies,
            };

            var motherId = Dal.MotherDal.AddMother(mother, nBirth);
            return (int)motherId;
        }

        //public static Timer timer;
        //public ChairToEventBl()
        //{
        //    timer = new System.Timers.Timer();
        //    timer.Interval = 60000;
        //    timer.Elapsed += TimerONChairCatch;
        //    timer.Enabled = true;
        //}

        //public static void TimerONChairCatch(Object source, System.Timers.ElapsedEventArgs e)
        //{
        //    CheckTimeOfBirth();
        //}


        public static void ChangeUserActiveAndStatusRequest(long MotherId)
        {
            Dal.MotherDal.ChangeUserActiveAndStatusRequest(MotherId);
        }

        public static void CheckTimeOfBirth()
        {

            List<Dal.Birth> birth = new List<Dal.Birth>();
            birth = Dal.MotherDal.CheckTimeOfBirth();

            foreach (var item in birth)
            {
                if (item.NumOfBabies == 1)
                {
                    DateTime Date = item.BirthDateOfBaby.AddDays(30);
                    if (Date >= DateTime.Today)
                        Dal.MotherDal.ChangeUserActiveAndStatusRequest(item.UserId);
                }
                else if (item.NumOfBabies == 2)
                {
                    DateTime Date = item.BirthDateOfBaby.AddDays(60);
                    if (Date >= DateTime.Today)
                        Dal.MotherDal.ChangeUserActiveAndStatusRequest(item.UserId);
                }

                else
                {
                    DateTime Date = item.BirthDateOfBaby.AddDays(120);
                    if (Date >= DateTime.Today)
                        Dal.MotherDal.ChangeUserActiveAndStatusRequest(item.UserId);
                }

            }
        }
        public static int GetNumOfMothers()
        {
            return Dal.MotherDal.GetNumOfMothers();
        }

        //public static long AddMother(Dto.motherDto motherDto)
        //{
        //    try
        //    {
        //        var userId = Dal.UserDal.AddUser(motherDto.User);
        //        //var kosher
        //        Dal.BirthDal.AddBirth(motherDto.Birth);
        //        Dal.MotherDal.AddMother(motherDto.Mother);
        //        return userId;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
    }
}
