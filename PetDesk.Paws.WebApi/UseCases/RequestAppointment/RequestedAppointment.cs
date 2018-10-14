﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetDesk.Paws.WebApi.UseCases.RequestAppointment
{
    //We're creating DTO's to load the JSon data into.
    //We're using local DTO's in this project versus ApplicationLevel DTO's in case the
    //the front end changes (API) we dont have to disrupt the application level logic
    public class RequestedAppointment
    {
        public int AppointmentID { get; set; }
        public string AppointmentType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime RequestDate { get; set; }

        public User User { get; set; }

        public Animal Animal { get; set; }
    }
}
