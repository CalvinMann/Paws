using PetDesk.Paws.Domain.Core.Models;
using PetDesk.Paws.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Patients
{
    public sealed class Patient : AggregateRoot
    {

        public Name FirstName { private set; get; }
        public Breed Breed { private set; get; }
        public Species Species { private set; get; }

        public Id ClientId { private set; get; }

        private Patient() { }

        public Patient(Name firstName, Breed breed, Species species, Guid clientId)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            Breed = breed;
            Species = species;

            ClientId = clientId;

        }
    }
}
