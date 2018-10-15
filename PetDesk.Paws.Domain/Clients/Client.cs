using PetDesk.Paws.Domain.Core.Models;
using PetDesk.Paws.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDesk.Paws.Domain.Clients
{
    public sealed class Client : AggregateRoot
    {
        public Name FirstName { private set; get; }

        public Name LastName { private set; get; }

        //never hold object references
        //store ids 
        public IReadOnlyCollection<Guid> Appointments
        {
            get
            {
                IReadOnlyCollection<Guid> readOnly = _appointments.GetAppointmentIds();
                return readOnly;
            }
        }

        private AppointmentCollection _appointments;


        public IReadOnlyCollection<Guid> Patients
        {
            get
            {
                IReadOnlyCollection<Guid> readOnly = _patients.GetPatientIds();
                return readOnly;
            }
        }
        private PatientsCollection _patients;


        private Client()
        {
            _appointments = new AppointmentCollection();
            _patients = new PatientsCollection();
        }

        public Client(Name firstName, Name lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;

            _appointments = new AppointmentCollection();
            _patients = new PatientsCollection();
        }

        public void AddAppointment(Guid appointmentId)
        {
            _appointments.Add(appointmentId);
        }

        public void AddPatient(Guid patientId)
        {
            _patients.Add(patientId);
        }
    }
}
