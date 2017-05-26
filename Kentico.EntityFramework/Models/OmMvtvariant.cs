using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmMvtvariant
    {
        public OmMvtvariant()
        {
            OmMvtcombinationVariation = new HashSet<OmMvtcombinationVariation>();
        }

        public int MvtvariantId { get; set; }
        public string MvtvariantName { get; set; }
        public string MvtvariantDisplayName { get; set; }
        public Guid? MvtvariantInstanceGuid { get; set; }
        public string MvtvariantZoneId { get; set; }
        public int MvtvariantPageTemplateId { get; set; }
        public bool MvtvariantEnabled { get; set; }
        public string MvtvariantWebParts { get; set; }
        public Guid MvtvariantGuid { get; set; }
        public DateTime MvtvariantLastModified { get; set; }
        public string MvtvariantDescription { get; set; }
        public int? MvtvariantDocumentId { get; set; }

        public virtual ICollection<OmMvtcombinationVariation> OmMvtcombinationVariation { get; set; }
        public virtual CmsPageTemplate MvtvariantPageTemplate { get; set; }
    }
}
