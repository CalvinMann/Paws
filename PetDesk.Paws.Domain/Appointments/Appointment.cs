using PetDesk.Paws.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Appointments
{
    //Seal the class so nothing can inherit from it
    public sealed class Appointment : AggregateRoot
    {
        public int AppointmentId { private set; get; }
        public bool IsAccountEnabled { get; private set; }
        public Guid SubscriberId { private set; get; }


        #region Constructors

        private Appointment() { }

        public Appointment(int appointmentId)
        {
            Id = Guid.NewGuid();
            AppointmentId = appointmentId;
            IsAccountEnabled = true;
        }

        #endregion

        #region Load

        public static Appointment Load(int appointmentId)
        {
            Appointment appointment = new Appointment()
            {
                AppointmentId = appointmentId
            

                //Set variables here
            };

            return appointment;
        }

        #endregion

        #region Commands


        public void SetSubcriberId(Id subscriberId)
        {
            ////Raise the event
            //SubscriberIdIsSet subscriberIsSet = new SubscriberIdIsSet(this.Id, this.Version, subscriberId);
            //Raise(subscriberIsSet);
        }

        public void AddReminder(string reminderName)
        {
            //Reminder reminder = new Reminder(Guid.NewGuid(), reminderName);


        }

        #endregion

    }
}
