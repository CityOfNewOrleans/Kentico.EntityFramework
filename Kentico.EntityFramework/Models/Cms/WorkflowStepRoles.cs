using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WorkflowStepRoles
    {
        public int WorkflowStepRoleId { get; set; }
        public int StepId { get; set; }
        public int RoleId { get; set; }
        public Guid? StepSourcePointGuid { get; set; }

        public virtual Role Role { get; set; }
        public virtual WorkflowStep Step { get; set; }
    }
}
