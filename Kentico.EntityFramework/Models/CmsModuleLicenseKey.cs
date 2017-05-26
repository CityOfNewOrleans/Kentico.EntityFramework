using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsModuleLicenseKey
    {
        public int ModuleLicenseKeyId { get; set; }
        public Guid ModuleLicenseKeyGuid { get; set; }
        public DateTime ModuleLicenseKeyLastModified { get; set; }
        public string ModuleLicenseKeyLicense { get; set; }
        public int ModuleLicenseKeyResourceId { get; set; }

        public virtual CmsResource ModuleLicenseKeyResource { get; set; }
    }
}
