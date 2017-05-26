using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsAcl
    {
        public CmsAcl()
        {
            CmsAclitem = new HashSet<CmsAclitem>();
            CmsTree = new HashSet<CmsTree>();
        }

        public int Aclid { get; set; }
        public string AclinheritedAcls { get; set; }
        public Guid Aclguid { get; set; }
        public DateTime AcllastModified { get; set; }
        public int? AclsiteId { get; set; }

        public virtual ICollection<CmsAclitem> CmsAclitem { get; set; }
        public virtual ICollection<CmsTree> CmsTree { get; set; }
        public virtual CmsSite Aclsite { get; set; }
    }
}
