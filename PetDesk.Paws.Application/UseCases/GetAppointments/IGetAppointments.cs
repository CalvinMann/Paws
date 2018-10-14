using PetDesk.Paws.Application.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.UseCases.GetAppointments
{
    public interface IGetAppointments
    {
        Task<AppointmentResult> GetAppointmentById(Guid id);
        Task<IEnumerable<AppointmentResult>> GetAllAppointments();
    }
}
