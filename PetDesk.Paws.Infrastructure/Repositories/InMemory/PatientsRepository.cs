using PetDesk.Paws.Application.Repositories;
using PetDesk.Paws.Domain.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Infrastructure.Repositories.InMemory
{
    public class PatientsRepository : IPatientReadOnlyRepository, IPatientWriteOnlyRepository
    {
        private readonly Context _context;

        public PatientsRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Patient>> GetAll()
        {
            return await Task.FromResult<IEnumerable<Patient>>(_context.Patients);
        }

        public async Task<Patient> GetById(Guid id)
        {
            Patient patient = _context.Patients
              .Where(c => c.Id == id)
              .SingleOrDefault();

            return await Task.FromResult<Patient>(patient);
        }

        //This is to save processin power and not load the client object
        public async Task<bool> ExistsById(Guid id)
        {
            return true;
        }

        public async Task Add(Patient patient)
        {
            _context.Patients.Add(patient);
            await Task.CompletedTask;
        }
    }
}
