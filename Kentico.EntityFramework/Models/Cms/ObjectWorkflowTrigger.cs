using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class ObjectWorkflowTrigger
    {
        public int TriggerId { get; set; }
        public Guid TriggerGuid { get; set; }
        public DateTime TriggerLastModified { get; set; }
        public int TriggerType { get; set; }
        public string TriggerMacroCondition { get; set; }
        public int TriggerWorkflowId { get; set; }
        public string TriggerDisplayName { get; set; }
        public string TriggerObjectType { get; set; }
        public string TriggerParameters { get; set; }
        public string TriggerTargetObjectType { get; set; }
        public int? TriggerTargetObjectId { get; set; }

        public virtual Workflow TriggerWorkflow { get; set; }
    }
}
