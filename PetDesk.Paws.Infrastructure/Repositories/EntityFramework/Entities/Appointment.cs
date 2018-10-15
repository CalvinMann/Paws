using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Infrastructure.Repositories.EntityFramework.Entities
{

    //These entities were created so that we can modify the model without affecting the domain entities. This also
    //seperates the coupling from our domain entities and EF.
    //EF requires these objects to be set up with certain traits like a public constructor and that might not be desirable
    public class Appointment
    {

    }
}
