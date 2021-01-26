using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class MediationController : ApiController
    {

        //[HttpGet]
        //[Route("GetVolunteetByService/{motherId:long}")]
        // public List<SelectVolunteerByServiceNew_Result> GetVolunteetByService(long MotherId)
        // {
        //     return Bll.MediationBll.selectvolunteerByService(MotherId);
        // }
        // [HttpGet]
        //// [Route("GetVolunteetByDay/{MotherId}")]
        // public List<SelectVolunteerByDay_Result> GetVolunteetByDay(long MotherId)
        // {
        //     return Bll.MediationBll.selectVolunteerByDay(MotherId);
        //// }
        //[HttpGet]
        //[Route("mediationFindVolunteer/{motherId:long}")]
        //public void mediationFindVolunteer(long MotherId)
        //{
        //    Bll.MediationBll.mediationCheck(MotherId);
        //}
        //[HttpPost]
        //[Route("VolunteerApproval/{ServiceManagmentId:long,VolunteerId:long}")]
        //public void VolunteerApproval(long ServiceManagmentId, long VolunteerId)
        //{
        //    Bll.MediationBll.VolunteerApproval(ServiceManagmentId, VolunteerId);
        //}
        //public int GetStatusRequest(long ServiceManagmentId)
        //{
        //    return Bll.MediationBll.GetStatusRequest(ServiceManagmentId);
        //}

        //public int PostServiceAndDayVolunteer(List<ServiceAndDaysToVolunteer> d)
        //{//הוספת שירותים למתנדבים
        //  return  Bll.MediationBll.PostServiceAndDayVolunteer( d);

        //}
        //public void postVolunteerByService(List<Dto.ServiceAndDayToVolunteerDto> a)
        //{
        //    Bll.MediationBll.PostServiceAndDayVolunteer(a);

        //}
        //public void postVolunteerByServiceAndDay(List<Dto.ServiceAndDayToVolunteerDto> a)
        //{
        //    Bll.MediationBll.PostServiceAndDayVolunteer(a);

        //}


        public IHttpActionResult GetByService(long ServiceId)
        {
            try
            {
                var q = Bll.ServiceManagmentToBirthBll.GetByService(ServiceId);
                if (q != null)
                    return Ok(q);
                return NotFound();
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        public IHttpActionResult GetByDay(long DayId)
        {
            try
            {
                var q = Bll.MediationBll.GetRequestByDay(DayId);
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