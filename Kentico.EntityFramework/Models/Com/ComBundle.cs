using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComBundle
    {
        public int BundleId { get; set; }
        public int Skuid { get; set; }

        public virtual ComSku Bundle { get; set; }
        public virtual ComSku Sku { get; set; }
    }
}
