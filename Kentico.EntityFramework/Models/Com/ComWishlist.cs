using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComWishlist
    {
        public int UserId { get; set; }
        public int Skuid { get; set; }
        public int SiteId { get; set; }

        public virtual Site Site { get; set; }
        public virtual ComSku Sku { get; set; }
        public virtual User User { get; set; }
    }
}
