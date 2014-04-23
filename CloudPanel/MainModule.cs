using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;
using Nancy.Authentication.Forms;

namespace CloudPanel
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = _ => "Welcome to CloudPanel!";

            Get["/login"] = _ => View["login"];
            Post["/login"] = _ => this.LoginAndRedirect(Guid.NewGuid(), null, "dashboard");

            Get["/logout"] = _ => this.Logout("/");

            Get["/dashboard"] = _ => View["dashboard"];
        }
    }
}
