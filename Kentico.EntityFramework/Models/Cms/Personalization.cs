using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Personalization
    {
        public int PersonalizationId { get; set; }
        public Guid PersonalizationGuid { get; set; }
        public DateTime PersonalizationLastModified { get; set; }
        public int? PersonalizationUserId { get; set; }
        public int? PersonalizationDocumentId { get; set; }
        public string PersonalizationWebParts { get; set; }
        public string PersonalizationDashboardName { get; set; }
        public int? PersonalizationSiteId { get; set; }

        public virtual Document PersonalizationDocument { get; set; }

#       warning Figure out new name for Personalization.Personalization
        //public virtual Personalization Personalization { get; set; }
        public virtual Personalization InversePersonalization { get; set; }
        public virtual Site PersonalizationSite { get; set; }
        public virtual User PersonalizationUser { get; set; }
    }
}
