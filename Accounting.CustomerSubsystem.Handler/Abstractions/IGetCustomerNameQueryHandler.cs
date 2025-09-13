using Accounting.CustomerSubsystem.DTOs.Query;
using Accounting.CustomerSubsystem.DTOs.ResponseDTOs;
using ShareSubsystem.Handlers.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.CustomerSubsystem.Handler.Abstractions
{
    public interface IGetCustomerNameQueryHandler : IQueryHandler<GetCustomerNameQuery, CustomerNameResponseDTO>
    {
    }
}
