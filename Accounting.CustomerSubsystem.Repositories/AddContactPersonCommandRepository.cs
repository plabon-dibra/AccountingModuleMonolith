using Accounting.CustomerSubsystem.Aggregators;
using Accounting.CustomerSubsystem.Repositories.Abstractions;
using Accounting.CustomerSubsystem.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.CustomerSubsystem.Repositories
{
    public class AddContactPersonCommandRepository : Repository<ContactPersonAggregateRoot>, IAddContactPersonCommandRepository
    {
        private readonly CustomerDbContext customerDbContext;
        public AddContactPersonCommandRepository(CustomerDbContext context) : base(context)
        {
            customerDbContext = context;
        }

        public async Task<ContactPersonAggregateRoot?> AddContactPersonAsync(ContactPersonAggregateRoot contactPersonAggregateRoot)
        {
            var entity = new ContactPerson
            {
                Cid = contactPersonAggregateRoot.Cid,
                Name = contactPersonAggregateRoot.Name,
                Designation = contactPersonAggregateRoot.Designation,
                Ptype = contactPersonAggregateRoot.Ptype,
                Email = contactPersonAggregateRoot.Email,
                Phone = contactPersonAggregateRoot.Phone
            };

            await customerDbContext.ContactPersons.AddAsync(entity);
            var affected = await customerDbContext.SaveChangesAsync();

            if (affected > 0)
            {
                // EF will populate auto-incremented Id after save
                contactPersonAggregateRoot.Id = entity.Id;
                return contactPersonAggregateRoot;
            }

            return null; // nothing inserted
        }
    }
}
