using PetDesk.Paws.Application.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.UseCases.RequestAppointment
{
    public interface IRequestAppointment
    {
        Task<AppointmentResult> CreateAppointment(string appointmentType, DateTime requestDate, Guid clientId, Guid patientId);
    }
}
