using Accounting.CustomerSubsystem.Aggregators;
using Accounting.CustomerSubsystem.DTOs.Query;
using Accounting.CustomerSubsystem.DTOs.ResponseDTOs;
using Accounting.CustomerSubsystem.Handler.Abstractions;
using Accounting.CustomerSubsystem.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.CustomerSubsystem.Handler
{
    public class GetCustomerNameQueryHandler : IGetCustomerNameQueryHandler
    {
        IGetCustomerNameQueryRepository _CustomerRepo;
        public GetCustomerNameQueryHandler(IGetCustomerNameQueryRepository getCustomerNameQueryRepository) {
            _CustomerRepo = getCustomerNameQueryRepository;
        }

        public async Task<CustomerNameResponseDTO> HandleAsync(GetCustomerNameQuery query)
        {
            GetCustomerNameAggregateRoot getCustomerNameAggregateRoot = new GetCustomerNameAggregateRoot();
            getCustomerNameAggregateRoot.MapDTO(query);
            var result = await _CustomerRepo.GetCustomerNameByCIdQueryAsync(getCustomerNameAggregateRoot);
            var response = result.GetCustomerNameResponseDTO();
            return response;
        }
    }
}
