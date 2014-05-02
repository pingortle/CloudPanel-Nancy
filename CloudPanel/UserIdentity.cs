using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy.Security;

namespace CloudPanel
{
    public class UserIdentity : IUserIdentity
    {
        public UserIdentity(string userName, IEnumerable<string> claims)
        {
            UserName = userName;
            Claims = claims;
        }

        public IEnumerable<string> Claims { get; private set; }

        public string UserName { get; private set; }
    }
}
