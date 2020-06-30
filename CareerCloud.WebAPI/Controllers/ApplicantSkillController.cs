﻿using System;
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
    public class ApplicantSkillController : ControllerBase
    {
        private readonly ApplicantSkillLogic _logic;
        public ApplicantSkillController()
        {
            var repo = new EFGenericRepository<ApplicantSkillPoco>();
            _logic = new ApplicantSkillLogic(repo);
        }


        [HttpGet]
        [Route("skill/{id}")]
        public ActionResult GetApplicantSkill(Guid id)
        {
            ApplicantSkillPoco poco = _logic.Get(id);
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
        [Route("skill")]
        public ActionResult GetAllApplicantSkill()
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
        [Route("skill")]
        public ActionResult PostApplicantSkill(
            [FromBody]ApplicantSkillPoco[] appEdupocos)
        {
            _logic.Add(appEdupocos);
            return Ok();

        }

        [HttpPut]
        [Route("skill")]
        public ActionResult PutApplicantSkill(
            [FromBody]ApplicantSkillPoco[] appEdupocos)
        {
            _logic.Update(appEdupocos);
            return Ok();

        }

        [HttpDelete]
        [Route("skill")]
        public ActionResult DeleteApplicantSkill(
            [FromBody]ApplicantSkillPoco[] appEdupocos)
        {
            _logic.Delete(appEdupocos);
            return Ok();

        }
    }
}