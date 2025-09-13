using Accounting.CustomerSubsystem.DTOs.Command;
using Accounting.CustomerSubsystem.DTOs.Query;
using Accounting.CustomerSubsystem.Handler.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.CustomerSubsystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        IServiceProvider _iServiceProvider;
        public CustomerController(IServiceProvider serviceProvider) { 
            _iServiceProvider = serviceProvider;
        }

        [HttpPost]
        [Route("api/AddCustomer")]
        public async Task<IActionResult> AddCustomerAsync([FromBody] AddContactPersonCommand data)
        {
            var handler = _iServiceProvider.GetService<IAddContactPersonCommandHandler>();
            var events = await handler.HandleAsync(data);
            return Ok(events);
        }


        [HttpGet]
        [Route("api/GetCustomerName")]
        public async Task<IActionResult> GetCustomerNameAsync([FromQuery] GetCustomerNameQuery data)
        {
            var handler = _iServiceProvider.GetService<IGetCustomerNameQueryHandler>();
            var Result = await handler.HandleAsync(data);
            return Ok(Result);
        }
    }
}
