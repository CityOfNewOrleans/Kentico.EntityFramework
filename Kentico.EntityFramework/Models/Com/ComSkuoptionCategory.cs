﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComSkuoptionCategory
    {
        public int Skuid { get; set; }
        public int CategoryId { get; set; }
        public bool? AllowAllOptions { get; set; }
        public int SkucategoryId { get; set; }
        public int? SkucategoryOrder { get; set; }

        public virtual ComOptionCategory Category { get; set; }
        public virtual ComSku Sku { get; set; }
    }
}
