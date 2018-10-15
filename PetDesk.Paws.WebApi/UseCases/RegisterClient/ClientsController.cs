using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetDesk.Paws.Application.Results;
using PetDesk.Paws.Application.UseCases.RegisterClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetDesk.Paws.WebApi.UseCases.RegisterClient
{
    [Route("api/[controller]")]
    public class ClientsController : Controller
    {

        private IRegisterClient _registerClient;

        public ClientsController(IRegisterClient registerClient)
        {
            _registerClient = registerClient;
        }
        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] Client client)
        {
            if (ModelState.IsValid)
            {
              ClientResult clientResult =  await _registerClient.Register(client.FirstName, client.LastName);

                return Ok();
            }

            return BadRequest(ModelState);
        }

    }
}
