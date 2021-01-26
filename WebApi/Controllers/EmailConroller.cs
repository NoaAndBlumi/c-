using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class EmailConroller : ApiController
    {
        //[HttpPut]
        //[Route("UpdatePassword/{UserId}")]
         public  long UpdatePassword(long UserId)
        {
            return Bll.EmailBll.UpdatePassword(UserId);
        }
    }
}