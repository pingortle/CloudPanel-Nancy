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

            Get["/random"] = _ =>
                {
                    User user = null;

                    using (var db = new CloudPanel.Persistence.CloudPanelContext())
                    {

                        db.Database.CreateIfNotExists();

                        db.Set<User>().Add(user = new User { Guid = Guid.NewGuid(), Username = "bill" });

                        db.SaveChanges();
                    }
                    return user == null ? "NULL" :  string.Format("Username: {0}, Guid: {1}", user.Username, user.Guid.ToString());
                };
        }
    }
}
