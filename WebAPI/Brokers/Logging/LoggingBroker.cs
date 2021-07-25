using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Brokers.DateTime;

namespace WebAPI.Brokers.Logging
{
    public class LoggingBroker : ILoggingBroker
    {
        private readonly ILogger _logger;
        private readonly IDateTimeBroker _dateTimeBroker;
        public LoggingBroker(ILogger logger, IDateTimeBroker dateTimeBroker)
        {
            _logger = logger;
            _dateTimeBroker = dateTimeBroker;
        }

        public void Critical(Exception exception)
        {
            _logger.LogCritical(exception, exception.Message);
        }

        public void Debug(string message)
        {
            message = _dateTimeBroker.GetCurrentDateTimeString() + " | " + message;
            _logger.LogDebug(message);
        }

        public void Error(Exception exception)
        {
            _logger.LogError(exception, exception.Message);
        }

        public void Information(string message)
        {
            message = _dateTimeBroker.GetCurrentDateTimeString() + " | " + message;
            _logger.LogInformation(message);
        }

        public void Trace(string message)
        {
            message = _dateTimeBroker.GetCurrentDateTimeString() + " | " + message;
            _logger.LogTrace(message);
        }

        public void Warning(string message)
        {
            message = _dateTimeBroker.GetCurrentDateTimeString() + " | " + message;
            _logger.LogWarning(message);
        }
    }
}
