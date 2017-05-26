using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComOrderAddress
    {
        public ComOrderAddress()
        {
            ComOrderOrderBillingAddress = new HashSet<ComOrder>();
            ComOrderOrderCompanyAddress = new HashSet<ComOrder>();
            ComOrderOrderShippingAddress = new HashSet<ComOrder>();
        }

        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressCity { get; set; }
        public string AddressZip { get; set; }
        public string AddressPhone { get; set; }
        public int AddressCountryId { get; set; }
        public int? AddressStateId { get; set; }
        public string AddressPersonalName { get; set; }
        public Guid? AddressGuid { get; set; }
        public DateTime AddressLastModified { get; set; }

        public virtual ICollection<ComOrder> ComOrderOrderBillingAddress { get; set; }
        public virtual ICollection<ComOrder> ComOrderOrderCompanyAddress { get; set; }
        public virtual ICollection<ComOrder> ComOrderOrderShippingAddress { get; set; }
        public virtual CmsCountry AddressCountry { get; set; }
        public virtual CmsState AddressState { get; set; }
    }
}
