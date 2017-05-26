using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ContentMenuItem
    {
        public int MenuItemId { get; set; }
        public string MenuItemName { get; set; }
        public Guid? MenuItemTeaserImage { get; set; }
        public string MenuItemGroup { get; set; }
    }
}
