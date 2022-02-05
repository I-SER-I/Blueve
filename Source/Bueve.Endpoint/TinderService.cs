using System;
using System.Threading;
using System.Threading.Tasks;
using Blueve.TinderApi;
using Microsoft.Extensions.Hosting;

namespace Blueve.Endpoint
{
    public class TinderService : BackgroundService
    {
        private readonly IHostApplicationLifetime _applicationLifetime;
        private readonly ITinderClient _tinderClient;

        public TinderService(ITinderClient tinderClient, IHostApplicationLifetime applicationLifetime)
        {
            _applicationLifetime = applicationLifetime;
            _tinderClient = tinderClient;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                
            }
            catch (TaskCanceledException exception) when (stoppingToken.IsCancellationRequested)
            {
                throw new Exception("Stop App: ", exception);
            }
        }
    }
}