using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGrateingTimer.Domain {
    public class DefaultTimeFormatter : ITimeFormatter {
        public string FormatTime(TimeSpan time) {
            string timeString = ""
            + time.Hours.ToString("0h") + ":"
            + time.Minutes.ToString("00m") + ":"
            + time.Seconds.ToString("00s") + ":"
            + time.Milliseconds.ToString("000ms");

            return timeString;
        }
    }
}
