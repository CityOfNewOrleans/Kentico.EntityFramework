using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsAutomationState
    {
        public CmsAutomationState()
        {
            CmsAutomationHistory = new HashSet<CmsAutomationHistory>();
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

        public virtual ICollection<CmsAutomationHistory> CmsAutomationHistory { get; set; }
        public virtual CmsSite StateSite { get; set; }
        public virtual CmsWorkflowStep StateStep { get; set; }
        public virtual CmsUser StateUser { get; set; }
        public virtual CmsWorkflow StateWorkflow { get; set; }
    }
}
