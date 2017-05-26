using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComSkutaxClasses
    {
        public int Skuid { get; set; }
        public int TaxClassId { get; set; }

        public virtual ComSku Sku { get; set; }
        public virtual ComTaxClass TaxClass { get; set; }
    }
}
