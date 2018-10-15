using PetDesk.Paws.Domain.Core.Models;

namespace PetDesk.Paws.Domain.Appointments
{
    public interface IAppointment
    {
        string AppointmentType { get; }
        Id ClientId { get; }
    }
}