using Core.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class AutoMapperExtension
    {
        public static void ConfigAutoMapper(this IServiceCollection services)
        {
            new AutoMapperConfig().Config(services);
        }
    }
}
