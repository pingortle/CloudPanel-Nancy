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

            TimeoutMilliseconds = HttpContext.Current.Session.Timeout * 60 * 1000;
            TimeoutMilliseconds = (HttpContext.Current.Session.Timeout - 2) * 60 * 1000;
        }

        public static string AppName { get; set; }

        public static int TimeoutMilliseconds { get; set; }
        public static int TimeoutWarningMilliseconds { get; set; }
    }
}