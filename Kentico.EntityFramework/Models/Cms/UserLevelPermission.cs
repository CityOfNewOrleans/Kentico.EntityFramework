using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class UserLevelPermission
    {
        public UserLevelPermission()
        {
            CmsAclitem = new HashSet<UserLevelPermissionItem>();
            CmsTree = new HashSet<Tree>();
        }

        public int Aclid { get; set; }
        public string AclinheritedAcls { get; set; }
        public Guid Aclguid { get; set; }
        public DateTime AcllastModified { get; set; }
        public int? AclsiteId { get; set; }

        public virtual ICollection<UserLevelPermissionItem> CmsAclitem { get; set; }
        public virtual ICollection<Tree> CmsTree { get; set; }
        public virtual Site Aclsite { get; set; }
    }
}
