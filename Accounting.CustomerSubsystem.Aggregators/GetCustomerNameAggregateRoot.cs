using Accounting.CustomerSubsystem.DTOs.Query;
using Accounting.CustomerSubsystem.DTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.CustomerSubsystem.Aggregators
{
    public class GetCustomerNameAggregateRoot
    {
        public int CId { get; set; }
        public string CompanyName { get; set; }

        public void MapDTO(GetCustomerNameQuery data)
        {
            CId = data.CId;
        }

        public CustomerNameResponseDTO GetCustomerNameResponseDTO()
        {
            return new CustomerNameResponseDTO
            {
                CId = CId,
                CompanyName = CompanyName
            };
        }
    }
}
