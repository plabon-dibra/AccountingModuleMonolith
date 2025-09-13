using Accounting.CustomerSubsystem.Repositories.Abstractions;
using Accounting.CustomerSubsystem.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.CustomerSubsystem.Repositories
{
    public static class DependencyInjection
    {
        public static IServiceCollection CustomerSubSystemRepoDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<CustomerDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TestConnection")));
            services.AddScoped<IGetCustomerNameQueryRepository, GetCustomerNameQueryRepository>();
            services.AddScoped<IAddContactPersonCommandRepository, AddContactPersonCommandRepository>();
            return services;
        }
    }
}
