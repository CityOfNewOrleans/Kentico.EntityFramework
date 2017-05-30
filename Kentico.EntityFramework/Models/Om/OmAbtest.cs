using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmAbtest
    {
        public OmAbtest()
        {
            OmAbvariant = new HashSet<OmAbvariant>();
        }

        public int AbtestId { get; set; }
        public string AbtestName { get; set; }
        public string AbtestDescription { get; set; }
        public string AbtestCulture { get; set; }
        public string AbtestOriginalPage { get; set; }
        public DateTime? AbtestOpenFrom { get; set; }
        public DateTime? AbtestOpenTo { get; set; }
        public int AbtestSiteId { get; set; }
        public Guid AbtestGuid { get; set; }
        public DateTime AbtestLastModified { get; set; }
        public string AbtestDisplayName { get; set; }
        public int AbtestIncludedTraffic { get; set; }
        public string AbtestVisitorTargeting { get; set; }
        public string AbtestConversions { get; set; }
        public Guid? AbtestWinnerGuid { get; set; }

        public virtual ICollection<OmAbvariant> OmAbvariant { get; set; }
        public virtual Site AbtestSite { get; set; }
    }
}
