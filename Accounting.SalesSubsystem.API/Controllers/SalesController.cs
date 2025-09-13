using Accounting.SalesSubsystem.Aggregators;
using Accounting.SalesSubsystem.Handler;
using Accounting.SalesSubsystem.Handler.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Accounting.SalesSubsystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly IServiceProvider _iServiceProvider;
        public SalesController(IServiceProvider iServiceProvider)
        {
            _iServiceProvider = iServiceProvider;
        }

        [HttpPost]
        [Route("api/GetSalesInfo")]
        public async Task<IActionResult> GetSalesInfo(int tno)
        {
            //var handler = _iServiceProvider.GetService<IGetSalesInfoQueryHandler>();
            var handler = _iServiceProvider.GetService<IGetSalesInfoQueryHandler>();
            var events = handler.HandleAsync(tno);
            return Ok(events);
        }

    }
}
