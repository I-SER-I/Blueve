using System;
using System.Linq;
using Blueve.TinderApi;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Blueve.Endpoint
{
    public class Program
    {
        public static String Token { get; set; }

        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        static IHostBuilder CreateHostBuilder(String[] arguments)
        {
            Token = arguments.First();
            return Host.CreateDefaultBuilder(arguments).ConfigureServices(ConfigureServices);
        }

        static void ConfigureServices(HostBuilderContext builder, IServiceCollection services)
        {
            services
                .AddSingleton<ITinderClient>(new TinderClient(Token))
                .AddHostedService<TinderService>();
        }
    }
}