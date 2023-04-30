using Infrastructure.Entities;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void ConfigDependencyInjectionInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
        }
    }
}
