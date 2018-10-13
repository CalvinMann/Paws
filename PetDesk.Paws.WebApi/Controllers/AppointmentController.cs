using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetDesk.Paws.Application.Results;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetDesk.Paws.WebApi.Controllers
{
    [Route("api/appointment")]
    public class AppointmentController : Controller
    {
        private readonly IHubContext<object> _hub;

        public AppointmentController(IHubContext<object> hub )
        {
            _hub = hub;
        }

        // POST api/appointment
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]  AppointmentDTO aptDto)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }

            return BadRequest(ModelState);
        }
    }
}
