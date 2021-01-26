using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class users
    {
        public static List<Dto.user> getAllUsers()
        {
            return converterEF.UsersConverters.ToDtoUsersList(Dal.UserDal.selectUser());
        }
        public static int adduser(Dto.user u)
        {
            try
            {
                return Dal.UserDal.AddUser(converterEF.UsersConverters.ToDalUsers(u));

            }
            catch
            {
                throw;
            }
        }
        public static int UpdateUser(Dto.user u)
        {

            try
            {
                return Dal.UserDal.UpdateUsers(converterEF.UsersConverters.ToDalUsers(u));
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public static int DeleteUserById(int id)
        {
            try
            {
                return Dal.UserDal.DeleteUser(id);
            }
            catch (Exception e)
            {

                throw;
            }
        }
       
    }
}
