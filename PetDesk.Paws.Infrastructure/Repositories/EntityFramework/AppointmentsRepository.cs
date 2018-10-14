using PetDesk.Paws.Application.Repositories;
using PetDesk.Paws.Domain.Appointments;
using PetDesk.Paws.Infrastructure.Repositories.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Infrastructure.Repositories.EntityFramework
{

    public class AppointmentsRepository : IAppointmentReadOnlyRepository, IAppointmentWriteOnlyRepository
    {
        public Task Add(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Appointment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Appointment> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
