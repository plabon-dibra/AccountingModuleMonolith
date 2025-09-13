using Accounting.CustomerSubsystem.Handler.Abstractions;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.CustomerSubsystem.Handler
{
    public static class DependencyInjection
    {
        public static IServiceCollection CustomerSubsystemHandlerDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IGetCustomerNameQueryHandler, GetCustomerNameQueryHandler>();
            services.AddScoped<IAddContactPersonCommandHandler, AddContactPersonCommandHandler>();
            return services;
        }
    }
}
