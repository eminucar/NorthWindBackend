using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyResolvers
{
    public class CoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddSingleton<Stopwatch>();
        }
    }
}
