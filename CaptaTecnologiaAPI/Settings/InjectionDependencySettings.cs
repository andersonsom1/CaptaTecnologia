using CaptaTecnologiaAPI.Models.Interfaces;
using CaptaTecnologiaAPI.Repository;
using CaptaTecnologiaAPI.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaptaTecnologiaAPI.Settings
{
    public static class InjectionDependencySettings
    {
        public static void AddInjectionDependencyConfiguration(IServiceCollection services)
        {
            // COMMANDS
            services.AddTransient<IServiceCotacaoMoeda, ServiceCotacaoMoeda>();
            services.AddTransient<IRepositoryCotacaoMoedas, RepositoryCotacaoMoedas>();
        }
    }

}
