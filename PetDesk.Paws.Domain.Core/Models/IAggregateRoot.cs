using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Core.Models
{
    //Every aggregate root will be an entity with a unique ID
    //This is left empty but the interface ensures that the implementing object is of type aggregate root
    //Left internal so only the domain objects can access this

    //Note: I suppose this could be an abstract class as well...
    public interface IAggregateRoot : IEntity
    {
       
         int Version { get; }
    }
}
