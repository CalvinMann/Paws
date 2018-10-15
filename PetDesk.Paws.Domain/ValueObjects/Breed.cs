using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.ValueObjects
{
    //I could turn this into a base class 
    public sealed class Breed
    {
        private string _text;

        public Breed(string text)
        {
            //Write all the business logic here 

            if (string.IsNullOrWhiteSpace(text))
                throw new BreedShouldNotBeEmptyException("The 'Breed' field is required");

            _text = text;
        }

        public static implicit operator Breed(string text)
        {
            return new Breed(text);
        }

        public static implicit operator string(Breed name)
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

            return ((Breed)obj)._text == _text;
        }
    }
}
