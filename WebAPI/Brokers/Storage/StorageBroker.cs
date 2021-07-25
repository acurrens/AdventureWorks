using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Brokers.Logging;

namespace WebAPI.Brokers.Storage
{
    public partial class StorageBroker : IStorageBroker   
    {
        private readonly IConfiguration configuration;
        private readonly ILoggingBroker logger;
        public StorageBroker(IConfiguration configuration, ILoggingBroker loggingBroker)
        {
            this.configuration = configuration;
            this.logger = loggingBroker;    
        }
    }
}
