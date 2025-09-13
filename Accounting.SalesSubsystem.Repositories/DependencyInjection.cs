using Accounting.SalesSubsystem.Repositories.Abstractions;
using Accounting.SalesSubsystem.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Accounting.SalesSubsystem.Repositories
{
    public static class DependencyInjection
    {
        public static IServiceCollection SalesSubsystemDependencyInjectionRepo(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IGetSalesInfoQueryRepository, GetSalesInfoQueryRepository>();
            services.AddDbContext<SalesDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("TestConnection")));
            return services;
        }
    }
}
