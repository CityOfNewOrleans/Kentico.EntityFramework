using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class StagingTaskUser
    {
        public int TaskUserId { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }

        public virtual StagingTask Task { get; set; }
        public virtual CmsUser User { get; set; }
    }
}
