using Accounting.CustomerSubsystem.Aggregators;
using Accounting.CustomerSubsystem.Repositories.Abstractions;
using Accounting.CustomerSubsystem.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.CustomerSubsystem.Repositories
{
    public class GetCustomerNameQueryRepository : Repository<GetCustomerNameAggregateRoot>, IGetCustomerNameQueryRepository
    {
        private readonly CustomerDbContext _context;
        public GetCustomerNameQueryRepository(CustomerDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<GetCustomerNameAggregateRoot> GetCustomerNameByCIdQueryAsync(GetCustomerNameAggregateRoot aggregateRoot)
        {
            try
            {
                var result = await (
                   from u in _context.Companies
                   where u.Id == aggregateRoot.CId
                   select new GetCustomerNameAggregateRoot
                   {
                       CId = u.Id,
                       CompanyName = u.Name
                   }).FirstOrDefaultAsync();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }
    }
}
