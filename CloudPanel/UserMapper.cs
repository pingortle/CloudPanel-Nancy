using System;

using Nancy.Authentication.Forms;

namespace CloudPanel
{
    public class UserMapper : IUserMapper
    {
        public Nancy.Security.IUserIdentity GetUserFromIdentifier(Guid identifier, Nancy.NancyContext context)
        {
            return new UserIdentity();
        }
    }
}
