using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsState
    {
        public CmsState()
        {
            ComAddress = new HashSet<ComAddress>();
            ComCustomer = new HashSet<ComCustomer>();
            ComOrderAddress = new HashSet<ComOrderAddress>();
            ComTaxClassState = new HashSet<ComTaxClassState>();
            OmAccount = new HashSet<OmAccount>();
            OmContact = new HashSet<OmContact>();
        }

        public int StateId { get; set; }
        public string StateDisplayName { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public int CountryId { get; set; }
        public Guid StateGuid { get; set; }
        public DateTime StateLastModified { get; set; }

        public virtual ICollection<ComAddress> ComAddress { get; set; }
        public virtual ICollection<ComCustomer> ComCustomer { get; set; }
        public virtual ICollection<ComOrderAddress> ComOrderAddress { get; set; }
        public virtual ICollection<ComTaxClassState> ComTaxClassState { get; set; }
        public virtual ICollection<OmAccount> OmAccount { get; set; }
        public virtual ICollection<OmContact> OmContact { get; set; }
        public virtual CmsCountry Country { get; set; }
    }
}
