using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetDesk.Paws.Application.Results;


namespace PetDesk.Paws.WebApi.Controllers
{
    [Route("api/appointments")] //Always hard code the routes so refactoring doesnt mess up routing
    [ApiController]
    public class AppointmentsController : Controller
    {

        // POST api/appointments
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]  List<AppointmentDTO> aptDtoList)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }

            return BadRequest(ModelState);
        }


        // GET api/appointments
        [HttpGet]
              public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

    }
}
