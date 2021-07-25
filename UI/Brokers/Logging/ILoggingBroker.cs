using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Brokers.Logging
{
    public interface ILoggingBroker
    {
        void Information(string message);
        void Trace(string message);
        void Debug(string message);
        void Warning(string message);
        void Error(Exception exception);
        void Critical(Exception exception);

    }
}
