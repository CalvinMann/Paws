using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PetDesk.Paws.Application.Repositories;
using PetDesk.Paws.Application.Results;
using PetDesk.Paws.Domain.Clients;
using PetDesk.Paws.Domain.Patients;

namespace PetDesk.Paws.Application.UseCases.RegisterPatient
{
    public class RegisterPatient : IRegisterPatient
    {
        private readonly IClientReadOnlyRepository _clientReadOnlyRepository;
        private readonly IPatientWriteOnlyRepository _patientWriteOnlyRepository;

        public RegisterPatient(IPatientWriteOnlyRepository patientWriteOnlyRepository,
            IClientReadOnlyRepository clientReadOnlyRepository)
        {
            _patientWriteOnlyRepository = patientWriteOnlyRepository;
            _clientReadOnlyRepository = clientReadOnlyRepository;
        }

        public async Task<PatientResult> Register(string firstName, string species, string breed, Guid clientId)
        {
            bool clientExists = await _clientReadOnlyRepository.ExistsById(clientId);
            if (!clientExists)
                throw new ClientNotFoundException($"The client {clientId} does not exists.");

            Patient patient = new Patient(firstName, breed, species, clientId );

            await _patientWriteOnlyRepository.Add(patient);

            PatientResult patientResult = new PatientResult(patient);

            return patientResult;
        }
    }
}
