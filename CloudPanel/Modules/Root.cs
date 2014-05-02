using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy;
using CloudPanel.Models;

namespace CloudPanel.Modules
{
    public class Root : NancyModule
    {
        public Root()
        {
            Get["/", ctx => ctx.CurrentUser == null] = _ => Response.AsRedirect("~/login");
            Get["/", ctx => ctx.CurrentUser != null] = _ => Response.AsRedirect("~/dashboard");
        }
    }
}
