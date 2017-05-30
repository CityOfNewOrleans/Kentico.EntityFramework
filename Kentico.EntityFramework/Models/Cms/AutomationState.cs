using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class AutomationState
    {
        public AutomationState()
        {
            CmsAutomationHistory = new HashSet<AutomationHistory>();
        }

        public int StateId { get; set; }
        public int StateStepId { get; set; }
        public int StateObjectId { get; set; }
        public string StateObjectType { get; set; }
        public string StateActionStatus { get; set; }
        public DateTime? StateCreated { get; set; }
        public DateTime? StateLastModified { get; set; }
        public int StateWorkflowId { get; set; }
        public int? StateStatus { get; set; }
        public int? StateSiteId { get; set; }
        public int? StateUserId { get; set; }
        public Guid StateGuid { get; set; }
        public string StateCustomData { get; set; }

        public virtual ICollection<AutomationHistory> CmsAutomationHistory { get; set; }
        public virtual Site StateSite { get; set; }
        public virtual WorkflowStep StateStep { get; set; }
        public virtual User StateUser { get; set; }
        public virtual Workflow StateWorkflow { get; set; }
    }
}
