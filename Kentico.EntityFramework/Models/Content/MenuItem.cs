using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Content
{
    public partial class MenuItem
    {
        public int MenuItemId { get; set; }
        public string MenuItemName { get; set; }
        public Guid? MenuItemTeaserImage { get; set; }
        public string MenuItemGroup { get; set; }
    }
}
