using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmContactStatus
    {
        public OmContactStatus()
        {
            OmContact = new HashSet<OmContact>();
        }

        public int ContactStatusId { get; set; }
        public string ContactStatusName { get; set; }
        public string ContactStatusDisplayName { get; set; }
        public string ContactStatusDescription { get; set; }

        public virtual ICollection<OmContact> OmContact { get; set; }
    }
}
