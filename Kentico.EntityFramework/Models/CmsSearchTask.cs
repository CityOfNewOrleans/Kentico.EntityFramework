using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsSearchTask
    {
        public int SearchTaskId { get; set; }
        public string SearchTaskType { get; set; }
        public string SearchTaskObjectType { get; set; }
        public string SearchTaskField { get; set; }
        public string SearchTaskValue { get; set; }
        public string SearchTaskServerName { get; set; }
        public string SearchTaskStatus { get; set; }
        public int SearchTaskPriority { get; set; }
        public DateTime SearchTaskCreated { get; set; }
        public string SearchTaskErrorMessage { get; set; }
        public int? SearchTaskRelatedObjectId { get; set; }
    }
}
