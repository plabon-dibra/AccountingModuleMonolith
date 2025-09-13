using Accounting.SalesSubsystem.Aggregators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.SalesSubsystem.Repositories.Abstractions
{
    public interface IGetSalesInfoQueryRepository : IRepository<GetSalesInfoAggregateRoot>
    {
        Task<GetSalesInfoAggregateRoot> GetSalesInfoByTnoQueryAsync(int tno);
    }
}
