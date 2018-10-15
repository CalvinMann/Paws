using PetDesk.Paws.Application.Repositories;
using PetDesk.Paws.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Infrastructure.Repositories.InMemory
{
    
    public class ClientsRepository : IClientReadOnlyRepository, IClientWriteOnlyRepository
    {

        private readonly Context _context;

        public ClientsRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            return await Task.FromResult<IEnumerable<Client>>(_context.Clients);
        }

        public async Task<Client> GetById(Guid id)
        {
            Client client = _context.Clients
              .Where(c => c.Id == id)
              .SingleOrDefault();

            return await Task.FromResult<Client>(client);
        }

        //This is to save processin power and not load the client object
        public async Task<bool> ExistsById(Guid id)
        {
            return true; 
        }

        public async Task Add(Client client)
        {
            _context.Clients.Add(client);
            await Task.CompletedTask;
        }

  
    }
}
