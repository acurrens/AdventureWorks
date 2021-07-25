using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Brokers.Logging
{
    public class LoggingBroker : ILoggingBroker
    {
        private readonly ILogger _logger;
        public LoggingBroker(ILogger logger)
        {
            _logger = logger;
        }

        public void Critical(Exception exception)
        {
            _logger.LogCritical(exception, exception.Message);
        }

        public void Debug(string message)
        {
            _logger.LogDebug(message);
        }

        public void Error(Exception exception)
        {
            _logger.LogError(exception, exception.Message);
        }

        public void Information(string message)
        {
            _logger.LogInformation(message);
        }

        public void Trace(string message)
        {
            _logger.LogTrace(message);
        }

        public void Warning(string message)
        {
            _logger.LogWarning(message);
        }
    }
}
