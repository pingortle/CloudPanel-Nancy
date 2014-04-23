using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;
using Nancy.Security;

namespace CloudPanel.Modules
{
    public class Dashboard : NancyModule
    {
        public Dashboard()
            : base("/dashboard")
        {
            this.RequiresAuthentication();

#if !DEBUG
            this.RequiresHttps(true);
#endif

            Get["/"] = _ => View["dashboard"];
        }
    }
}
