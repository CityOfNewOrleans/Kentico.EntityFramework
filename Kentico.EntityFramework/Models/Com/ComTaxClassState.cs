using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComTaxClassState
    {
        public int TaxClassStateId { get; set; }
        public int TaxClassId { get; set; }
        public int StateId { get; set; }
        public double TaxValue { get; set; }

        public virtual CmsState State { get; set; }
        public virtual ComTaxClass TaxClass { get; set; }
    }
}
