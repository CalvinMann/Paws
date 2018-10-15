using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetDesk.Paws.Application.Results;
using PetDesk.Paws.Application.UseCases.RegisterPatient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetDesk.Paws.WebApi.UseCases.RegisterPatient
{
    [Route("api/[controller]")]
    public class PatientsController : Controller
    {
        private readonly IRegisterPatient _registerPatient;

       public PatientsController(IRegisterPatient registerPatient)
        {
            _registerPatient = registerPatient;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] Patient patient)
        {
            if (ModelState.IsValid)
            {
                PatientResult patientResult = await _registerPatient.Register(patient.FirstName, patient.Species, patient.Breed, patient.ClientId);

                return Ok();
            }

            return BadRequest(ModelState);
        }

       
    }
}
