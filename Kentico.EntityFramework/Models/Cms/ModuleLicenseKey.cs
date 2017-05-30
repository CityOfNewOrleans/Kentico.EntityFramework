using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class ModuleLicenseKey
    {
        public int ModuleLicenseKeyId { get; set; }
        public Guid ModuleLicenseKeyGuid { get; set; }
        public DateTime ModuleLicenseKeyLastModified { get; set; }
        public string ModuleLicenseKeyLicense { get; set; }
        public int ModuleLicenseKeyResourceId { get; set; }

        public virtual Resource ModuleLicenseKeyResource { get; set; }
    }
}
