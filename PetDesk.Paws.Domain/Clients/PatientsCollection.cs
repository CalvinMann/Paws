using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PetDesk.Paws.Domain.Clients
{
    public class PatientsCollection
    {
        private readonly IList<Guid> _patientIds;

        public PatientsCollection()
        {
            _patientIds = new List<Guid>();
        }

        //Load the existing list into a read only so it cannot be modified
        public IReadOnlyCollection<Guid> GetPatientIds()
        {
            IReadOnlyCollection<Guid> patientIds = new ReadOnlyCollection<Guid>(_patientIds);
            return patientIds;
        }

        public void Add(Guid patientId)
        {
            _patientIds.Add(patientId);
        }

        public void Remove(Guid patientId)
        {
            _patientIds.Remove(patientId);
        }
    }
}
