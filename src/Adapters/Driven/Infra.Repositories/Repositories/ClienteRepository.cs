﻿using QuickOrder.Adapters.Driven.PostgresDB.Core;
using QuickOrder.Core.Domain.Entities;
using QuickOrder.Core.Domain.Repositories;

namespace QuickOrder.Adapters.Driven.PostgresDB.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationContext context) :
            base(context)
        {
        }

    }
}
