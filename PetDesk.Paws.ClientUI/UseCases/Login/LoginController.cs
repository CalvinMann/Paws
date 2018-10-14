using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PetDesk.Paws.ClientUI.UseCases.Login
{
    //[Route("login")]
    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            return View("Login");
        }

    }
}