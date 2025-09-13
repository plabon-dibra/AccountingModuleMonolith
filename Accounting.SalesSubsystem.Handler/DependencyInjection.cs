using Accounting.SalesSubsystem.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Accounting.SalesSubsystem.Aggregators;
using Accounting.SalesSubsystem.Handler.Abstractions;

namespace Accounting.SalesSubsystem.Handler
{
    public static class DependencyInjection
    {
        public static IServiceCollection SalesSubsystemDependencyInjectionHandler(this IServiceCollection services, IConfiguration configuration)
        {
            //    services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IGetSalesInfoQueryHandler, GetSalesInfoQueryHandler>();
            services.SalesSubsystemDependencyInjectionRepo(configuration);
            services.SalesSubsystemDependencyInjection(configuration);
            return services;
        }
    }
}
