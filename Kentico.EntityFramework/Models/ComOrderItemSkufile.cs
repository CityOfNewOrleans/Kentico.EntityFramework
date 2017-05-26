using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComOrderItemSkufile
    {
        public int OrderItemSkufileId { get; set; }
        public Guid Token { get; set; }
        public int OrderItemId { get; set; }
        public int FileId { get; set; }

        public virtual ComSkufile File { get; set; }
        public virtual ComOrderItem OrderItem { get; set; }
    }
}
