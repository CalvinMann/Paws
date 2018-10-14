using PetDesk.Paws.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Appointments
{
    //Seal the class so nothing can inherit from it
    public sealed class Appointment : AggregateRoot
    {
        public Id ClientId { private set; get; }
        public string AppointmentType { private set; get; }


        #region Constructors

        private Appointment() { }

        public Appointment(string appointmentType, Id clientId)
        {
            Id = Guid.NewGuid();
            ClientId = clientId;
          
        }

        #endregion

        #region Load

        public static Appointment Load(Id appointmentId, Id clientId, string appointmentType)
        {
            Appointment appointment = new Appointment()
            {
                Id = appointmentId,
                ClientId = clientId,
                AppointmentType = appointmentType


                //Set variables here
            };

            return appointment;
        }

        #endregion

        #region Commands


       

        #endregion

    }
}
