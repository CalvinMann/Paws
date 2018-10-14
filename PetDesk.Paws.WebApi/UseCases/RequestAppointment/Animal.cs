using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetDesk.Paws.WebApi.UseCases.RequestAppointment
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string FirstName { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
    }
}
