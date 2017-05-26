using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ExportTask
    {
        public int TaskId { get; set; }
        public int? TaskSiteId { get; set; }
        public string TaskTitle { get; set; }
        public string TaskData { get; set; }
        public DateTime TaskTime { get; set; }
        public string TaskType { get; set; }
        public string TaskObjectType { get; set; }
        public int? TaskObjectId { get; set; }

        public virtual CmsSite TaskSite { get; set; }
    }
}
