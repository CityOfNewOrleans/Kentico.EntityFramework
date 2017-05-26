using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class BoardModerator
    {
        public int BoardId { get; set; }
        public int UserId { get; set; }

        public virtual BoardBoard Board { get; set; }
        public virtual CmsUser User { get; set; }
    }
}
