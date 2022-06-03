using System;

namespace NonGrateingTimer
{
    public interface ITimeFormatter
    {
        string FormatTime(TimeSpan time);
    }
}
