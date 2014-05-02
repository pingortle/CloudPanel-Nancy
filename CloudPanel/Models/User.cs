using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudPanel.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public Guid Guid { get; set; }

        public virtual IList<Claim> Claims { get; set; }
    }
}
