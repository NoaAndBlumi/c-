using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class UserController : ApiController
    {
        public IHttpActionResult GetUsers() {
            try
            {
                var q = Bll.users.getAllUsers();
                if (q != null)
                    return Ok(q);
                return NotFound();
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        public IHttpActionResult PostUser(Dto.user u)
        {
            try
            {
                int x = Bll.users.adduser(u);
                    

                if (x == 0)
                    return NotFound();
                else
                    return Ok(x);
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }
        //public IHttpActionResult PostUser(Dto.user u)
        //{
        //    try
        //    {
        //        int x = Bll.users.UpdateUser(u);

        //        if (x == 0)
        //            return NotFound();
        //        else
        //            return Ok(x);
        //    }
        //    catch (Exception e)
        //    {

        //        return BadRequest(e.Message);
        //    }
        //}

        public IHttpActionResult DeleteUserById(int id)
        {
           
            try
            {
                int x = Bll.users.DeleteUserById(id);

                if (x == 0)
                    return NotFound();
                else
                    return Ok(x);
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

       
    }
}
