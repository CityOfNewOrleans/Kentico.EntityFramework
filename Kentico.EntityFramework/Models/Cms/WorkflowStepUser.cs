using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WorkflowStepUser
    {
        public int WorkflowStepUserId { get; set; }
        public int StepId { get; set; }
        public int UserId { get; set; }
        public Guid? StepSourcePointGuid { get; set; }

        public virtual WorkflowStep Step { get; set; }
        public virtual User User { get; set; }
    }
}
