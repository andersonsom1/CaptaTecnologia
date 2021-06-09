using CaptaTecnologia.Handler;
using CaptaTecnologia.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;
using CaptaTecnologia.Models.Interfaces;
using System.Net.Http.Headers;

namespace CaptaTecnologia.Settings
{
    public static class ConfigurationServices
    {
        public static void AddConfigurationServices(this IServiceCollection services, IConfigurationRoot configuration)
        {

            //CONFIGURATION
            services.Configure<AppConfiguration>(configuration);
            services.AddTransient<HttpClientAuthorizationDelegatingHandler>();

            // REFIT - CLIENT
            ConfigurationRefitClient(services, configuration);
        }

        private static void ConfigurationRefitClient(IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddHttpClient("BCBApiService", client =>
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(configuration.GetSection("UrlBaseBCB").Value);
            })
           .AddHttpMessageHandler<HttpClientAuthorizationDelegatingHandler>()
           .AddTypedClient(RestService.For<IBCBService>);

        }
    }
}
