using PetDesk.Paws.Domain.Clients;
using PetDesk.Paws.Domain.Patients;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.Repositories
{
    public interface IPatientWriteOnlyRepository
    {
        Task Add(Patient patient);
    }
}
