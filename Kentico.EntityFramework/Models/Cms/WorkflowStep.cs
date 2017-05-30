using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WorkflowStep
    {
        public WorkflowStep()
        {
            CmsAutomationHistoryHistoryStep = new HashSet<AutomationHistory>();
            CmsAutomationHistoryHistoryTargetStep = new HashSet<AutomationHistory>();
            CmsAutomationState = new HashSet<AutomationState>();
            CmsDocument = new HashSet<Document>();
            CmsObjectSettings = new HashSet<ObjectSettings>();
            CmsVersionHistory = new HashSet<VersionHistory>();
            CmsWorkflowHistoryStep = new HashSet<WorkflowHistory>();
            CmsWorkflowHistoryTargetStep = new HashSet<WorkflowHistory>();
            CmsWorkflowStepRoles = new HashSet<WorkflowStepRoles>();
            CmsWorkflowStepUser = new HashSet<WorkflowStepUser>();
            CmsWorkflowTransitionTransitionEndStep = new HashSet<WorkflowTransition>();
            CmsWorkflowTransitionTransitionStartStep = new HashSet<WorkflowTransition>();
        }

        public int StepId { get; set; }
        public string StepDisplayName { get; set; }
        public string StepName { get; set; }
        public int? StepOrder { get; set; }
        public int StepWorkflowId { get; set; }
        public Guid StepGuid { get; set; }
        public DateTime StepLastModified { get; set; }
        public int? StepType { get; set; }
        public bool? StepAllowReject { get; set; }
        public string StepDefinition { get; set; }
        public int? StepRolesSecurity { get; set; }
        public int? StepUsersSecurity { get; set; }
        public string StepApprovedTemplateName { get; set; }
        public string StepRejectedTemplateName { get; set; }
        public string StepReadyforApprovalTemplateName { get; set; }
        public bool? StepSendApproveEmails { get; set; }
        public bool? StepSendRejectEmails { get; set; }
        public bool? StepSendReadyForApprovalEmails { get; set; }
        public bool? StepSendEmails { get; set; }
        public bool? StepAllowPublish { get; set; }
        public int? StepActionId { get; set; }
        public string StepActionParameters { get; set; }
        public int? StepWorkflowType { get; set; }

        public virtual ICollection<AutomationHistory> CmsAutomationHistoryHistoryStep { get; set; }
        public virtual ICollection<AutomationHistory> CmsAutomationHistoryHistoryTargetStep { get; set; }
        public virtual ICollection<AutomationState> CmsAutomationState { get; set; }
        public virtual ICollection<Document> CmsDocument { get; set; }
        public virtual ICollection<ObjectSettings> CmsObjectSettings { get; set; }
        public virtual ICollection<VersionHistory> CmsVersionHistory { get; set; }
        public virtual ICollection<WorkflowHistory> CmsWorkflowHistoryStep { get; set; }
        public virtual ICollection<WorkflowHistory> CmsWorkflowHistoryTargetStep { get; set; }
        public virtual ICollection<WorkflowStepRoles> CmsWorkflowStepRoles { get; set; }
        public virtual ICollection<WorkflowStepUser> CmsWorkflowStepUser { get; set; }
        public virtual ICollection<WorkflowTransition> CmsWorkflowTransitionTransitionEndStep { get; set; }
        public virtual ICollection<WorkflowTransition> CmsWorkflowTransitionTransitionStartStep { get; set; }
        public virtual WorkflowAction StepAction { get; set; }
        public virtual Workflow StepWorkflow { get; set; }
    }
}
