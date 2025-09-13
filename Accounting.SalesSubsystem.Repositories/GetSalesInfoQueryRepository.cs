using Accounting.SalesSubsystem.Aggregators;
using Accounting.SalesSubsystem.Repositories.Abstractions;
using Accounting.SalesSubsystem.Repositories.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Accounting.SalesSubsystem.Repositories
{
    public class GetSalesInfoQueryRepository : IGetSalesInfoQueryRepository
    {
        private readonly SalesDbContext _context;
        public GetSalesInfoQueryRepository(SalesDbContext dbContext) //: base(dbContext)
        { 
            _context = dbContext;
        }
        //public string getSalesInfo()
        //{
        //    SalesDbContext n = new SalesDbContext();

        //    var g = n.Sales.FirstOrDefault();

        //    return "got it";
        //}
        public Task AddAsync(GetSalesInfoAggregateRoot entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(GetSalesInfoAggregateRoot entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetSalesInfoAggregateRoot>> FindAsync(Expression<Func<GetSalesInfoAggregateRoot, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetSalesInfoAggregateRoot>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetSalesInfoAggregateRoot?> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<GetSalesInfoAggregateRoot> GetSalesInfoByTnoQueryAsync(int  tno)
        {
            try
            {
                var data = _context.Sales.FirstOrDefault(x => x.Tno == tno);
                if (data == null)
                {
                    return null; 
                }

                return new GetSalesInfoAggregateRoot
                {
                    Tno = data.Tno,
                    Tax = data.Tax,
                    CashReceived =data.CashReceived,
                    AccReceivable = data.AccReceivable,
                    Pcode = data.Pcode,
                    Cid =data.Cid,
                    Sdate = data.Sdate,
                    Edate = data.Edate,
                    SalesPrice = data.SalesPrice,
                    Comments = data.Comments,
                    Duration = data.Duration,
                    JpId = data.JpId,
                    SalesPerson = data.SalesPerson,
                    BillContactId = data.BillContactId
                };
            }
            catch (SqlException ex)
            {

                throw new Exception();
            }
            catch (Exception ex)
            {
              
               throw new Exception();
            }
           
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(GetSalesInfoAggregateRoot entity)
        {
            throw new NotImplementedException();
        }
    }
}
