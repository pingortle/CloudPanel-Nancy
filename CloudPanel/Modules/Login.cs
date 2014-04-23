using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;
using Nancy.Authentication.Forms;

namespace CloudPanel.Modules
{
    public class Login : NancyModule
    {
        public Login()
        {
            Get["/login"] = _ => View["login"];
            Post["/login"] = _ => this.LoginAndRedirect(Guid.NewGuid(), null, "dashboard");

            Get["/logout"] = _ => this.Logout("/");
        }
    }
}