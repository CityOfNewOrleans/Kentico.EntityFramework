using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WebPartContainer
    {
        public WebPartContainer()
        {
            CmsWebPartContainerSite = new HashSet<WebPartContainerSite>();
        }

        public int ContainerId { get; set; }
        public string ContainerDisplayName { get; set; }
        public string ContainerName { get; set; }
        public string ContainerTextBefore { get; set; }
        public string ContainerTextAfter { get; set; }
        public Guid ContainerGuid { get; set; }
        public DateTime ContainerLastModified { get; set; }
        public string ContainerCss { get; set; }

        public virtual ICollection<WebPartContainerSite> CmsWebPartContainerSite { get; set; }
    }
}
