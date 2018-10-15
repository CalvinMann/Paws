using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PetDesk.Paws.ClientUI.UseCases.ProjectInformation
{
    //[Route("api/[controller]")]
    public class ProjectInformationController : Controller
    {
        public IActionResult Index()
        {
            return View("ProjectInformation");
        }

    }
}