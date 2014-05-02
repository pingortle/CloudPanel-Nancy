using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;
using Nancy.Security;

namespace CloudPanel.Modules
{
    public class AuthRoot : NancyModule
    {
        public AuthRoot()
        {
            this.RequiresAuthentication();
            this.RequiresClaims(new[] { "Admin", });

            Get["/settings"] = _ => View["settings"];
        }
    }
}
