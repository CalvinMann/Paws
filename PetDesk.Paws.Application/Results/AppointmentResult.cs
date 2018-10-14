using PetDesk.Paws.Domain.Appointments;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Application.Results
{
    //This is a DTO that we use to wrap our domain classes in.
    //We dont want to return our domain classes to the UI because we may have sensitive data we dont want to expose

    public class AppointmentResult
    {
        public AppointmentResult(Appointment appointment)
        {
            //Do the mappings here
        }

    }
}
