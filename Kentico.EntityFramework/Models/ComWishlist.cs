using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComWishlist
    {
        public int UserId { get; set; }
        public int Skuid { get; set; }
        public int SiteId { get; set; }

        public virtual CmsSite Site { get; set; }
        public virtual ComSku Sku { get; set; }
        public virtual CmsUser User { get; set; }
    }
}
