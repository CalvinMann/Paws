using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Infrastructure.WebSockets.SignalR
{
    //This is a DTO. 
    //We may want to limit whats sent to the client and therefore we dont want to use our domain objects
    public class Appointment
    {
     
            public string AppointmentType { get; set; }
            public DateTime RequestDate { get; set; }
            public Guid ClientId { get; set; }
            public Guid PatientId { get; set; }
        
    }
}
