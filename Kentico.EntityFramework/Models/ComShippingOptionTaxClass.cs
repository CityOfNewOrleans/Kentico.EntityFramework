using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComShippingOptionTaxClass
    {
        public int ShippingOptionId { get; set; }
        public int TaxClassId { get; set; }

        public virtual ComShippingOption ShippingOption { get; set; }
        public virtual ComTaxClass TaxClass { get; set; }
    }
}
