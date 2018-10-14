using PetDesk.Paws.Domain.Appointments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.Repositories
{
    public interface IAppointmentReadOnlyRepository
    {
        Task<Appointment> GetById(Guid id);
        Task<IEnumerable<Appointment>> GetAll();
    }
}
