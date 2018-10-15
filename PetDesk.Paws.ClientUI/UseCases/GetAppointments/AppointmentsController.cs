using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PetDesk.Paws.ClientUI.UseCases.GetAppointments
{
    [Route("api/[controller]")]
    public class AppointmentsController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:44399//api/appointments"); //webapi
            //var appointments = await response.Content.ReadAsAsync<IEnumerable<Product>>();

            return View("Appointments");
        }
    }
}