using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class StagingTaskGroup
    {
        public StagingTaskGroup()
        {
            StagingTaskGroupTask = new HashSet<StagingTaskGroupTask>();
            StagingTaskGroupUser = new HashSet<StagingTaskGroupUser>();
        }

        public int TaskGroupId { get; set; }
        public string TaskGroupCodeName { get; set; }
        public Guid TaskGroupGuid { get; set; }
        public string TaskGroupDescription { get; set; }

        public virtual ICollection<StagingTaskGroupTask> StagingTaskGroupTask { get; set; }
        public virtual ICollection<StagingTaskGroupUser> StagingTaskGroupUser { get; set; }
    }
}
