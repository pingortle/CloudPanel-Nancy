using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Nancy.Security;

namespace CloudPanel
{
    public class UserIdentity : IUserIdentity
    {
        public IEnumerable<string> Claims
        {
            get { return new[] { "Admin", }; }
        }

        public string UserName
        {
            get { return "Default"; }
        }
    }
}
