using Accounting.CustomerSubsystem.Aggregators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.CustomerSubsystem.Repositories.Abstractions
{
    public interface IGetCustomerNameQueryRepository: IRepository<GetCustomerNameAggregateRoot>
    {
        Task<GetCustomerNameAggregateRoot> GetCustomerNameByCIdQueryAsync(GetCustomerNameAggregateRoot aggregateRoot);
    }
}
