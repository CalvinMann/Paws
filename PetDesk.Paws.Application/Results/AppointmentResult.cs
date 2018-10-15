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
        public string AppointmentType { get; set; }
        public DateTime RequestDate { get; set; }
        public Guid ClientId { get; set; }
        public Guid PatientId { get; set; }

        public AppointmentResult(Appointment appointment)
        {
            //Do the mappings here 
            //Could look into using AutoMapper

            AppointmentType = appointment.AppointmentType;
            RequestDate = appointment.RequestedDateTime;
            ClientId = appointment.ClientId;
            PatientId = appointment.PatientId;
        }

    }
}
