using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudPanel
{
    public static class GlobalSettings
    {
        static GlobalSettings()
        {
            AppName = "CloudPanel";

            TimeoutMilliseconds = 10 * 60 * 1000;
            TimeoutWarningMilliseconds = 8 * 60 * 1000;
        }

        public static string AppName { get; set; }

        public static int TimeoutMilliseconds { get; set; }
        public static int TimeoutWarningMilliseconds { get; set; }
    }
}