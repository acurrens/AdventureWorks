using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Brokers.DateTime
{
    public class DateTimeBroker : IDateTimeBroker
    {
        public DateTimeOffset GetCurrentDateTime()
        {
            return DateTimeOffset.UtcNow;
        }
        public string GetCurrentDateTimeString()
        {
            return GetCurrentDateTime().ToString("MM-dd-yyyy hh:mm:ss");
        }
    }
}
