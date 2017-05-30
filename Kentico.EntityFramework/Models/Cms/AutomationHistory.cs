using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class AutomationHistory
    {
        public int HistoryId { get; set; }
        public int? HistoryStepId { get; set; }
        public string HistoryStepName { get; set; }
        public string HistoryStepDisplayName { get; set; }
        public int? HistoryStepType { get; set; }
        public int? HistoryTargetStepId { get; set; }
        public string HistoryTargetStepName { get; set; }
        public string HistoryTargetStepDisplayName { get; set; }
        public int? HistoryTargetStepType { get; set; }
        public int? HistoryApprovedByUserId { get; set; }
        public DateTime? HistoryApprovedWhen { get; set; }
        public string HistoryComment { get; set; }
        public int? HistoryTransitionType { get; set; }
        public int HistoryWorkflowId { get; set; }
        public bool? HistoryRejected { get; set; }
        public bool HistoryWasRejected { get; set; }
        public int HistoryStateId { get; set; }

        public virtual User HistoryApprovedByUser { get; set; }
        public virtual AutomationState HistoryState { get; set; }
        public virtual WorkflowStep HistoryStep { get; set; }
        public virtual WorkflowStep HistoryTargetStep { get; set; }
        public virtual Workflow HistoryWorkflow { get; set; }
    }
}
