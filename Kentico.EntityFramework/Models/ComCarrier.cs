using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComCarrier
    {
        public ComCarrier()
        {
            ComShippingOption = new HashSet<ComShippingOption>();
        }

        public int CarrierId { get; set; }
        public string CarrierDisplayName { get; set; }
        public string CarrierName { get; set; }
        public int CarrierSiteId { get; set; }
        public Guid CarrierGuid { get; set; }
        public string CarrierAssemblyName { get; set; }
        public string CarrierClassName { get; set; }
        public DateTime CarrierLastModified { get; set; }

        public virtual ICollection<ComShippingOption> ComShippingOption { get; set; }
        public virtual CmsSite CarrierSite { get; set; }
    }
}
