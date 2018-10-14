using PetDesk.Paws.Domain.Core.Models;
using PetDesk.Paws.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Patients
{
    public sealed class Patient
    {
        public Id Id { private set; get; }

        public Name FirstName { private set; get; }

        private Patient() { }

        public Patient(Name firstName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
        }
    }
}
