using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsSiteDomainAlias
    {
        public int SiteDomainAliasId { get; set; }
        public string SiteDomainAliasName { get; set; }
        public int SiteId { get; set; }
        public string SiteDefaultVisitorCulture { get; set; }
        public Guid? SiteDomainGuid { get; set; }
        public DateTime SiteDomainLastModified { get; set; }
        public string SiteDomainDefaultAliasPath { get; set; }
        public string SiteDomainRedirectUrl { get; set; }

        public virtual CmsSite Site { get; set; }
    }
}
