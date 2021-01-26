using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
namespace WebApi.Controllers
{
    public class BirthControllers
    {

        public long Post(BirthDto b)
        {
        
            return Bll.BirthBll.AddBirth(b);
          
        }
    }
}
