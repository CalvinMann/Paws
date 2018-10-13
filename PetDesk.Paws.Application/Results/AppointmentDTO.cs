using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Application.Results
{
    public class AppointmentDTO
    {
        public int AppointmentID { get; set; }
        public string AppointmentType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime RequestDate { get; set; }

        public UserDTO User { get; set; }

        public AnimalDTO Animal { get; set; }
    }
}
