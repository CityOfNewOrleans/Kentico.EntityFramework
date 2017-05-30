using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmAccountStatus
    {
        public OmAccountStatus()
        {
            OmAccount = new HashSet<OmAccount>();
        }

        public int AccountStatusId { get; set; }
        public string AccountStatusName { get; set; }
        public string AccountStatusDisplayName { get; set; }
        public string AccountStatusDescription { get; set; }

        public virtual ICollection<OmAccount> OmAccount { get; set; }
    }
}
