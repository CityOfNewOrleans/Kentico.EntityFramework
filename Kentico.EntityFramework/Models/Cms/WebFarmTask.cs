using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WebFarmTask
    {
        public WebFarmTask()
        {
            CmsWebFarmServerTask = new HashSet<WebFarmServerTask>();
        }

        public int TaskId { get; set; }
        public string TaskType { get; set; }
        public string TaskTextData { get; set; }
        public byte[] TaskBinaryData { get; set; }
        public DateTime? TaskCreated { get; set; }
        public string TaskTarget { get; set; }
        public string TaskMachineName { get; set; }
        public Guid? TaskGuid { get; set; }
        public bool? TaskIsAnonymous { get; set; }
        public string TaskErrorMessage { get; set; }
        public bool? TaskIsMemory { get; set; }

        public virtual ICollection<WebFarmServerTask> CmsWebFarmServerTask { get; set; }
    }
}
