using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Core.Models
{
    //I sealed the class so it cant be inherited
    public sealed class Id : ValueObject<Id>
    {
        private Guid _internalId;

        //Here we check that the Guid is valid and throw an exception if it isnt. 
        //This is done so that any class that uses this value object can ensure that the value is always in a true state
        public Id(Guid id)
        {
            if (id == null || id == Guid.Empty)
                throw new GuidShouldNotBeEmptyException("The 'Id' field is required");

            _internalId = id;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return _internalId;
        }

        //Use the impliciit operator to set the Guid just as you would a primitive type
        public static implicit operator Id(Guid id)
        {
            return new Id(id);
        }

        //Use the impliciit operator to set the Guid just as you would a primitive type
        public static implicit operator Guid(Id id)
        {
            return id._internalId;
        }


    }
}
