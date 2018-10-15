using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetDesk.Paws.WebApi.UseCases.RegisterPatient
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }

        public Guid ClientId { get; set; }
    }
}
