using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsWorkflowStep
    {
        public CmsWorkflowStep()
        {
            CmsAutomationHistoryHistoryStep = new HashSet<CmsAutomationHistory>();
            CmsAutomationHistoryHistoryTargetStep = new HashSet<CmsAutomationHistory>();
            CmsAutomationState = new HashSet<CmsAutomationState>();
            CmsDocument = new HashSet<CmsDocument>();
            CmsObjectSettings = new HashSet<CmsObjectSettings>();
            CmsVersionHistory = new HashSet<CmsVersionHistory>();
            CmsWorkflowHistoryStep = new HashSet<CmsWorkflowHistory>();
            CmsWorkflowHistoryTargetStep = new HashSet<CmsWorkflowHistory>();
            CmsWorkflowStepRoles = new HashSet<CmsWorkflowStepRoles>();
            CmsWorkflowStepUser = new HashSet<CmsWorkflowStepUser>();
            CmsWorkflowTransitionTransitionEndStep = new HashSet<CmsWorkflowTransition>();
            CmsWorkflowTransitionTransitionStartStep = new HashSet<CmsWorkflowTransition>();
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

        public virtual ICollection<CmsAutomationHistory> CmsAutomationHistoryHistoryStep { get; set; }
        public virtual ICollection<CmsAutomationHistory> CmsAutomationHistoryHistoryTargetStep { get; set; }
        public virtual ICollection<CmsAutomationState> CmsAutomationState { get; set; }
        public virtual ICollection<CmsDocument> CmsDocument { get; set; }
        public virtual ICollection<CmsObjectSettings> CmsObjectSettings { get; set; }
        public virtual ICollection<CmsVersionHistory> CmsVersionHistory { get; set; }
        public virtual ICollection<CmsWorkflowHistory> CmsWorkflowHistoryStep { get; set; }
        public virtual ICollection<CmsWorkflowHistory> CmsWorkflowHistoryTargetStep { get; set; }
        public virtual ICollection<CmsWorkflowStepRoles> CmsWorkflowStepRoles { get; set; }
        public virtual ICollection<CmsWorkflowStepUser> CmsWorkflowStepUser { get; set; }
        public virtual ICollection<CmsWorkflowTransition> CmsWorkflowTransitionTransitionEndStep { get; set; }
        public virtual ICollection<CmsWorkflowTransition> CmsWorkflowTransitionTransitionStartStep { get; set; }
        public virtual CmsWorkflowAction StepAction { get; set; }
        public virtual CmsWorkflow StepWorkflow { get; set; }
    }
}
