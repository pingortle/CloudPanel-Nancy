using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;

namespace CloudPanel.Modules
{
    public class Root : NancyModule
    {
        public Root()
        {
            Get["/"] = _ => "Welcome to CloudPanel!";
        }
    }
}
