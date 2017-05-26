using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComVariantOption
    {
        public int VariantSkuid { get; set; }
        public int OptionSkuid { get; set; }

        public virtual ComSku OptionSku { get; set; }
        public virtual ComSku VariantSku { get; set; }
    }
}
