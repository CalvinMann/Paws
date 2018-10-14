using PetDesk.Paws.Domain.Core.Models;
using PetDesk.Paws.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Clients
{
    public sealed class Client : AggregateRoot
    {
        public Name FirstName { private set; get; }

        public Name LastName { private set; get; }

        private Client() { }

        public Client(Name firstName, Name lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
