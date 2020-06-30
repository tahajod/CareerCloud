﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.Pocos;
using CareerCloud.EntityFrameworkDataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareerCloud.WebAPI.Controllers
{
    [Route("api/careercloud/applicant/v1")]
    [ApiController]
    public class ApplicantEducationController : ControllerBase
    {
        private readonly ApplicantEducationLogic _logic;

        public ApplicantEducationController()
        {
            var repo = new EFGenericRepository<ApplicantEducationPoco>();
            _logic = new ApplicantEducationLogic(repo);
        }

        [HttpGet]
        [Route("education/{id}")]
        public ActionResult GetApplicantEducation(Guid id)
        {
            ApplicantEducationPoco poco = _logic.Get(id);
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
        [Route("education")]
        public ActionResult GetAllApplicantEducation()
        {
            var applicants = _logic.GetAll();
            if (applicants == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(applicants);
            }

        }

               
        [HttpPost]
        [Route("education")]
        public ActionResult PostApplicantEducation(
            [FromBody] ApplicantEducationPoco[] appEduPocos)
        {
            _logic.Add(appEduPocos);
            return Ok();
        }

        [HttpPut]
        [Route("education")]
        public ActionResult PutApplicantEducation(
            [FromBody] ApplicantEducationPoco[] appEduPocos)
        {
            _logic.Update(appEduPocos);
            return Ok();
        }

        [HttpDelete]
        [Route("education")]
        public ActionResult DeleteApplicantEducation(
            [FromBody] ApplicantEducationPoco[] appEduPocos)
        {
            _logic.Delete(appEduPocos);
            return Ok();
        }

    }

}