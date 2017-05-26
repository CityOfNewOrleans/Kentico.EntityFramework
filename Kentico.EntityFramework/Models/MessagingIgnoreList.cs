using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class MessagingIgnoreList
    {
        public int IgnoreListUserId { get; set; }
        public int IgnoreListIgnoredUserId { get; set; }

        public virtual CmsUser IgnoreListIgnoredUser { get; set; }
        public virtual CmsUser IgnoreListUser { get; set; }
    }
}
