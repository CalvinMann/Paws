using PetDesk.Paws.Domain.Appointments;
using PetDesk.Paws.Domain.Clients;
using PetDesk.Paws.Domain.Patients;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PetDesk.Paws.Infrastructure.Repositories.InMemory
{
    public class Context
    {
        public Collection<Appointment> Appointments { get; set; }
        public Collection<Client> Clients { get; set; }
        public Collection<Patient> Patients { get; set; }


        public Context()
        {
            Appointments = new Collection<Appointment>();
            Clients = new Collection<Client>();
            Patients = new Collection<Patient>();

            //Seed the DB

            Client client = new Client("Wendy", "McMichael");

            Patient patient = new Patient("Dirk", "Terrier", "Dog", client.Id);

            Appointment appointment = new Appointment("Vacs", DateTime.Now, client.Id, patient.Id);

            client.AddPatient(patient.Id);
            client.AddAppointment(appointment.Id);

            Clients.Add(client);
            Patients.Add(patient);
            Appointments.Add(appointment);
        }
    }
}
