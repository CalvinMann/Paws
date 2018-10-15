using PetDesk.Paws.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.Repositories
{
    public interface IClientReadOnlyRepository
    {
        Task<bool> ExistsById(Guid id);
        Task<Client> GetById(Guid id);
        Task<IEnumerable<Client>> GetAll();
    }
}
