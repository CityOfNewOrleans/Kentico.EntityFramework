﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsWorkflowTransition
    {
        public int TransitionId { get; set; }
        public int TransitionStartStepId { get; set; }
        public int TransitionEndStepId { get; set; }
        public int TransitionType { get; set; }
        public DateTime TransitionLastModified { get; set; }
        public Guid? TransitionSourcePointGuid { get; set; }
        public int TransitionWorkflowId { get; set; }

        public virtual CmsWorkflowStep TransitionEndStep { get; set; }
        public virtual CmsWorkflowStep TransitionStartStep { get; set; }
        public virtual CmsWorkflow TransitionWorkflow { get; set; }
    }
}
