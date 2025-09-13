using Accounting.SalesSubsystem.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.SalesSubsystem.Handler.Abstractions
{
    public interface IGetSalesInfoQueryHandler
    {
        public Task<SalesInfoResponseDTO> HandleAsync(int tno);
    }
}
