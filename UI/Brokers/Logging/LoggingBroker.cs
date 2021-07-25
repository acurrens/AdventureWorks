using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Brokers.Logging
{
    public class LoggingBroker : ILoggingBroker
    {
        private readonly ILogger _logger;  
        public LoggingBroker(ILogger logger)
        {
            _logger = logger;
        }

        public void LogCritical(Exception exception)
        {
            _logger.LogCritical(exception, exception.Message);
        }

        public void LogDebug(string message)
        {
            _logger.LogDebug(message);
        }

        public void LogError(Exception exception)
        {
            _logger.LogError(exception, exception.Message);
        }

        public void LogInformation(string message)
        {
            _logger.LogInformation(message);
        }

        public void LogTrace(string message)
        {
            _logger.LogTrace(message);
        }

        public void LogWarning(string message)
        {
            _logger.LogWarning(message);
        }
    }
}
