using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsSite
    {
        public CmsSite()
        {
            AnalyticsCampaign = new HashSet<AnalyticsCampaign>();
            AnalyticsConversion = new HashSet<AnalyticsConversion>();
            AnalyticsStatistics = new HashSet<AnalyticsStatistics>();
            BoardBoard = new HashSet<BoardBoard>();
            ChatNotification = new HashSet<ChatNotification>();
            ChatOnlineSupport = new HashSet<ChatOnlineSupport>();
            ChatOnlineUser = new HashSet<ChatOnlineUser>();
            ChatRoom = new HashSet<ChatRoom>();
            ChatSupportCannedResponse = new HashSet<ChatSupportCannedResponse>();
            CmsAbuseReport = new HashSet<CmsAbuseReport>();
            CmsAcl = new HashSet<CmsAcl>();
            CmsAttachment = new HashSet<CmsAttachment>();
            CmsAttachmentHistory = new HashSet<CmsAttachmentHistory>();
            CmsAutomationState = new HashSet<CmsAutomationState>();
            CmsBannedIp = new HashSet<CmsBannedIp>();
            CmsBanner = new HashSet<CmsBanner>();
            CmsBannerCategory = new HashSet<CmsBannerCategory>();
            CmsCategory = new HashSet<CmsCategory>();
            CmsClassSite = new HashSet<CmsClassSite>();
            CmsCssStylesheetSite = new HashSet<CmsCssStylesheetSite>();
            CmsDocumentAlias = new HashSet<CmsDocumentAlias>();
            CmsDocumentTypeScope = new HashSet<CmsDocumentTypeScope>();
            CmsEmailTemplate = new HashSet<CmsEmailTemplate>();
            CmsForm = new HashSet<CmsForm>();
            CmsMembership = new HashSet<CmsMembership>();
            CmsMetaFile = new HashSet<CmsMetaFile>();
            CmsObjectVersionHistory = new HashSet<CmsObjectVersionHistory>();
            CmsPageTemplate = new HashSet<CmsPageTemplate>();
            CmsPageTemplateScope = new HashSet<CmsPageTemplateScope>();
            CmsPageTemplateSite = new HashSet<CmsPageTemplateSite>();
            CmsPersonalization = new HashSet<CmsPersonalization>();
            CmsRelationshipNameSite = new HashSet<CmsRelationshipNameSite>();
            CmsResourceSite = new HashSet<CmsResourceSite>();
            CmsRole = new HashSet<CmsRole>();
            CmsScheduledTask = new HashSet<CmsScheduledTask>();
            CmsSearchIndexSite = new HashSet<CmsSearchIndexSite>();
            CmsSession = new HashSet<CmsSession>();
            CmsSettingsKey = new HashSet<CmsSettingsKey>();
            CmsSiteCulture = new HashSet<CmsSiteCulture>();
            CmsSiteDomainAlias = new HashSet<CmsSiteDomainAlias>();
            CmsSmtpserverSite = new HashSet<CmsSmtpserverSite>();
            CmsTagGroup = new HashSet<CmsTagGroup>();
            CmsTreeNodeLinkedNodeSite = new HashSet<CmsTree>();
            CmsTreeNodeSite = new HashSet<CmsTree>();
            CmsUserCulture = new HashSet<CmsUserCulture>();
            CmsUserSite = new HashSet<CmsUserSite>();
            CmsVersionHistory = new HashSet<CmsVersionHistory>();
            CmsWebPartContainerSite = new HashSet<CmsWebPartContainerSite>();
            CmsWorkflowScope = new HashSet<CmsWorkflowScope>();
            ComCarrier = new HashSet<ComCarrier>();
            ComCurrency = new HashSet<ComCurrency>();
            ComCustomer = new HashSet<ComCustomer>();
            ComCustomerCreditHistory = new HashSet<ComCustomerCreditHistory>();
            ComDepartment = new HashSet<ComDepartment>();
            ComDiscount = new HashSet<ComDiscount>();
            ComDiscountCoupon = new HashSet<ComDiscountCoupon>();
            ComExchangeTable = new HashSet<ComExchangeTable>();
            ComInternalStatus = new HashSet<ComInternalStatus>();
            ComManufacturer = new HashSet<ComManufacturer>();
            ComMultiBuyDiscount = new HashSet<ComMultiBuyDiscount>();
            CommunityGroup = new HashSet<CommunityGroup>();
            ComOptionCategory = new HashSet<ComOptionCategory>();
            ComOrder = new HashSet<ComOrder>();
            ComOrderStatus = new HashSet<ComOrderStatus>();
            ComPaymentOption = new HashSet<ComPaymentOption>();
            ComPublicStatus = new HashSet<ComPublicStatus>();
            ComShippingOption = new HashSet<ComShippingOption>();
            ComShoppingCart = new HashSet<ComShoppingCart>();
            ComSku = new HashSet<ComSku>();
            ComSupplier = new HashSet<ComSupplier>();
            ComTaxClass = new HashSet<ComTaxClass>();
            ComWishlist = new HashSet<ComWishlist>();
            ExportHistory = new HashSet<ExportHistory>();
            ExportTask = new HashSet<ExportTask>();
            ForumsAttachment = new HashSet<ForumsAttachment>();
            ForumsForum = new HashSet<ForumsForum>();
            ForumsForumGroup = new HashSet<ForumsForumGroup>();
            ForumsUserFavorites = new HashSet<ForumsUserFavorites>();
            IntegrationTask = new HashSet<IntegrationTask>();
            MediaFile = new HashSet<MediaFile>();
            MediaLibrary = new HashSet<MediaLibrary>();
            NewsletterEmails = new HashSet<NewsletterEmails>();
            NewsletterEmailTemplate = new HashSet<NewsletterEmailTemplate>();
            NewsletterNewsletter = new HashSet<NewsletterNewsletter>();
            NewsletterNewsletterIssue = new HashSet<NewsletterNewsletterIssue>();
            NewsletterSubscriber = new HashSet<NewsletterSubscriber>();
            NotificationSubscription = new HashSet<NotificationSubscription>();
            NotificationTemplate = new HashSet<NotificationTemplate>();
            OmAbtest = new HashSet<OmAbtest>();
            OmAbvariant = new HashSet<OmAbvariant>();
            OmMvtest = new HashSet<OmMvtest>();
            PollsPoll = new HashSet<PollsPoll>();
            PollsPollSite = new HashSet<PollsPollSite>();
            ReportingReportSubscription = new HashSet<ReportingReportSubscription>();
            SharePointSharePointConnection = new HashSet<SharePointSharePointConnection>();
            SharePointSharePointFile = new HashSet<SharePointSharePointFile>();
            SharePointSharePointLibrary = new HashSet<SharePointSharePointLibrary>();
            SmFacebookAccount = new HashSet<SmFacebookAccount>();
            SmFacebookApplication = new HashSet<SmFacebookApplication>();
            SmFacebookPost = new HashSet<SmFacebookPost>();
            SmLinkedInApplication = new HashSet<SmLinkedInApplication>();
            SmLinkedInPost = new HashSet<SmLinkedInPost>();
            SmTwitterAccount = new HashSet<SmTwitterAccount>();
            SmTwitterApplication = new HashSet<SmTwitterApplication>();
            SmTwitterPost = new HashSet<SmTwitterPost>();
            StagingServer = new HashSet<StagingServer>();
            StagingTask = new HashSet<StagingTask>();
        }

        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public string SiteDisplayName { get; set; }
        public string SiteDescription { get; set; }
        public string SiteStatus { get; set; }
        public string SiteDomainName { get; set; }
        public int? SiteDefaultStylesheetId { get; set; }
        public string SiteDefaultVisitorCulture { get; set; }
        public int? SiteDefaultEditorStylesheet { get; set; }
        public Guid SiteGuid { get; set; }
        public DateTime SiteLastModified { get; set; }
        public bool? SiteIsOffline { get; set; }
        public string SiteOfflineRedirectUrl { get; set; }
        public string SiteOfflineMessage { get; set; }
        public string SitePresentationUrl { get; set; }
        public bool? SiteIsContentOnly { get; set; }

        public virtual ICollection<AnalyticsCampaign> AnalyticsCampaign { get; set; }
        public virtual ICollection<AnalyticsConversion> AnalyticsConversion { get; set; }
        public virtual ICollection<AnalyticsStatistics> AnalyticsStatistics { get; set; }
        public virtual ICollection<BoardBoard> BoardBoard { get; set; }
        public virtual ICollection<ChatNotification> ChatNotification { get; set; }
        public virtual ICollection<ChatOnlineSupport> ChatOnlineSupport { get; set; }
        public virtual ICollection<ChatOnlineUser> ChatOnlineUser { get; set; }
        public virtual ICollection<ChatRoom> ChatRoom { get; set; }
        public virtual ICollection<ChatSupportCannedResponse> ChatSupportCannedResponse { get; set; }
        public virtual ICollection<CmsAbuseReport> CmsAbuseReport { get; set; }
        public virtual ICollection<CmsAcl> CmsAcl { get; set; }
        public virtual ICollection<CmsAttachment> CmsAttachment { get; set; }
        public virtual ICollection<CmsAttachmentHistory> CmsAttachmentHistory { get; set; }
        public virtual ICollection<CmsAutomationState> CmsAutomationState { get; set; }
        public virtual ICollection<CmsBannedIp> CmsBannedIp { get; set; }
        public virtual ICollection<CmsBanner> CmsBanner { get; set; }
        public virtual ICollection<CmsBannerCategory> CmsBannerCategory { get; set; }
        public virtual ICollection<CmsCategory> CmsCategory { get; set; }
        public virtual ICollection<CmsClassSite> CmsClassSite { get; set; }
        public virtual ICollection<CmsCssStylesheetSite> CmsCssStylesheetSite { get; set; }
        public virtual ICollection<CmsDocumentAlias> CmsDocumentAlias { get; set; }
        public virtual ICollection<CmsDocumentTypeScope> CmsDocumentTypeScope { get; set; }
        public virtual ICollection<CmsEmailTemplate> CmsEmailTemplate { get; set; }
        public virtual ICollection<CmsForm> CmsForm { get; set; }
        public virtual ICollection<CmsMembership> CmsMembership { get; set; }
        public virtual ICollection<CmsMetaFile> CmsMetaFile { get; set; }
        public virtual ICollection<CmsObjectVersionHistory> CmsObjectVersionHistory { get; set; }
        public virtual ICollection<CmsPageTemplate> CmsPageTemplate { get; set; }
        public virtual ICollection<CmsPageTemplateScope> CmsPageTemplateScope { get; set; }
        public virtual ICollection<CmsPageTemplateSite> CmsPageTemplateSite { get; set; }
        public virtual ICollection<CmsPersonalization> CmsPersonalization { get; set; }
        public virtual ICollection<CmsRelationshipNameSite> CmsRelationshipNameSite { get; set; }
        public virtual ICollection<CmsResourceSite> CmsResourceSite { get; set; }
        public virtual ICollection<CmsRole> CmsRole { get; set; }
        public virtual ICollection<CmsScheduledTask> CmsScheduledTask { get; set; }
        public virtual ICollection<CmsSearchIndexSite> CmsSearchIndexSite { get; set; }
        public virtual ICollection<CmsSession> CmsSession { get; set; }
        public virtual ICollection<CmsSettingsKey> CmsSettingsKey { get; set; }
        public virtual ICollection<CmsSiteCulture> CmsSiteCulture { get; set; }
        public virtual ICollection<CmsSiteDomainAlias> CmsSiteDomainAlias { get; set; }
        public virtual ICollection<CmsSmtpserverSite> CmsSmtpserverSite { get; set; }
        public virtual ICollection<CmsTagGroup> CmsTagGroup { get; set; }
        public virtual ICollection<CmsTree> CmsTreeNodeLinkedNodeSite { get; set; }
        public virtual ICollection<CmsTree> CmsTreeNodeSite { get; set; }
        public virtual ICollection<CmsUserCulture> CmsUserCulture { get; set; }
        public virtual ICollection<CmsUserSite> CmsUserSite { get; set; }
        public virtual ICollection<CmsVersionHistory> CmsVersionHistory { get; set; }
        public virtual ICollection<CmsWebPartContainerSite> CmsWebPartContainerSite { get; set; }
        public virtual ICollection<CmsWorkflowScope> CmsWorkflowScope { get; set; }
        public virtual ICollection<ComCarrier> ComCarrier { get; set; }
        public virtual ICollection<ComCurrency> ComCurrency { get; set; }
        public virtual ICollection<ComCustomer> ComCustomer { get; set; }
        public virtual ICollection<ComCustomerCreditHistory> ComCustomerCreditHistory { get; set; }
        public virtual ICollection<ComDepartment> ComDepartment { get; set; }
        public virtual ICollection<ComDiscount> ComDiscount { get; set; }
        public virtual ICollection<ComDiscountCoupon> ComDiscountCoupon { get; set; }
        public virtual ICollection<ComExchangeTable> ComExchangeTable { get; set; }
        public virtual ICollection<ComInternalStatus> ComInternalStatus { get; set; }
        public virtual ICollection<ComManufacturer> ComManufacturer { get; set; }
        public virtual ICollection<ComMultiBuyDiscount> ComMultiBuyDiscount { get; set; }
        public virtual ICollection<CommunityGroup> CommunityGroup { get; set; }
        public virtual ICollection<ComOptionCategory> ComOptionCategory { get; set; }
        public virtual ICollection<ComOrder> ComOrder { get; set; }
        public virtual ICollection<ComOrderStatus> ComOrderStatus { get; set; }
        public virtual ICollection<ComPaymentOption> ComPaymentOption { get; set; }
        public virtual ICollection<ComPublicStatus> ComPublicStatus { get; set; }
        public virtual ICollection<ComShippingOption> ComShippingOption { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCart { get; set; }
        public virtual ICollection<ComSku> ComSku { get; set; }
        public virtual ICollection<ComSupplier> ComSupplier { get; set; }
        public virtual ICollection<ComTaxClass> ComTaxClass { get; set; }
        public virtual ICollection<ComWishlist> ComWishlist { get; set; }
        public virtual ICollection<ExportHistory> ExportHistory { get; set; }
        public virtual ICollection<ExportTask> ExportTask { get; set; }
        public virtual ICollection<ForumsAttachment> ForumsAttachment { get; set; }
        public virtual ICollection<ForumsForum> ForumsForum { get; set; }
        public virtual ICollection<ForumsForumGroup> ForumsForumGroup { get; set; }
        public virtual ICollection<ForumsUserFavorites> ForumsUserFavorites { get; set; }
        public virtual ICollection<IntegrationTask> IntegrationTask { get; set; }
        public virtual ICollection<MediaFile> MediaFile { get; set; }
        public virtual ICollection<MediaLibrary> MediaLibrary { get; set; }
        public virtual ICollection<NewsletterEmails> NewsletterEmails { get; set; }
        public virtual ICollection<NewsletterEmailTemplate> NewsletterEmailTemplate { get; set; }
        public virtual ICollection<NewsletterNewsletter> NewsletterNewsletter { get; set; }
        public virtual ICollection<NewsletterNewsletterIssue> NewsletterNewsletterIssue { get; set; }
        public virtual ICollection<NewsletterSubscriber> NewsletterSubscriber { get; set; }
        public virtual ICollection<NotificationSubscription> NotificationSubscription { get; set; }
        public virtual ICollection<NotificationTemplate> NotificationTemplate { get; set; }
        public virtual ICollection<OmAbtest> OmAbtest { get; set; }
        public virtual ICollection<OmAbvariant> OmAbvariant { get; set; }
        public virtual ICollection<OmMvtest> OmMvtest { get; set; }
        public virtual ICollection<PollsPoll> PollsPoll { get; set; }
        public virtual ICollection<PollsPollSite> PollsPollSite { get; set; }
        public virtual ICollection<ReportingReportSubscription> ReportingReportSubscription { get; set; }
        public virtual ICollection<SharePointSharePointConnection> SharePointSharePointConnection { get; set; }
        public virtual ICollection<SharePointSharePointFile> SharePointSharePointFile { get; set; }
        public virtual ICollection<SharePointSharePointLibrary> SharePointSharePointLibrary { get; set; }
        public virtual ICollection<SmFacebookAccount> SmFacebookAccount { get; set; }
        public virtual ICollection<SmFacebookApplication> SmFacebookApplication { get; set; }
        public virtual ICollection<SmFacebookPost> SmFacebookPost { get; set; }
        public virtual ICollection<SmLinkedInApplication> SmLinkedInApplication { get; set; }
        public virtual ICollection<SmLinkedInPost> SmLinkedInPost { get; set; }
        public virtual ICollection<SmTwitterAccount> SmTwitterAccount { get; set; }
        public virtual ICollection<SmTwitterApplication> SmTwitterApplication { get; set; }
        public virtual ICollection<SmTwitterPost> SmTwitterPost { get; set; }
        public virtual ICollection<StagingServer> StagingServer { get; set; }
        public virtual ICollection<StagingTask> StagingTask { get; set; }
        public virtual CmsCssStylesheet SiteDefaultEditorStylesheetNavigation { get; set; }
        public virtual CmsCssStylesheet SiteDefaultStylesheet { get; set; }
    }
}
