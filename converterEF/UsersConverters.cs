using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converterEF
{
    public class UsersConverters
    {
        public static Dal.Users ToDalUsers(Dto.user e)
        {
            Dal.Users en = new Dal.Users();
            en.UserId = e.UserId;
            en.RoleId = e.RoleId;
            en.FirstName = e.FirstName;
            en.LastName = e.LastName;
            en.Password = e.Password;
            en.Email = e.Email;
            en.Phone = e.Phone;
            en.Address = e.Address;
            en.NumOfHouse = e.NumOfHouse;
            en.Locality = e.Locality;
            en.BirthDate = e.BirthDate;
            en.Active = e.Active;
            return en;

        }
        public static Dto.user ToDtoUsers(Dal.Users e) {
            Dto.user en = new Dto.user();
            en.UserId = e.UserId;
            en.RoleId = e.RoleId;
            en.FirstName = e.FirstName;
            en.LastName = e.LastName;
            en.Password = e.Password;
            en.Email = e.Email;
            en.Phone = e.Phone;
            en.Address = e.Address;
            en.NumOfHouse = e.NumOfHouse;
            en.Locality = e.Locality;
            en.BirthDate = e.BirthDate;
            en.Active = e.Active;
            return en;
        }

        public static List<Dal.Users> ToDalUsersList(List<Dto.user> le)
        {
            List<Dal.Users> lpn = new List<Dal.Users>();
            foreach (var item in le)
            {
                lpn.Add(ToDalUsers(item));
            }
            return lpn;
        }

        public static List<Dto.user> ToDtoUsersList(List<Dal.Users> le)
        {
            List<Dto.user> lpn = new List<Dto.user>();
            foreach (var item in le)
            {
                lpn.Add(ToDtoUsers(item));
            }
            return lpn;
        }
    }
}
