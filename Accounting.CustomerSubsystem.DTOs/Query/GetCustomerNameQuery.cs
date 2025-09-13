using Accounting.CustomerSubsystem.DTOs.ResponseDTOs;
using ShareSubsystem.Handlers.Handlers;


namespace Accounting.CustomerSubsystem.DTOs.Query
{
    public class GetCustomerNameQuery : IQuery<CustomerNameResponseDTO>
    {
        public int CId { get; set; }
    }
}
