using CaptaTecnologiaAPI.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaptaTecnologiaAPI.Settings
{
    public static class ConfigurationServices
    {
        public static void AddConfigurationServices(this IServiceCollection services, IConfiguration configuration)
        {

            //CONFIGURATION
            services.Configure<AppConfiguration>(configuration);
        }
    }
}