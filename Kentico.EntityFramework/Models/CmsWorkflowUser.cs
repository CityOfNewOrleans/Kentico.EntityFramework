using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsWorkflowUser
    {
        public int WorkflowId { get; set; }
        public int UserId { get; set; }

        public virtual CmsUser User { get; set; }
        public virtual CmsWorkflow Workflow { get; set; }
    }
}
