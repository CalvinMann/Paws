using PetDesk.Paws.Domain.Appointments;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PetDesk.Paws.Domain.Clients
{
    //We're encapsulating a list so we can control the operations of what can be done to it
    public sealed class AppointmentCollection
    {
        private readonly IList<Guid> _appointmentIds;

        public AppointmentCollection()
        {
            _appointmentIds = new List<Guid>();
        }

        //Load the existing list into a read only so it cannot be modified
        public IReadOnlyCollection<Guid> GetAppointmentIds()
        {
            IReadOnlyCollection<Guid> appointmentIds = new ReadOnlyCollection<Guid>(_appointmentIds);
            return appointmentIds;
        }

        public void Add(Guid appointmentId)
        {
            _appointmentIds.Add(appointmentId);
        }

    }
}
