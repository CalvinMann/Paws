using PetDesk.Paws.Domain.Appointments;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PetDesk.Paws.Infrastructure.Repositories.InMemory
{
    public class Context
    {
        public Collection<Appointment> Appointments { get; set; }
       

        public Context()
        {
            Appointments = new Collection<Appointment>();
        }
    }
}
