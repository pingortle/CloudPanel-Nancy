using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudPanel.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string Key { get; set; }

        public virtual IList<User> Users { get; set; }
    }
}