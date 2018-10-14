using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Core.Models
{
    //A layer of inheritance in case I need to add more to the custom exceptions
    public class DomainException : Exception
    {
        public DomainException(string businessMessage)
            : base(businessMessage)
        {
        }
    }

    //I set the constructor to be internal so that I can only implmenent and set the exception string in the domain project
    public class IdShouldNotBeEmptyException : DomainException
    {
        internal IdShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
