
using PetDesk.Paws.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Core.Models
{
    //This aggregate root class will serve as a base call for our aggregate
    //Here we can implment domain events in our root classes so we can follow the UnitOfWork principal

    public abstract class AggregateRoot : IAggregateRoot
    {
        private readonly Dictionary<Type, Action<object>> handlers = new Dictionary<Type, Action<object>>();
        private readonly List<IDomainEvent> domainEvents = new List<IDomainEvent>();

        public virtual int Version { get; protected set; }

        public Id Id { get; protected set; }

        public AggregateRoot()
        {
            Version = 0; //reset the version everytime a new object is created
        }

        protected void Register<T>(Action<T> when)
        {
            handlers.Add(typeof(T), e => when((T)e));
        }

        protected void Raise(IDomainEvent domainEvent)
        {
            domainEvents.Add(domainEvent);
            handlers[domainEvent.GetType()](domainEvent); //Calls the delegate
            Version++; //We change the version number 
        }

        public IReadOnlyCollection<IDomainEvent> GetEvents()
        {
            return domainEvents; 
        }

        public void Apply(IDomainEvent domainEvent)
        {
            handlers[domainEvent.GetType()](domainEvent);
            Version++;
        }
    }

}
