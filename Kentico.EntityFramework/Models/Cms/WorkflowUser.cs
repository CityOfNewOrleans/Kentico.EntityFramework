using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WorkflowUser
    {
        public int WorkflowId { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual Workflow Workflow { get; set; }
    }
}
