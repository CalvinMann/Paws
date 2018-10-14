using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Application
{
    //We set these access modifies to be internal so the messages can only be written in the application

        //Creating individual exceptions may not be ideal since theyre vritaully all the same
        //However, this does allow for us to identify exact exceptions and add more detail to it
        //later if useful for logging or event tracking
    internal class AppointmentNotFoundException : Exception
    {
        internal AppointmentNotFoundException(string message)
            : base(message)
        { }
    }

    internal class ClientNotFoundException : Exception
    {
        internal ClientNotFoundException(string message)
            : base(message)
        { }
    }
  
}
