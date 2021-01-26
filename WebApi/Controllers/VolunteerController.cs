using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Bll;
using Dto;

namespace WebApi.Controllers
{
    public class VolunteerController: ApiController
    {
        [HttpPost]
        public long Post(user volunteerDto)
        {
            return VolunteerBll.AddVolunteer(volunteerDto);
        }
    }
}