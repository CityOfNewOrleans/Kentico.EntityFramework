using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms

{
    public partial class Workflow
    {
        public Workflow()
        {
            CmsAutomationHistory = new HashSet<AutomationHistory>();
            CmsAutomationState = new HashSet<AutomationState>();
            CmsObjectWorkflowTrigger = new HashSet<ObjectWorkflowTrigger>();
            CmsVersionHistory = new HashSet<VersionHistory>();
            CmsWorkflowHistory = new HashSet<WorkflowHistory>();
            CmsWorkflowScope = new HashSet<WorkflowScope>();
            CmsWorkflowStep = new HashSet<WorkflowStep>();
            CmsWorkflowTransition = new HashSet<WorkflowTransition>();
            CmsWorkflowUser = new HashSet<WorkflowUser>();
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

        public virtual ICollection<AutomationHistory> CmsAutomationHistory { get; set; }
        public virtual ICollection<AutomationState> CmsAutomationState { get; set; }
        public virtual ICollection<ObjectWorkflowTrigger> CmsObjectWorkflowTrigger { get; set; }
        public virtual ICollection<VersionHistory> CmsVersionHistory { get; set; }
        public virtual ICollection<WorkflowHistory> CmsWorkflowHistory { get; set; }
        public virtual ICollection<WorkflowScope> CmsWorkflowScope { get; set; }
        public virtual ICollection<WorkflowStep> CmsWorkflowStep { get; set; }
        public virtual ICollection<WorkflowTransition> CmsWorkflowTransition { get; set; }
        public virtual ICollection<WorkflowUser> CmsWorkflowUser { get; set; }
    }
}
