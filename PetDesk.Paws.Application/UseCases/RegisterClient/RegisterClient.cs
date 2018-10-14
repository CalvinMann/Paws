using PetDesk.Paws.Application.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.UseCases.RegisterClient
{
    public sealed class RegisterClient : IRegisterClient
    {
        public async Task<ClientResult> Register(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
