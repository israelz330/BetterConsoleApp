using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

//DE, Serilog, Settings

namespace ConsoleUI
{
    partial class Program
    {
        public class GreetingService : IGreetingService
        {
            private readonly ILogger<GreetingService> _log;
            private readonly IConfiguration _config;

            public GreetingService(ILogger<GreetingService> log, IConfiguration config)
            {
                _log = log;
                _config = config;
            }
            public void Run()
            {
                for (int i = 0; i < _config.GetValue<int>("LoopTimes"); i++)
                {
                    //This is #_
                    _log.LogWarning("Run number {runNumber}", i);
                }
            }
        }
    }
}
