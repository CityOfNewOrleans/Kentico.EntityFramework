using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class IntegrationTask
    {
        public IntegrationTask()
        {
            IntegrationSynchronization = new HashSet<IntegrationSynchronization>();
        }

        public int TaskId { get; set; }
        public int? TaskNodeId { get; set; }
        public int? TaskDocumentId { get; set; }
        public string TaskNodeAliasPath { get; set; }
        public string TaskTitle { get; set; }
        public DateTime TaskTime { get; set; }
        public string TaskType { get; set; }
        public string TaskObjectType { get; set; }
        public int? TaskObjectId { get; set; }
        public bool TaskIsInbound { get; set; }
        public string TaskProcessType { get; set; }
        public string TaskData { get; set; }
        public int? TaskSiteId { get; set; }
        public string TaskDataType { get; set; }

        public virtual ICollection<IntegrationSynchronization> IntegrationSynchronization { get; set; }
        public virtual CmsSite TaskSite { get; set; }
    }
}
