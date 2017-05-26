﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsWorkflowStepRoles
    {
        public int WorkflowStepRoleId { get; set; }
        public int StepId { get; set; }
        public int RoleId { get; set; }
        public Guid? StepSourcePointGuid { get; set; }

        public virtual CmsRole Role { get; set; }
        public virtual CmsWorkflowStep Step { get; set; }
    }
}
