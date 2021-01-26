using Bll;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class MotherController : ApiController
    {
        public long Post(MotherDto mother)
        {
            return MotherBll.AddMother(mother);
        }

        //public IHttpActionResult GetAllRequest()
        //{
        //    try
        //    {
        //        var q = ServiceManagmentToBirthBll.GetAllReques();
        //        if (q != null)
        //            return Ok(q);
        //        return NotFound();
        //    }

        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }
        //}
        public IHttpActionResult GetNumOfMothers()
        {
            try
            {
                var q = MotherBll.GetNumOfMothers();
                if (q != null)
                    return Ok(q);
                return NotFound();
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
