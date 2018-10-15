using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.ValueObjects
{
    public class DateWithTime
    {
        private DateTime _dt;

        public DateWithTime(DateTime dateTime)
        {
            //Write all the business logic here 

            //Write logic to make sure the date and time isnt less than Dt.Now
            if (dateTime == null)
                throw new NameShouldNotBeEmptyException("The 'Name' field is required");

            _dt = dateTime;
        }

        public static implicit operator DateWithTime(DateTime dateTime)
        {
            return new DateWithTime(dateTime);
        }

        public static implicit operator DateTime(DateWithTime dateTime)
        {
            return dateTime._dt;
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

            return ((DateWithTime)obj)._dt == _dt;
        }
    }
}
