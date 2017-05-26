using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class StagingTaskGroupTask
    {
        public int TaskGroupTaskId { get; set; }
        public int TaskGroupId { get; set; }
        public int TaskId { get; set; }

        public virtual StagingTaskGroup TaskGroup { get; set; }
        public virtual StagingTask Task { get; set; }
    }
}
