using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetDesk.Paws.Application.Repositories;
using PetDesk.Paws.Application.Results;
using PetDesk.Paws.Application.UseCases.GetAppointments;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetDesk.Paws.WebApi.UseCases.GetAppointments
{
    [Route("api/[controller]")]
    public class AppointmentsController : Controller
    {
        private readonly IGetAppointments _getAppointments;

        public AppointmentsController(IGetAppointments getAppointments)
        {
            _getAppointments = getAppointments;
        }

        /// <summary>
        /// Get all appointments
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<AppointmentResult> appointmentResults = await _getAppointments.GetAllAppointments();

            return Ok(appointmentResults);
        }
    }
}
