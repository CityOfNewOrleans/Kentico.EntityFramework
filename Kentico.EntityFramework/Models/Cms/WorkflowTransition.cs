using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WorkflowTransition
    {
        public int TransitionId { get; set; }
        public int TransitionStartStepId { get; set; }
        public int TransitionEndStepId { get; set; }
        public int TransitionType { get; set; }
        public DateTime TransitionLastModified { get; set; }
        public Guid? TransitionSourcePointGuid { get; set; }
        public int TransitionWorkflowId { get; set; }

        public virtual WorkflowStep TransitionEndStep { get; set; }
        public virtual WorkflowStep TransitionStartStep { get; set; }
        public virtual Workflow TransitionWorkflow { get; set; }
    }
}
