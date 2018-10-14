using PetDesk.Paws.Application.Repositories;
using PetDesk.Paws.Application.Results;
using PetDesk.Paws.Domain.Appointments;
using PetDesk.Paws.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.UseCases.RequestAppointment
{
    public sealed class RequestAppointment : IRequestAppointment
    {
        private readonly IClientReadOnlyRepository _clientReadOnlyRepository;

        public RequestAppointment(IClientReadOnlyRepository clientReadOnlyRepository)
        {
            _clientReadOnlyRepository = clientReadOnlyRepository;
        }

        public async Task<AppointmentResult> CreateAppointment(string appointmentType, DateTime requestDate, Guid clientId)
        {

            Client client = await _clientReadOnlyRepository.GetById(clientId);
            if (client == null)
                throw new ClientNotFoundException($"The account {clientId} does not exists or is already closed.");

            Appointment appointment = new Appointment(appointmentType, clientId);

            AppointmentResult aptResult = new AppointmentResult(appointment);

            return aptResult;
        }
    }
}
