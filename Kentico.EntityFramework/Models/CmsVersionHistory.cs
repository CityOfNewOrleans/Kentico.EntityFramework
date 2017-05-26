using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsVersionHistory
    {
        public CmsVersionHistory()
        {
            CmsDocumentDocumentCheckedOutVersionHistory = new HashSet<CmsDocument>();
            CmsDocumentDocumentPublishedVersionHistory = new HashSet<CmsDocument>();
            CmsVersionAttachment = new HashSet<CmsVersionAttachment>();
            CmsWorkflowHistory = new HashSet<CmsWorkflowHistory>();
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

        public virtual ICollection<CmsDocument> CmsDocumentDocumentCheckedOutVersionHistory { get; set; }
        public virtual ICollection<CmsDocument> CmsDocumentDocumentPublishedVersionHistory { get; set; }
        public virtual ICollection<CmsVersionAttachment> CmsVersionAttachment { get; set; }
        public virtual ICollection<CmsWorkflowHistory> CmsWorkflowHistory { get; set; }
        public virtual CmsUser ModifiedByUser { get; set; }
        public virtual CmsSite NodeSite { get; set; }
        public virtual CmsClass VersionClass { get; set; }
        public virtual CmsUser VersionDeletedByUser { get; set; }
        public virtual CmsWorkflow VersionWorkflow { get; set; }
        public virtual CmsWorkflowStep VersionWorkflowStep { get; set; }
    }
}
