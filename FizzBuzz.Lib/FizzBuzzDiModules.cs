using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz.Lib
{
    public sealed class FizzBuzzDiModules
    {
        public static void Load(IServiceCollection services)
        {
            services.AddSingleton<FizzBuzzCalc>();
        }
    }
}
