using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsWebPartContainer
    {
        public CmsWebPartContainer()
        {
            CmsWebPartContainerSite = new HashSet<CmsWebPartContainerSite>();
        }

        public int ContainerId { get; set; }
        public string ContainerDisplayName { get; set; }
        public string ContainerName { get; set; }
        public string ContainerTextBefore { get; set; }
        public string ContainerTextAfter { get; set; }
        public Guid ContainerGuid { get; set; }
        public DateTime ContainerLastModified { get; set; }
        public string ContainerCss { get; set; }

        public virtual ICollection<CmsWebPartContainerSite> CmsWebPartContainerSite { get; set; }
    }
}
