using Accounting.CustomerSubsystem.Aggregators;
using ShareSubsystem.Handlers.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.CustomerSubsystem.Repositories.Abstractions
{
    public interface IAddContactPersonCommandRepository : IRepository<ContactPersonAggregateRoot>
    {
        Task<ContactPersonAggregateRoot?> AddContactPersonAsync(ContactPersonAggregateRoot contactPersonAggregateRoot);
    }
}
