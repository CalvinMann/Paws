using PetDesk.Paws.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.ValueObjects
{
    //I set the constructor to be internal so that I can only implmenent and set the exception string in the domain project
    public class NameShouldNotBeEmptyException : DomainException
    {
        internal NameShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
