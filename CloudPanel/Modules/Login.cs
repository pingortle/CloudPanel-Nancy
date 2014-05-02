using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;
using Nancy.Authentication.Forms;
using CloudPanel.Persistence;
using CloudPanel.Models;

namespace CloudPanel.Modules
{
    public class Login : NancyModule
    {
        public Login()
        {
            Get["/login"] = _ => View["login"];
            Post["/login"] = x =>
                {
                    User user = null;
                    string username = Request.Form.uname;
                    string password = Request.Form.pword;
                    using (var ctx = new CloudPanelContext())
                        user = ctx.Users.FirstOrDefault(y => y.Username == username && y.Password == password);

                    if ( user != null)
                        return this.Login(user.Guid, DateTime.Now.AddMinutes(10));
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
