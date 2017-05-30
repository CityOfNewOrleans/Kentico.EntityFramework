using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class StagingTask
    {
        public StagingTask()
        {
            StagingSynchronization = new HashSet<StagingSynchronization>();
            StagingTaskGroupTask = new HashSet<StagingTaskGroupTask>();
            StagingTaskUser = new HashSet<StagingTaskUser>();
        }

        public int TaskId { get; set; }
        public int? TaskSiteId { get; set; }
        public int? TaskDocumentId { get; set; }
        public string TaskNodeAliasPath { get; set; }
        public string TaskTitle { get; set; }
        public string TaskData { get; set; }
        public DateTime TaskTime { get; set; }
        public string TaskType { get; set; }
        public string TaskObjectType { get; set; }
        public int? TaskObjectId { get; set; }
        public bool? TaskRunning { get; set; }
        public int? TaskNodeId { get; set; }
        public string TaskServers { get; set; }

        public virtual ICollection<StagingSynchronization> StagingSynchronization { get; set; }
        public virtual ICollection<StagingTaskGroupTask> StagingTaskGroupTask { get; set; }
        public virtual ICollection<StagingTaskUser> StagingTaskUser { get; set; }
        public virtual Site TaskSite { get; set; }
    }
}
