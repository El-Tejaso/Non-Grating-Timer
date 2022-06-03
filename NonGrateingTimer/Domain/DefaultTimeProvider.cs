using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGrateingTimer.Domain
{
    public class DefaultTimeProvider : IDateTimeProvider
    {
        public DateTime Now()
        {
            return DateTime.UtcNow;
        }
    }
}
