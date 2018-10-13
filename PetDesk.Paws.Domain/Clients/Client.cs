using PetDesk.Paws.Domain.Core.Models;
using PetDesk.Paws.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Clients
{
    public sealed class Client
    {
        public Id Id { private set; get; }

        public Name Name { private set; get; }

        public Guid AccountId { private set; get; }

        //This is useful if we decide to implement event sourcing
        public int Version { private set; get; }

        private Client() { }

        public Client(Name name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        //public void SetAccountId(Id accountId)
        //{
        //    AccountId = accountId;
        //}
    }
}
