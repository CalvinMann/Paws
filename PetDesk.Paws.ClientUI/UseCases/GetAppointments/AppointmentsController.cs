using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PetDesk.Paws.ClientUI.UseCases.GetAppointments
{
    [Route("Appointments")]
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            return View("Appointments");
        }
    }
}