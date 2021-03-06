﻿using PetDesk.Paws.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetDesk.Paws.Application.Repositories
{
    public interface IClientWriteOnlyRepository
    {
        Task Add(Client client);
    }
}
