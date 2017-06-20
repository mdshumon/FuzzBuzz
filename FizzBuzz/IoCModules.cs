using System;
using System.Collections.Generic;
using System.Text;
using FizzBuzz.Lib;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz
{
    public class IoCModules
    {
        public static IServiceCollection LoadAllIocModules(IServiceCollection services)
        {
            FizzBuzzDiModules.Load(services);
            return services;
        }
    }
}