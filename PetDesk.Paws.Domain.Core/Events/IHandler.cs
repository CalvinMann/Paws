using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Core.Events
{
    public interface IHandler<T> where T : IDomainEvent
    {

    }
}
