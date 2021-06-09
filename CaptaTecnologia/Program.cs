using CaptaTecnologia.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace CaptaTecnologia
{
    public class Program
    {

        public static IConfigurationRoot Configuration { get; private set; }

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    // APPSETTINGS
                    var builder = new ConfigurationBuilder()
                        .SetBasePath(string.Concat(hostContext.HostingEnvironment.ContentRootPath, hostContext.HostingEnvironment.IsDevelopment() ? "/Develop" : "/config"))
                        .AddJsonFile("application.json", optional: true, reloadOnChange: true)
                        .AddCommandLine(args)
                        .AddEnvironmentVariables();

                    Configuration = builder.Build();

                    ConfigurationServices.AddConfigurationServices(services, Configuration);
                    InjectionDependencySettings.AddInjectionDependencyConfiguration(services);

                    services.AddHostedService<Worker>();

                });
    }
}
