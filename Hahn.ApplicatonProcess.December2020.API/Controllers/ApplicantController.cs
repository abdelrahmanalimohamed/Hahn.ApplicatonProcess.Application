using Hahn.ApplicatonProcess.December2020.Domain.InMemory_DB;
using Hahn.ApplicatonProcess.December2020.Domain.Model;
using Hahn.ApplicatonProcess.December2020.Domain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.December2020.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly IApplicantRepository _applicantRepository;
        public ApplicantController(IApplicantRepository applicantRepository)
        {
            _applicantRepository = applicantRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _applicantRepository.GetAllApplicant();

            return new OkObjectResult(data);
        }



        [HttpGet]
        [Route("GetApplicant")]
        public async Task<IActionResult> GetOne(int? id)
        {
            var applicant = await _applicantRepository.GetApplicant(id);

            return  Ok(applicant);
        }


        [HttpDelete]
        [Route("DeleteApplicant")]
        public async Task <IActionResult> DeleteApplicant(int id)
        {
            var applicant = await _applicantRepository.DeleteApplicant(id);

            if (applicant > 0)
            {
                return Ok("Deleted");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("CreateApplicant")]
        public async Task<IActionResult> CreateApplicant(ApplicantModel applicantModel)
        {
            var postapplicant = await _applicantRepository.CreateApplicant(applicantModel);

            if (postapplicant > 0)
            {
                return Ok(postapplicant);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("UpdateApplicant")]
        public async Task<IActionResult> UpdateApplicant(int id , ApplicantModel applicantModel)
        {
            var update_applicant = await _applicantRepository.UpdateApplicant(id, applicantModel);

            if (update_applicant > 0)
            {
                return Ok(update_applicant);
            }
            else
            {
                return BadRequest();
            }
        }
            






       

    }
}
