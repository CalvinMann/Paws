using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetDesk.Paws.ClientUI.UseCases.LoadDashboard
{
    [Route("api/[controller]")]
    public class DashboardController : Controller
    {

        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:44399//api/appointments"); //webapi
            

            return View("Dashboard");
        }
    }
}
