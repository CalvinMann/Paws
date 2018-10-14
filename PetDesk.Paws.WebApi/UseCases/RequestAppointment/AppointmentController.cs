using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using PetDesk.Paws.Infrastructure.WebSockets.SignalR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetDesk.Paws.WebApi.UseCases.RequestAppointment
{
    [Route("api/[controller]")]
    public class AppointmentController : Controller
    {

        public AppointmentController()
        {
           
        }

        // POST api/appointment
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]  RequestedAppointment reqApt)
        {

            if (ModelState.IsValid)
            {
                return Ok();
            }

            return BadRequest(ModelState);
        }
    }
}
