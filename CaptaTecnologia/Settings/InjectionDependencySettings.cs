using CaptaTecnologia.Application;
using CaptaTecnologia.Models.Interfaces;
using CaptaTecnologia.Repository;
using CaptaTecnologia.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptaTecnologia.Settings
{
    public static class InjectionDependencySettings
    {
        public static void AddInjectionDependencyConfiguration(IServiceCollection services)
        {
            // COMMANDS
            services.AddTransient<IServiceMoedas, ServiceMoedas>();
            services.AddTransient<IRepositoryMoedas, RepositoryMoedas>();
            services.AddTransient<IAppExecute, AppExecute>();
            services.RemoveAll<IHttpMessageHandlerBuilderFilter>();
        }
    }
}
