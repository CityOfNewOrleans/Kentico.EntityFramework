using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmContactRole
    {
        public OmContactRole()
        {
            OmAccountContact = new HashSet<OmAccountContact>();
        }

        public int ContactRoleId { get; set; }
        public string ContactRoleName { get; set; }
        public string ContactRoleDisplayName { get; set; }
        public string ContactRoleDescription { get; set; }

        public virtual ICollection<OmAccountContact> OmAccountContact { get; set; }
    }
}
