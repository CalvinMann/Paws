using PetDesk.Paws.Domain.Appointments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.Repositories
{
    public interface IAppointmentWriteOnlyRepository
    {
        Task Add(Appointment appointment);
    }
}
