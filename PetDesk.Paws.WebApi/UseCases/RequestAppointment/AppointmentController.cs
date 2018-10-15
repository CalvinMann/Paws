using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using PetDesk.Paws.Application.Results;
using PetDesk.Paws.Application.UseCases.RequestAppointment;
using PetDesk.Paws.Infrastructure.WebSockets.SignalR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetDesk.Paws.WebApi.UseCases.RequestAppointment
{
    [Route("api/[controller]")]
    public class AppointmentController : Controller
    {
        private IRequestAppointment _requestAppointment;

        public AppointmentController(IRequestAppointment requestAppointment)
        {
            _requestAppointment = requestAppointment;
        }

        // POST api/appointment
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]  Appointment appointment)
        {

            if (ModelState.IsValid)
            {
                AppointmentResult appointmentResult = await _requestAppointment.CreateAppointment(
                          appointment.AppointmentType, appointment.RequestDate, 
                          appointment.ClientId, appointment.PatientId);

                return Ok();
            }

            return BadRequest(ModelState);
        }
    }
}
