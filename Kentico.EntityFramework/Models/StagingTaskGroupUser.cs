﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class StagingTaskGroupUser
    {
        public int TaskGroupUserId { get; set; }
        public int TaskGroupId { get; set; }
        public int UserId { get; set; }

        public virtual StagingTaskGroup TaskGroup { get; set; }
        public virtual CmsUser User { get; set; }
    }
}
