using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PauseMe
{
    public static class TimeSpanExtension
    {
        public static string ToShortString(this TimeSpan ts)
        {
            string formatstring = "";
            if (ts.Hours != 0)
                formatstring = string.Join("' '", formatstring, "h'h'");

            if (ts.Minutes != 0)
                formatstring = string.Join("' '", formatstring, "m'm'");

            formatstring = string.Join("' '", formatstring, "s's'");
            return ts.ToString(formatstring);
        }
    }
}
