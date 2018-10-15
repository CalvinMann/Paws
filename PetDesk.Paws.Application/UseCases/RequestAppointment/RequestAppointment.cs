using PetDesk.Paws.Application.Repositories;
using PetDesk.Paws.Application.Results;
using PetDesk.Paws.Domain.Appointments;
using PetDesk.Paws.Domain.Clients;
using PetDesk.Paws.Domain.Patients;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.UseCases.RequestAppointment
{
    public sealed class RequestAppointment : IRequestAppointment
    {
        private readonly IClientReadOnlyRepository _clientReadOnlyRepository;
        private readonly IPatientReadOnlyRepository _patientReadOnlyRepository;

        public RequestAppointment(IClientReadOnlyRepository clientReadOnlyRepository,
                                    IPatientReadOnlyRepository patientReadOnlyRepository)
        {
            _clientReadOnlyRepository = clientReadOnlyRepository;
            _patientReadOnlyRepository = patientReadOnlyRepository;
        }

        public async Task<AppointmentResult> CreateAppointment(string appointmentType, DateTime requestDate, Guid clientId, Guid patientId)
        {

            bool clientExists = await _clientReadOnlyRepository.ExistsById(clientId);
            if (!clientExists)
                throw new ClientNotFoundException($"The client {clientId} does not exists.");

            bool patientExists = await _patientReadOnlyRepository.ExistsById(patientId);
            if (!patientExists)
                throw new PatientNotFoundException($"The patient {patientId} does not exists.");


            Appointment appointment = new Appointment(appointmentType, requestDate, clientId, patientId);

            AppointmentResult aptResult = new AppointmentResult(appointment);

            return aptResult;
        }
    }
}
