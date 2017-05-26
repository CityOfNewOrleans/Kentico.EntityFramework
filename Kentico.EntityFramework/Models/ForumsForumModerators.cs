using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ForumsForumModerators
    {
        public int UserId { get; set; }
        public int ForumId { get; set; }

        public virtual ForumsForum Forum { get; set; }
        public virtual CmsUser User { get; set; }
    }
}
