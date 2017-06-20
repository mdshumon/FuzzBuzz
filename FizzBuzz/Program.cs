using System;
using FizzBuzz.Lib;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz
{
    class Program
    {
        static IServiceCollection services = new ServiceCollection();
        static IServiceProvider IoC { get; set; }
        public Program()
        {
        }
        static void Main(string[] args)
        {
            services = IoCModules.LoadAllIocModules(services);
            IoC = services.BuildServiceProvider();
            var fbi = IoC.GetService<FizzBuzzCalc>();
            //testing loop
            for (int i = 0; i <= 100; i++)
                Console.WriteLine(fbi.FizzOrBuzz(i));
            Console.ReadKey();
        }
    }
}