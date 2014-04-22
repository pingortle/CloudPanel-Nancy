using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;

namespace CloudPanel
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = _ => "Welcome to CloudPanel!";

            Get["/login"] = _ => "Username: ________\n Password: ________";

            Get["/dashboard"] = _ => "This is the dashboard.";
        }
    }
}