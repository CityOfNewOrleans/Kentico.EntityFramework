using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Country
    {
        public Country()
        {
            CmsState = new HashSet<State>();
            ComAddress = new HashSet<ComAddress>();
            ComCustomer = new HashSet<ComCustomer>();
            ComOrderAddress = new HashSet<ComOrderAddress>();
            ComTaxClassCountry = new HashSet<ComTaxClassCountry>();
            OmAccount = new HashSet<OmAccount>();
            OmContact = new HashSet<OmContact>();
        }

        public int CountryId { get; set; }
        public string CountryDisplayName { get; set; }
        public string CountryName { get; set; }
        public Guid CountryGuid { get; set; }
        public DateTime CountryLastModified { get; set; }
        public string CountryTwoLetterCode { get; set; }
        public string CountryThreeLetterCode { get; set; }

        public virtual ICollection<State> CmsState { get; set; }
        public virtual ICollection<ComAddress> ComAddress { get; set; }
        public virtual ICollection<ComCustomer> ComCustomer { get; set; }
        public virtual ICollection<ComOrderAddress> ComOrderAddress { get; set; }
        public virtual ICollection<ComTaxClassCountry> ComTaxClassCountry { get; set; }
        public virtual ICollection<OmAccount> OmAccount { get; set; }
        public virtual ICollection<OmContact> OmContact { get; set; }
    }
}
