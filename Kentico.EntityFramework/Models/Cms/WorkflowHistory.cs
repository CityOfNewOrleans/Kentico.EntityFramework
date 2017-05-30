using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WorkflowHistory
    {
        public int WorkflowHistoryId { get; set; }
        public int VersionHistoryId { get; set; }
        public int? StepId { get; set; }
        public string StepDisplayName { get; set; }
        public int? ApprovedByUserId { get; set; }
        public DateTime? ApprovedWhen { get; set; }
        public string Comment { get; set; }
        public bool WasRejected { get; set; }
        public string StepName { get; set; }
        public int? TargetStepId { get; set; }
        public string TargetStepName { get; set; }
        public string TargetStepDisplayName { get; set; }
        public int? StepType { get; set; }
        public int? TargetStepType { get; set; }
        public string HistoryObjectType { get; set; }
        public int? HistoryObjectId { get; set; }
        public int? HistoryTransitionType { get; set; }
        public int? HistoryWorkflowId { get; set; }
        public bool? HistoryRejected { get; set; }

        public virtual User ApprovedByUser { get; set; }
        public virtual Workflow HistoryWorkflow { get; set; }
        public virtual WorkflowStep Step { get; set; }
        public virtual WorkflowStep TargetStep { get; set; }
        public virtual VersionHistory VersionHistory { get; set; }
    }
}
