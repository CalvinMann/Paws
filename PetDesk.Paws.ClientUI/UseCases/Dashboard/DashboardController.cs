using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetDesk.Paws.Application.Results;
using PetDesk.Paws.Application.UseCases.GetAppointments;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetDesk.Paws.ClientUI.UseCases.Dashboard
{
    public class DashboardController : Controller
    {
        private readonly IGetAppointments _getAppointments;

        public DashboardController(IGetAppointments getAppointments)
        {
            _getAppointments = getAppointments;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<AppointmentResult> appointmentResults = await _getAppointments.GetAllAppointments();

            return View("Dashboard", appointmentResults);
        }
    }
}
