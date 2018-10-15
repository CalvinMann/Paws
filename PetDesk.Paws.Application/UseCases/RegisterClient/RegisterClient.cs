using PetDesk.Paws.Application.Repositories;
using PetDesk.Paws.Application.Results;
using PetDesk.Paws.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.UseCases.RegisterClient
{
    public sealed class RegisterClient : IRegisterClient
    {
        private IClientWriteOnlyRepository _clientWriteOnlyRepository;

        public RegisterClient(IClientWriteOnlyRepository clientWriteOnlyRepository)
        {
            _clientWriteOnlyRepository = clientWriteOnlyRepository;
        }

        public async Task<ClientResult> Register(string firstName, string lastName)
        {
            Client client = new Client(firstName, lastName);

            await _clientWriteOnlyRepository.Add(client);

            ClientResult clientResult = new ClientResult(client);

            return clientResult;

        }
    }
}
