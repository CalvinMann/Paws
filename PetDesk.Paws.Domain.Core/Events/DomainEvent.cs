using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Core.Events
{
    public class DomainEvent : IDomainEvent
    {
        public DomainEvent(Guid AggregateRootId, int Version)
        {
            this.AggregateRootId = AggregateRootId;
            this.Version = Version;
        }

        public Guid AggregateRootId { get; private set; }

        public int Version { get; private set; }
    }
}
