using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.SalesSubsystem.Aggregators
{
    public static class DependencyInjection
    {
        public static IServiceCollection SalesSubsystemDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(GetSalesInfoAggregateRoot));

            //    services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //    services.AddScoped<IGetSalesInfoQueryRepository, GetSalesInfoQueryRepository>();
            return services;
        }

    }
}
