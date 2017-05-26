using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsDocument
    {
        public CmsDocument()
        {
            BlogComment = new HashSet<BlogComment>();
            BlogPostSubscription = new HashSet<BlogPostSubscription>();
            BoardBoard = new HashSet<BoardBoard>();
            CmsAttachment = new HashSet<CmsAttachment>();
            CmsDocumentCategory = new HashSet<CmsDocumentCategory>();
            CmsDocumentTag = new HashSet<CmsDocumentTag>();
            CmsPersonalization = new HashSet<CmsPersonalization>();
            ForumsForum = new HashSet<ForumsForum>();
            OmPersonalizationVariant = new HashSet<OmPersonalizationVariant>();
        }

        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentNamePath { get; set; }
        public DateTime? DocumentModifiedWhen { get; set; }
        public int? DocumentModifiedByUserId { get; set; }
        public int? DocumentForeignKeyValue { get; set; }
        public int? DocumentCreatedByUserId { get; set; }
        public DateTime? DocumentCreatedWhen { get; set; }
        public int? DocumentCheckedOutByUserId { get; set; }
        public DateTime? DocumentCheckedOutWhen { get; set; }
        public int? DocumentCheckedOutVersionHistoryId { get; set; }
        public int? DocumentPublishedVersionHistoryId { get; set; }
        public int? DocumentWorkflowStepId { get; set; }
        public DateTime? DocumentPublishFrom { get; set; }
        public DateTime? DocumentPublishTo { get; set; }
        public string DocumentUrlPath { get; set; }
        public string DocumentCulture { get; set; }
        public int DocumentNodeId { get; set; }
        public string DocumentPageTitle { get; set; }
        public string DocumentPageKeyWords { get; set; }
        public string DocumentPageDescription { get; set; }
        public bool DocumentShowInSiteMap { get; set; }
        public bool DocumentMenuItemHideInNavigation { get; set; }
        public string DocumentMenuCaption { get; set; }
        public string DocumentMenuStyle { get; set; }
        public string DocumentMenuItemImage { get; set; }
        public string DocumentMenuItemLeftImage { get; set; }
        public string DocumentMenuItemRightImage { get; set; }
        public int? DocumentPageTemplateId { get; set; }
        public string DocumentMenuJavascript { get; set; }
        public string DocumentMenuRedirectUrl { get; set; }
        public bool? DocumentUseNamePathForUrlPath { get; set; }
        public int? DocumentStylesheetId { get; set; }
        public string DocumentContent { get; set; }
        public string DocumentMenuClass { get; set; }
        public string DocumentMenuStyleHighlighted { get; set; }
        public string DocumentMenuClassHighlighted { get; set; }
        public string DocumentMenuItemImageHighlighted { get; set; }
        public string DocumentMenuItemLeftImageHighlighted { get; set; }
        public string DocumentMenuItemRightImageHighlighted { get; set; }
        public bool? DocumentMenuItemInactive { get; set; }
        public string DocumentCustomData { get; set; }
        public string DocumentExtensions { get; set; }
        public string DocumentTags { get; set; }
        public int? DocumentTagGroupId { get; set; }
        public string DocumentWildcardRule { get; set; }
        public string DocumentWebParts { get; set; }
        public double? DocumentRatingValue { get; set; }
        public int? DocumentRatings { get; set; }
        public int? DocumentPriority { get; set; }
        public string DocumentType { get; set; }
        public DateTime? DocumentLastPublished { get; set; }
        public bool? DocumentUseCustomExtensions { get; set; }
        public string DocumentGroupWebParts { get; set; }
        public bool? DocumentCheckedOutAutomatically { get; set; }
        public string DocumentTrackConversionName { get; set; }
        public string DocumentConversionValue { get; set; }
        public bool? DocumentSearchExcluded { get; set; }
        public string DocumentLastVersionNumber { get; set; }
        public bool? DocumentIsArchived { get; set; }
        public string DocumentHash { get; set; }
        public bool? DocumentLogVisitActivity { get; set; }
        public Guid? DocumentGuid { get; set; }
        public Guid? DocumentWorkflowCycleGuid { get; set; }
        public string DocumentSitemapSettings { get; set; }
        public bool? DocumentIsWaitingForTranslation { get; set; }
        public string DocumentSkuname { get; set; }
        public string DocumentSkudescription { get; set; }
        public string DocumentSkushortDescription { get; set; }
        public string DocumentWorkflowActionStatus { get; set; }
        public bool? DocumentMenuRedirectToFirstChild { get; set; }
        public bool DocumentCanBePublished { get; set; }
        public bool DocumentInheritsStylesheet { get; set; }

        public virtual ICollection<BlogComment> BlogComment { get; set; }
        public virtual ICollection<BlogPostSubscription> BlogPostSubscription { get; set; }
        public virtual ICollection<BoardBoard> BoardBoard { get; set; }
        public virtual ICollection<CmsAttachment> CmsAttachment { get; set; }
        public virtual ICollection<CmsDocumentCategory> CmsDocumentCategory { get; set; }
        public virtual ICollection<CmsDocumentTag> CmsDocumentTag { get; set; }
        public virtual ICollection<CmsPersonalization> CmsPersonalization { get; set; }
        public virtual ICollection<ForumsForum> ForumsForum { get; set; }
        public virtual ICollection<OmPersonalizationVariant> OmPersonalizationVariant { get; set; }
        public virtual CmsUser DocumentCheckedOutByUser { get; set; }
        public virtual CmsVersionHistory DocumentCheckedOutVersionHistory { get; set; }
        public virtual CmsUser DocumentCreatedByUser { get; set; }
        public virtual CmsUser DocumentModifiedByUser { get; set; }
        public virtual CmsTree DocumentNode { get; set; }
        public virtual CmsPageTemplate DocumentPageTemplate { get; set; }
        public virtual CmsVersionHistory DocumentPublishedVersionHistory { get; set; }
        public virtual CmsCssStylesheet DocumentStylesheet { get; set; }
        public virtual CmsTagGroup DocumentTagGroup { get; set; }
        public virtual CmsWorkflowStep DocumentWorkflowStep { get; set; }
    }
}
