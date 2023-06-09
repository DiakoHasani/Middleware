﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extensions
{
    public static class MemoryCacheException
    {
        public static void ConfigMemoryCache(this IServiceCollection services)
        {
            services.AddMemoryCache();
        }
    }
}
