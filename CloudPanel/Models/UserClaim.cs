using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudPanel.Models
{
    public class UserClaim
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int ClaimId { get; set; }
        public virtual Claim Claim { get; set; }
    }
}
