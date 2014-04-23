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

            Get["/settings"] = _ => View["settings"];
        }
    }
}
