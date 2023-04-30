using Application.CacheServices;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void ConfigDependencyInjectionApplication(this IServiceCollection services)
        {
            services.AddScoped<IUserCache, UserCache>();

            services.AddScoped<IUserService, UserService>();
        }
    }
}
