using PetDesk.Paws.Application.Repositories;
using PetDesk.Paws.Domain.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Infrastructure.Repositories.InMemory
{

    public class AppointmentsRepository : IAppointmentReadOnlyRepository, IAppointmentWriteOnlyRepository
    {

        private readonly Context _context;

        public AppointmentsRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Appointment>> GetAll()
        {
            return await Task.FromResult<IEnumerable<Appointment>>(_context.Appointments);
        }

        public async Task<Appointment> GetById(Guid id)
        {
            Appointment appointment = _context.Appointments
              .Where(a => a.Id == id)
              .SingleOrDefault();

            return await Task.FromResult<Appointment>(appointment);
        }

        public async Task Add(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            await Task.CompletedTask;
        }


    }

}
