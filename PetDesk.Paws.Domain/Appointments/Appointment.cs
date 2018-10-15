using PetDesk.Paws.Domain.Core.Models;
using PetDesk.Paws.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Appointments
{
    //Seal the class so nothing can inherit from it
    public sealed class Appointment : AggregateRoot, IAppointment
    {
        //We're making the properties private sets so they are encapsulated
        //The only way to modify them is to call a method
        public Id ClientId { private set; get; }
        public Id PatientId { private set; get; }
        public string AppointmentType { private set; get; }
        public DateWithTime RequestedDateTime { private set; get; }

        public DateTime CreatedDateTime { private set; get; }

        #region Constructors

        private Appointment() { }

        public Appointment(string appointmentType,  DateWithTime requestedDateWithTime, Id clientId, Id patientId)
        {
            Id = Guid.NewGuid();
            CreatedDateTime = DateTime.Now;
            AppointmentType = appointmentType;
            RequestedDateTime = requestedDateWithTime;
            ClientId = clientId;
            PatientId = patientId;
          
        }

        #endregion

        #region Load

        public static Appointment Load(Id appointmentId, Id clientId, Id patientId, string appointmentType, DateWithTime requestedDateTime, DateTime createdDateTime)
        {
            Appointment appointment = new Appointment()
            {
                Id = appointmentId,
                ClientId = clientId,
                PatientId = patientId,
                AppointmentType = appointmentType,
                RequestedDateTime = requestedDateTime,
                CreatedDateTime = createdDateTime

                //Set variables here
            };

            return appointment;
        }

        #endregion

        #region Commands


       

        #endregion

    }
}
