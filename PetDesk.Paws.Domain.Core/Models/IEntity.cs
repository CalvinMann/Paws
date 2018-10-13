using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Core.Models
{
    //making this interface internal because only domain entities need to implement it
    public interface IEntity
    {
        //Every Entity must have an ID
        Id Id { get; }
    }
}
