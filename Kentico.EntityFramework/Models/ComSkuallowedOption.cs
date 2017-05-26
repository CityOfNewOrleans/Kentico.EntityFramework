using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComSkuallowedOption
    {
        public int OptionSkuid { get; set; }
        public int Skuid { get; set; }

        public virtual ComSku OptionSku { get; set; }
        public virtual ComSku Sku { get; set; }
    }
}
