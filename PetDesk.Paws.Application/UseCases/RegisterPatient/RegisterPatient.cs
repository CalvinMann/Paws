using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PetDesk.Paws.Application.Repositories;
using PetDesk.Paws.Application.Results;
using PetDesk.Paws.Domain.Patients;

namespace PetDesk.Paws.Application.UseCases.RegisterPatient
{
    public class RegisterPatient : IRegisterPatient
    {
        private readonly IPatientWriteOnlyRepository _patientWriteOnlyRepository;

        public RegisterPatient(IPatientWriteOnlyRepository patientWriteOnlyRepository)
        {
            _patientWriteOnlyRepository = patientWriteOnlyRepository;
        }

        public async Task<PatientResult> Register(string firstName, string species, string breed, Guid clientId)
        {
            Patient patient = new Patient(firstName, breed, species );

            await _patientWriteOnlyRepository.Add(patient);

            PatientResult patientResult = new PatientResult(patient);

            return patientResult;
        }
    }
}
