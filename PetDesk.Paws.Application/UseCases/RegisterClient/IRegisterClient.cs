using PetDesk.Paws.Application.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.UseCases.RegisterClient
{
   public interface IRegisterClient
    {
        Task<ClientResult> Register(string firstName, string lastName);
    }
}
