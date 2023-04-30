using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class DataBaseExtension
    {
        private static string ConnectionString = "data source=.;initial catalog=MiddlewareDb;integrated security=true;";
        public static void ConfigDatabase(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>(item => item.UseSqlServer(ConnectionString));
        }
    }
}
