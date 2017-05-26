using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComMultiBuyDiscountSku
    {
        public int MultiBuyDiscountId { get; set; }
        public int Skuid { get; set; }

        public virtual ComMultiBuyDiscount MultiBuyDiscount { get; set; }
        public virtual ComSku Sku { get; set; }
    }
}
