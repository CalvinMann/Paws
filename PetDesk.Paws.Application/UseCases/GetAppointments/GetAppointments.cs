using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PetDesk.Paws.Application.Repositories;
using PetDesk.Paws.Application.Results;
using PetDesk.Paws.Domain.Appointments;

namespace PetDesk.Paws.Application.UseCases.GetAppointments
{
    public class GetAppointments : IGetAppointments
    {
        private IAppointmentReadOnlyRepository _appointmentReadOnlyRepository;

        public GetAppointments(IAppointmentReadOnlyRepository appointmentReadOnlyRepository)
        {
            _appointmentReadOnlyRepository = appointmentReadOnlyRepository;
        }

        public async Task<AppointmentResult> GetAppointmentById(Guid id)
        {
            Appointment appointment = await _appointmentReadOnlyRepository.GetById(id);

            if (appointment == null)
                throw new AppointmentNotFoundException($"The appointment {id} does not exists or is not processed yet.");

            AppointmentResult appointmentResult = new AppointmentResult(appointment);
                return appointmentResult;
            
        }

        public async Task<IEnumerable<AppointmentResult>> GetAllAppointments()
        {
            IEnumerable<Appointment> appointments = await _appointmentReadOnlyRepository.GetAll();

            List<AppointmentResult> appointmentResults = new List<AppointmentResult>();

            foreach (Appointment appointment in appointments)
            {
                AppointmentResult appointmentResult = new AppointmentResult(appointment);
                appointmentResults.Add(appointmentResult);
            }

            return appointmentResults;
        }
    }
}
