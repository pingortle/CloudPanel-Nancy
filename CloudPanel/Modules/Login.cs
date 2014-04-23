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
            Post["/login"] = x =>
                {
                    if (Request.Form.uname == "admin" && Request.Form.pword == "admin")
                        return this.LoginAndRedirect(Guid.NewGuid(), null, "dashboard");
                    else
                    {
                        ViewBag.message = "Failed!";
                        return View["login"];
                    }
                };

            Get["/logout"] = _ => this.Logout("/");
        }
    }
}
