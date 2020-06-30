using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareerCloud.WebAPI.Controllers
{
    [Route("api/careercloud/applicant/v1")]
    [ApiController]
    public class ApplicantJobApplicationController : ControllerBase
    {
        private readonly ApplicantJobApplicationLogic _logic;
        public ApplicantJobApplicationController()
        {
            var repo = new EFGenericRepository<ApplicantJobApplicationPoco>();
            _logic = new ApplicantJobApplicationLogic(repo);
        }


        [HttpGet]
        [Route("jobApplication/{id}")]
        public ActionResult GetApplicantJobApplication(Guid id)
        {
            ApplicantJobApplicationPoco poco = _logic.Get(id);
            if (poco == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(poco);
            }
        }


        [HttpGet]
        [Route("jobApplication")]
        public ActionResult GetAllApplicantJobApplication()
        {
            var applications = _logic.GetAll();

            if (applications == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(applications);
            }

        }

        [HttpPost]
        [Route("jobApplication")]
        public ActionResult PostApplicantJobApplication(
            [FromBody]ApplicantJobApplicationPoco[] appJobApp)
        {
            _logic.Add(appJobApp);
            return Ok();

        }

        [HttpPut]
        [Route("jobApplication")]
        public ActionResult PutApplicantJobApplication(
            [FromBody]ApplicantJobApplicationPoco[] appJobApp)
        {
            _logic.Update(appJobApp);
            return Ok();
        }

        [HttpDelete]
        [Route("jobApplication")]
        public ActionResult DeleteApplicantJobApplication(
            [FromBody]ApplicantJobApplicationPoco[] appJobApp)
        {
            _logic.Delete(appJobApp);
            return Ok();
        }

    }
}