using PetDesk.Paws.Application.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.UseCases.RegisterPatient
{
    public interface IRegisterPatient
    {
        Task<PatientResult> Register(string firstName, string species, string breed, Guid clientId);
    }
}
