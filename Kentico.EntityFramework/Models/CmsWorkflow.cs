using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsWorkflow
    {
        public CmsWorkflow()
        {
            CmsAutomationHistory = new HashSet<CmsAutomationHistory>();
            CmsAutomationState = new HashSet<CmsAutomationState>();
            CmsObjectWorkflowTrigger = new HashSet<CmsObjectWorkflowTrigger>();
            CmsVersionHistory = new HashSet<CmsVersionHistory>();
            CmsWorkflowHistory = new HashSet<CmsWorkflowHistory>();
            CmsWorkflowScope = new HashSet<CmsWorkflowScope>();
            CmsWorkflowStep = new HashSet<CmsWorkflowStep>();
            CmsWorkflowTransition = new HashSet<CmsWorkflowTransition>();
            CmsWorkflowUser = new HashSet<CmsWorkflowUser>();
        }

        public int WorkflowId { get; set; }
        public string WorkflowDisplayName { get; set; }
        public string WorkflowName { get; set; }
        public Guid WorkflowGuid { get; set; }
        public DateTime WorkflowLastModified { get; set; }
        public bool? WorkflowAutoPublishChanges { get; set; }
        public bool? WorkflowUseCheckinCheckout { get; set; }
        public int? WorkflowType { get; set; }
        public bool? WorkflowSendEmails { get; set; }
        public bool? WorkflowSendApproveEmails { get; set; }
        public bool? WorkflowSendRejectEmails { get; set; }
        public bool? WorkflowSendPublishEmails { get; set; }
        public bool? WorkflowSendArchiveEmails { get; set; }
        public string WorkflowApprovedTemplateName { get; set; }
        public string WorkflowRejectedTemplateName { get; set; }
        public string WorkflowPublishedTemplateName { get; set; }
        public string WorkflowArchivedTemplateName { get; set; }
        public bool? WorkflowSendReadyForApprovalEmails { get; set; }
        public string WorkflowReadyForApprovalTemplateName { get; set; }
        public string WorkflowNotificationTemplateName { get; set; }
        public string WorkflowAllowedObjects { get; set; }
        public int? WorkflowRecurrenceType { get; set; }
        public bool? WorkflowEnabled { get; set; }

        public virtual ICollection<CmsAutomationHistory> CmsAutomationHistory { get; set; }
        public virtual ICollection<CmsAutomationState> CmsAutomationState { get; set; }
        public virtual ICollection<CmsObjectWorkflowTrigger> CmsObjectWorkflowTrigger { get; set; }
        public virtual ICollection<CmsVersionHistory> CmsVersionHistory { get; set; }
        public virtual ICollection<CmsWorkflowHistory> CmsWorkflowHistory { get; set; }
        public virtual ICollection<CmsWorkflowScope> CmsWorkflowScope { get; set; }
        public virtual ICollection<CmsWorkflowStep> CmsWorkflowStep { get; set; }
        public virtual ICollection<CmsWorkflowTransition> CmsWorkflowTransition { get; set; }
        public virtual ICollection<CmsWorkflowUser> CmsWorkflowUser { get; set; }
    }
}
