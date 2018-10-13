using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Core.Events
{
    public interface IDomainEvent
    {
        Guid AggregateRootId { get; } //Necessary to apply events to the root
        int Version { get; }
    }
}
