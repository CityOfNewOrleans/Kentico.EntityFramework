using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComTaxClassCountry
    {
        public int TaxClassCountryId { get; set; }
        public int TaxClassId { get; set; }
        public int CountryId { get; set; }
        public double TaxValue { get; set; }

        public virtual CmsCountry Country { get; set; }
        public virtual ComTaxClass TaxClass { get; set; }
    }
}
