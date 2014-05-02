using System;
using System.Linq;

using Nancy.Authentication.Forms;
using CloudPanel.Persistence;

namespace CloudPanel
{
    public class UserMapper : IUserMapper
    {
        public Nancy.Security.IUserIdentity GetUserFromIdentifier(Guid identifier, Nancy.NancyContext context)
        {
            UserIdentity userId = null;
            using (var ctx = new CloudPanelContext())
            {
                var user = ctx.Users.Where(x => x.Guid == identifier).FirstOrDefault();
                userId = new UserIdentity(user.Username, user.Claims.Select(x => x.Key).ToArray());
            }

            return userId;
        }
    }
}
