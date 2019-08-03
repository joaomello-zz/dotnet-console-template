using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Mello.ConsoleTemplate
{
    class App
    {
        private readonly ILogger<App> _logger;
        private readonly IOptionsMonitor<AppSettings> _appSettings;

        public App(ILogger<App> logger, IOptionsMonitor<AppSettings> appSettings)
        {
            _logger = logger;
            _appSettings = appSettings;
        }

        public Task Run()
        {
            _logger.LogInformation($"Run: {_appSettings.CurrentValue.ConsoleTitle}");
            return Task.FromResult(0);
        }
    }
}