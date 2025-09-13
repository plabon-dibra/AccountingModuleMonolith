using Accounting.SalesSubsystem.DTOs;
using Accounting.SalesSubsystem.Handler.Abstractions;
using Accounting.SalesSubsystem.Repositories.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.SalesSubsystem.Handler
{
    public class GetSalesInfoQueryHandler : IGetSalesInfoQueryHandler
    {
        private readonly IGetSalesInfoQueryRepository _repository;
        public GetSalesInfoQueryHandler(IGetSalesInfoQueryRepository rep) {
           _repository = rep;
        }
        public async Task<SalesInfoResponseDTO> HandleAsync(int tno)
        {
            var data = await _repository.GetSalesInfoByTnoQueryAsync(tno);
            var dto = data.GetSalesInfoResponseDTO();
            return dto;
        }
    }
}
