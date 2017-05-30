using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class VersionHistory
    {
        public VersionHistory()
        {
            CmsDocumentDocumentCheckedOutVersionHistory = new HashSet<Document>();
            CmsDocumentDocumentPublishedVersionHistory = new HashSet<Document>();
            CmsVersionAttachment = new HashSet<VersionAttachment>();
            CmsWorkflowHistory = new HashSet<WorkflowHistory>();
        }

        public int VersionHistoryId { get; set; }
        public int NodeSiteId { get; set; }
        public int? DocumentId { get; set; }
        public string DocumentNamePath { get; set; }
        public string NodeXml { get; set; }
        public int? ModifiedByUserId { get; set; }
        public DateTime ModifiedWhen { get; set; }
        public string VersionNumber { get; set; }
        public string VersionComment { get; set; }
        public bool ToBePublished { get; set; }
        public DateTime? PublishFrom { get; set; }
        public DateTime? PublishTo { get; set; }
        public DateTime? WasPublishedFrom { get; set; }
        public DateTime? WasPublishedTo { get; set; }
        public string VersionDocumentName { get; set; }
        public string VersionDocumentType { get; set; }
        public int? VersionClassId { get; set; }
        public string VersionMenuRedirectUrl { get; set; }
        public int? VersionWorkflowId { get; set; }
        public int? VersionWorkflowStepId { get; set; }
        public string VersionNodeAliasPath { get; set; }
        public int? VersionDeletedByUserId { get; set; }
        public DateTime? VersionDeletedWhen { get; set; }

        public virtual ICollection<Document> CmsDocumentDocumentCheckedOutVersionHistory { get; set; }
        public virtual ICollection<Document> CmsDocumentDocumentPublishedVersionHistory { get; set; }
        public virtual ICollection<VersionAttachment> CmsVersionAttachment { get; set; }
        public virtual ICollection<WorkflowHistory> CmsWorkflowHistory { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual Site NodeSite { get; set; }
        public virtual Class VersionClass { get; set; }
        public virtual User VersionDeletedByUser { get; set; }
        public virtual Workflow VersionWorkflow { get; set; }
        public virtual WorkflowStep VersionWorkflowStep { get; set; }
    }
}
