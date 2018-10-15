using PetDesk.Paws.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.ValueObjects
{
    //I set the constructor to be internal so that I can only implmenent and set the exception string in the domain project

    //Creating individual exceptions may not be ideal since theyre virtualy all the same
    //However, this does allow for us to identify exact exceptions and add more detail to it
    //later if useful for logging or event tracking

    public class NameShouldNotBeEmptyException : DomainException
    {
        internal NameShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }

    public class BreedShouldNotBeEmptyException : DomainException
    {
        internal BreedShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }

    public class SpeciesShouldNotBeEmptyException : DomainException
    {
        internal SpeciesShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }

    
}
