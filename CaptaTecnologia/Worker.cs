using CaptaTecnologia.Models.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CaptaTecnologia
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IAppExecute _services;
        private readonly IHostApplicationLifetime _hostApplicationLifetime;

        public Worker(IHostApplicationLifetime hostApplicationLifetime, ILogger<Worker> logger, IServiceScopeFactory factory)
        {
            _logger = logger;
            _hostApplicationLifetime = hostApplicationLifetime;
            _services = factory.CreateScope().ServiceProvider.GetRequiredService<IAppExecute>();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await _services.Start();
            _hostApplicationLifetime.StopApplication();
        }
    }
}
