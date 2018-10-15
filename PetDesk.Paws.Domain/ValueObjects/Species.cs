using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.ValueObjects
{
    public class Species
    {
        private string _text;

        public Species(string text)
        {
            //Write all the business logic here 

            if (string.IsNullOrWhiteSpace(text))
                throw new SpeciesShouldNotBeEmptyException("The 'Species' field is required");

            _text = text;
        }

        public static implicit operator Species(string text)
        {
            return new Species(text);
        }

        public static implicit operator string(Species name)
        {
            return name._text;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is string)
            {
                return obj.ToString() == _text;
            }

            return ((Species)obj)._text == _text;
        }
    }
}
