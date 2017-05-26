using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kentico.EntityFramework.Models
{
    public partial class vanilla_kenticoContext : DbContext
    {
        public virtual DbSet<AnalyticsCampaign> AnalyticsCampaign { get; set; }
        public virtual DbSet<AnalyticsCampaignAsset> AnalyticsCampaignAsset { get; set; }
        public virtual DbSet<AnalyticsCampaignAssetUrl> AnalyticsCampaignAssetUrl { get; set; }
        public virtual DbSet<AnalyticsCampaignConversion> AnalyticsCampaignConversion { get; set; }
        public virtual DbSet<AnalyticsCampaignConversionHits> AnalyticsCampaignConversionHits { get; set; }
        public virtual DbSet<AnalyticsCampaignObjective> AnalyticsCampaignObjective { get; set; }
        public virtual DbSet<AnalyticsConversion> AnalyticsConversion { get; set; }
        public virtual DbSet<AnalyticsDayHits> AnalyticsDayHits { get; set; }
        public virtual DbSet<AnalyticsExitPages> AnalyticsExitPages { get; set; }
        public virtual DbSet<AnalyticsHourHits> AnalyticsHourHits { get; set; }
        public virtual DbSet<AnalyticsMonthHits> AnalyticsMonthHits { get; set; }
        public virtual DbSet<AnalyticsStatistics> AnalyticsStatistics { get; set; }
        public virtual DbSet<AnalyticsWeekHits> AnalyticsWeekHits { get; set; }
        public virtual DbSet<AnalyticsYearHits> AnalyticsYearHits { get; set; }
        public virtual DbSet<BadWordsWord> BadWordsWord { get; set; }
        public virtual DbSet<BadWordsWordCulture> BadWordsWordCulture { get; set; }
        public virtual DbSet<BlogComment> BlogComment { get; set; }
        public virtual DbSet<BlogPostSubscription> BlogPostSubscription { get; set; }
        public virtual DbSet<BoardBoard> BoardBoard { get; set; }
        public virtual DbSet<BoardMessage> BoardMessage { get; set; }
        public virtual DbSet<BoardModerator> BoardModerator { get; set; }
        public virtual DbSet<BoardRole> BoardRole { get; set; }
        public virtual DbSet<BoardSubscription> BoardSubscription { get; set; }
        public virtual DbSet<ChatInitiatedChatRequest> ChatInitiatedChatRequest { get; set; }
        public virtual DbSet<ChatMessage> ChatMessage { get; set; }
        public virtual DbSet<ChatNotification> ChatNotification { get; set; }
        public virtual DbSet<ChatOnlineSupport> ChatOnlineSupport { get; set; }
        public virtual DbSet<ChatOnlineUser> ChatOnlineUser { get; set; }
        public virtual DbSet<ChatPopupWindowSettings> ChatPopupWindowSettings { get; set; }
        public virtual DbSet<ChatRoom> ChatRoom { get; set; }
        public virtual DbSet<ChatRoomUser> ChatRoomUser { get; set; }
        public virtual DbSet<ChatSupportCannedResponse> ChatSupportCannedResponse { get; set; }
        public virtual DbSet<ChatSupportTakenRoom> ChatSupportTakenRoom { get; set; }
        public virtual DbSet<ChatUser> ChatUser { get; set; }
        public virtual DbSet<CiFileMetadata> CiFileMetadata { get; set; }
        public virtual DbSet<CmsAbuseReport> CmsAbuseReport { get; set; }
        public virtual DbSet<CmsAcl> CmsAcl { get; set; }
        public virtual DbSet<CmsAclitem> CmsAclitem { get; set; }
        public virtual DbSet<CmsAllowedChildClasses> CmsAllowedChildClasses { get; set; }
        public virtual DbSet<CmsAlternativeForm> CmsAlternativeForm { get; set; }
        public virtual DbSet<CmsAttachment> CmsAttachment { get; set; }
        public virtual DbSet<CmsAttachmentForEmail> CmsAttachmentForEmail { get; set; }
        public virtual DbSet<CmsAttachmentHistory> CmsAttachmentHistory { get; set; }
        public virtual DbSet<CmsAutomationHistory> CmsAutomationHistory { get; set; }
        public virtual DbSet<CmsAutomationState> CmsAutomationState { get; set; }
        public virtual DbSet<CmsAvatar> CmsAvatar { get; set; }
        public virtual DbSet<CmsBadge> CmsBadge { get; set; }
        public virtual DbSet<CmsBannedIp> CmsBannedIp { get; set; }
        public virtual DbSet<CmsBanner> CmsBanner { get; set; }
        public virtual DbSet<CmsBannerCategory> CmsBannerCategory { get; set; }
        public virtual DbSet<CmsCategory> CmsCategory { get; set; }
        public virtual DbSet<CmsClass> CmsClass { get; set; }
        public virtual DbSet<CmsClassSite> CmsClassSite { get; set; }
        public virtual DbSet<CmsCountry> CmsCountry { get; set; }
        public virtual DbSet<CmsCssStylesheet> CmsCssStylesheet { get; set; }
        public virtual DbSet<CmsCssStylesheetSite> CmsCssStylesheetSite { get; set; }
        public virtual DbSet<CmsCulture> CmsCulture { get; set; }
        public virtual DbSet<CmsDeviceProfile> CmsDeviceProfile { get; set; }
        public virtual DbSet<CmsDeviceProfileLayout> CmsDeviceProfileLayout { get; set; }
        public virtual DbSet<CmsDocument> CmsDocument { get; set; }
        public virtual DbSet<CmsDocumentAlias> CmsDocumentAlias { get; set; }
        public virtual DbSet<CmsDocumentCategory> CmsDocumentCategory { get; set; }
        public virtual DbSet<CmsDocumentTag> CmsDocumentTag { get; set; }
        public virtual DbSet<CmsDocumentTypeScope> CmsDocumentTypeScope { get; set; }
        public virtual DbSet<CmsDocumentTypeScopeClass> CmsDocumentTypeScopeClass { get; set; }
        public virtual DbSet<CmsEmail> CmsEmail { get; set; }
        public virtual DbSet<CmsEmailAttachment> CmsEmailAttachment { get; set; }
        public virtual DbSet<CmsEmailTemplate> CmsEmailTemplate { get; set; }
        public virtual DbSet<CmsEmailUser> CmsEmailUser { get; set; }
        public virtual DbSet<CmsEventLog> CmsEventLog { get; set; }
        public virtual DbSet<CmsExternalLogin> CmsExternalLogin { get; set; }
        public virtual DbSet<CmsForm> CmsForm { get; set; }
        public virtual DbSet<CmsFormRole> CmsFormRole { get; set; }
        public virtual DbSet<CmsFormUserControl> CmsFormUserControl { get; set; }
        public virtual DbSet<CmsHelpTopic> CmsHelpTopic { get; set; }
        public virtual DbSet<CmsInlineControl> CmsInlineControl { get; set; }
        public virtual DbSet<CmsLayout> CmsLayout { get; set; }
        public virtual DbSet<CmsLicenseKey> CmsLicenseKey { get; set; }
        public virtual DbSet<CmsMacroRule> CmsMacroRule { get; set; }
        public virtual DbSet<CmsMembership> CmsMembership { get; set; }
        public virtual DbSet<CmsMembershipRole> CmsMembershipRole { get; set; }
        public virtual DbSet<CmsMembershipUser> CmsMembershipUser { get; set; }
        public virtual DbSet<CmsMetaFile> CmsMetaFile { get; set; }
        public virtual DbSet<CmsModuleLicenseKey> CmsModuleLicenseKey { get; set; }
        public virtual DbSet<CmsObjectSettings> CmsObjectSettings { get; set; }
        public virtual DbSet<CmsObjectVersionHistory> CmsObjectVersionHistory { get; set; }
        public virtual DbSet<CmsObjectWorkflowTrigger> CmsObjectWorkflowTrigger { get; set; }
        public virtual DbSet<CmsOpenIduser> CmsOpenIduser { get; set; }
        public virtual DbSet<CmsPageTemplate> CmsPageTemplate { get; set; }
        public virtual DbSet<CmsPageTemplateCategory> CmsPageTemplateCategory { get; set; }
        public virtual DbSet<CmsPageTemplateScope> CmsPageTemplateScope { get; set; }
        public virtual DbSet<CmsPageTemplateSite> CmsPageTemplateSite { get; set; }
        public virtual DbSet<CmsPermission> CmsPermission { get; set; }
        public virtual DbSet<CmsPersonalization> CmsPersonalization { get; set; }
        public virtual DbSet<CmsQuery> CmsQuery { get; set; }
        public virtual DbSet<CmsRelationship> CmsRelationship { get; set; }
        public virtual DbSet<CmsRelationshipName> CmsRelationshipName { get; set; }
        public virtual DbSet<CmsRelationshipNameSite> CmsRelationshipNameSite { get; set; }
        public virtual DbSet<CmsResource> CmsResource { get; set; }
        public virtual DbSet<CmsResourceLibrary> CmsResourceLibrary { get; set; }
        public virtual DbSet<CmsResourceSite> CmsResourceSite { get; set; }
        public virtual DbSet<CmsResourceString> CmsResourceString { get; set; }
        public virtual DbSet<CmsResourceTranslation> CmsResourceTranslation { get; set; }
        public virtual DbSet<CmsRole> CmsRole { get; set; }
        public virtual DbSet<CmsRoleApplication> CmsRoleApplication { get; set; }
        public virtual DbSet<CmsRolePermission> CmsRolePermission { get; set; }
        public virtual DbSet<CmsRoleUielement> CmsRoleUielement { get; set; }
        public virtual DbSet<CmsScheduledTask> CmsScheduledTask { get; set; }
        public virtual DbSet<CmsSearchEngine> CmsSearchEngine { get; set; }
        public virtual DbSet<CmsSearchIndex> CmsSearchIndex { get; set; }
        public virtual DbSet<CmsSearchIndexCulture> CmsSearchIndexCulture { get; set; }
        public virtual DbSet<CmsSearchIndexSite> CmsSearchIndexSite { get; set; }
        public virtual DbSet<CmsSearchTask> CmsSearchTask { get; set; }
        public virtual DbSet<CmsSession> CmsSession { get; set; }
        public virtual DbSet<CmsSettingsCategory> CmsSettingsCategory { get; set; }
        public virtual DbSet<CmsSettingsKey> CmsSettingsKey { get; set; }
        public virtual DbSet<CmsSite> CmsSite { get; set; }
        public virtual DbSet<CmsSiteCulture> CmsSiteCulture { get; set; }
        public virtual DbSet<CmsSiteDomainAlias> CmsSiteDomainAlias { get; set; }
        public virtual DbSet<CmsSmtpserver> CmsSmtpserver { get; set; }
        public virtual DbSet<CmsSmtpserverSite> CmsSmtpserverSite { get; set; }
        public virtual DbSet<CmsState> CmsState { get; set; }
        public virtual DbSet<CmsTag> CmsTag { get; set; }
        public virtual DbSet<CmsTagGroup> CmsTagGroup { get; set; }
        public virtual DbSet<CmsTemplateDeviceLayout> CmsTemplateDeviceLayout { get; set; }
        public virtual DbSet<CmsTimeZone> CmsTimeZone { get; set; }
        public virtual DbSet<CmsTransformation> CmsTransformation { get; set; }
        public virtual DbSet<CmsTranslationService> CmsTranslationService { get; set; }
        public virtual DbSet<CmsTranslationSubmission> CmsTranslationSubmission { get; set; }
        public virtual DbSet<CmsTranslationSubmissionItem> CmsTranslationSubmissionItem { get; set; }
        public virtual DbSet<CmsTree> CmsTree { get; set; }
        public virtual DbSet<CmsUielement> CmsUielement { get; set; }
        public virtual DbSet<CmsUser> CmsUser { get; set; }
        public virtual DbSet<CmsUserCulture> CmsUserCulture { get; set; }
        public virtual DbSet<CmsUserRole> CmsUserRole { get; set; }
        public virtual DbSet<CmsUserSettings> CmsUserSettings { get; set; }
        public virtual DbSet<CmsUserSite> CmsUserSite { get; set; }
        public virtual DbSet<CmsVersionAttachment> CmsVersionAttachment { get; set; }
        public virtual DbSet<CmsVersionHistory> CmsVersionHistory { get; set; }
        public virtual DbSet<CmsWebFarmServer> CmsWebFarmServer { get; set; }
        public virtual DbSet<CmsWebFarmServerLog> CmsWebFarmServerLog { get; set; }
        public virtual DbSet<CmsWebFarmServerMonitoring> CmsWebFarmServerMonitoring { get; set; }
        public virtual DbSet<CmsWebFarmServerTask> CmsWebFarmServerTask { get; set; }
        public virtual DbSet<CmsWebFarmTask> CmsWebFarmTask { get; set; }
        public virtual DbSet<CmsWebPart> CmsWebPart { get; set; }
        public virtual DbSet<CmsWebPartCategory> CmsWebPartCategory { get; set; }
        public virtual DbSet<CmsWebPartContainer> CmsWebPartContainer { get; set; }
        public virtual DbSet<CmsWebPartContainerSite> CmsWebPartContainerSite { get; set; }
        public virtual DbSet<CmsWebPartLayout> CmsWebPartLayout { get; set; }
        public virtual DbSet<CmsWebTemplate> CmsWebTemplate { get; set; }
        public virtual DbSet<CmsWidget> CmsWidget { get; set; }
        public virtual DbSet<CmsWidgetCategory> CmsWidgetCategory { get; set; }
        public virtual DbSet<CmsWidgetRole> CmsWidgetRole { get; set; }
        public virtual DbSet<CmsWorkflow> CmsWorkflow { get; set; }
        public virtual DbSet<CmsWorkflowAction> CmsWorkflowAction { get; set; }
        public virtual DbSet<CmsWorkflowHistory> CmsWorkflowHistory { get; set; }
        public virtual DbSet<CmsWorkflowScope> CmsWorkflowScope { get; set; }
        public virtual DbSet<CmsWorkflowStep> CmsWorkflowStep { get; set; }
        public virtual DbSet<CmsWorkflowStepRoles> CmsWorkflowStepRoles { get; set; }
        public virtual DbSet<CmsWorkflowStepUser> CmsWorkflowStepUser { get; set; }
        public virtual DbSet<CmsWorkflowTransition> CmsWorkflowTransition { get; set; }
        public virtual DbSet<CmsWorkflowUser> CmsWorkflowUser { get; set; }
        public virtual DbSet<ComAddress> ComAddress { get; set; }
        public virtual DbSet<ComBundle> ComBundle { get; set; }
        public virtual DbSet<ComCarrier> ComCarrier { get; set; }
        public virtual DbSet<ComCouponCode> ComCouponCode { get; set; }
        public virtual DbSet<ComCurrency> ComCurrency { get; set; }
        public virtual DbSet<ComCurrencyExchangeRate> ComCurrencyExchangeRate { get; set; }
        public virtual DbSet<ComCustomer> ComCustomer { get; set; }
        public virtual DbSet<ComCustomerCreditHistory> ComCustomerCreditHistory { get; set; }
        public virtual DbSet<ComDepartment> ComDepartment { get; set; }
        public virtual DbSet<ComDepartmentTaxClass> ComDepartmentTaxClass { get; set; }
        public virtual DbSet<ComDiscount> ComDiscount { get; set; }
        public virtual DbSet<ComDiscountCoupon> ComDiscountCoupon { get; set; }
        public virtual DbSet<ComExchangeTable> ComExchangeTable { get; set; }
        public virtual DbSet<ComInternalStatus> ComInternalStatus { get; set; }
        public virtual DbSet<ComManufacturer> ComManufacturer { get; set; }
        public virtual DbSet<ComMultiBuyCouponCode> ComMultiBuyCouponCode { get; set; }
        public virtual DbSet<ComMultiBuyDiscount> ComMultiBuyDiscount { get; set; }
        public virtual DbSet<ComMultiBuyDiscountDepartment> ComMultiBuyDiscountDepartment { get; set; }
        public virtual DbSet<ComMultiBuyDiscountSku> ComMultiBuyDiscountSku { get; set; }
        public virtual DbSet<ComOptionCategory> ComOptionCategory { get; set; }
        public virtual DbSet<ComOrder> ComOrder { get; set; }
        public virtual DbSet<ComOrderAddress> ComOrderAddress { get; set; }
        public virtual DbSet<ComOrderItem> ComOrderItem { get; set; }
        public virtual DbSet<ComOrderItemSkufile> ComOrderItemSkufile { get; set; }
        public virtual DbSet<ComOrderStatus> ComOrderStatus { get; set; }
        public virtual DbSet<ComOrderStatusUser> ComOrderStatusUser { get; set; }
        public virtual DbSet<ComPaymentOption> ComPaymentOption { get; set; }
        public virtual DbSet<ComPublicStatus> ComPublicStatus { get; set; }
        public virtual DbSet<ComShippingCost> ComShippingCost { get; set; }
        public virtual DbSet<ComShippingOption> ComShippingOption { get; set; }
        public virtual DbSet<ComShippingOptionTaxClass> ComShippingOptionTaxClass { get; set; }
        public virtual DbSet<ComShoppingCart> ComShoppingCart { get; set; }
        public virtual DbSet<ComShoppingCartSku> ComShoppingCartSku { get; set; }
        public virtual DbSet<ComSku> ComSku { get; set; }
        public virtual DbSet<ComSkuallowedOption> ComSkuallowedOption { get; set; }
        public virtual DbSet<ComSkudiscountCoupon> ComSkudiscountCoupon { get; set; }
        public virtual DbSet<ComSkufile> ComSkufile { get; set; }
        public virtual DbSet<ComSkuoptionCategory> ComSkuoptionCategory { get; set; }
        public virtual DbSet<ComSkutaxClasses> ComSkutaxClasses { get; set; }
        public virtual DbSet<ComSupplier> ComSupplier { get; set; }
        public virtual DbSet<ComTaxClass> ComTaxClass { get; set; }
        public virtual DbSet<ComTaxClassCountry> ComTaxClassCountry { get; set; }
        public virtual DbSet<ComTaxClassState> ComTaxClassState { get; set; }
        public virtual DbSet<ComVariantOption> ComVariantOption { get; set; }
        public virtual DbSet<ComVolumeDiscount> ComVolumeDiscount { get; set; }
        public virtual DbSet<ComWishlist> ComWishlist { get; set; }
        public virtual DbSet<CommunityFriend> CommunityFriend { get; set; }
        public virtual DbSet<CommunityGroup> CommunityGroup { get; set; }
        public virtual DbSet<CommunityGroupMember> CommunityGroupMember { get; set; }
        public virtual DbSet<CommunityGroupRolePermission> CommunityGroupRolePermission { get; set; }
        public virtual DbSet<CommunityInvitation> CommunityInvitation { get; set; }
        public virtual DbSet<ContentArticle> ContentArticle { get; set; }
        public virtual DbSet<ContentBlog> ContentBlog { get; set; }
        public virtual DbSet<ContentBlogMonth> ContentBlogMonth { get; set; }
        public virtual DbSet<ContentBlogPost> ContentBlogPost { get; set; }
        public virtual DbSet<ContentBookingEvent> ContentBookingEvent { get; set; }
        public virtual DbSet<ContentEvent> ContentEvent { get; set; }
        public virtual DbSet<ContentFaq> ContentFaq { get; set; }
        public virtual DbSet<ContentFile> ContentFile { get; set; }
        public virtual DbSet<ContentJob> ContentJob { get; set; }
        public virtual DbSet<ContentKbarticle> ContentKbarticle { get; set; }
        public virtual DbSet<ContentMenuItem> ContentMenuItem { get; set; }
        public virtual DbSet<ContentNews> ContentNews { get; set; }
        public virtual DbSet<ContentOffice> ContentOffice { get; set; }
        public virtual DbSet<ContentPressRelease> ContentPressRelease { get; set; }
        public virtual DbSet<ContentProduct> ContentProduct { get; set; }
        public virtual DbSet<ContentSimpleArticle> ContentSimpleArticle { get; set; }
        public virtual DbSet<CustomtableSampleTable> CustomtableSampleTable { get; set; }
        public virtual DbSet<EventsAttendee> EventsAttendee { get; set; }
        public virtual DbSet<ExportHistory> ExportHistory { get; set; }
        public virtual DbSet<ExportTask> ExportTask { get; set; }
        public virtual DbSet<ForumsAttachment> ForumsAttachment { get; set; }
        public virtual DbSet<ForumsForum> ForumsForum { get; set; }
        public virtual DbSet<ForumsForumGroup> ForumsForumGroup { get; set; }
        public virtual DbSet<ForumsForumModerators> ForumsForumModerators { get; set; }
        public virtual DbSet<ForumsForumPost> ForumsForumPost { get; set; }
        public virtual DbSet<ForumsForumRoles> ForumsForumRoles { get; set; }
        public virtual DbSet<ForumsForumSubscription> ForumsForumSubscription { get; set; }
        public virtual DbSet<ForumsUserFavorites> ForumsUserFavorites { get; set; }
        public virtual DbSet<IntegrationConnector> IntegrationConnector { get; set; }
        public virtual DbSet<IntegrationSyncLog> IntegrationSyncLog { get; set; }
        public virtual DbSet<IntegrationSynchronization> IntegrationSynchronization { get; set; }
        public virtual DbSet<IntegrationTask> IntegrationTask { get; set; }
        public virtual DbSet<MediaFile> MediaFile { get; set; }
        public virtual DbSet<MediaLibrary> MediaLibrary { get; set; }
        public virtual DbSet<MediaLibraryRolePermission> MediaLibraryRolePermission { get; set; }
        public virtual DbSet<MessagingContactList> MessagingContactList { get; set; }
        public virtual DbSet<MessagingIgnoreList> MessagingIgnoreList { get; set; }
        public virtual DbSet<MessagingMessage> MessagingMessage { get; set; }
        public virtual DbSet<NewsletterAbtest> NewsletterAbtest { get; set; }
        public virtual DbSet<NewsletterClickedLink> NewsletterClickedLink { get; set; }
        public virtual DbSet<NewsletterEmailTemplate> NewsletterEmailTemplate { get; set; }
        public virtual DbSet<NewsletterEmailTemplateNewsletter> NewsletterEmailTemplateNewsletter { get; set; }
        public virtual DbSet<NewsletterEmails> NewsletterEmails { get; set; }
        public virtual DbSet<NewsletterIssueContactGroup> NewsletterIssueContactGroup { get; set; }
        public virtual DbSet<NewsletterLink> NewsletterLink { get; set; }
        public virtual DbSet<NewsletterNewsletter> NewsletterNewsletter { get; set; }
        public virtual DbSet<NewsletterNewsletterIssue> NewsletterNewsletterIssue { get; set; }
        public virtual DbSet<NewsletterOpenedEmail> NewsletterOpenedEmail { get; set; }
        public virtual DbSet<NewsletterSubscriber> NewsletterSubscriber { get; set; }
        public virtual DbSet<NewsletterSubscriberNewsletter> NewsletterSubscriberNewsletter { get; set; }
        public virtual DbSet<NewsletterUnsubscription> NewsletterUnsubscription { get; set; }
        public virtual DbSet<NotificationGateway> NotificationGateway { get; set; }
        public virtual DbSet<NotificationSubscription> NotificationSubscription { get; set; }
        public virtual DbSet<NotificationTemplate> NotificationTemplate { get; set; }
        public virtual DbSet<NotificationTemplateText> NotificationTemplateText { get; set; }
        public virtual DbSet<OmAbtest> OmAbtest { get; set; }
        public virtual DbSet<OmAbvariant> OmAbvariant { get; set; }
        public virtual DbSet<OmAccount> OmAccount { get; set; }
        public virtual DbSet<OmAccountContact> OmAccountContact { get; set; }
        public virtual DbSet<OmAccountStatus> OmAccountStatus { get; set; }
        public virtual DbSet<OmActivity> OmActivity { get; set; }
        public virtual DbSet<OmActivityRecalculationQueue> OmActivityRecalculationQueue { get; set; }
        public virtual DbSet<OmActivityType> OmActivityType { get; set; }
        public virtual DbSet<OmContact> OmContact { get; set; }
        public virtual DbSet<OmContactChangeRecalculationQueue> OmContactChangeRecalculationQueue { get; set; }
        public virtual DbSet<OmContactGroup> OmContactGroup { get; set; }
        public virtual DbSet<OmContactGroupMember> OmContactGroupMember { get; set; }
        public virtual DbSet<OmContactRole> OmContactRole { get; set; }
        public virtual DbSet<OmContactStatus> OmContactStatus { get; set; }
        public virtual DbSet<OmMembership> OmMembership { get; set; }
        public virtual DbSet<OmMvtcombination> OmMvtcombination { get; set; }
        public virtual DbSet<OmMvtcombinationVariation> OmMvtcombinationVariation { get; set; }
        public virtual DbSet<OmMvtest> OmMvtest { get; set; }
        public virtual DbSet<OmMvtvariant> OmMvtvariant { get; set; }
        public virtual DbSet<OmPersonalizationVariant> OmPersonalizationVariant { get; set; }
        public virtual DbSet<OmRule> OmRule { get; set; }
        public virtual DbSet<OmScore> OmScore { get; set; }
        public virtual DbSet<OmScoreContactRule> OmScoreContactRule { get; set; }
        public virtual DbSet<OmVisitorToContact> OmVisitorToContact { get; set; }
        public virtual DbSet<PersonasPersona> PersonasPersona { get; set; }
        public virtual DbSet<PersonasPersonaNode> PersonasPersonaNode { get; set; }
        public virtual DbSet<PollsPoll> PollsPoll { get; set; }
        public virtual DbSet<PollsPollAnswer> PollsPollAnswer { get; set; }
        public virtual DbSet<PollsPollRoles> PollsPollRoles { get; set; }
        public virtual DbSet<PollsPollSite> PollsPollSite { get; set; }
        public virtual DbSet<ReportingReport> ReportingReport { get; set; }
        public virtual DbSet<ReportingReportCategory> ReportingReportCategory { get; set; }
        public virtual DbSet<ReportingReportGraph> ReportingReportGraph { get; set; }
        public virtual DbSet<ReportingReportSubscription> ReportingReportSubscription { get; set; }
        public virtual DbSet<ReportingReportTable> ReportingReportTable { get; set; }
        public virtual DbSet<ReportingReportValue> ReportingReportValue { get; set; }
        public virtual DbSet<ReportingSavedGraph> ReportingSavedGraph { get; set; }
        public virtual DbSet<ReportingSavedReport> ReportingSavedReport { get; set; }
        public virtual DbSet<SharePointSharePointConnection> SharePointSharePointConnection { get; set; }
        public virtual DbSet<SharePointSharePointFile> SharePointSharePointFile { get; set; }
        public virtual DbSet<SharePointSharePointLibrary> SharePointSharePointLibrary { get; set; }
        public virtual DbSet<SmFacebookAccount> SmFacebookAccount { get; set; }
        public virtual DbSet<SmFacebookApplication> SmFacebookApplication { get; set; }
        public virtual DbSet<SmFacebookPost> SmFacebookPost { get; set; }
        public virtual DbSet<SmInsight> SmInsight { get; set; }
        public virtual DbSet<SmInsightHitDay> SmInsightHitDay { get; set; }
        public virtual DbSet<SmInsightHitMonth> SmInsightHitMonth { get; set; }
        public virtual DbSet<SmInsightHitWeek> SmInsightHitWeek { get; set; }
        public virtual DbSet<SmInsightHitYear> SmInsightHitYear { get; set; }
        public virtual DbSet<SmLinkedInAccount> SmLinkedInAccount { get; set; }
        public virtual DbSet<SmLinkedInApplication> SmLinkedInApplication { get; set; }
        public virtual DbSet<SmLinkedInPost> SmLinkedInPost { get; set; }
        public virtual DbSet<SmTwitterAccount> SmTwitterAccount { get; set; }
        public virtual DbSet<SmTwitterApplication> SmTwitterApplication { get; set; }
        public virtual DbSet<SmTwitterPost> SmTwitterPost { get; set; }
        public virtual DbSet<StagingServer> StagingServer { get; set; }
        public virtual DbSet<StagingSynchronization> StagingSynchronization { get; set; }
        public virtual DbSet<StagingTask> StagingTask { get; set; }
        public virtual DbSet<StagingTaskGroup> StagingTaskGroup { get; set; }
        public virtual DbSet<StagingTaskGroupTask> StagingTaskGroupTask { get; set; }
        public virtual DbSet<StagingTaskGroupUser> StagingTaskGroupUser { get; set; }
        public virtual DbSet<StagingTaskUser> StagingTaskUser { get; set; }
        public virtual DbSet<TempFile> TempFile { get; set; }

        // Unable to generate entity type for table 'dbo.CMS_ModuleUsageCounter'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=(local);Database=vanilla-kentico;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnalyticsCampaign>(entity =>
            {
                entity.HasKey(e => e.CampaignId)
                    .HasName("PK_Analytics_Campaign");

                entity.ToTable("Analytics_Campaign");

                entity.HasIndex(e => e.CampaignScheduledTaskId)
                    .HasName("IX_Analytics_Campaign_CampaignScheduledTaskID");

                entity.HasIndex(e => e.CampaignSiteId)
                    .HasName("IX_Analytics_Campaign_CampaignSiteID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.CampaignDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CampaignGuid).HasColumnName("CampaignGUID");

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CampaignScheduledTaskId).HasColumnName("CampaignScheduledTaskID");

                entity.Property(e => e.CampaignSiteId).HasColumnName("CampaignSiteID");

                entity.Property(e => e.CampaignUtmcode)
                    .HasColumnName("CampaignUTMCode")
                    .HasMaxLength(200);

                entity.HasOne(d => d.CampaignScheduledTask)
                    .WithMany(p => p.AnalyticsCampaign)
                    .HasForeignKey(d => d.CampaignScheduledTaskId)
                    .HasConstraintName("FK_Analytics_Campaign_CampaignScheduledTaskID_ScheduledTask");

                entity.HasOne(d => d.CampaignSite)
                    .WithMany(p => p.AnalyticsCampaign)
                    .HasForeignKey(d => d.CampaignSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_Campaign_StatisticsSiteID_CMS_Site");
            });

            modelBuilder.Entity<AnalyticsCampaignAsset>(entity =>
            {
                entity.HasKey(e => e.CampaignAssetId)
                    .HasName("PK_Analytics_CampaignAsset");

                entity.ToTable("Analytics_CampaignAsset");

                entity.HasIndex(e => e.CampaignAssetCampaignId)
                    .HasName("IX_Analytics_CampaignAsset_CampaignAssetCampaignID");

                entity.Property(e => e.CampaignAssetId).HasColumnName("CampaignAssetID");

                entity.Property(e => e.CampaignAssetAssetGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.CampaignAssetCampaignId)
                    .HasColumnName("CampaignAssetCampaignID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CampaignAssetGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.CampaignAssetLastModified).HasDefaultValueSql("'1/1/0001 12:00:00 AM'");

                entity.Property(e => e.CampaignAssetSiteName).HasMaxLength(200);

                entity.Property(e => e.CampaignAssetType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.HasOne(d => d.CampaignAssetCampaign)
                    .WithMany(p => p.AnalyticsCampaignAsset)
                    .HasForeignKey(d => d.CampaignAssetCampaignId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_CampaignAsset_CampaignAssetCampaignID_Analytics_Campaign");
            });

            modelBuilder.Entity<AnalyticsCampaignAssetUrl>(entity =>
            {
                entity.HasKey(e => e.CampaignAssetUrlId)
                    .HasName("PK_Analytics_CampaignAssetUrl");

                entity.ToTable("Analytics_CampaignAssetUrl");

                entity.HasIndex(e => e.CampaignAssetUrlCampaignAssetId)
                    .HasName("IX_Analytics_CampaignAssetUrl_CampaignAssetUrlCampaignAssetID");

                entity.Property(e => e.CampaignAssetUrlId).HasColumnName("CampaignAssetUrlID");

                entity.Property(e => e.CampaignAssetUrlCampaignAssetId)
                    .HasColumnName("CampaignAssetUrlCampaignAssetID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CampaignAssetUrlGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.CampaignAssetUrlPageTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CampaignAssetUrlTarget)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.HasOne(d => d.CampaignAssetUrlCampaignAsset)
                    .WithMany(p => p.AnalyticsCampaignAssetUrl)
                    .HasForeignKey(d => d.CampaignAssetUrlCampaignAssetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_CampaignAssetUrl_CampaignAssetUrlCampaignAssetID_Analytics_CampaignAsset");
            });

            modelBuilder.Entity<AnalyticsCampaignConversion>(entity =>
            {
                entity.HasKey(e => e.CampaignConversionId)
                    .HasName("PK_Analytics_CampaignConversion");

                entity.ToTable("Analytics_CampaignConversion");

                entity.HasIndex(e => e.CampaignConversionCampaignId)
                    .HasName("IX_Analytics_CampaignConversion_CampaignConversionCampaignID");

                entity.Property(e => e.CampaignConversionId).HasColumnName("CampaignConversionID");

                entity.Property(e => e.CampaignConversionActivityType)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CampaignConversionCampaignId)
                    .HasColumnName("CampaignConversionCampaignID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CampaignConversionDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CampaignConversionGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.CampaignConversionHits).HasDefaultValueSql("0");

                entity.Property(e => e.CampaignConversionIsFunnelStep).HasDefaultValueSql("0");

                entity.Property(e => e.CampaignConversionItemId).HasColumnName("CampaignConversionItemID");

                entity.Property(e => e.CampaignConversionLastModified).HasDefaultValueSql("'1/1/0001 12:00:00 AM'");

                entity.Property(e => e.CampaignConversionName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CampaignConversionOrder).HasDefaultValueSql("0");

                entity.Property(e => e.CampaignConversionUrl).HasColumnName("CampaignConversionURL");

                entity.Property(e => e.CampaignConversionValue).HasDefaultValueSql("0");

                entity.HasOne(d => d.CampaignConversionCampaign)
                    .WithMany(p => p.AnalyticsCampaignConversion)
                    .HasForeignKey(d => d.CampaignConversionCampaignId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_CampaignConversion_CampaignConversionCampaignID_Analytics_Campaign");
            });

            modelBuilder.Entity<AnalyticsCampaignConversionHits>(entity =>
            {
                entity.HasKey(e => e.CampaignConversionHitsId)
                    .HasName("PK_Analytics_CampaignConversionHits");

                entity.ToTable("Analytics_CampaignConversionHits");

                entity.HasIndex(e => e.CampaignConversionHitsConversionId)
                    .HasName("IX_Analytics_CampaignConversionHits_CampaignConversionHitsConversionID");

                entity.Property(e => e.CampaignConversionHitsId).HasColumnName("CampaignConversionHitsID");

                entity.Property(e => e.CampaignConversionHitsConversionId)
                    .HasColumnName("CampaignConversionHitsConversionID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CampaignConversionHitsCount).HasDefaultValueSql("0");

                entity.Property(e => e.CampaignConversionHitsSourceName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.HasOne(d => d.CampaignConversionHitsConversion)
                    .WithMany(p => p.AnalyticsCampaignConversionHits)
                    .HasForeignKey(d => d.CampaignConversionHitsConversionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_CampaignConversionHits_CampaignConversionHitsConversionID_Analytics_CampaignConversion");
            });

            modelBuilder.Entity<AnalyticsCampaignObjective>(entity =>
            {
                entity.HasKey(e => e.CampaignObjectiveId)
                    .HasName("PK_Analytics_CampaignObjective");

                entity.ToTable("Analytics_CampaignObjective");

                entity.HasIndex(e => e.CampaignObjectiveCampaignConversionId)
                    .HasName("IX_Analytics_CampaignObjective_CampaignObjectiveCampaignConversionID");

                entity.HasIndex(e => e.CampaignObjectiveCampaignId)
                    .HasName("CK_Analytics_CampaignObjective_CampaignObjectiveCampaignID")
                    .IsUnique();

                entity.Property(e => e.CampaignObjectiveId).HasColumnName("CampaignObjectiveID");

                entity.Property(e => e.CampaignObjectiveCampaignConversionId)
                    .HasColumnName("CampaignObjectiveCampaignConversionID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CampaignObjectiveCampaignId)
                    .HasColumnName("CampaignObjectiveCampaignID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CampaignObjectiveGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.CampaignObjectiveLastModified).HasDefaultValueSql("'1/1/0001 12:00:00 AM'");

                entity.HasOne(d => d.CampaignObjectiveCampaignConversion)
                    .WithMany(p => p.AnalyticsCampaignObjective)
                    .HasForeignKey(d => d.CampaignObjectiveCampaignConversionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_CampaignObjective_CampaignObjectiveCampaignConversionID_Analytics_CampaignConversion");

                entity.HasOne(d => d.CampaignObjectiveCampaign)
                    .WithOne(p => p.AnalyticsCampaignObjective)
                    .HasForeignKey<AnalyticsCampaignObjective>(d => d.CampaignObjectiveCampaignId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_CampaignObjective_CampaignObjectiveCampaignID_Analytics_Campaign");
            });

            modelBuilder.Entity<AnalyticsConversion>(entity =>
            {
                entity.HasKey(e => e.ConversionId)
                    .HasName("PK_CMS_Conversion");

                entity.ToTable("Analytics_Conversion");

                entity.HasIndex(e => e.ConversionSiteId)
                    .HasName("IX_Analytics_Conversion_ConversionSiteID");

                entity.Property(e => e.ConversionId).HasColumnName("ConversionID");

                entity.Property(e => e.ConversionDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ConversionGuid).HasColumnName("ConversionGUID");

                entity.Property(e => e.ConversionName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ConversionSiteId).HasColumnName("ConversionSiteID");

                entity.HasOne(d => d.ConversionSite)
                    .WithMany(p => p.AnalyticsConversion)
                    .HasForeignKey(d => d.ConversionSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_Conversion_ConversionSiteID_CMS_Site");
            });

            modelBuilder.Entity<AnalyticsDayHits>(entity =>
            {
                entity.HasKey(e => e.HitsId)
                    .HasName("PK_Analytics_DayHits");

                entity.ToTable("Analytics_DayHits");

                entity.HasIndex(e => e.HitsStatisticsId)
                    .HasName("IX_Analytics_DayHits_HitsStatisticsID");

                entity.HasIndex(e => new { e.HitsStartTime, e.HitsEndTime })
                    .HasName("IX_Analytics_DayHits_HitsStartTime_HitsEndTime");

                entity.Property(e => e.HitsId).HasColumnName("HitsID");

                entity.Property(e => e.HitsStatisticsId).HasColumnName("HitsStatisticsID");

                entity.HasOne(d => d.HitsStatistics)
                    .WithMany(p => p.AnalyticsDayHits)
                    .HasForeignKey(d => d.HitsStatisticsId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_DayHits_HitsStatisticsID_Analytics_Statistics");
            });

            modelBuilder.Entity<AnalyticsExitPages>(entity =>
            {
                entity.HasKey(e => e.SessionIdentificator)
                    .HasName("PK_Analytics_ExitPages");

                entity.ToTable("Analytics_ExitPages");

                entity.HasIndex(e => e.ExitPageLastModified)
                    .HasName("IX_Analytics_ExitPages_ExitPageLastModified");

                entity.Property(e => e.SessionIdentificator).HasMaxLength(200);

                entity.Property(e => e.ExitPageCulture).HasMaxLength(10);

                entity.Property(e => e.ExitPageNodeId).HasColumnName("ExitPageNodeID");

                entity.Property(e => e.ExitPageSiteId).HasColumnName("ExitPageSiteID");
            });

            modelBuilder.Entity<AnalyticsHourHits>(entity =>
            {
                entity.HasKey(e => e.HitsId)
                    .HasName("PK_Analytics_HourHits");

                entity.ToTable("Analytics_HourHits");

                entity.HasIndex(e => e.HitsStatisticsId)
                    .HasName("IX_Analytics_HourHits_HitsStatisticsID");

                entity.HasIndex(e => new { e.HitsStartTime, e.HitsEndTime })
                    .HasName("IX_Analytics_HourHits_HitsStartTime_HitsEndTime");

                entity.Property(e => e.HitsId).HasColumnName("HitsID");

                entity.Property(e => e.HitsStatisticsId).HasColumnName("HitsStatisticsID");

                entity.HasOne(d => d.HitsStatistics)
                    .WithMany(p => p.AnalyticsHourHits)
                    .HasForeignKey(d => d.HitsStatisticsId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_HourHits_HitsStatisticsID_Analytics_Statistics");
            });

            modelBuilder.Entity<AnalyticsMonthHits>(entity =>
            {
                entity.HasKey(e => e.HitsId)
                    .HasName("PK_Analytics_MonthHits");

                entity.ToTable("Analytics_MonthHits");

                entity.HasIndex(e => e.HitsStatisticsId)
                    .HasName("IX_Analytics_MonthHits_HitsStatisticsID");

                entity.HasIndex(e => new { e.HitsStartTime, e.HitsEndTime })
                    .HasName("IX_Analytics_MonthHits_HitsStartTime_HitsEndTime");

                entity.Property(e => e.HitsId).HasColumnName("HitsID");

                entity.Property(e => e.HitsStatisticsId).HasColumnName("HitsStatisticsID");

                entity.HasOne(d => d.HitsStatistics)
                    .WithMany(p => p.AnalyticsMonthHits)
                    .HasForeignKey(d => d.HitsStatisticsId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_MonthHits_HitsStatisticsID_Analytics_Statistics");
            });

            modelBuilder.Entity<AnalyticsStatistics>(entity =>
            {
                entity.HasKey(e => e.StatisticsId)
                    .HasName("PK_Analytics_Statistics");

                entity.ToTable("Analytics_Statistics");

                entity.HasIndex(e => e.StatisticsCode)
                    .HasName("IX_Analytics_Statistics_StatisticsCode_StatisticsSiteID_StatisticsObjectID_StatisticsObjectCulture");

                entity.HasIndex(e => e.StatisticsSiteId)
                    .HasName("IX_Analytics_Statistics_StatisticsSiteID");

                entity.Property(e => e.StatisticsId).HasColumnName("StatisticsID");

                entity.Property(e => e.StatisticsCode)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StatisticsObjectCulture)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.StatisticsObjectId).HasColumnName("StatisticsObjectID");

                entity.Property(e => e.StatisticsObjectName)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.StatisticsSiteId).HasColumnName("StatisticsSiteID");

                entity.HasOne(d => d.StatisticsSite)
                    .WithMany(p => p.AnalyticsStatistics)
                    .HasForeignKey(d => d.StatisticsSiteId)
                    .HasConstraintName("FK_Analytics_Statistics_StatisticsSiteID_CMS_Site");
            });

            modelBuilder.Entity<AnalyticsWeekHits>(entity =>
            {
                entity.HasKey(e => e.HitsId)
                    .HasName("PK_Analytics_WeekHits");

                entity.ToTable("Analytics_WeekHits");

                entity.HasIndex(e => e.HitsStatisticsId)
                    .HasName("IX_Analytics_WeekHits_HitsStatisticsID");

                entity.HasIndex(e => new { e.HitsStartTime, e.HitsEndTime })
                    .HasName("IX_Analytics_WeekHits_HitsStartTime_HitsEndTime");

                entity.Property(e => e.HitsId).HasColumnName("HitsID");

                entity.Property(e => e.HitsStatisticsId).HasColumnName("HitsStatisticsID");

                entity.HasOne(d => d.HitsStatistics)
                    .WithMany(p => p.AnalyticsWeekHits)
                    .HasForeignKey(d => d.HitsStatisticsId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_WeekHits_HitsStatisticsID_Analytics_Statistics");
            });

            modelBuilder.Entity<AnalyticsYearHits>(entity =>
            {
                entity.HasKey(e => e.HitsId)
                    .HasName("PK_Analytics_YearHits");

                entity.ToTable("Analytics_YearHits");

                entity.HasIndex(e => e.HitsStatisticsId)
                    .HasName("IX_Analytics_WeekYearHits_HitsStatisticsID");

                entity.HasIndex(e => new { e.HitsStartTime, e.HitsEndTime })
                    .HasName("IX_Analytics_YearHits_HitsStartTime_HitsEndTime");

                entity.Property(e => e.HitsId).HasColumnName("HitsID");

                entity.Property(e => e.HitsStatisticsId).HasColumnName("HitsStatisticsID");

                entity.HasOne(d => d.HitsStatistics)
                    .WithMany(p => p.AnalyticsYearHits)
                    .HasForeignKey(d => d.HitsStatisticsId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Analytics_YearHits_HitsStatisticsID_Analytics_Statistics");
            });

            modelBuilder.Entity<BadWordsWord>(entity =>
            {
                entity.HasKey(e => e.WordId)
                    .HasName("PK_BadWords_Word");

                entity.ToTable("BadWords_Word");

                entity.HasIndex(e => e.WordExpression)
                    .HasName("IX_BadWords_Word_WordExpression");

                entity.HasIndex(e => e.WordIsGlobal)
                    .HasName("IX_BadWords_Word_WordIsGlobal");

                entity.Property(e => e.WordId).HasColumnName("WordID");

                entity.Property(e => e.WordExpression)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.WordGuid).HasColumnName("WordGUID");

                entity.Property(e => e.WordIsGlobal).HasDefaultValueSql("0");

                entity.Property(e => e.WordIsRegularExpression).HasDefaultValueSql("0");

                entity.Property(e => e.WordReplacement).HasMaxLength(200);
            });

            modelBuilder.Entity<BadWordsWordCulture>(entity =>
            {
                entity.HasKey(e => new { e.WordId, e.CultureId })
                    .HasName("PK_BadWords_WordCulture");

                entity.ToTable("BadWords_WordCulture");

                entity.HasIndex(e => e.CultureId)
                    .HasName("IX_BadWords_WordCulture_CultureID");

                entity.Property(e => e.WordId).HasColumnName("WordID");

                entity.Property(e => e.CultureId).HasColumnName("CultureID");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.BadWordsWordCulture)
                    .HasForeignKey(d => d.CultureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BadWords_WordCulture_CultureID_CMS_Culture");

                entity.HasOne(d => d.Word)
                    .WithMany(p => p.BadWordsWordCulture)
                    .HasForeignKey(d => d.WordId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BadWords_WordCulture_WordID_BadWords_Word");
            });

            modelBuilder.Entity<BlogComment>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PK_Blog_Comment");

                entity.ToTable("Blog_Comment");

                entity.HasIndex(e => e.CommentApprovedByUserId)
                    .HasName("IX_Blog_Comment_CommentApprovedByUserID");

                entity.HasIndex(e => e.CommentDate)
                    .HasName("IX_Blog_Comment_CommentDate");

                entity.HasIndex(e => e.CommentPostDocumentId)
                    .HasName("IX_Blog_Comment_CommentPostDocumentID");

                entity.HasIndex(e => e.CommentUserId)
                    .HasName("IX_Blog_Comment_CommentUserID");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CommentApproved).HasDefaultValueSql("0");

                entity.Property(e => e.CommentApprovedByUserId).HasColumnName("CommentApprovedByUserID");

                entity.Property(e => e.CommentEmail).HasMaxLength(254);

                entity.Property(e => e.CommentGuid)
                    .HasColumnName("CommentGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.CommentIsSpam).HasDefaultValueSql("0");

                entity.Property(e => e.CommentPostDocumentId).HasColumnName("CommentPostDocumentID");

                entity.Property(e => e.CommentText).IsRequired();

                entity.Property(e => e.CommentUrl).HasMaxLength(450);

                entity.Property(e => e.CommentUserId).HasColumnName("CommentUserID");

                entity.Property(e => e.CommentUserName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.CommentApprovedByUser)
                    .WithMany(p => p.BlogCommentCommentApprovedByUser)
                    .HasForeignKey(d => d.CommentApprovedByUserId)
                    .HasConstraintName("FK_Blog_Comment_CommentApprovedByUserID_CMS_User");

                entity.HasOne(d => d.CommentPostDocument)
                    .WithMany(p => p.BlogComment)
                    .HasForeignKey(d => d.CommentPostDocumentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Blog_Comment_CommentPostDocumentID_CMS_Document");

                entity.HasOne(d => d.CommentUser)
                    .WithMany(p => p.BlogCommentCommentUser)
                    .HasForeignKey(d => d.CommentUserId)
                    .HasConstraintName("FK_Blog_Comment_CommentUserID_CMS_User");
            });

            modelBuilder.Entity<BlogPostSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId)
                    .HasName("PK_Blog_PostSubscription");

                entity.ToTable("Blog_PostSubscription");

                entity.HasIndex(e => e.SubscriptionPostDocumentId)
                    .HasName("IX_Blog_PostSubscription_SubscriptionPostDocumentID");

                entity.HasIndex(e => e.SubscriptionUserId)
                    .HasName("IX_Blog_PostSubscription_SubscriptionUserID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.SubscriptionApprovalHash).HasMaxLength(100);

                entity.Property(e => e.SubscriptionEmail).HasMaxLength(254);

                entity.Property(e => e.SubscriptionGuid).HasColumnName("SubscriptionGUID");

                entity.Property(e => e.SubscriptionPostDocumentId).HasColumnName("SubscriptionPostDocumentID");

                entity.Property(e => e.SubscriptionUserId).HasColumnName("SubscriptionUserID");

                entity.HasOne(d => d.SubscriptionPostDocument)
                    .WithMany(p => p.BlogPostSubscription)
                    .HasForeignKey(d => d.SubscriptionPostDocumentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Blog_PostSubscription_SubscriptionPostDocumentID_CMS_Document");

                entity.HasOne(d => d.SubscriptionUser)
                    .WithMany(p => p.BlogPostSubscription)
                    .HasForeignKey(d => d.SubscriptionUserId)
                    .HasConstraintName("FK_Blog_PostSubscription_SubscriptionUserID_CMS_User");
            });

            modelBuilder.Entity<BoardBoard>(entity =>
            {
                entity.HasKey(e => e.BoardId)
                    .HasName("PK_Board_Board");

                entity.ToTable("Board_Board");

                entity.HasIndex(e => e.BoardSiteId)
                    .HasName("IX_Board_Board_BoardSiteID");

                entity.HasIndex(e => new { e.BoardDocumentId, e.BoardName })
                    .HasName("IX_Board_Board_BoardDocumentID_BoardName")
                    .IsUnique();

                entity.HasIndex(e => new { e.BoardGroupId, e.BoardName })
                    .HasName("IX_Board_Board_BoardGroupID_BoardName");

                entity.HasIndex(e => new { e.BoardUserId, e.BoardName })
                    .HasName("IX_Board_Board_BoardUserID_BoardName");

                entity.Property(e => e.BoardId).HasColumnName("BoardID");

                entity.Property(e => e.BoardBaseUrl)
                    .HasColumnName("BoardBaseURL")
                    .HasMaxLength(450);

                entity.Property(e => e.BoardDescription).IsRequired();

                entity.Property(e => e.BoardDisplayName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.BoardDocumentId).HasColumnName("BoardDocumentID");

                entity.Property(e => e.BoardEnableSubscriptions).HasDefaultValueSql("0");

                entity.Property(e => e.BoardGroupId).HasColumnName("BoardGroupID");

                entity.Property(e => e.BoardGuid).HasColumnName("BoardGUID");

                entity.Property(e => e.BoardLastMessageUserName).HasMaxLength(250);

                entity.Property(e => e.BoardName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BoardOptInApprovalUrl)
                    .HasColumnName("BoardOptInApprovalURL")
                    .HasMaxLength(450);

                entity.Property(e => e.BoardRequireEmails).HasDefaultValueSql("0");

                entity.Property(e => e.BoardSiteId).HasColumnName("BoardSiteID");

                entity.Property(e => e.BoardUnsubscriptionUrl)
                    .HasColumnName("BoardUnsubscriptionURL")
                    .HasMaxLength(450);

                entity.Property(e => e.BoardUserId).HasColumnName("BoardUserID");

                entity.HasOne(d => d.BoardDocument)
                    .WithMany(p => p.BoardBoard)
                    .HasForeignKey(d => d.BoardDocumentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Board_Board_BoardDocumentID_CMS_Document");

                entity.HasOne(d => d.BoardGroup)
                    .WithMany(p => p.BoardBoard)
                    .HasForeignKey(d => d.BoardGroupId)
                    .HasConstraintName("FK_Board_Board_BoardGroupID_Community_Group");

                entity.HasOne(d => d.BoardSite)
                    .WithMany(p => p.BoardBoard)
                    .HasForeignKey(d => d.BoardSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Board_Board_BoardSiteID_CMS_Site");

                entity.HasOne(d => d.BoardUser)
                    .WithMany(p => p.BoardBoard)
                    .HasForeignKey(d => d.BoardUserId)
                    .HasConstraintName("FK_Board_Board_BoardUserID_CMS_User");
            });

            modelBuilder.Entity<BoardMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK_Board_Message");

                entity.ToTable("Board_Message");

                entity.HasIndex(e => e.MessageApprovedByUserId)
                    .HasName("IX_Board_Message_MessageApprovedByUserID");

                entity.HasIndex(e => e.MessageInserted)
                    .HasName("IX_Board_Message_MessageInserted");

                entity.HasIndex(e => e.MessageUserId)
                    .HasName("IX_Board_Message_MessageUserID");

                entity.HasIndex(e => new { e.MessageApproved, e.MessageIsSpam })
                    .HasName("IX_Board_Message_MessageApproved_MessageIsSpam");

                entity.HasIndex(e => new { e.MessageBoardId, e.MessageGuid })
                    .HasName("IX_Board_Message_MessageBoardID_MessageGUID")
                    .IsUnique();

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.MessageApproved).HasDefaultValueSql("0");

                entity.Property(e => e.MessageApprovedByUserId).HasColumnName("MessageApprovedByUserID");

                entity.Property(e => e.MessageAvatarGuid).HasColumnName("MessageAvatarGUID");

                entity.Property(e => e.MessageBoardId)
                    .HasColumnName("MessageBoardID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MessageEmail)
                    .IsRequired()
                    .HasMaxLength(254)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.MessageGuid)
                    .HasColumnName("MessageGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.MessageInserted).HasDefaultValueSql("'8/26/2008 12:14:50 PM'");

                entity.Property(e => e.MessageIsSpam).HasDefaultValueSql("0");

                entity.Property(e => e.MessageLastModified).HasDefaultValueSql("'8/26/2008 12:15:04 PM'");

                entity.Property(e => e.MessageText)
                    .IsRequired()
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MessageUrl)
                    .IsRequired()
                    .HasColumnName("MessageURL")
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MessageUserId).HasColumnName("MessageUserID");

                entity.Property(e => e.MessageUserInfo)
                    .IsRequired()
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MessageUserName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.MessageApprovedByUser)
                    .WithMany(p => p.BoardMessageMessageApprovedByUser)
                    .HasForeignKey(d => d.MessageApprovedByUserId)
                    .HasConstraintName("FK_Board_Message_MessageApprovedByUserID_CMS_User");

                entity.HasOne(d => d.MessageBoard)
                    .WithMany(p => p.BoardMessage)
                    .HasForeignKey(d => d.MessageBoardId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Board_Message_MessageBoardID_Board_Board");

                entity.HasOne(d => d.MessageUser)
                    .WithMany(p => p.BoardMessageMessageUser)
                    .HasForeignKey(d => d.MessageUserId)
                    .HasConstraintName("FK_Board_Message_MessageUserID_CMS_User");
            });

            modelBuilder.Entity<BoardModerator>(entity =>
            {
                entity.HasKey(e => new { e.BoardId, e.UserId })
                    .HasName("PK_Board_Moderator");

                entity.ToTable("Board_Moderator");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_Board_Moderator_UserID");

                entity.Property(e => e.BoardId).HasColumnName("BoardID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Board)
                    .WithMany(p => p.BoardModerator)
                    .HasForeignKey(d => d.BoardId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Board_Moderator_BoardID_Board_Board");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BoardModerator)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Board_Moderator_UserID_CMS_User");
            });

            modelBuilder.Entity<BoardRole>(entity =>
            {
                entity.HasKey(e => new { e.BoardId, e.RoleId })
                    .HasName("PK_Board_Role");

                entity.ToTable("Board_Role");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_Board_Role_RoleID");

                entity.Property(e => e.BoardId).HasColumnName("BoardID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Board)
                    .WithMany(p => p.BoardRole)
                    .HasForeignKey(d => d.BoardId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Board_Role_BoardID_Board_Board");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.BoardRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Board_Role_RoleID_CMS_Role");
            });

            modelBuilder.Entity<BoardSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId)
                    .HasName("PK_Board_Subscription");

                entity.ToTable("Board_Subscription");

                entity.HasIndex(e => e.SubscriptionBoardId)
                    .HasName("IX_Board_Subscription_SubscriptionBoardID");

                entity.HasIndex(e => e.SubscriptionUserId)
                    .HasName("IX_Board_Subscription_SubscriptionUserID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.SubscriptionApprovalHash).HasMaxLength(100);

                entity.Property(e => e.SubscriptionBoardId).HasColumnName("SubscriptionBoardID");

                entity.Property(e => e.SubscriptionEmail)
                    .IsRequired()
                    .HasMaxLength(254)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.SubscriptionGuid).HasColumnName("SubscriptionGUID");

                entity.Property(e => e.SubscriptionUserId).HasColumnName("SubscriptionUserID");

                entity.HasOne(d => d.SubscriptionBoard)
                    .WithMany(p => p.BoardSubscription)
                    .HasForeignKey(d => d.SubscriptionBoardId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Board_Subscription_SubscriptionBoardID_Board_Board");

                entity.HasOne(d => d.SubscriptionUser)
                    .WithMany(p => p.BoardSubscription)
                    .HasForeignKey(d => d.SubscriptionUserId)
                    .HasConstraintName("FK_Board_Subscription_SubscriptionUserID_CMS_User");
            });

            modelBuilder.Entity<ChatInitiatedChatRequest>(entity =>
            {
                entity.HasKey(e => e.InitiatedChatRequestId)
                    .HasName("PK_Chat_InitiatedChatRequest");

                entity.ToTable("Chat_InitiatedChatRequest");

                entity.HasIndex(e => e.InitiatedChatRequestInitiatorChatUserId)
                    .HasName("IX_Chat_InitiatedChatRequest_InitiatedChatRequestInitiatorChatUserID");

                entity.HasIndex(e => e.InitiatedChatRequestRoomId)
                    .HasName("UQ_Chat_InitiatedChatRequest_RoomID")
                    .IsUnique();

                entity.HasIndex(e => e.InitiatedChatRequestUserId)
                    .HasName("IX_Chat_InitiatedChatRequest_InitiatedChatRequestUserID");

                entity.HasIndex(e => new { e.InitiatedChatRequestUserId, e.InitiatedChatRequestContactId })
                    .HasName("UQ_Chat_InitiatedChatRequest_UserIDContactID")
                    .IsUnique();

                entity.Property(e => e.InitiatedChatRequestId).HasColumnName("InitiatedChatRequestID");

                entity.Property(e => e.InitiatedChatRequestContactId)
                    .IsRequired()
                    .HasColumnName("InitiatedChatRequestContactID");

                entity.Property(e => e.InitiatedChatRequestInitiatorChatUserId).HasColumnName("InitiatedChatRequestInitiatorChatUserID");

                entity.Property(e => e.InitiatedChatRequestInitiatorName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InitiatedChatRequestRoomId).HasColumnName("InitiatedChatRequestRoomID");

                entity.Property(e => e.InitiatedChatRequestState).HasDefaultValueSql("1");

                entity.Property(e => e.InitiatedChatRequestUserId)
                    .IsRequired()
                    .HasColumnName("InitiatedChatRequestUserID");

                entity.HasOne(d => d.InitiatedChatRequestInitiatorChatUser)
                    .WithMany(p => p.ChatInitiatedChatRequest)
                    .HasForeignKey(d => d.InitiatedChatRequestInitiatorChatUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Chat_InitiatedChatRequest_Chat_User");

                entity.HasOne(d => d.InitiatedChatRequestRoom)
                    .WithOne(p => p.ChatInitiatedChatRequest)
                    .HasForeignKey<ChatInitiatedChatRequest>(d => d.InitiatedChatRequestRoomId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Chat_InitiatedChatRequest_Chat_Room");

                entity.HasOne(d => d.InitiatedChatRequestUser)
                    .WithMany(p => p.ChatInitiatedChatRequest)
                    .HasForeignKey(d => d.InitiatedChatRequestUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Chat_InitiatedChatRequest_CMS_User");
            });

            modelBuilder.Entity<ChatMessage>(entity =>
            {
                entity.ToTable("Chat_Message");

                entity.HasIndex(e => e.ChatMessageLastModified)
                    .HasName("IX_Chat_Message_ChatMessageLastModified");

                entity.HasIndex(e => e.ChatMessageRecipientId)
                    .HasName("IX_Chat_Message_ChatMessageRecipientID");

                entity.HasIndex(e => e.ChatMessageRoomId)
                    .HasName("IX_Chat_Message_ChatMessageRoomID");

                entity.HasIndex(e => e.ChatMessageSystemMessageType)
                    .HasName("IX_Chat_Message_ChatMessageSystemMessageType");

                entity.HasIndex(e => e.ChatMessageUserId)
                    .HasName("IX_Chat_Message_ChatMessageUserID");

                entity.Property(e => e.ChatMessageId).HasColumnName("ChatMessageID");

                entity.Property(e => e.ChatMessageCreatedWhen).HasDefaultValueSql("'7/25/2011 2:47:18 PM'");

                entity.Property(e => e.ChatMessageIpaddress)
                    .IsRequired()
                    .HasColumnName("ChatMessageIPAddress")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChatMessageLastModified).HasDefaultValueSql("'8/3/2011 11:24:54 AM'");

                entity.Property(e => e.ChatMessageRecipientId).HasColumnName("ChatMessageRecipientID");

                entity.Property(e => e.ChatMessageRejected).HasDefaultValueSql("0");

                entity.Property(e => e.ChatMessageRoomId)
                    .HasColumnName("ChatMessageRoomID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChatMessageSystemMessageType).HasDefaultValueSql("0");

                entity.Property(e => e.ChatMessageText)
                    .IsRequired()
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChatMessageUserId).HasColumnName("ChatMessageUserID");

                entity.HasOne(d => d.ChatMessageRecipient)
                    .WithMany(p => p.ChatMessageChatMessageRecipient)
                    .HasForeignKey(d => d.ChatMessageRecipientId)
                    .HasConstraintName("FK_Chat_Message_Chat_User_Recipient");

                entity.HasOne(d => d.ChatMessageRoom)
                    .WithMany(p => p.ChatMessage)
                    .HasForeignKey(d => d.ChatMessageRoomId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Chat_Message_Chat_Room");

                entity.HasOne(d => d.ChatMessageUser)
                    .WithMany(p => p.ChatMessageChatMessageUser)
                    .HasForeignKey(d => d.ChatMessageUserId)
                    .HasConstraintName("FK_Chat_Message_Chat_User_Sender");
            });

            modelBuilder.Entity<ChatNotification>(entity =>
            {
                entity.ToTable("Chat_Notification");

                entity.HasIndex(e => e.ChatNotificationReceiverId)
                    .HasName("IX_Chat_Notification_ChatNotificationReceiverID");

                entity.HasIndex(e => e.ChatNotificationRoomId)
                    .HasName("IX_Chat_Notification_ChatNotificationRoomID");

                entity.HasIndex(e => e.ChatNotificationSenderId)
                    .HasName("IX_Chat_Notification_ChatNotificationSenderID");

                entity.HasIndex(e => e.ChatNotificationSiteId)
                    .HasName("IX_Chat_Notification_ChatNotificationSiteID");

                entity.Property(e => e.ChatNotificationId).HasColumnName("ChatNotificationID");

                entity.Property(e => e.ChatNotificationReceiverId).HasColumnName("ChatNotificationReceiverID");

                entity.Property(e => e.ChatNotificationRoomId).HasColumnName("ChatNotificationRoomID");

                entity.Property(e => e.ChatNotificationSenderId).HasColumnName("ChatNotificationSenderID");

                entity.Property(e => e.ChatNotificationSiteId).HasColumnName("ChatNotificationSiteID");

                entity.HasOne(d => d.ChatNotificationReceiver)
                    .WithMany(p => p.ChatNotificationChatNotificationReceiver)
                    .HasForeignKey(d => d.ChatNotificationReceiverId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Chat_Notification_Chat_User_Receiver");

                entity.HasOne(d => d.ChatNotificationRoom)
                    .WithMany(p => p.ChatNotification)
                    .HasForeignKey(d => d.ChatNotificationRoomId)
                    .HasConstraintName("FK_Chat_Notification_Chat_Room");

                entity.HasOne(d => d.ChatNotificationSender)
                    .WithMany(p => p.ChatNotificationChatNotificationSender)
                    .HasForeignKey(d => d.ChatNotificationSenderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Chat_Notification_Chat_User_Sender");

                entity.HasOne(d => d.ChatNotificationSite)
                    .WithMany(p => p.ChatNotification)
                    .HasForeignKey(d => d.ChatNotificationSiteId)
                    .HasConstraintName("FK_Chat_Notification_CMS_Site");
            });

            modelBuilder.Entity<ChatOnlineSupport>(entity =>
            {
                entity.ToTable("Chat_OnlineSupport");

                entity.HasIndex(e => e.ChatOnlineSupportChatUserId)
                    .HasName("IX_Chat_OnlineSupport_ChatOnlineSupportChatUserID");

                entity.HasIndex(e => e.ChatOnlineSupportSiteId)
                    .HasName("IX_Chat_OnlineSupport_SiteID");

                entity.HasIndex(e => new { e.ChatOnlineSupportChatUserId, e.ChatOnlineSupportSiteId })
                    .HasName("UQ_Chat_OnlineSupport_ChatUserID-SiteID")
                    .IsUnique();

                entity.Property(e => e.ChatOnlineSupportId).HasColumnName("ChatOnlineSupportID");

                entity.Property(e => e.ChatOnlineSupportChatUserId).HasColumnName("ChatOnlineSupportChatUserID");

                entity.Property(e => e.ChatOnlineSupportSiteId).HasColumnName("ChatOnlineSupportSiteID");

                entity.Property(e => e.ChatOnlineSupportToken).HasMaxLength(50);

                entity.HasOne(d => d.ChatOnlineSupportChatUser)
                    .WithMany(p => p.ChatOnlineSupport)
                    .HasForeignKey(d => d.ChatOnlineSupportChatUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Chat_OnlineSupport_Chat_User");

                entity.HasOne(d => d.ChatOnlineSupportSite)
                    .WithMany(p => p.ChatOnlineSupport)
                    .HasForeignKey(d => d.ChatOnlineSupportSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Chat_OnlineSupport_CMS_Site");
            });

            modelBuilder.Entity<ChatOnlineUser>(entity =>
            {
                entity.ToTable("Chat_OnlineUser");

                entity.HasIndex(e => e.ChatOnlineUserChatUserId)
                    .HasName("IX_Chat_OnlineUser_ChatOnlineUserChatUserID");

                entity.HasIndex(e => e.ChatOnlineUserSiteId)
                    .HasName("IX_Chat_OnlineUser_SiteID");

                entity.HasIndex(e => new { e.ChatOnlineUserChatUserId, e.ChatOnlineUserSiteId })
                    .HasName("UQ_Chat_OnlineUser_SiteID-ChatUserID")
                    .IsUnique();

                entity.Property(e => e.ChatOnlineUserId).HasColumnName("ChatOnlineUserID");

                entity.Property(e => e.ChatOnlineUserChatUserId).HasColumnName("ChatOnlineUserChatUserID");

                entity.Property(e => e.ChatOnlineUserIsHidden).HasDefaultValueSql("0");

                entity.Property(e => e.ChatOnlineUserSiteId).HasColumnName("ChatOnlineUserSiteID");

                entity.Property(e => e.ChatOnlineUserToken).HasMaxLength(50);

                entity.HasOne(d => d.ChatOnlineUserChatUser)
                    .WithMany(p => p.ChatOnlineUser)
                    .HasForeignKey(d => d.ChatOnlineUserChatUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Chat_OnlineUser_Chat_User");

                entity.HasOne(d => d.ChatOnlineUserSite)
                    .WithMany(p => p.ChatOnlineUser)
                    .HasForeignKey(d => d.ChatOnlineUserSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Chat_OnlineUser_CMS_Site");
            });

            modelBuilder.Entity<ChatPopupWindowSettings>(entity =>
            {
                entity.ToTable("Chat_PopupWindowSettings");

                entity.Property(e => e.ChatPopupWindowSettingsId).HasColumnName("ChatPopupWindowSettingsID");

                entity.Property(e => e.ChatPopupWindowSettingsHashCode).HasDefaultValueSql("0");

                entity.Property(e => e.ErrorClearTransformationName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ErrorTransformationName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MessageTransformationName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserTransformationName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ChatRoom>(entity =>
            {
                entity.ToTable("Chat_Room");

                entity.HasIndex(e => e.ChatRoomCreatedByChatUserId)
                    .HasName("IX_Chat_Room_ChatRoomCreatedByChatUserID");

                entity.HasIndex(e => e.ChatRoomEnabled)
                    .HasName("IX_Chat_Room_Enabled");

                entity.HasIndex(e => e.ChatRoomIsSupport)
                    .HasName("IX_Chat_Room_IsSupport");

                entity.HasIndex(e => e.ChatRoomSiteId)
                    .HasName("IX_Chat_Room_SiteID");

                entity.Property(e => e.ChatRoomId).HasColumnName("ChatRoomID");

                entity.Property(e => e.ChatRoomCreatedByChatUserId).HasColumnName("ChatRoomCreatedByChatUserID");

                entity.Property(e => e.ChatRoomDescription).HasMaxLength(500);

                entity.Property(e => e.ChatRoomDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChatRoomGuid)
                    .HasColumnName("ChatRoomGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.ChatRoomIsOneToOne).HasDefaultValueSql("0");

                entity.Property(e => e.ChatRoomIsSupport).HasDefaultValueSql("0");

                entity.Property(e => e.ChatRoomLastModification).HasDefaultValueSql("'10/19/2011 12:16:33 PM'");

                entity.Property(e => e.ChatRoomName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ChatRoomPassword).HasMaxLength(100);

                entity.Property(e => e.ChatRoomPrivate).HasDefaultValueSql("0");

                entity.Property(e => e.ChatRoomPrivateStateLastModification).HasDefaultValueSql("'1/30/2012 4:36:47 PM'");

                entity.Property(e => e.ChatRoomSiteId).HasColumnName("ChatRoomSiteID");

                entity.HasOne(d => d.ChatRoomCreatedByChatUser)
                    .WithMany(p => p.ChatRoom)
                    .HasForeignKey(d => d.ChatRoomCreatedByChatUserId)
                    .HasConstraintName("FK_Chat_Room_Chat_User");

                entity.HasOne(d => d.ChatRoomSite)
                    .WithMany(p => p.ChatRoom)
                    .HasForeignKey(d => d.ChatRoomSiteId)
                    .HasConstraintName("FK_Chat_Room_CMS_Site");
            });

            modelBuilder.Entity<ChatRoomUser>(entity =>
            {
                entity.ToTable("Chat_RoomUser");

                entity.HasIndex(e => e.ChatRoomUserChatUserId)
                    .HasName("IX_Chat_RoomUser_ChatRoomUserChatUserID");

                entity.HasIndex(e => e.ChatRoomUserRoomId)
                    .HasName("IX_Chat_RoomUser_ChatRoomUserRoomID");

                entity.HasIndex(e => new { e.ChatRoomUserRoomId, e.ChatRoomUserChatUserId })
                    .HasName("UQ_Chat_RoomUser_RoomID-ChatUserID")
                    .IsUnique();

                entity.Property(e => e.ChatRoomUserId).HasColumnName("ChatRoomUserID");

                entity.Property(e => e.ChatRoomUserAdminLevel).HasDefaultValueSql("0");

                entity.Property(e => e.ChatRoomUserChatUserId)
                    .HasColumnName("ChatRoomUserChatUserID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChatRoomUserLastModification).HasDefaultValueSql("'11/10/2011 3:29:00 PM'");

                entity.Property(e => e.ChatRoomUserRoomId)
                    .HasColumnName("ChatRoomUserRoomID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ChatRoomUserChatUser)
                    .WithMany(p => p.ChatRoomUser)
                    .HasForeignKey(d => d.ChatRoomUserChatUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Chat_RoomUser_Chat_User");

                entity.HasOne(d => d.ChatRoomUserRoom)
                    .WithMany(p => p.ChatRoomUser)
                    .HasForeignKey(d => d.ChatRoomUserRoomId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Chat_RoomUser_Chat_Room");
            });

            modelBuilder.Entity<ChatSupportCannedResponse>(entity =>
            {
                entity.ToTable("Chat_SupportCannedResponse");

                entity.HasIndex(e => e.ChatSupportCannedResponseChatUserId)
                    .HasName("IX_Chat_SupportCannedResponse_ChatSupportCannedResponseChatUserID");

                entity.HasIndex(e => e.ChatSupportCannedResponseSiteId)
                    .HasName("IX_Chat_SupportCannedResponse_ChatSupportCannedResponseSiteID");

                entity.Property(e => e.ChatSupportCannedResponseId).HasColumnName("ChatSupportCannedResponseID");

                entity.Property(e => e.ChatSupportCannedResponseChatUserId).HasColumnName("ChatSupportCannedResponseChatUserID");

                entity.Property(e => e.ChatSupportCannedResponseName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ChatSupportCannedResponseSiteId).HasColumnName("ChatSupportCannedResponseSiteID");

                entity.Property(e => e.ChatSupportCannedResponseTagName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChatSupportCannedResponseText)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.ChatSupportCannedResponseChatUser)
                    .WithMany(p => p.ChatSupportCannedResponse)
                    .HasForeignKey(d => d.ChatSupportCannedResponseChatUserId)
                    .HasConstraintName("FK_Chat_SupportCannedResponse_Chat_User");

                entity.HasOne(d => d.ChatSupportCannedResponseSite)
                    .WithMany(p => p.ChatSupportCannedResponse)
                    .HasForeignKey(d => d.ChatSupportCannedResponseSiteId)
                    .HasConstraintName("FK_Chat_SupportCannedResponse_CMS_Site");
            });

            modelBuilder.Entity<ChatSupportTakenRoom>(entity =>
            {
                entity.ToTable("Chat_SupportTakenRoom");

                entity.HasIndex(e => e.ChatSupportTakenRoomChatUserId)
                    .HasName("IX_Chat_SupportTakenRoom_ChatSupportTakenRoomChatUserID");

                entity.HasIndex(e => e.ChatSupportTakenRoomRoomId)
                    .HasName("IX_Chat_SupportTakenRoom_ChatSupportTakenRoomRoomID");

                entity.Property(e => e.ChatSupportTakenRoomId).HasColumnName("ChatSupportTakenRoomID");

                entity.Property(e => e.ChatSupportTakenRoomChatUserId).HasColumnName("ChatSupportTakenRoomChatUserID");

                entity.Property(e => e.ChatSupportTakenRoomLastModification).HasDefaultValueSql("'4/16/2012 5:11:30 PM'");

                entity.Property(e => e.ChatSupportTakenRoomRoomId)
                    .HasColumnName("ChatSupportTakenRoomRoomID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ChatSupportTakenRoomChatUser)
                    .WithMany(p => p.ChatSupportTakenRoom)
                    .HasForeignKey(d => d.ChatSupportTakenRoomChatUserId)
                    .HasConstraintName("FK_Chat_SupportTakenRoom_Chat_User");

                entity.HasOne(d => d.ChatSupportTakenRoomRoom)
                    .WithMany(p => p.ChatSupportTakenRoom)
                    .HasForeignKey(d => d.ChatSupportTakenRoomRoomId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Chat_SupportTakenRoom_Chat_Room");
            });

            modelBuilder.Entity<ChatUser>(entity =>
            {
                entity.ToTable("Chat_User");

                entity.HasIndex(e => e.ChatUserUserId)
                    .HasName("IX_Chat_User_UserID");

                entity.Property(e => e.ChatUserId).HasColumnName("ChatUserID");

                entity.Property(e => e.ChatUserLastModification).HasDefaultValueSql("'2/20/2012 2:02:00 PM'");

                entity.Property(e => e.ChatUserNickname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ChatUserUserId).HasColumnName("ChatUserUserID");

                entity.HasOne(d => d.ChatUserUser)
                    .WithMany(p => p.ChatUser)
                    .HasForeignKey(d => d.ChatUserUserId)
                    .HasConstraintName("FK_Chat_User_CMS_User");
            });

            modelBuilder.Entity<CiFileMetadata>(entity =>
            {
                entity.HasKey(e => e.FileMetadataId)
                    .HasName("PK_CI_FileMetadata");

                entity.ToTable("CI_FileMetadata");

                entity.HasIndex(e => e.FileLocation)
                    .HasName("UQ_CI_FileMetadata_FileLocation")
                    .IsUnique();

                entity.Property(e => e.FileMetadataId).HasColumnName("FileMetadataID");

                entity.Property(e => e.FileHash)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.FileLocation)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<CmsAbuseReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK_CMS_AbuseReport");

                entity.ToTable("CMS_AbuseReport");

                entity.HasIndex(e => e.ReportSiteId)
                    .HasName("IX_CMS_AbuseReport_ReportSiteID");

                entity.HasIndex(e => e.ReportStatus)
                    .HasName("IX_CMS_AbuseReport_ReportStatus");

                entity.HasIndex(e => e.ReportUserId)
                    .HasName("IX_CMS_AbuseReport_ReportUserID");

                entity.HasIndex(e => e.ReportWhen)
                    .HasName("IX_CMS_AbuseReport_ReportWhen");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.ReportComment)
                    .IsRequired()
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReportCulture)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReportGuid)
                    .HasColumnName("ReportGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.ReportObjectId).HasColumnName("ReportObjectID");

                entity.Property(e => e.ReportObjectType).HasMaxLength(100);

                entity.Property(e => e.ReportSiteId)
                    .HasColumnName("ReportSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReportStatus).HasDefaultValueSql("0");

                entity.Property(e => e.ReportTitle)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReportUrl)
                    .IsRequired()
                    .HasColumnName("ReportURL")
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReportUserId).HasColumnName("ReportUserID");

                entity.Property(e => e.ReportWhen).HasDefaultValueSql("'9/11/2008 4:32:15 PM'");

                entity.HasOne(d => d.ReportSite)
                    .WithMany(p => p.CmsAbuseReport)
                    .HasForeignKey(d => d.ReportSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_AbuseReport_ReportSiteID_CMS_Site");

                entity.HasOne(d => d.ReportUser)
                    .WithMany(p => p.CmsAbuseReport)
                    .HasForeignKey(d => d.ReportUserId)
                    .HasConstraintName("FK_CMS_AbuseReport_ReportUserID_CMS_User");
            });

            modelBuilder.Entity<CmsAcl>(entity =>
            {
                entity.HasKey(e => e.Aclid)
                    .HasName("PK_CMS_ACL");

                entity.ToTable("CMS_ACL");

                entity.HasIndex(e => e.AclinheritedAcls)
                    .HasName("IX_CMS_ACL_ACLInheritedACLs");

                entity.HasIndex(e => e.AclsiteId)
                    .HasName("IX_CMS_ACL_ACLSiteID");

                entity.Property(e => e.Aclid).HasColumnName("ACLID");

                entity.Property(e => e.Aclguid)
                    .HasColumnName("ACLGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.AclinheritedAcls)
                    .IsRequired()
                    .HasColumnName("ACLInheritedACLs")
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AcllastModified)
                    .HasColumnName("ACLLastModified")
                    .HasDefaultValueSql("'10/30/2008 9:17:31 AM'");

                entity.Property(e => e.AclsiteId).HasColumnName("ACLSiteID");

                entity.HasOne(d => d.Aclsite)
                    .WithMany(p => p.CmsAcl)
                    .HasForeignKey(d => d.AclsiteId)
                    .HasConstraintName("FK_CMS_ACL_ACLSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsAclitem>(entity =>
            {
                entity.HasKey(e => e.AclitemId)
                    .HasName("PK_CMS_ACLItem");

                entity.ToTable("CMS_ACLItem");

                entity.HasIndex(e => e.Aclid)
                    .HasName("IX_CMS_ACLItem_ACLID");

                entity.HasIndex(e => e.LastModifiedByUserId)
                    .HasName("IX_CMS_ACLItem_LastModifiedByUserID");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_CMS_ACLItem_RoleID");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_CMS_ACLItem_UserID");

                entity.Property(e => e.AclitemId).HasColumnName("ACLItemID");

                entity.Property(e => e.Aclid).HasColumnName("ACLID");

                entity.Property(e => e.AclitemGuid)
                    .HasColumnName("ACLItemGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.Allowed).HasDefaultValueSql("0");

                entity.Property(e => e.Denied).HasDefaultValueSql("0");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Acl)
                    .WithMany(p => p.CmsAclitem)
                    .HasForeignKey(d => d.Aclid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_ACLItem_ACLID_CMS_ACL");

                entity.HasOne(d => d.LastModifiedByUser)
                    .WithMany(p => p.CmsAclitemLastModifiedByUser)
                    .HasForeignKey(d => d.LastModifiedByUserId)
                    .HasConstraintName("FK_CMS_ACLItem_LastModifiedByUserID_CMS_User");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CmsAclitem)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_CMS_ACLItem_RoleID_CMS_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsAclitemUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CMS_ACLItem_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsAllowedChildClasses>(entity =>
            {
                entity.HasKey(e => new { e.ParentClassId, e.ChildClassId })
                    .HasName("PK_CMS_AllowedChildClasses");

                entity.ToTable("CMS_AllowedChildClasses");

                entity.HasIndex(e => e.ChildClassId)
                    .HasName("IX_CMS_AllowedChildClasses_ChildClassID");

                entity.Property(e => e.ParentClassId).HasColumnName("ParentClassID");

                entity.Property(e => e.ChildClassId).HasColumnName("ChildClassID");

                entity.HasOne(d => d.ChildClass)
                    .WithMany(p => p.CmsAllowedChildClassesChildClass)
                    .HasForeignKey(d => d.ChildClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_AllowedChildClasses_ChildClassID_CMS_Class");

                entity.HasOne(d => d.ParentClass)
                    .WithMany(p => p.CmsAllowedChildClassesParentClass)
                    .HasForeignKey(d => d.ParentClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_AllowedChildClasses_ParentClassID_CMS_Class");
            });

            modelBuilder.Entity<CmsAlternativeForm>(entity =>
            {
                entity.HasKey(e => e.FormId)
                    .HasName("PK_CMS_AlternativeForm");

                entity.ToTable("CMS_AlternativeForm");

                entity.HasIndex(e => e.FormCoupledClassId)
                    .HasName("IX_CMS_AlternativeForm_FormCoupledClassID");

                entity.HasIndex(e => new { e.FormClassId, e.FormName })
                    .HasName("IX_CMS_AlternativeForm_FormClassID_FormName");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.FormClassId).HasColumnName("FormClassID");

                entity.Property(e => e.FormCoupledClassId).HasColumnName("FormCoupledClassID");

                entity.Property(e => e.FormCustomizedColumns).HasMaxLength(400);

                entity.Property(e => e.FormDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FormGuid).HasColumnName("FormGUID");

                entity.Property(e => e.FormHideNewParentFields).HasDefaultValueSql("0");

                entity.Property(e => e.FormIsCustom).HasDefaultValueSql("0");

                entity.Property(e => e.FormLayoutType).HasMaxLength(50);

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FormVersionGuid)
                    .HasColumnName("FormVersionGUID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.FormClass)
                    .WithMany(p => p.CmsAlternativeFormFormClass)
                    .HasForeignKey(d => d.FormClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_AlternativeForm_FormClassID_CMS_Class");

                entity.HasOne(d => d.FormCoupledClass)
                    .WithMany(p => p.CmsAlternativeFormFormCoupledClass)
                    .HasForeignKey(d => d.FormCoupledClassId)
                    .HasConstraintName("FK_CMS_AlternativeForm_FormCoupledClassID_CMS_Class");
            });

            modelBuilder.Entity<CmsAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId)
                    .HasName("PK_CMS_Attachment");

                entity.ToTable("CMS_Attachment");

                entity.HasIndex(e => e.AttachmentDocumentId)
                    .HasName("IX_CMS_Attachment_AttachmentDocumentID");

                entity.HasIndex(e => e.AttachmentSiteId)
                    .HasName("IX_CMS_Attachment_AttachmentSiteID");

                entity.HasIndex(e => e.AttachmentVariantParentId)
                    .HasName("IX_CMS_Attachment_AttachmentVariantParentID");

                entity.HasIndex(e => new { e.AttachmentGuid, e.AttachmentSiteId })
                    .HasName("IX_CMS_Attachment_AttachmentGUID_AttachmentSiteID");

                entity.HasIndex(e => new { e.AttachmentVariantDefinitionIdentifier, e.AttachmentVariantParentId })
                    .HasName("IX_CMS_Attachment_AttachmentVariantParentID_AttachmentVariantDefinitionIdentifier")
                    .IsUnique();

                entity.HasIndex(e => new { e.AttachmentDocumentId, e.AttachmentName, e.AttachmentIsUnsorted, e.AttachmentOrder })
                    .HasName("IX_CMS_Attachment_AttachmentDocumentID_AttachmentIsUnsorted_AttachmentName_AttachmentOrder");

                entity.HasIndex(e => new { e.AttachmentIsUnsorted, e.AttachmentGroupGuid, e.AttachmentFormGuid, e.AttachmentOrder })
                    .HasName("IX_CMS_Attachment_AttachmentIsUnsorted_AttachmentGroupGUID_AttachmentFormGUID_AttachmentOrder");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.AttachmentDocumentId).HasColumnName("AttachmentDocumentID");

                entity.Property(e => e.AttachmentExtension)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AttachmentFormGuid).HasColumnName("AttachmentFormGUID");

                entity.Property(e => e.AttachmentGroupGuid).HasColumnName("AttachmentGroupGUID");

                entity.Property(e => e.AttachmentGuid).HasColumnName("AttachmentGUID");

                entity.Property(e => e.AttachmentHash).HasMaxLength(32);

                entity.Property(e => e.AttachmentMimeType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AttachmentName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.AttachmentSiteId).HasColumnName("AttachmentSiteID");

                entity.Property(e => e.AttachmentTitle).HasMaxLength(250);

                entity.Property(e => e.AttachmentVariantDefinitionIdentifier)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AttachmentVariantParentId)
                    .IsRequired()
                    .HasColumnName("AttachmentVariantParentID");

                entity.HasOne(d => d.AttachmentDocument)
                    .WithMany(p => p.CmsAttachment)
                    .HasForeignKey(d => d.AttachmentDocumentId)
                    .HasConstraintName("FK_CMS_Attachment_AttachmentDocumentID_CMS_Document");

                entity.HasOne(d => d.AttachmentSite)
                    .WithMany(p => p.CmsAttachment)
                    .HasForeignKey(d => d.AttachmentSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Attachment_AttachmentSiteID_CMS_Site");

                entity.HasOne(d => d.AttachmentVariantParent)
                    .WithMany(p => p.InverseAttachmentVariantParent)
                    .HasForeignKey(d => d.AttachmentVariantParentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Attachment_AttachmentVariantParentID_CMS_Attachment");
            });

            modelBuilder.Entity<CmsAttachmentForEmail>(entity =>
            {
                entity.HasKey(e => new { e.EmailId, e.AttachmentId })
                    .HasName("PK_CMS_AttachmentForEmail");

                entity.ToTable("CMS_AttachmentForEmail");

                entity.HasIndex(e => e.AttachmentId)
                    .HasName("IX_CMS_AttachmentForEmail_AttachmentID");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.CmsAttachmentForEmail)
                    .HasForeignKey(d => d.AttachmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_AttachmentForEmail_AttachmentID_CMS_EmailAttachment");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.CmsAttachmentForEmail)
                    .HasForeignKey(d => d.EmailId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_AttachmentForEmail_EmailID_CMS_Email");
            });

            modelBuilder.Entity<CmsAttachmentHistory>(entity =>
            {
                entity.HasKey(e => e.AttachmentHistoryId)
                    .HasName("PK_CMS_AttachmentHistory");

                entity.ToTable("CMS_AttachmentHistory");

                entity.HasIndex(e => e.AttachmentGuid)
                    .HasName("IX_CMS_AttachmentHistory_AttachmentGUID");

                entity.HasIndex(e => e.AttachmentSiteId)
                    .HasName("IX_CMS_AttachmentHistory_AttachmentSiteID");

                entity.HasIndex(e => e.AttachmentVariantParentId)
                    .HasName("IX_CMS_AttachmentHistory_AttachmentVariantParentID");

                entity.HasIndex(e => new { e.AttachmentDocumentId, e.AttachmentName })
                    .HasName("IX_CMS_AttachmentHistory_AttachmentDocumentID_AttachmentName");

                entity.HasIndex(e => new { e.AttachmentVariantDefinitionIdentifier, e.AttachmentVariantParentId })
                    .HasName("IX_CMS_AttachmentHistory_AttachmentVariantParentID_AttachmentVariantDefinitionIdentifier")
                    .IsUnique();

                entity.HasIndex(e => new { e.AttachmentIsUnsorted, e.AttachmentGroupGuid, e.AttachmentOrder })
                    .HasName("IX_CMS_AttachmentHistory_AttachmentIsUnsorted_AttachmentGroupGUID_AttachmentOrder");

                entity.Property(e => e.AttachmentHistoryId).HasColumnName("AttachmentHistoryID");

                entity.Property(e => e.AttachmentDocumentId).HasColumnName("AttachmentDocumentID");

                entity.Property(e => e.AttachmentExtension)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AttachmentGroupGuid).HasColumnName("AttachmentGroupGUID");

                entity.Property(e => e.AttachmentGuid).HasColumnName("AttachmentGUID");

                entity.Property(e => e.AttachmentHash).HasMaxLength(32);

                entity.Property(e => e.AttachmentHistoryGuid)
                    .HasColumnName("AttachmentHistoryGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.AttachmentMimeType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AttachmentName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.AttachmentSiteId).HasColumnName("AttachmentSiteID");

                entity.Property(e => e.AttachmentTitle).HasMaxLength(250);

                entity.Property(e => e.AttachmentVariantDefinitionIdentifier)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AttachmentVariantParentId)
                    .IsRequired()
                    .HasColumnName("AttachmentVariantParentID");

                entity.HasOne(d => d.AttachmentSite)
                    .WithMany(p => p.CmsAttachmentHistory)
                    .HasForeignKey(d => d.AttachmentSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_AttachmentHistory_AttachmentSiteID_CMS_Site");

                entity.HasOne(d => d.AttachmentVariantParent)
                    .WithMany(p => p.InverseAttachmentVariantParent)
                    .HasForeignKey(d => d.AttachmentVariantParentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_AttachmentHistory_AttachmentVariantParentID_CMS_AttachmentHistory");
            });

            modelBuilder.Entity<CmsAutomationHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PK_CMS_AutomationHistory");

                entity.ToTable("CMS_AutomationHistory");

                entity.HasIndex(e => e.HistoryApprovedByUserId)
                    .HasName("IX_CMS_AutomationHistory_HistoryApprovedByUserID");

                entity.HasIndex(e => e.HistoryApprovedWhen)
                    .HasName("IX_CMS_AutomationHistory_HistoryApprovedWhen");

                entity.HasIndex(e => e.HistoryStateId)
                    .HasName("IX_CMS_AutomationHistory_HistoryStateID");

                entity.HasIndex(e => e.HistoryStepId)
                    .HasName("IX_CMS_AutomationHistory_HistoryStepID");

                entity.HasIndex(e => e.HistoryTargetStepId)
                    .HasName("IX_CMS_AutomationHistory_HistoryTargetStepID");

                entity.HasIndex(e => e.HistoryWorkflowId)
                    .HasName("IX_CMS_AutomationHistory_HistoryWorkflowID");

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.HistoryApprovedByUserId).HasColumnName("HistoryApprovedByUserID");

                entity.Property(e => e.HistoryRejected).HasDefaultValueSql("0");

                entity.Property(e => e.HistoryStateId)
                    .HasColumnName("HistoryStateID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HistoryStepDisplayName)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HistoryStepId).HasColumnName("HistoryStepID");

                entity.Property(e => e.HistoryStepName).HasMaxLength(440);

                entity.Property(e => e.HistoryTargetStepDisplayName).HasMaxLength(450);

                entity.Property(e => e.HistoryTargetStepId).HasColumnName("HistoryTargetStepID");

                entity.Property(e => e.HistoryTargetStepName).HasMaxLength(440);

                entity.Property(e => e.HistoryWasRejected).HasDefaultValueSql("0");

                entity.Property(e => e.HistoryWorkflowId)
                    .HasColumnName("HistoryWorkflowID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.HistoryApprovedByUser)
                    .WithMany(p => p.CmsAutomationHistory)
                    .HasForeignKey(d => d.HistoryApprovedByUserId)
                    .HasConstraintName("FK_CMS_AutomationHistory_HistoryApprovedByUserID");

                entity.HasOne(d => d.HistoryState)
                    .WithMany(p => p.CmsAutomationHistory)
                    .HasForeignKey(d => d.HistoryStateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_AutomationHistory_HistoryStateID");

                entity.HasOne(d => d.HistoryStep)
                    .WithMany(p => p.CmsAutomationHistoryHistoryStep)
                    .HasForeignKey(d => d.HistoryStepId)
                    .HasConstraintName("FK_CMS_AutomationHistory_HistoryStepID");

                entity.HasOne(d => d.HistoryTargetStep)
                    .WithMany(p => p.CmsAutomationHistoryHistoryTargetStep)
                    .HasForeignKey(d => d.HistoryTargetStepId)
                    .HasConstraintName("FK_CMS_AutomationHistory_HistoryTargetStepID");

                entity.HasOne(d => d.HistoryWorkflow)
                    .WithMany(p => p.CmsAutomationHistory)
                    .HasForeignKey(d => d.HistoryWorkflowId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_AutomationHistory_HistoryWorkflowID");
            });

            modelBuilder.Entity<CmsAutomationState>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK_CMS_AutomationState");

                entity.ToTable("CMS_AutomationState");

                entity.HasIndex(e => e.StateSiteId)
                    .HasName("IX_CMS_AutomationState_StateSiteID");

                entity.HasIndex(e => e.StateStepId)
                    .HasName("IX_CMS_AutomationState_StateStepID");

                entity.HasIndex(e => e.StateUserId)
                    .HasName("IX_CMS_AutomationState_StateUserID");

                entity.HasIndex(e => e.StateWorkflowId)
                    .HasName("IX_CMS_AutomationState_StateWorkflowID");

                entity.HasIndex(e => new { e.StateObjectId, e.StateObjectType })
                    .HasName("IX_CMS_AutomationState_StateObjectID_StateObjectType");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateActionStatus).HasMaxLength(450);

                entity.Property(e => e.StateGuid)
                    .HasColumnName("StateGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.StateObjectId).HasColumnName("StateObjectID");

                entity.Property(e => e.StateObjectType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StateSiteId).HasColumnName("StateSiteID");

                entity.Property(e => e.StateStepId).HasColumnName("StateStepID");

                entity.Property(e => e.StateUserId).HasColumnName("StateUserID");

                entity.Property(e => e.StateWorkflowId)
                    .HasColumnName("StateWorkflowID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.StateSite)
                    .WithMany(p => p.CmsAutomationState)
                    .HasForeignKey(d => d.StateSiteId)
                    .HasConstraintName("FK_CMS_AutomationState_StateSiteID_CMS_Site");

                entity.HasOne(d => d.StateStep)
                    .WithMany(p => p.CmsAutomationState)
                    .HasForeignKey(d => d.StateStepId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_AutomationState_StateStepID");

                entity.HasOne(d => d.StateUser)
                    .WithMany(p => p.CmsAutomationState)
                    .HasForeignKey(d => d.StateUserId)
                    .HasConstraintName("FK_CMS_AutomationState_StateUserID_CMS_User");

                entity.HasOne(d => d.StateWorkflow)
                    .WithMany(p => p.CmsAutomationState)
                    .HasForeignKey(d => d.StateWorkflowId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_AutomationState_StateWorkflowID");
            });

            modelBuilder.Entity<CmsAvatar>(entity =>
            {
                entity.HasKey(e => e.AvatarId)
                    .HasName("PK_CMS_Avatar");

                entity.ToTable("CMS_Avatar");

                entity.HasIndex(e => e.AvatarGuid)
                    .HasName("IX_CMS_Avatar_AvatarGUID");

                entity.HasIndex(e => e.AvatarName)
                    .HasName("IX_CMS_Avatar_AvatarName");

                entity.HasIndex(e => new { e.AvatarType, e.AvatarIsCustom })
                    .HasName("IX_CMS_Avatar_AvatarType_AvatarIsCustom");

                entity.Property(e => e.AvatarId).HasColumnName("AvatarID");

                entity.Property(e => e.AvatarFileExtension)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AvatarFileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AvatarGuid).HasColumnName("AvatarGUID");

                entity.Property(e => e.AvatarMimeType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AvatarName).HasMaxLength(200);

                entity.Property(e => e.AvatarType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultFemaleUserAvatar).HasDefaultValueSql("0");

                entity.Property(e => e.DefaultGroupAvatar).HasDefaultValueSql("0");

                entity.Property(e => e.DefaultMaleUserAvatar).HasDefaultValueSql("0");

                entity.Property(e => e.DefaultUserAvatar).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CmsBadge>(entity =>
            {
                entity.HasKey(e => e.BadgeId)
                    .HasName("PK_CMS_Badge");

                entity.ToTable("CMS_Badge");

                entity.HasIndex(e => e.BadgeTopLimit)
                    .HasName("IX_CMS_Badge_BadgeTopLimit");

                entity.Property(e => e.BadgeId).HasColumnName("BadgeID");

                entity.Property(e => e.BadgeDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BadgeGuid)
                    .HasColumnName("BadgeGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.BadgeImageUrl)
                    .HasColumnName("BadgeImageURL")
                    .HasMaxLength(200);

                entity.Property(e => e.BadgeIsAutomatic).HasDefaultValueSql("0");

                entity.Property(e => e.BadgeLastModified).HasDefaultValueSql("'9/25/2008 5:07:55 PM'");

                entity.Property(e => e.BadgeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CmsBannedIp>(entity =>
            {
                entity.HasKey(e => e.IpaddressId)
                    .HasName("PK_CMS_BannedIP");

                entity.ToTable("CMS_BannedIP");

                entity.HasIndex(e => e.IpaddressSiteId)
                    .HasName("IX_CMS_BannedIP_IPAddressSiteID");

                entity.HasIndex(e => new { e.Ipaddress, e.IpaddressSiteId })
                    .HasName("IX_CMS_BannedIP_IPAddressSiteID_IPAddress");

                entity.Property(e => e.IpaddressId).HasColumnName("IPAddressID");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(100);

                entity.Property(e => e.IpaddressAllowOverride)
                    .HasColumnName("IPAddressAllowOverride")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IpaddressAllowed)
                    .HasColumnName("IPAddressAllowed")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IpaddressBanEnabled)
                    .HasColumnName("IPAddressBanEnabled")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IpaddressBanReason)
                    .HasColumnName("IPAddressBanReason")
                    .HasMaxLength(450);

                entity.Property(e => e.IpaddressBanType)
                    .IsRequired()
                    .HasColumnName("IPAddressBanType")
                    .HasMaxLength(100);

                entity.Property(e => e.IpaddressGuid).HasColumnName("IPAddressGUID");

                entity.Property(e => e.IpaddressLastModified).HasColumnName("IPAddressLastModified");

                entity.Property(e => e.IpaddressRegular)
                    .IsRequired()
                    .HasColumnName("IPAddressRegular")
                    .HasMaxLength(200);

                entity.Property(e => e.IpaddressSiteId).HasColumnName("IPAddressSiteID");

                entity.HasOne(d => d.IpaddressSite)
                    .WithMany(p => p.CmsBannedIp)
                    .HasForeignKey(d => d.IpaddressSiteId)
                    .HasConstraintName("FK_CMS_BannedIP_IPAddressSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsBanner>(entity =>
            {
                entity.HasKey(e => e.BannerId)
                    .HasName("PK__CMS_Bann__32E86A313F433E64");

                entity.ToTable("CMS_Banner");

                entity.HasIndex(e => e.BannerCategoryId)
                    .HasName("IX_CMS_Banner_BannerCategoryID");

                entity.HasIndex(e => e.BannerSiteId)
                    .HasName("IX_CMS_Banner_BannerSiteID");

                entity.Property(e => e.BannerId).HasColumnName("BannerID");

                entity.Property(e => e.BannerBlank).HasDefaultValueSql("0");

                entity.Property(e => e.BannerCategoryId)
                    .HasColumnName("BannerCategoryID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BannerContent)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.BannerDisplayName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BannerEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.BannerGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.BannerLastModified).HasDefaultValueSql("'1/1/1970 12:00:00 AM'");

                entity.Property(e => e.BannerName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BannerSiteId).HasColumnName("BannerSiteID");

                entity.Property(e => e.BannerType).HasDefaultValueSql("2");

                entity.Property(e => e.BannerUrl)
                    .IsRequired()
                    .HasColumnName("BannerURL")
                    .HasMaxLength(2083);

                entity.Property(e => e.BannerWeight).HasDefaultValueSql("5");

                entity.HasOne(d => d.BannerCategory)
                    .WithMany(p => p.CmsBanner)
                    .HasForeignKey(d => d.BannerCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Banner_CMS_BannerCategory");

                entity.HasOne(d => d.BannerSite)
                    .WithMany(p => p.CmsBanner)
                    .HasForeignKey(d => d.BannerSiteId)
                    .HasConstraintName("FK_CMS_Banner_CMS_Site");
            });

            modelBuilder.Entity<CmsBannerCategory>(entity =>
            {
                entity.HasKey(e => e.BannerCategoryId)
                    .HasName("PK__CMS_BannerCategory");

                entity.ToTable("CMS_BannerCategory");

                entity.HasIndex(e => e.BannerCategorySiteId)
                    .HasName("IX_CMS_BannerCategory_BannerCategorySiteID");

                entity.HasIndex(e => new { e.BannerCategoryName, e.BannerCategorySiteId })
                    .HasName("IX_CMS_BannerCategory_BannerCategoryName_BannerCategorySiteID")
                    .IsUnique();

                entity.Property(e => e.BannerCategoryId).HasColumnName("BannerCategoryID");

                entity.Property(e => e.BannerCategoryDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BannerCategoryEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.BannerCategoryGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.BannerCategoryLastModified).HasDefaultValueSql("'1/1/1970 12:00:00 AM'");

                entity.Property(e => e.BannerCategoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BannerCategorySiteId)
                    .IsRequired()
                    .HasColumnName("BannerCategorySiteID");

                entity.HasOne(d => d.BannerCategorySite)
                    .WithMany(p => p.CmsBannerCategory)
                    .HasForeignKey(d => d.BannerCategorySiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_BannerCategory_CMS_Site");
            });

            modelBuilder.Entity<CmsCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_CMS_Category");

                entity.ToTable("CMS_Category");

                entity.HasIndex(e => e.CategorySiteId)
                    .HasName("IX_CMS_Category_CategorySiteID");

                entity.HasIndex(e => e.CategoryUserId)
                    .HasName("IX_CMS_Category_CategoryUserID");

                entity.HasIndex(e => new { e.CategoryDisplayName, e.CategoryEnabled })
                    .HasName("IX_CMS_Category_CategoryDisplayName_CategoryEnabled");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryDisplayName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CategoryEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.CategoryGuid)
                    .HasColumnName("CategoryGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.CategoryIdpath)
                    .HasColumnName("CategoryIDPath")
                    .HasMaxLength(450);

                entity.Property(e => e.CategoryName).HasMaxLength(250);

                entity.Property(e => e.CategoryNamePath).HasMaxLength(1500);

                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentID");

                entity.Property(e => e.CategorySiteId).HasColumnName("CategorySiteID");

                entity.Property(e => e.CategoryUserId).HasColumnName("CategoryUserID");

                entity.HasOne(d => d.CategorySite)
                    .WithMany(p => p.CmsCategory)
                    .HasForeignKey(d => d.CategorySiteId)
                    .HasConstraintName("FK_CMS_Category_CategorySiteID_CMS_Site");

                entity.HasOne(d => d.CategoryUser)
                    .WithMany(p => p.CmsCategory)
                    .HasForeignKey(d => d.CategoryUserId)
                    .HasConstraintName("FK_CMS_Category_CategoryUserID_CMS_User");
            });

            modelBuilder.Entity<CmsClass>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PK_CMS_Class");

                entity.ToTable("CMS_Class");

                entity.HasIndex(e => e.ClassDefaultPageTemplateId)
                    .HasName("IX_CMS_Class_ClassDefaultPageTemplateID");

                entity.HasIndex(e => e.ClassLoadGeneration)
                    .HasName("IX_CMS_Class_ClassLoadGeneration");

                entity.HasIndex(e => e.ClassPageTemplateCategoryId)
                    .HasName("IX_CMS_Class_ClassPageTemplateCategoryID");

                entity.HasIndex(e => e.ClassResourceId)
                    .HasName("IX_CMS_Class_ClassResourceID");

                entity.HasIndex(e => new { e.ClassName, e.ClassGuid })
                    .HasName("IX_CMS_Class_ClassName_ClassGUID");

                entity.HasIndex(e => new { e.ClassId, e.ClassName, e.ClassDisplayName })
                    .HasName("IX_CMS_Class_ClassID_ClassName_ClassDisplayName");

                entity.HasIndex(e => new { e.ClassXmlSchema, e.ClassTableName, e.ClassName })
                    .HasName("IX_CMS_Class_ClassName")
                    .IsUnique();

                entity.HasIndex(e => new { e.ClassShowAsSystemTable, e.ClassIsCustomTable, e.ClassIsCoupledClass, e.ClassIsDocumentType })
                    .HasName("IX_CMS_Class_ClassShowAsSystemTable_ClassIsCustomTable_ClassIsCoupledClass_ClassIsDocumentType");

                entity.Property(e => e.ClassId)
                    .HasColumnName("ClassID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ClassConnectionString).HasMaxLength(100);

                entity.Property(e => e.ClassCreateSku).HasColumnName("ClassCreateSKU");

                entity.Property(e => e.ClassCustomizedColumns).HasMaxLength(400);

                entity.Property(e => e.ClassDefaultObjectType).HasMaxLength(100);

                entity.Property(e => e.ClassDefaultPageTemplateId).HasColumnName("ClassDefaultPageTemplateID");

                entity.Property(e => e.ClassDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ClassEditingPageUrl).HasMaxLength(450);

                entity.Property(e => e.ClassFormDefinition).IsRequired();

                entity.Property(e => e.ClassFormLayoutType).HasMaxLength(50);

                entity.Property(e => e.ClassGuid).HasColumnName("ClassGUID");

                entity.Property(e => e.ClassIconClass).HasMaxLength(200);

                entity.Property(e => e.ClassInheritsFromClassId).HasColumnName("ClassInheritsFromClassID");

                entity.Property(e => e.ClassIsContentOnly).HasDefaultValueSql("0");

                entity.Property(e => e.ClassIsCoupledClass).HasDefaultValueSql("0");

                entity.Property(e => e.ClassIsCustomTable).HasDefaultValueSql("0");

                entity.Property(e => e.ClassIsDocumentType).HasDefaultValueSql("0");

                entity.Property(e => e.ClassListPageUrl).HasMaxLength(450);

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ClassNewPageUrl).HasMaxLength(450);

                entity.Property(e => e.ClassNodeAliasSource).HasMaxLength(100);

                entity.Property(e => e.ClassNodeNameSource)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ClassPageTemplateCategoryId).HasColumnName("ClassPageTemplateCategoryID");

                entity.Property(e => e.ClassPreviewPageUrl).HasMaxLength(450);

                entity.Property(e => e.ClassResourceId).HasColumnName("ClassResourceID");

                entity.Property(e => e.ClassSearchContentColumn).HasMaxLength(200);

                entity.Property(e => e.ClassSearchCreationDateColumn).HasMaxLength(200);

                entity.Property(e => e.ClassSearchImageColumn).HasMaxLength(200);

                entity.Property(e => e.ClassSearchTitleColumn).HasMaxLength(200);

                entity.Property(e => e.ClassShowColumns).HasMaxLength(1000);

                entity.Property(e => e.ClassSkudefaultDepartmentId).HasColumnName("ClassSKUDefaultDepartmentID");

                entity.Property(e => e.ClassSkudefaultDepartmentName)
                    .HasColumnName("ClassSKUDefaultDepartmentName")
                    .HasMaxLength(200);

                entity.Property(e => e.ClassSkudefaultProductType)
                    .HasColumnName("ClassSKUDefaultProductType")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassSkumappings).HasColumnName("ClassSKUMappings");

                entity.Property(e => e.ClassTableName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ClassUrlpattern)
                    .HasColumnName("ClassURLPattern")
                    .HasMaxLength(200);

                entity.Property(e => e.ClassUsesVersioning).HasDefaultValueSql("0");

                entity.Property(e => e.ClassVersionGuid)
                    .HasColumnName("ClassVersionGUID")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassViewPageUrl).HasMaxLength(450);

                entity.Property(e => e.ClassXmlSchema).IsRequired();

                entity.HasOne(d => d.ClassDefaultPageTemplate)
                    .WithMany(p => p.CmsClass)
                    .HasForeignKey(d => d.ClassDefaultPageTemplateId)
                    .HasConstraintName("FK_CMS_Class_ClassDefaultPageTemplateID_CMS_PageTemplate");

                entity.HasOne(d => d.Class)
                    .WithOne(p => p.InverseClass)
                    .HasForeignKey<CmsClass>(d => d.ClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Class_CMS_Class");

                entity.HasOne(d => d.ClassPageTemplateCategory)
                    .WithMany(p => p.CmsClass)
                    .HasForeignKey(d => d.ClassPageTemplateCategoryId)
                    .HasConstraintName("FK_CMS_Class_ClassPageTemplateCategoryID_CMS_PageTemplateCategory");

                entity.HasOne(d => d.ClassResource)
                    .WithMany(p => p.CmsClass)
                    .HasForeignKey(d => d.ClassResourceId)
                    .HasConstraintName("FK_CMS_Class_ClassResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsClassSite>(entity =>
            {
                entity.HasKey(e => new { e.ClassId, e.SiteId })
                    .HasName("PK_CMS_ClassSite");

                entity.ToTable("CMS_ClassSite");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_CMS_ClassSite_SiteID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.CmsClassSite)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Class_ClassID_CMS_Class");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsClassSite)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Class_SiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK_CMS_Country");

                entity.ToTable("CMS_Country");

                entity.HasIndex(e => e.CountryDisplayName)
                    .HasName("IX_CMS_Country_CountryDisplayName");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CountryGuid)
                    .HasColumnName("CountryGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.CountryLastModified).HasDefaultValueSql("'11/14/2013 1:43:04 PM'");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CountryThreeLetterCode).HasMaxLength(3);

                entity.Property(e => e.CountryTwoLetterCode).HasMaxLength(2);
            });

            modelBuilder.Entity<CmsCssStylesheet>(entity =>
            {
                entity.HasKey(e => e.StylesheetId)
                    .HasName("PK_CMS_CssStylesheet");

                entity.ToTable("CMS_CssStylesheet");

                entity.HasIndex(e => e.StylesheetDisplayName)
                    .HasName("IX_CMS_CssStylesheet_StylesheetDisplayName");

                entity.HasIndex(e => e.StylesheetName)
                    .HasName("IX_CMS_CssStylesheet_StylesheetName");

                entity.Property(e => e.StylesheetId).HasColumnName("StylesheetID");

                entity.Property(e => e.StylesheetDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StylesheetDynamicLanguage)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("'plaincss'");

                entity.Property(e => e.StylesheetGuid).HasColumnName("StylesheetGUID");

                entity.Property(e => e.StylesheetName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StylesheetVersionGuid).HasColumnName("StylesheetVersionGUID");
            });

            modelBuilder.Entity<CmsCssStylesheetSite>(entity =>
            {
                entity.HasKey(e => new { e.StylesheetId, e.SiteId })
                    .HasName("PK_CMS_CssStylesheetSite");

                entity.ToTable("CMS_CssStylesheetSite");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_CMS_CssStylesheetSite_SiteID");

                entity.Property(e => e.StylesheetId).HasColumnName("StylesheetID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsCssStylesheetSite)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_CssStylesheetSite_SiteID_CMS_Site");

                entity.HasOne(d => d.Stylesheet)
                    .WithMany(p => p.CmsCssStylesheetSite)
                    .HasForeignKey(d => d.StylesheetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_CssStylesheetSite_StylesheetID_CMS_CssStylesheet");
            });

            modelBuilder.Entity<CmsCulture>(entity =>
            {
                entity.HasKey(e => e.CultureId)
                    .HasName("PK_CMS_Culture");

                entity.ToTable("CMS_Culture");

                entity.HasIndex(e => e.CultureAlias)
                    .HasName("IX_CMS_CulturAlias");

                entity.HasIndex(e => e.CultureCode)
                    .HasName("IX_CMS_Culture_CultureCode");

                entity.HasIndex(e => e.CultureName)
                    .HasName("IX_CMS_Culture_CultureName");

                entity.Property(e => e.CultureId).HasColumnName("CultureID");

                entity.Property(e => e.CultureAlias).HasMaxLength(100);

                entity.Property(e => e.CultureCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CultureGuid).HasColumnName("CultureGUID");

                entity.Property(e => e.CultureIsUiculture)
                    .HasColumnName("CultureIsUICulture")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CultureName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CultureShortName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CmsDeviceProfile>(entity =>
            {
                entity.HasKey(e => e.ProfileId)
                    .HasName("PK_CMS_DeviceProfile");

                entity.ToTable("CMS_DeviceProfile");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ProfileDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ProfileEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.ProfileGuid).HasColumnName("ProfileGUID");

                entity.Property(e => e.ProfileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CmsDeviceProfileLayout>(entity =>
            {
                entity.HasKey(e => e.DeviceProfileLayoutId)
                    .HasName("PK_CMS_DeviceProfileLayout");

                entity.ToTable("CMS_DeviceProfileLayout");

                entity.HasIndex(e => e.DeviceProfileId)
                    .HasName("IX_CMS_DeviceProfileLayout_DeviceProfileID");

                entity.HasIndex(e => e.SourceLayoutId)
                    .HasName("IX_CMS_DeviceProfileLayout_SourceLayoutID");

                entity.HasIndex(e => e.TargetLayoutId)
                    .HasName("IX_CMS_DeviceProfileLayout_TargetLayoutID");

                entity.Property(e => e.DeviceProfileLayoutId).HasColumnName("DeviceProfileLayoutID");

                entity.Property(e => e.DeviceProfileId).HasColumnName("DeviceProfileID");

                entity.Property(e => e.DeviceProfileLayoutGuid).HasColumnName("DeviceProfileLayoutGUID");

                entity.Property(e => e.SourceLayoutId).HasColumnName("SourceLayoutID");

                entity.Property(e => e.TargetLayoutId).HasColumnName("TargetLayoutID");

                entity.HasOne(d => d.DeviceProfile)
                    .WithMany(p => p.CmsDeviceProfileLayout)
                    .HasForeignKey(d => d.DeviceProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_DeviceProfileLayout_DeviceProfileID_CMS_DeviceProfile");

                entity.HasOne(d => d.SourceLayout)
                    .WithMany(p => p.CmsDeviceProfileLayoutSourceLayout)
                    .HasForeignKey(d => d.SourceLayoutId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_DeviceProfileLayout_SourceLayoutID_CMS_Layout");

                entity.HasOne(d => d.TargetLayout)
                    .WithMany(p => p.CmsDeviceProfileLayoutTargetLayout)
                    .HasForeignKey(d => d.TargetLayoutId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_DeviceProfileLayout_TargetLayoutID_CMS_Layout");
            });

            modelBuilder.Entity<CmsDocument>(entity =>
            {
                entity.HasKey(e => e.DocumentId)
                    .HasName("PK_CMS_Document");

                entity.ToTable("CMS_Document");

                entity.HasIndex(e => e.DocumentCheckedOutByUserId)
                    .HasName("IX_CMS_Document_DocumentCheckedOutByUserID");

                entity.HasIndex(e => e.DocumentCheckedOutVersionHistoryId)
                    .HasName("IX_CMS_Document_DocumentCheckedOutVersionHistoryID");

                entity.HasIndex(e => e.DocumentCreatedByUserId)
                    .HasName("IX_CMS_Document_DocumentCreatedByUserID");

                entity.HasIndex(e => e.DocumentCulture)
                    .HasName("IX_CMS_Document_DocumentCulture");

                entity.HasIndex(e => e.DocumentModifiedByUserId)
                    .HasName("IX_CMS_Document_DocumentModifiedByUserID");

                entity.HasIndex(e => e.DocumentPageTemplateId)
                    .HasName("IX_CMS_Document_DocumentPageTemplateID");

                entity.HasIndex(e => e.DocumentPublishedVersionHistoryId)
                    .HasName("IX_CMS_Document_DocumentPublishedVersionHistoryID");

                entity.HasIndex(e => e.DocumentTagGroupId)
                    .HasName("IX_CMS_Document_DocumentTagGroupID");

                entity.HasIndex(e => e.DocumentWorkflowStepId)
                    .HasName("IX_CMS_Document_DocumentWorkflowStepID");

                entity.HasIndex(e => new { e.DocumentWildcardRule, e.DocumentPriority })
                    .HasName("IX_CMS_Document_DocumentWildcardRule_DocumentPriority");

                entity.HasIndex(e => new { e.DocumentForeignKeyValue, e.DocumentId, e.DocumentNodeId })
                    .HasName("IX_CMS_Document_DocumentForeignKeyValue_DocumentID_DocumentNodeID");

                entity.HasIndex(e => new { e.DocumentId, e.DocumentNodeId, e.DocumentUrlPath })
                    .HasName("IX_CMS_Document_DocumentUrlPath_DocumentID_DocumentNodeID");

                entity.HasIndex(e => new { e.DocumentNodeId, e.DocumentId, e.DocumentCulture })
                    .HasName("IX_CMS_Document_DocumentNodeID_DocumentID_DocumentCulture")
                    .IsUnique();

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.DocumentCanBePublished).HasDefaultValueSql("1");

                entity.Property(e => e.DocumentCheckedOutByUserId).HasColumnName("DocumentCheckedOutByUserID");

                entity.Property(e => e.DocumentCheckedOutVersionHistoryId).HasColumnName("DocumentCheckedOutVersionHistoryID");

                entity.Property(e => e.DocumentConversionValue).HasMaxLength(100);

                entity.Property(e => e.DocumentCreatedByUserId).HasColumnName("DocumentCreatedByUserID");

                entity.Property(e => e.DocumentCulture)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DocumentExtensions).HasMaxLength(100);

                entity.Property(e => e.DocumentGuid).HasColumnName("DocumentGUID");

                entity.Property(e => e.DocumentHash).HasMaxLength(32);

                entity.Property(e => e.DocumentInheritsStylesheet).HasDefaultValueSql("1");

                entity.Property(e => e.DocumentLastVersionNumber).HasMaxLength(50);

                entity.Property(e => e.DocumentMenuCaption).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuClass).HasMaxLength(100);

                entity.Property(e => e.DocumentMenuClassHighlighted).HasMaxLength(100);

                entity.Property(e => e.DocumentMenuItemImage).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemImageHighlighted).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemLeftImage).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemLeftImageHighlighted).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemRightImage).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemRightImageHighlighted).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuJavascript).HasMaxLength(450);

                entity.Property(e => e.DocumentMenuRedirectToFirstChild).HasDefaultValueSql("0");

                entity.Property(e => e.DocumentMenuRedirectUrl).HasMaxLength(450);

                entity.Property(e => e.DocumentMenuStyle).HasMaxLength(100);

                entity.Property(e => e.DocumentMenuStyleHighlighted).HasMaxLength(200);

                entity.Property(e => e.DocumentModifiedByUserId).HasColumnName("DocumentModifiedByUserID");

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DocumentNamePath).HasMaxLength(1500);

                entity.Property(e => e.DocumentNodeId).HasColumnName("DocumentNodeID");

                entity.Property(e => e.DocumentPageTemplateId).HasColumnName("DocumentPageTemplateID");

                entity.Property(e => e.DocumentPublishedVersionHistoryId).HasColumnName("DocumentPublishedVersionHistoryID");

                entity.Property(e => e.DocumentSitemapSettings).HasMaxLength(100);

                entity.Property(e => e.DocumentSkudescription).HasColumnName("DocumentSKUDescription");

                entity.Property(e => e.DocumentSkuname)
                    .HasColumnName("DocumentSKUName")
                    .HasMaxLength(440);

                entity.Property(e => e.DocumentSkushortDescription).HasColumnName("DocumentSKUShortDescription");

                entity.Property(e => e.DocumentStylesheetId).HasColumnName("DocumentStylesheetID");

                entity.Property(e => e.DocumentTagGroupId).HasColumnName("DocumentTagGroupID");

                entity.Property(e => e.DocumentTrackConversionName).HasMaxLength(200);

                entity.Property(e => e.DocumentType).HasMaxLength(50);

                entity.Property(e => e.DocumentUrlPath).HasMaxLength(450);

                entity.Property(e => e.DocumentUseCustomExtensions).HasDefaultValueSql("0");

                entity.Property(e => e.DocumentWildcardRule).HasMaxLength(440);

                entity.Property(e => e.DocumentWorkflowActionStatus).HasMaxLength(450);

                entity.Property(e => e.DocumentWorkflowCycleGuid).HasColumnName("DocumentWorkflowCycleGUID");

                entity.Property(e => e.DocumentWorkflowStepId).HasColumnName("DocumentWorkflowStepID");

                entity.HasOne(d => d.DocumentCheckedOutByUser)
                    .WithMany(p => p.CmsDocumentDocumentCheckedOutByUser)
                    .HasForeignKey(d => d.DocumentCheckedOutByUserId)
                    .HasConstraintName("FK_CMS_Document_DocumentCheckedOutByUserID_CMS_User");

                entity.HasOne(d => d.DocumentCheckedOutVersionHistory)
                    .WithMany(p => p.CmsDocumentDocumentCheckedOutVersionHistory)
                    .HasForeignKey(d => d.DocumentCheckedOutVersionHistoryId)
                    .HasConstraintName("FK_CMS_Document_DocumentCheckedOutVersionHistoryID_CMS_VersionHistory");

                entity.HasOne(d => d.DocumentCreatedByUser)
                    .WithMany(p => p.CmsDocumentDocumentCreatedByUser)
                    .HasForeignKey(d => d.DocumentCreatedByUserId)
                    .HasConstraintName("FK_CMS_Document_DocumentCreatedByUserID_CMS_User");

                entity.HasOne(d => d.DocumentModifiedByUser)
                    .WithMany(p => p.CmsDocumentDocumentModifiedByUser)
                    .HasForeignKey(d => d.DocumentModifiedByUserId)
                    .HasConstraintName("FK_CMS_Document_DocumentModifiedByUserID_CMS_User");

                entity.HasOne(d => d.DocumentNode)
                    .WithMany(p => p.CmsDocument)
                    .HasForeignKey(d => d.DocumentNodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Document_DocumentNodeID_CMS_Tree");

                entity.HasOne(d => d.DocumentPageTemplate)
                    .WithMany(p => p.CmsDocument)
                    .HasForeignKey(d => d.DocumentPageTemplateId)
                    .HasConstraintName("FK_CMS_Document_DocumentPageTemplateID_CMS_Template");

                entity.HasOne(d => d.DocumentPublishedVersionHistory)
                    .WithMany(p => p.CmsDocumentDocumentPublishedVersionHistory)
                    .HasForeignKey(d => d.DocumentPublishedVersionHistoryId)
                    .HasConstraintName("FK_CMS_Document_DocumentPublishedVersionHistoryID_CMS_VersionHistory");

                entity.HasOne(d => d.DocumentStylesheet)
                    .WithMany(p => p.CmsDocument)
                    .HasForeignKey(d => d.DocumentStylesheetId)
                    .HasConstraintName("FK_CMS_Document_DocumentStylesheetID_CMS_CssStylesheet");

                entity.HasOne(d => d.DocumentTagGroup)
                    .WithMany(p => p.CmsDocument)
                    .HasForeignKey(d => d.DocumentTagGroupId)
                    .HasConstraintName("FK_CMS_Document_DocumentTagGroupID_CMS_TagGroup");

                entity.HasOne(d => d.DocumentWorkflowStep)
                    .WithMany(p => p.CmsDocument)
                    .HasForeignKey(d => d.DocumentWorkflowStepId)
                    .HasConstraintName("FK_CMS_Document_DocumentWorkflowStepID_CMS_WorkflowStep");
            });

            modelBuilder.Entity<CmsDocumentAlias>(entity =>
            {
                entity.HasKey(e => e.AliasId)
                    .HasName("PK_CMS_DocumentAlias");

                entity.ToTable("CMS_DocumentAlias");

                entity.HasIndex(e => e.AliasCulture)
                    .HasName("IX_CMS_Document_AliasCulture");

                entity.HasIndex(e => e.AliasNodeId)
                    .HasName("IX_CMS_DocumentAlias_AliasNodeID");

                entity.HasIndex(e => e.AliasSiteId)
                    .HasName("IX_CMS_DocumentAlias_AliasSiteID");

                entity.HasIndex(e => e.AliasUrlpath)
                    .HasName("IX_CMS_DocumentAlias_AliasURLPath");

                entity.HasIndex(e => new { e.AliasWildcardRule, e.AliasPriority })
                    .HasName("IX_CMS_DocumentAlias_AliasWildcardRule_AliasPriority");

                entity.Property(e => e.AliasId).HasColumnName("AliasID");

                entity.Property(e => e.AliasActionMode).HasMaxLength(50);

                entity.Property(e => e.AliasCulture)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.AliasExtensions)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.AliasGuid).HasColumnName("AliasGUID");

                entity.Property(e => e.AliasLastModified).HasDefaultValueSql("'10/22/2008 12:55:43 PM'");

                entity.Property(e => e.AliasNodeId).HasColumnName("AliasNodeID");

                entity.Property(e => e.AliasSiteId)
                    .HasColumnName("AliasSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AliasUrlpath)
                    .HasColumnName("AliasURLPath")
                    .HasMaxLength(450)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.AliasWildcardRule).HasMaxLength(440);

                entity.HasOne(d => d.AliasNode)
                    .WithMany(p => p.CmsDocumentAlias)
                    .HasForeignKey(d => d.AliasNodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_DocumentAlias_AliasNodeID_CMS_Tree");

                entity.HasOne(d => d.AliasSite)
                    .WithMany(p => p.CmsDocumentAlias)
                    .HasForeignKey(d => d.AliasSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_DocumentAlias_AliasSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsDocumentCategory>(entity =>
            {
                entity.HasKey(e => new { e.DocumentId, e.CategoryId })
                    .HasName("PK_CMS_DocumentCategory");

                entity.ToTable("CMS_DocumentCategory");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CMS_DocumentCategory_CategoryID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CmsDocumentCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_DocumentCategory_CategoryID_CMS_Category");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.CmsDocumentCategory)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_DocumentCategory_DocumentID_CMS_Document");
            });

            modelBuilder.Entity<CmsDocumentTag>(entity =>
            {
                entity.HasKey(e => new { e.DocumentId, e.TagId })
                    .HasName("PK_CMS_DocumentTag");

                entity.ToTable("CMS_DocumentTag");

                entity.HasIndex(e => e.TagId)
                    .HasName("IX_CMS_DocumentTag_TagID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.CmsDocumentTag)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_DocumentTag_DocumentID_CMS_Document");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.CmsDocumentTag)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_DocumentTag_TagID_CMS_Tag");
            });

            modelBuilder.Entity<CmsDocumentTypeScope>(entity =>
            {
                entity.HasKey(e => e.ScopeId)
                    .HasName("PK_CMS_DocumentTypeScope");

                entity.ToTable("CMS_DocumentTypeScope");

                entity.HasIndex(e => e.ScopePath)
                    .HasName("IX_CMS_DocumentTypeScope_ScopePath");

                entity.HasIndex(e => e.ScopeSiteId)
                    .HasName("IX_CMS_DocumentTypeScope_ScopeSiteID");

                entity.Property(e => e.ScopeId).HasColumnName("ScopeID");

                entity.Property(e => e.ScopeAllowAbvariant)
                    .HasColumnName("ScopeAllowABVariant")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScopeAllowAllTypes).HasDefaultValueSql("0");

                entity.Property(e => e.ScopeAllowLinks).HasDefaultValueSql("0");

                entity.Property(e => e.ScopeGuid).HasColumnName("ScopeGUID");

                entity.Property(e => e.ScopeLastModified).HasDefaultValueSql("'4/30/2013 2:47:21 PM'");

                entity.Property(e => e.ScopePath)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ScopeSiteId).HasColumnName("ScopeSiteID");

                entity.HasOne(d => d.ScopeSite)
                    .WithMany(p => p.CmsDocumentTypeScope)
                    .HasForeignKey(d => d.ScopeSiteId)
                    .HasConstraintName("FK_CMS_DocumentTypeScope_ScopeSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsDocumentTypeScopeClass>(entity =>
            {
                entity.HasKey(e => new { e.ScopeId, e.ClassId })
                    .HasName("PK_CMS_DocumentTypeScopeClass");

                entity.ToTable("CMS_DocumentTypeScopeClass");

                entity.HasIndex(e => e.ClassId)
                    .HasName("IX_CMS_DocumentTypeScopeClass_ClassID");

                entity.Property(e => e.ScopeId).HasColumnName("ScopeID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.CmsDocumentTypeScopeClass)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_DocumentTypeScopeClass_ClassID_CMS_Class");

                entity.HasOne(d => d.Scope)
                    .WithMany(p => p.CmsDocumentTypeScopeClass)
                    .HasForeignKey(d => d.ScopeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_DocumentTypeScopeClass_ScopeID_CMS_DocumentTypeScope");
            });

            modelBuilder.Entity<CmsEmail>(entity =>
            {
                entity.HasKey(e => e.EmailId)
                    .HasName("PK_CMS_Email");

                entity.ToTable("CMS_Email");

                entity.HasIndex(e => new { e.EmailStatus, e.EmailLastSendResult, e.EmailPriority, e.EmailId })
                    .HasName("IX_CMS_Email_EmailPriority_EmailID")
                    .IsUnique();

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.EmailBcc).HasMaxLength(998);

                entity.Property(e => e.EmailCc).HasMaxLength(998);

                entity.Property(e => e.EmailFrom)
                    .IsRequired()
                    .HasMaxLength(254)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.EmailGuid).HasColumnName("EmailGUID");

                entity.Property(e => e.EmailIsMass).HasDefaultValueSql("1");

                entity.Property(e => e.EmailLastModified).HasDefaultValueSql("'6/17/2016 10:11:21 AM'");

                entity.Property(e => e.EmailLastSendResult).IsRequired();

                entity.Property(e => e.EmailReplyTo).HasMaxLength(254);

                entity.Property(e => e.EmailSetName).HasMaxLength(250);

                entity.Property(e => e.EmailSetRelatedId).HasColumnName("EmailSetRelatedID");

                entity.Property(e => e.EmailSiteId).HasColumnName("EmailSiteID");

                entity.Property(e => e.EmailStatus).IsRequired();

                entity.Property(e => e.EmailSubject)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EmailTo).HasMaxLength(998);
            });

            modelBuilder.Entity<CmsEmailAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId)
                    .HasName("PK_CMS_EmailAttachment");

                entity.ToTable("CMS_EmailAttachment");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.AttachmentBinary).IsRequired();

                entity.Property(e => e.AttachmentContentId)
                    .HasColumnName("AttachmentContentID")
                    .HasMaxLength(255);

                entity.Property(e => e.AttachmentExtension)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AttachmentGuid).HasColumnName("AttachmentGUID");

                entity.Property(e => e.AttachmentMimeType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AttachmentName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.AttachmentSiteId).HasColumnName("AttachmentSiteID");
            });

            modelBuilder.Entity<CmsEmailTemplate>(entity =>
            {
                entity.HasKey(e => e.EmailTemplateId)
                    .HasName("PK_CMS_EmailTemplate");

                entity.ToTable("CMS_EmailTemplate");

                entity.HasIndex(e => e.EmailTemplateDisplayName)
                    .HasName("IX_CMS_EmailTemplate_EmailTemplateDisplayName");

                entity.HasIndex(e => e.EmailTemplateSiteId)
                    .HasName("IX_CMS_EmailTemplate_EmailTemplateSiteID");

                entity.HasIndex(e => new { e.EmailTemplateName, e.EmailTemplateSiteId })
                    .HasName("IX_CMS_EmailTemplate_EmailTemplateName_EmailTemplateSiteID");

                entity.Property(e => e.EmailTemplateId).HasColumnName("EmailTemplateID");

                entity.Property(e => e.EmailTemplateBcc).HasMaxLength(998);

                entity.Property(e => e.EmailTemplateCc).HasMaxLength(998);

                entity.Property(e => e.EmailTemplateDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EmailTemplateFrom).HasMaxLength(254);

                entity.Property(e => e.EmailTemplateGuid).HasColumnName("EmailTemplateGUID");

                entity.Property(e => e.EmailTemplateName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.EmailTemplateReplyTo).HasMaxLength(254);

                entity.Property(e => e.EmailTemplateSiteId).HasColumnName("EmailTemplateSiteID");

                entity.Property(e => e.EmailTemplateSubject).HasMaxLength(250);

                entity.Property(e => e.EmailTemplateType).HasMaxLength(100);

                entity.HasOne(d => d.EmailTemplateSite)
                    .WithMany(p => p.CmsEmailTemplate)
                    .HasForeignKey(d => d.EmailTemplateSiteId)
                    .HasConstraintName("FK_CMS_Email_EmailTemplateSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsEmailUser>(entity =>
            {
                entity.HasKey(e => new { e.EmailId, e.UserId })
                    .HasName("PK_CMS_EmailUser");

                entity.ToTable("CMS_EmailUser");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_CMS_EmailUser_Status");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_CMS_EmailUser_UserID");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.CmsEmailUser)
                    .HasForeignKey(d => d.EmailId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_EmailUser_EmailID_CMS_Email");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsEmailUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_EmailUser_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsEventLog>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_CMS_EventLog");

                entity.ToTable("CMS_EventLog");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_CMS_EventLog_SiteID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.EventCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.EventMachineName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.EventTime).HasDefaultValueSql("'4/21/2015 8:21:43 AM'");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.EventUrl).HasDefaultValueSql("N''");

                entity.Property(e => e.EventUrlReferrer).HasDefaultValueSql("N''");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.NodeId).HasColumnName("NodeID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(250);
            });

            modelBuilder.Entity<CmsExternalLogin>(entity =>
            {
                entity.HasKey(e => e.ExternalLoginId)
                    .HasName("PK_CMS_ExternalLogin");

                entity.ToTable("CMS_ExternalLogin");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_CMS_ExternalLogin_UserID");

                entity.Property(e => e.ExternalLoginId).HasColumnName("ExternalLoginID");

                entity.Property(e => e.IdentityKey).HasMaxLength(200);

                entity.Property(e => e.LoginProvider).HasMaxLength(200);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsExternalLogin)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_ExternalLogin_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsForm>(entity =>
            {
                entity.HasKey(e => e.FormId)
                    .HasName("PK_CMS_Form");

                entity.ToTable("CMS_Form");

                entity.HasIndex(e => e.FormClassId)
                    .HasName("IX_CMS_Form_FormClassID");

                entity.HasIndex(e => e.FormDisplayName)
                    .HasName("IX_CMS_Form_FormDisplayName");

                entity.HasIndex(e => e.FormSiteId)
                    .HasName("IX_CMS_Form_FormSiteID");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.FormClassId).HasColumnName("FormClassID");

                entity.Property(e => e.FormClearAfterSave).HasDefaultValueSql("0");

                entity.Property(e => e.FormConfirmationEmailField).HasMaxLength(254);

                entity.Property(e => e.FormConfirmationEmailSubject)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.FormConfirmationSendFromEmail).HasMaxLength(254);

                entity.Property(e => e.FormDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FormEmailAttachUploadedDocs).HasDefaultValueSql("0");

                entity.Property(e => e.FormEmailSubject).HasMaxLength(250);

                entity.Property(e => e.FormGuid)
                    .HasColumnName("FormGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.FormItems).HasDefaultValueSql("0");

                entity.Property(e => e.FormLastModified).HasDefaultValueSql("'9/17/2012 1:37:08 PM'");

                entity.Property(e => e.FormLogActivity).HasDefaultValueSql("1");

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FormRedirectToUrl).HasMaxLength(400);

                entity.Property(e => e.FormSendFromEmail).HasMaxLength(254);

                entity.Property(e => e.FormSendToEmail).HasMaxLength(998);

                entity.Property(e => e.FormSiteId).HasColumnName("FormSiteID");

                entity.Property(e => e.FormSubmitButtonImage).HasMaxLength(255);

                entity.Property(e => e.FormSubmitButtonText)
                    .HasMaxLength(400)
                    .HasDefaultValueSql("N''");

                entity.HasOne(d => d.FormClass)
                    .WithMany(p => p.CmsForm)
                    .HasForeignKey(d => d.FormClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Form_FormClassID_CMS_Class");

                entity.HasOne(d => d.FormSite)
                    .WithMany(p => p.CmsForm)
                    .HasForeignKey(d => d.FormSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Form_FormSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsFormRole>(entity =>
            {
                entity.HasKey(e => new { e.FormId, e.RoleId })
                    .HasName("PK_CMS_FormRole");

                entity.ToTable("CMS_FormRole");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_CMS_FormRole_RoleID");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.CmsFormRole)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_FormRole_FormID_CMS_Form");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CmsFormRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_FormRole_RoleID_CMS_Role");
            });

            modelBuilder.Entity<CmsFormUserControl>(entity =>
            {
                entity.HasKey(e => e.UserControlId)
                    .HasName("PK_CMS_FormUserControl");

                entity.ToTable("CMS_FormUserControl");

                entity.HasIndex(e => e.UserControlCodeName)
                    .HasName("IX_CMS_FormUserControl_UserControlCodeName")
                    .IsUnique();

                entity.HasIndex(e => e.UserControlDisplayName)
                    .HasName("IX_CMS_FormUserControl_UserControlDisplayName");

                entity.HasIndex(e => e.UserControlParentId)
                    .HasName("IX_CMS_FormUserControl_UserControlParentID");

                entity.HasIndex(e => e.UserControlResourceId)
                    .HasName("IX_CMS_FormUserControl_UserControlResourceID");

                entity.Property(e => e.UserControlId).HasColumnName("UserControlID");

                entity.Property(e => e.UserControlCodeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UserControlDefaultDataType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserControlDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UserControlFileName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.UserControlForBinary).HasDefaultValueSql("0");

                entity.Property(e => e.UserControlForDocAttachments).HasDefaultValueSql("0");

                entity.Property(e => e.UserControlForDocRelationships).HasDefaultValueSql("0");

                entity.Property(e => e.UserControlForGuid).HasDefaultValueSql("0");

                entity.Property(e => e.UserControlForVisibility).HasDefaultValueSql("0");

                entity.Property(e => e.UserControlGuid).HasColumnName("UserControlGUID");

                entity.Property(e => e.UserControlIsSystem).HasDefaultValueSql("0");

                entity.Property(e => e.UserControlParentId).HasColumnName("UserControlParentID");

                entity.Property(e => e.UserControlPriority).HasDefaultValueSql("0");

                entity.Property(e => e.UserControlResourceId).HasColumnName("UserControlResourceID");

                entity.Property(e => e.UserControlShowInCustomTables).HasDefaultValueSql("0");

                entity.Property(e => e.UserControlThumbnailGuid).HasColumnName("UserControlThumbnailGUID");

                entity.HasOne(d => d.UserControlParent)
                    .WithMany(p => p.InverseUserControlParent)
                    .HasForeignKey(d => d.UserControlParentId)
                    .HasConstraintName("FK_CMS_FormUserControl_UserControlParentID_CMS_FormUserControl");

                entity.HasOne(d => d.UserControlResource)
                    .WithMany(p => p.CmsFormUserControl)
                    .HasForeignKey(d => d.UserControlResourceId)
                    .HasConstraintName("FK_CMS_FormUserControl_UserControlResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsHelpTopic>(entity =>
            {
                entity.HasKey(e => e.HelpTopicId)
                    .HasName("PK_CMS_HelpTopic");

                entity.ToTable("CMS_HelpTopic");

                entity.Property(e => e.HelpTopicId).HasColumnName("HelpTopicID");

                entity.Property(e => e.HelpTopicGuid).HasColumnName("HelpTopicGUID");

                entity.Property(e => e.HelpTopicLink)
                    .IsRequired()
                    .HasMaxLength(1023)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.HelpTopicName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.HelpTopicUielementId).HasColumnName("HelpTopicUIElementID");
            });

            modelBuilder.Entity<CmsInlineControl>(entity =>
            {
                entity.HasKey(e => e.ControlId)
                    .HasName("PK_CMS_InlineControl");

                entity.ToTable("CMS_InlineControl");

                entity.HasIndex(e => e.ControlDisplayName)
                    .HasName("IX_CMS_InlineControl_ControlDisplayName");

                entity.HasIndex(e => e.ControlResourceId)
                    .HasName("IX_CMS_InlineControl_ControlResourceID");

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.Property(e => e.ControlDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ControlFileName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ControlGuid).HasColumnName("ControlGUID");

                entity.Property(e => e.ControlName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ControlResourceId).HasColumnName("ControlResourceID");

                entity.HasOne(d => d.ControlResource)
                    .WithMany(p => p.CmsInlineControl)
                    .HasForeignKey(d => d.ControlResourceId)
                    .HasConstraintName("FK_CMS_InlineControl_ControlResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsLayout>(entity =>
            {
                entity.HasKey(e => e.LayoutId)
                    .HasName("PK_CMS_Layout");

                entity.ToTable("CMS_Layout");

                entity.HasIndex(e => e.LayoutDisplayName)
                    .HasName("IX_CMS_Layout_LayoutDisplayName");

                entity.Property(e => e.LayoutId).HasColumnName("LayoutID");

                entity.Property(e => e.LayoutCode)
                    .IsRequired()
                    .HasDefaultValueSql("'<cms:CMSWebPartZone ZoneID=\"zoneA\" runat=\"server\" />'");

                entity.Property(e => e.LayoutCodeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LayoutCss).HasColumnName("LayoutCSS");

                entity.Property(e => e.LayoutDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LayoutGuid)
                    .HasColumnName("LayoutGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.LayoutIconClass).HasMaxLength(200);

                entity.Property(e => e.LayoutIsConvertible).HasDefaultValueSql("0");

                entity.Property(e => e.LayoutThumbnailGuid).HasColumnName("LayoutThumbnailGUID");

                entity.Property(e => e.LayoutType).HasMaxLength(50);

                entity.Property(e => e.LayoutVersionGuid)
                    .HasColumnName("LayoutVersionGUID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CmsLicenseKey>(entity =>
            {
                entity.HasKey(e => e.LicenseKeyId)
                    .HasName("PK_CMS_LicenseKey");

                entity.ToTable("CMS_LicenseKey");

                entity.HasIndex(e => e.LicenseDomain)
                    .HasName("IX_CMS_LicenseKey_LicenseDomain");

                entity.Property(e => e.LicenseKeyId).HasColumnName("LicenseKeyID");

                entity.Property(e => e.LicenseDomain).HasMaxLength(255);

                entity.Property(e => e.LicenseEdition).HasMaxLength(200);

                entity.Property(e => e.LicenseExpiration).HasMaxLength(200);
            });

            modelBuilder.Entity<CmsMacroRule>(entity =>
            {
                entity.HasKey(e => e.MacroRuleId)
                    .HasName("PK_CMS_MacroRule");

                entity.ToTable("CMS_MacroRule");

                entity.Property(e => e.MacroRuleId).HasColumnName("MacroRuleID");

                entity.Property(e => e.MacroRuleCondition)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.MacroRuleDescription).HasMaxLength(450);

                entity.Property(e => e.MacroRuleDisplayName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MacroRuleEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.MacroRuleGuid)
                    .HasColumnName("MacroRuleGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.MacroRuleIsCustom).HasDefaultValueSql("0");

                entity.Property(e => e.MacroRuleLastModified).HasDefaultValueSql("'5/1/2012 8:46:33 AM'");

                entity.Property(e => e.MacroRuleName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MacroRuleRequiredData).HasMaxLength(2500);

                entity.Property(e => e.MacroRuleRequiresContext).HasDefaultValueSql("0");

                entity.Property(e => e.MacroRuleResourceName).HasMaxLength(100);

                entity.Property(e => e.MacroRuleText)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<CmsMembership>(entity =>
            {
                entity.HasKey(e => e.MembershipId)
                    .HasName("PK_CMS_Membership");

                entity.ToTable("CMS_Membership");

                entity.HasIndex(e => e.MembershipSiteId)
                    .HasName("IX_CMS_Membership_MembershipSiteID");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.MembershipDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MembershipGuid).HasColumnName("MembershipGUID");

                entity.Property(e => e.MembershipName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MembershipSiteId).HasColumnName("MembershipSiteID");

                entity.HasOne(d => d.MembershipSite)
                    .WithMany(p => p.CmsMembership)
                    .HasForeignKey(d => d.MembershipSiteId)
                    .HasConstraintName("FK_CMS_Membership_MembershipSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsMembershipRole>(entity =>
            {
                entity.HasKey(e => new { e.MembershipId, e.RoleId })
                    .HasName("PK_CMS_MembershipRole");

                entity.ToTable("CMS_MembershipRole");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_CMS_MembershipRole_RoleID");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.CmsMembershipRole)
                    .HasForeignKey(d => d.MembershipId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_MembershipRole_MembershipID_CMS_Membership");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CmsMembershipRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_MembershipRole_RoleID_CMS_Role");
            });

            modelBuilder.Entity<CmsMembershipUser>(entity =>
            {
                entity.HasKey(e => e.MembershipUserId)
                    .HasName("PK_CMS_MembershipUser");

                entity.ToTable("CMS_MembershipUser");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_CMS_MembershipUser_UserID");

                entity.HasIndex(e => new { e.MembershipId, e.UserId })
                    .HasName("IX_CMS_MembershipUser_MembershipID_UserID")
                    .IsUnique();

                entity.Property(e => e.MembershipUserId).HasColumnName("MembershipUserID");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.CmsMembershipUser)
                    .HasForeignKey(d => d.MembershipId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_MembershipUser_MembershipID_CMS_Membership");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsMembershipUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_MembershipUser_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsMetaFile>(entity =>
            {
                entity.HasKey(e => e.MetaFileId)
                    .HasName("PK_CMS_MetaFile");

                entity.ToTable("CMS_MetaFile");

                entity.HasIndex(e => e.MetaFileSiteId)
                    .HasName("IX_CMS_MetaFile_MetaFileSiteID");

                entity.HasIndex(e => new { e.MetaFileObjectType, e.MetaFileObjectId, e.MetaFileGroupName })
                    .HasName("IX_CMS_Metafile_MetaFileObjectType_MetaFileObjectID_MetaFileGroupName");

                entity.HasIndex(e => new { e.MetaFileGuid, e.MetaFileSiteId, e.MetaFileObjectType, e.MetaFileObjectId, e.MetaFileGroupName })
                    .HasName("IX_CMS_MetaFile_MetaFileGUID_MetaFileSiteID_MetaFileObjectType_MetaFileObjectID_MetaFileGroupName");

                entity.Property(e => e.MetaFileId).HasColumnName("MetaFileID");

                entity.Property(e => e.MetaFileExtension)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MetaFileGroupName).HasMaxLength(100);

                entity.Property(e => e.MetaFileGuid).HasColumnName("MetaFileGUID");

                entity.Property(e => e.MetaFileMimeType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MetaFileName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.MetaFileObjectId).HasColumnName("MetaFileObjectID");

                entity.Property(e => e.MetaFileObjectType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MetaFileSiteId).HasColumnName("MetaFileSiteID");

                entity.Property(e => e.MetaFileTitle).HasMaxLength(250);

                entity.HasOne(d => d.MetaFileSite)
                    .WithMany(p => p.CmsMetaFile)
                    .HasForeignKey(d => d.MetaFileSiteId)
                    .HasConstraintName("FK_CMS_MetaFile_MetaFileSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsModuleLicenseKey>(entity =>
            {
                entity.HasKey(e => e.ModuleLicenseKeyId)
                    .HasName("PK_CMS_ModuleLicenseKey");

                entity.ToTable("CMS_ModuleLicenseKey");

                entity.HasIndex(e => e.ModuleLicenseKeyResourceId)
                    .HasName("IX_CMS_ModuleLicenseKey_ModuleLicenseKeyResourceID");

                entity.Property(e => e.ModuleLicenseKeyId).HasColumnName("ModuleLicenseKeyID");

                entity.Property(e => e.ModuleLicenseKeyGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.ModuleLicenseKeyLastModified).HasDefaultValueSql("'1/1/0001 12:00:00 AM'");

                entity.Property(e => e.ModuleLicenseKeyLicense)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ModuleLicenseKeyResourceId)
                    .HasColumnName("ModuleLicenseKeyResourceID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ModuleLicenseKeyResource)
                    .WithMany(p => p.CmsModuleLicenseKey)
                    .HasForeignKey(d => d.ModuleLicenseKeyResourceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_ModuleLicenseKey_ModuleLicenseKeyResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsObjectSettings>(entity =>
            {
                entity.HasKey(e => e.ObjectSettingsId)
                    .HasName("PK_CMS_ObjectSettings");

                entity.ToTable("CMS_ObjectSettings");

                entity.HasIndex(e => e.ObjectCheckedOutByUserId)
                    .HasName("IX_CMS_ObjectSettings_ObjectCheckedOutByUserID");

                entity.HasIndex(e => e.ObjectCheckedOutVersionHistoryId)
                    .HasName("IX_CMS_ObjectSettings_ObjectCheckedOutVersionHistoryID");

                entity.HasIndex(e => e.ObjectPublishedVersionHistoryId)
                    .HasName("IX_CMS_ObjectSettings_ObjectPublishedVersionHistoryID");

                entity.HasIndex(e => e.ObjectWorkflowStepId)
                    .HasName("IX_CMS_ObjectSettings_ObjectWorkflowStepID");

                entity.HasIndex(e => new { e.ObjectSettingsObjectId, e.ObjectSettingsObjectType })
                    .HasName("IX_CMS_ObjectSettings_ObjectSettingsObjectType_ObjectSettingsObjectID")
                    .IsUnique();

                entity.Property(e => e.ObjectSettingsId).HasColumnName("ObjectSettingsID");

                entity.Property(e => e.ObjectCheckedOutByUserId).HasColumnName("ObjectCheckedOutByUserID");

                entity.Property(e => e.ObjectCheckedOutVersionHistoryId).HasColumnName("ObjectCheckedOutVersionHistoryID");

                entity.Property(e => e.ObjectPublishedVersionHistoryId).HasColumnName("ObjectPublishedVersionHistoryID");

                entity.Property(e => e.ObjectSettingsObjectId)
                    .HasColumnName("ObjectSettingsObjectID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ObjectSettingsObjectType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ObjectWorkflowSendEmails).HasDefaultValueSql("1");

                entity.Property(e => e.ObjectWorkflowStepId).HasColumnName("ObjectWorkflowStepID");

                entity.HasOne(d => d.ObjectCheckedOutByUser)
                    .WithMany(p => p.CmsObjectSettings)
                    .HasForeignKey(d => d.ObjectCheckedOutByUserId)
                    .HasConstraintName("FK_CMS_ObjectSettings_ObjectCheckedOutByUserID_CMS_User");

                entity.HasOne(d => d.ObjectCheckedOutVersionHistory)
                    .WithMany(p => p.CmsObjectSettingsObjectCheckedOutVersionHistory)
                    .HasForeignKey(d => d.ObjectCheckedOutVersionHistoryId)
                    .HasConstraintName("FK_CMS_ObjectSettings_ObjectCheckedOutVersionHistoryID_CMS_ObjectVersionHistory");

                entity.HasOne(d => d.ObjectPublishedVersionHistory)
                    .WithMany(p => p.CmsObjectSettingsObjectPublishedVersionHistory)
                    .HasForeignKey(d => d.ObjectPublishedVersionHistoryId)
                    .HasConstraintName("FK_CMS_ObjectSettings_ObjectPublishedVersionHistoryID_CMS_ObjectVersionHistory");

                entity.HasOne(d => d.ObjectWorkflowStep)
                    .WithMany(p => p.CmsObjectSettings)
                    .HasForeignKey(d => d.ObjectWorkflowStepId)
                    .HasConstraintName("FK_CMS_ObjectSettings_ObjectWorkflowStepID_CMS_WorkflowStep");
            });

            modelBuilder.Entity<CmsObjectVersionHistory>(entity =>
            {
                entity.HasKey(e => e.VersionId)
                    .HasName("PK_CMS_ObjectVersionHistory_VersionID");

                entity.ToTable("CMS_ObjectVersionHistory");

                entity.HasIndex(e => e.VersionModifiedByUserId)
                    .HasName("IX_CMS_ObjectVersionHistory_VersionModifiedByUserID");

                entity.HasIndex(e => new { e.VersionDeletedByUserId, e.VersionDeletedWhen })
                    .HasName("IX_CMS_ObjectVersionHistory_VersionDeletedByUserID_VersionDeletedWhen");

                entity.HasIndex(e => new { e.VersionObjectSiteId, e.VersionDeletedWhen })
                    .HasName("IX_CMS_ObjectVersionHistory_VersionObjectSiteID_VersionDeletedWhen");

                entity.HasIndex(e => new { e.VersionObjectType, e.VersionObjectId, e.VersionId })
                    .HasName("PK_CMS_ObjectVersionHistory")
                    .IsUnique();

                entity.HasIndex(e => new { e.VersionObjectType, e.VersionObjectId, e.VersionModifiedWhen })
                    .HasName("IX_CMS_ObjectVersionHistory_VersionObjectType_VersionObjectID_VersionModifiedWhen");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionBinaryDataXml).HasColumnName("VersionBinaryDataXML");

                entity.Property(e => e.VersionDeletedByUserId).HasColumnName("VersionDeletedByUserID");

                entity.Property(e => e.VersionModifiedByUserId).HasColumnName("VersionModifiedByUserID");

                entity.Property(e => e.VersionNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VersionObjectDisplayName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.VersionObjectId)
                    .IsRequired()
                    .HasColumnName("VersionObjectID");

                entity.Property(e => e.VersionObjectSiteId).HasColumnName("VersionObjectSiteID");

                entity.Property(e => e.VersionObjectType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VersionSiteBindingIds).HasColumnName("VersionSiteBindingIDs");

                entity.Property(e => e.VersionXml)
                    .IsRequired()
                    .HasColumnName("VersionXML");

                entity.HasOne(d => d.VersionDeletedByUser)
                    .WithMany(p => p.CmsObjectVersionHistoryVersionDeletedByUser)
                    .HasForeignKey(d => d.VersionDeletedByUserId)
                    .HasConstraintName("FK_CMS_ObjectVersionHistory_VersionDeletedByUserID_CMS_User");

                entity.HasOne(d => d.VersionModifiedByUser)
                    .WithMany(p => p.CmsObjectVersionHistoryVersionModifiedByUser)
                    .HasForeignKey(d => d.VersionModifiedByUserId)
                    .HasConstraintName("FK_CMS_ObjectVersionHistory_VersionModifiedByUserID_CMS_User");

                entity.HasOne(d => d.VersionObjectSite)
                    .WithMany(p => p.CmsObjectVersionHistory)
                    .HasForeignKey(d => d.VersionObjectSiteId)
                    .HasConstraintName("FK_CMS_ObjectVersionHistory_VersionObjectSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsObjectWorkflowTrigger>(entity =>
            {
                entity.HasKey(e => e.TriggerId)
                    .HasName("PK_CMS_ObjectWorkflowTrigger");

                entity.ToTable("CMS_ObjectWorkflowTrigger");

                entity.HasIndex(e => e.TriggerWorkflowId)
                    .HasName("IX_CMS_ObjectWorkflowTrigger_TriggerWorkflowID");

                entity.Property(e => e.TriggerId).HasColumnName("TriggerID");

                entity.Property(e => e.TriggerDisplayName)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TriggerGuid).HasColumnName("TriggerGUID");

                entity.Property(e => e.TriggerObjectType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TriggerTargetObjectId).HasColumnName("TriggerTargetObjectID");

                entity.Property(e => e.TriggerTargetObjectType).HasMaxLength(100);

                entity.Property(e => e.TriggerType).HasDefaultValueSql("0");

                entity.Property(e => e.TriggerWorkflowId)
                    .HasColumnName("TriggerWorkflowID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.TriggerWorkflow)
                    .WithMany(p => p.CmsObjectWorkflowTrigger)
                    .HasForeignKey(d => d.TriggerWorkflowId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_ObjectWorkflowTrigger_TriggerWorkflowID");
            });

            modelBuilder.Entity<CmsOpenIduser>(entity =>
            {
                entity.HasKey(e => e.OpenIduserId)
                    .HasName("PK_CMS_OpenIDUser");

                entity.ToTable("CMS_OpenIDUser");

                entity.HasIndex(e => e.OpenId)
                    .HasName("IX_CMS_OpenIDUser_OpenID");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_CMS_OpenIDUser_UserID");

                entity.Property(e => e.OpenIduserId).HasColumnName("OpenIDUserID");

                entity.Property(e => e.OpenId)
                    .IsRequired()
                    .HasColumnName("OpenID")
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OpenIdproviderUrl)
                    .HasColumnName("OpenIDProviderURL")
                    .HasMaxLength(450);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsOpenIduser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_OpenIDUser_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsPageTemplate>(entity =>
            {
                entity.HasKey(e => e.PageTemplateId)
                    .HasName("PK_CMS_PageTemplate");

                entity.ToTable("CMS_PageTemplate");

                entity.HasIndex(e => e.PageTemplateCategoryId)
                    .HasName("IX_CMS_PageTemplate_PageTemplateCategoryID");

                entity.HasIndex(e => e.PageTemplateLayoutId)
                    .HasName("IX_CMS_PageTemplate_PageTemplateLayoutID");

                entity.HasIndex(e => new { e.PageTemplateCodeName, e.PageTemplateDisplayName })
                    .HasName("IX_CMS_PageTemplate_PageTemplateCodeName_PageTemplateDisplayName");

                entity.HasIndex(e => new { e.PageTemplateIsReusable, e.PageTemplateForAllPages, e.PageTemplateShowAsMasterTemplate })
                    .HasName("IX_CMS_PageTemplate_PageTemplateIsReusable_PageTemplateForAllPages_PageTemplateShowAsMasterTemplate");

                entity.HasIndex(e => new { e.PageTemplateSiteId, e.PageTemplateCodeName, e.PageTemplateGuid })
                    .HasName("IX_CMS_PageTemplate_PageTemplateSiteID_PageTemplateCodeName_PageTemplateGUID");

                entity.Property(e => e.PageTemplateId).HasColumnName("PageTemplateID");

                entity.Property(e => e.PageTemplateCategoryId).HasColumnName("PageTemplateCategoryID");

                entity.Property(e => e.PageTemplateCloneAsAdHoc).HasDefaultValueSql("0");

                entity.Property(e => e.PageTemplateCodeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PageTemplateCss).HasColumnName("PageTemplateCSS");

                entity.Property(e => e.PageTemplateDefaultAction).HasMaxLength(200);

                entity.Property(e => e.PageTemplateDefaultController).HasMaxLength(200);

                entity.Property(e => e.PageTemplateDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PageTemplateFile).HasMaxLength(400);

                entity.Property(e => e.PageTemplateForAllPages).HasDefaultValueSql("1");

                entity.Property(e => e.PageTemplateGuid).HasColumnName("PageTemplateGUID");

                entity.Property(e => e.PageTemplateIconClass).HasMaxLength(200);

                entity.Property(e => e.PageTemplateInheritPageLevels).HasMaxLength(200);

                entity.Property(e => e.PageTemplateIsLayout).HasDefaultValueSql("0");

                entity.Property(e => e.PageTemplateIsReusable).HasDefaultValueSql("0");

                entity.Property(e => e.PageTemplateLayoutId).HasColumnName("PageTemplateLayoutID");

                entity.Property(e => e.PageTemplateLayoutType).HasMaxLength(50);

                entity.Property(e => e.PageTemplateMasterPageTemplateId).HasColumnName("PageTemplateMasterPageTemplateID");

                entity.Property(e => e.PageTemplateNodeGuid).HasColumnName("PageTemplateNodeGUID");

                entity.Property(e => e.PageTemplateShowAsMasterTemplate).HasDefaultValueSql("0");

                entity.Property(e => e.PageTemplateSiteId).HasColumnName("PageTemplateSiteID");

                entity.Property(e => e.PageTemplateThumbnailGuid).HasColumnName("PageTemplateThumbnailGUID");

                entity.Property(e => e.PageTemplateType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("N'portal'");

                entity.Property(e => e.PageTemplateVersionGuid)
                    .HasColumnName("PageTemplateVersionGUID")
                    .HasMaxLength(200);

                entity.HasOne(d => d.PageTemplateCategory)
                    .WithMany(p => p.CmsPageTemplate)
                    .HasForeignKey(d => d.PageTemplateCategoryId)
                    .HasConstraintName("FK_CMS_PageTemplate_PageTemplateCategoryID_CMS_PageTemplateCategory");

                entity.HasOne(d => d.PageTemplateLayoutNavigation)
                    .WithMany(p => p.CmsPageTemplate)
                    .HasForeignKey(d => d.PageTemplateLayoutId)
                    .HasConstraintName("FK_CMS_PageTemplate_PageTemplateLayoutID_CMS_Layout");

                entity.HasOne(d => d.PageTemplateSite)
                    .WithMany(p => p.CmsPageTemplate)
                    .HasForeignKey(d => d.PageTemplateSiteId)
                    .HasConstraintName("FK_CMS_PageTemplate_PageTemplateSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsPageTemplateCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_CMS_PageTemplateCategory");

                entity.ToTable("CMS_PageTemplateCategory");

                entity.HasIndex(e => e.CategoryLevel)
                    .HasName("IX_CMS_PageTemplateCategory_CategoryLevel");

                entity.HasIndex(e => e.CategoryParentId)
                    .HasName("IX_CMS_PageTemplateCategory_CategoryParentID");

                entity.HasIndex(e => e.CategoryPath)
                    .HasName("IX_CMS_PageTemplateCategory_CategoryPath")
                    .IsUnique();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryChildCount).HasDefaultValueSql("0");

                entity.Property(e => e.CategoryDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CategoryGuid).HasColumnName("CategoryGUID");

                entity.Property(e => e.CategoryImagePath).HasMaxLength(450);

                entity.Property(e => e.CategoryName).HasMaxLength(200);

                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentID");

                entity.Property(e => e.CategoryPath)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.CategoryTemplateChildCount).HasDefaultValueSql("0");

                entity.HasOne(d => d.CategoryParent)
                    .WithMany(p => p.InverseCategoryParent)
                    .HasForeignKey(d => d.CategoryParentId)
                    .HasConstraintName("FK_CMS_PageTemplateCategory_CategoryParentID_CMS_PageTemplateCategory");
            });

            modelBuilder.Entity<CmsPageTemplateScope>(entity =>
            {
                entity.HasKey(e => e.PageTemplateScopeId)
                    .HasName("PK_CMS_PageTemplateScope");

                entity.ToTable("CMS_PageTemplateScope");

                entity.HasIndex(e => e.PageTemplateScopeClassId)
                    .HasName("IX_CMS_PageTemplateScope_PageTemplateScopeClassID");

                entity.HasIndex(e => e.PageTemplateScopeCultureId)
                    .HasName("IX_CMS_PageTemplateScope_PageTemplateScopeCultureID");

                entity.HasIndex(e => e.PageTemplateScopeLevels)
                    .HasName("IX_CMS_PageTemplateScope_PageTemplateScopeLevels");

                entity.HasIndex(e => e.PageTemplateScopePath)
                    .HasName("IX_CMS_PageTemplateScope_PageTemplateScopePath");

                entity.HasIndex(e => e.PageTemplateScopeSiteId)
                    .HasName("IX_CMS_PageTemplateScope_PageTemplateScopeSiteID");

                entity.HasIndex(e => e.PageTemplateScopeTemplateId)
                    .HasName("IX_CMS_PageTemplateScope_PageTemplateScopeTemplateID");

                entity.Property(e => e.PageTemplateScopeId).HasColumnName("PageTemplateScopeID");

                entity.Property(e => e.PageTemplateScopeClassId).HasColumnName("PageTemplateScopeClassID");

                entity.Property(e => e.PageTemplateScopeCultureId).HasColumnName("PageTemplateScopeCultureID");

                entity.Property(e => e.PageTemplateScopeGuid)
                    .HasColumnName("PageTemplateScopeGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.PageTemplateScopeLastModified).HasDefaultValueSql("'2/22/2010 9:30:07 AM'");

                entity.Property(e => e.PageTemplateScopeLevels).HasMaxLength(450);

                entity.Property(e => e.PageTemplateScopePath)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PageTemplateScopeSiteId).HasColumnName("PageTemplateScopeSiteID");

                entity.Property(e => e.PageTemplateScopeTemplateId)
                    .HasColumnName("PageTemplateScopeTemplateID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.PageTemplateScopeClass)
                    .WithMany(p => p.CmsPageTemplateScope)
                    .HasForeignKey(d => d.PageTemplateScopeClassId)
                    .HasConstraintName("FK_CMS_PageTemplateScope_PageTemplateScopeClassID_CMS_Class");

                entity.HasOne(d => d.PageTemplateScopeCulture)
                    .WithMany(p => p.CmsPageTemplateScope)
                    .HasForeignKey(d => d.PageTemplateScopeCultureId)
                    .HasConstraintName("FK_CMS_PageTemplateScope_PageTemplateScopeCultureID_CMS_Culture");

                entity.HasOne(d => d.PageTemplateScopeSite)
                    .WithMany(p => p.CmsPageTemplateScope)
                    .HasForeignKey(d => d.PageTemplateScopeSiteId)
                    .HasConstraintName("FK_CMS_PageTemplateScope_PageTemplateScopeSiteID_CMS_Site");

                entity.HasOne(d => d.PageTemplateScopeTemplate)
                    .WithMany(p => p.CmsPageTemplateScope)
                    .HasForeignKey(d => d.PageTemplateScopeTemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_PageTemplateScope_PageTemplateScopeTemplateID_CMS_PageTemplate");
            });

            modelBuilder.Entity<CmsPageTemplateSite>(entity =>
            {
                entity.HasKey(e => new { e.PageTemplateId, e.SiteId })
                    .HasName("PK_CMS_PageTemplateSite");

                entity.ToTable("CMS_PageTemplateSite");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_CMS_PageTemplateSite_SiteID");

                entity.Property(e => e.PageTemplateId).HasColumnName("PageTemplateID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.PageTemplate)
                    .WithMany(p => p.CmsPageTemplateSite)
                    .HasForeignKey(d => d.PageTemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_PageTemplateSite_PageTemplateID_CMS_PageTemplate");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsPageTemplateSite)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_PageTemplateSite_SiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId)
                    .HasName("PK_CMS_Permission");

                entity.ToTable("CMS_Permission");

                entity.HasIndex(e => new { e.ClassId, e.PermissionName })
                    .HasName("IX_CMS_Permission_ClassID_PermissionName");

                entity.HasIndex(e => new { e.ResourceId, e.PermissionName })
                    .HasName("IX_CMS_Permission_ResourceID_PermissionName");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.PermissionDisplayInMatrix).HasDefaultValueSql("0");

                entity.Property(e => e.PermissionDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PermissionGuid).HasColumnName("PermissionGUID");

                entity.Property(e => e.PermissionName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.CmsPermission)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_CMS_Permission_ClassID_CMS_Class");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.CmsPermission)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_CMS_Permission_ResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsPersonalization>(entity =>
            {
                entity.HasKey(e => e.PersonalizationId)
                    .HasName("PK_CMS_Personalization");

                entity.ToTable("CMS_Personalization");

                entity.HasIndex(e => e.PersonalizationDocumentId)
                    .HasName("IX_CMS_Personalization_PersonalizationUserID_PersonalizationDocumentID");

                entity.HasIndex(e => e.PersonalizationSiteId)
                    .HasName("IX_CMS_Personalization_PersonalizationSiteID_SiteID");

                entity.HasIndex(e => e.PersonalizationUserId)
                    .HasName("IX_CMS_Personalization_PersonalizationUserID");

                entity.HasIndex(e => new { e.PersonalizationId, e.PersonalizationUserId, e.PersonalizationDocumentId, e.PersonalizationDashboardName })
                    .HasName("IX_CMS_Personalization_PersonalizationID_PersonalizationUserID_PersonalizationDocumentID_PersonalizationDashboardName")
                    .IsUnique();

                entity.Property(e => e.PersonalizationId)
                    .HasColumnName("PersonalizationID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PersonalizationDashboardName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PersonalizationDocumentId)
                    .IsRequired()
                    .HasColumnName("PersonalizationDocumentID");

                entity.Property(e => e.PersonalizationGuid)
                    .HasColumnName("PersonalizationGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.PersonalizationLastModified).HasDefaultValueSql("'9/2/2008 5:36:59 PM'");

                entity.Property(e => e.PersonalizationSiteId).HasColumnName("PersonalizationSiteID");

                entity.Property(e => e.PersonalizationUserId)
                    .IsRequired()
                    .HasColumnName("PersonalizationUserID");

                entity.HasOne(d => d.PersonalizationDocument)
                    .WithMany(p => p.CmsPersonalization)
                    .HasForeignKey(d => d.PersonalizationDocumentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Personalization_PersonalizationDocumentID_CMS_Document");

                entity.HasOne(d => d.Personalization)
                    .WithOne(p => p.InversePersonalization)
                    .HasForeignKey<CmsPersonalization>(d => d.PersonalizationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Personalization_CMS_Personalization");

                entity.HasOne(d => d.PersonalizationSite)
                    .WithMany(p => p.CmsPersonalization)
                    .HasForeignKey(d => d.PersonalizationSiteId)
                    .HasConstraintName("FK_CMS_Personalization_PersonalizationSiteID_CMS_Site");

                entity.HasOne(d => d.PersonalizationUser)
                    .WithMany(p => p.CmsPersonalization)
                    .HasForeignKey(d => d.PersonalizationUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Personalization_PersonalizationUserID_CMS_User");
            });

            modelBuilder.Entity<CmsQuery>(entity =>
            {
                entity.HasKey(e => e.QueryId)
                    .HasName("PK_CMS_Query");

                entity.ToTable("CMS_Query");

                entity.HasIndex(e => e.QueryLoadGeneration)
                    .HasName("IX_CMS_Query_QueryLoadGeneration");

                entity.HasIndex(e => new { e.ClassId, e.QueryName })
                    .HasName("IX_CMS_Query_QueryClassID_QueryName");

                entity.Property(e => e.QueryId).HasColumnName("QueryID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.QueryConnectionString).HasMaxLength(100);

                entity.Property(e => e.QueryGuid)
                    .HasColumnName("QueryGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.QueryIsCustom).HasDefaultValueSql("0");

                entity.Property(e => e.QueryLoadGeneration).HasDefaultValueSql("0");

                entity.Property(e => e.QueryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.QueryText).IsRequired();

                entity.Property(e => e.QueryTypeId).HasColumnName("QueryTypeID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.CmsQuery)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_CMS_Query_ClassID_CMS_Class");
            });

            modelBuilder.Entity<CmsRelationship>(entity =>
            {
                entity.HasKey(e => e.RelationshipId)
                    .HasName("PK_CMS_Relationship");

                entity.ToTable("CMS_Relationship");

                entity.HasIndex(e => e.LeftNodeId)
                    .HasName("IX_CMS_Relationship_LeftNodeID");

                entity.HasIndex(e => e.RelationshipNameId)
                    .HasName("IX_CMS_Relationship_RelationshipNameID");

                entity.HasIndex(e => e.RightNodeId)
                    .HasName("IX_CMS_Relationship_RightNodeID");

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.LeftNodeId).HasColumnName("LeftNodeID");

                entity.Property(e => e.RelationshipNameId).HasColumnName("RelationshipNameID");

                entity.Property(e => e.RightNodeId).HasColumnName("RightNodeID");

                entity.HasOne(d => d.LeftNode)
                    .WithMany(p => p.CmsRelationshipLeftNode)
                    .HasForeignKey(d => d.LeftNodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Relationship_LeftNodeID_CMS_Tree");

                entity.HasOne(d => d.RelationshipName)
                    .WithMany(p => p.CmsRelationship)
                    .HasForeignKey(d => d.RelationshipNameId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Relationship_RelationshipNameID_CMS_RelationshipName");

                entity.HasOne(d => d.RightNode)
                    .WithMany(p => p.CmsRelationshipRightNode)
                    .HasForeignKey(d => d.RightNodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Relationship_RightNodeID_CMS_Tree");
            });

            modelBuilder.Entity<CmsRelationshipName>(entity =>
            {
                entity.HasKey(e => e.RelationshipNameId)
                    .HasName("PK_CMS_RelationshipName");

                entity.ToTable("CMS_RelationshipName");

                entity.HasIndex(e => e.RelationshipAllowedObjects)
                    .HasName("IX_CMS_RelationshipName_RelationshipAllowedObjects");

                entity.HasIndex(e => new { e.RelationshipName, e.RelationshipDisplayName })
                    .HasName("IX_CMS_RelationshipName_RelationshipName_RelationshipDisplayName");

                entity.Property(e => e.RelationshipNameId).HasColumnName("RelationshipNameID");

                entity.Property(e => e.RelationshipAllowedObjects).HasMaxLength(450);

                entity.Property(e => e.RelationshipDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RelationshipGuid)
                    .HasColumnName("RelationshipGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.RelationshipName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CmsRelationshipNameSite>(entity =>
            {
                entity.HasKey(e => new { e.RelationshipNameId, e.SiteId })
                    .HasName("PK_CMS_RelationshipNameSite");

                entity.ToTable("CMS_RelationshipNameSite");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_CMS_RelationshipNameSite_SiteID");

                entity.Property(e => e.RelationshipNameId).HasColumnName("RelationshipNameID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.RelationshipName)
                    .WithMany(p => p.CmsRelationshipNameSite)
                    .HasForeignKey(d => d.RelationshipNameId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_RelationshipNameSite_RelationshipNameID_CMS_RelationshipName");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsRelationshipNameSite)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_RelationshipNameSite_SiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsResource>(entity =>
            {
                entity.HasKey(e => e.ResourceId)
                    .HasName("PK_CMS_Resource");

                entity.ToTable("CMS_Resource");

                entity.HasIndex(e => e.ResourceDisplayName)
                    .HasName("IX_CMS_Resource_ResourceDisplayName");

                entity.HasIndex(e => e.ResourceName)
                    .HasName("IX_CMS_Resource_ResourceName");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.ResourceAuthor).HasMaxLength(200);

                entity.Property(e => e.ResourceDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ResourceGuid).HasColumnName("ResourceGUID");

                entity.Property(e => e.ResourceHasFiles).HasDefaultValueSql("0");

                entity.Property(e => e.ResourceInstallationState)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ResourceInstalledVersion)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ResourceUrl)
                    .HasColumnName("ResourceURL")
                    .HasMaxLength(1000);

                entity.Property(e => e.ResourceVersion).HasMaxLength(200);

                entity.Property(e => e.ShowInDevelopment).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CmsResourceLibrary>(entity =>
            {
                entity.HasKey(e => e.ResourceLibraryId)
                    .HasName("PK_CMS_ResourceLibrary");

                entity.ToTable("CMS_ResourceLibrary");

                entity.HasIndex(e => e.ResourceLibraryResourceId)
                    .HasName("IX_CMS_ResourceLibrary");

                entity.Property(e => e.ResourceLibraryId).HasColumnName("ResourceLibraryID");

                entity.Property(e => e.ResourceLibraryPath)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ResourceLibraryResourceId)
                    .HasColumnName("ResourceLibraryResourceID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ResourceLibraryResource)
                    .WithMany(p => p.CmsResourceLibrary)
                    .HasForeignKey(d => d.ResourceLibraryResourceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_ResourceLibrary_CMS_Resource");
            });

            modelBuilder.Entity<CmsResourceSite>(entity =>
            {
                entity.HasKey(e => new { e.ResourceId, e.SiteId })
                    .HasName("PK_CMS_ResourceSite");

                entity.ToTable("CMS_ResourceSite");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_CMS_ResourceSite_SiteID");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.CmsResourceSite)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_ResourceSite_ResourceID_CMS_Resource");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsResourceSite)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_ResourceSite_SiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsResourceString>(entity =>
            {
                entity.HasKey(e => e.StringId)
                    .HasName("PK_CMS_ResourceString");

                entity.ToTable("CMS_ResourceString");

                entity.HasIndex(e => e.StringKey)
                    .HasName("IX_CMS_ResourceString_StringKey");

                entity.HasIndex(e => e.StringLoadGeneration)
                    .HasName("IX_CMS_ResourceString_StringLoadGeneration");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.StringGuid).HasColumnName("StringGUID");

                entity.Property(e => e.StringKey)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StringLoadGeneration).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CmsResourceTranslation>(entity =>
            {
                entity.HasKey(e => e.TranslationId)
                    .HasName("PK_CMS_ResourceTranslation");

                entity.ToTable("CMS_ResourceTranslation");

                entity.HasIndex(e => e.TranslationCultureId)
                    .HasName("IX_CMS_ResourceTranslation_TranslationCultureID");

                entity.HasIndex(e => e.TranslationStringId)
                    .HasName("IX_CMS_ResourceTranslation_TranslationStringID");

                entity.Property(e => e.TranslationId).HasColumnName("TranslationID");

                entity.Property(e => e.TranslationCultureId).HasColumnName("TranslationCultureID");

                entity.Property(e => e.TranslationStringId).HasColumnName("TranslationStringID");

                entity.HasOne(d => d.TranslationCulture)
                    .WithMany(p => p.CmsResourceTranslation)
                    .HasForeignKey(d => d.TranslationCultureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_ResourceTranslation_TranslationCultureID_CMS_Culture");

                entity.HasOne(d => d.TranslationString)
                    .WithMany(p => p.CmsResourceTranslation)
                    .HasForeignKey(d => d.TranslationStringId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_ResourceTranslation_TranslationStringID_CMS_ResourceString");
            });

            modelBuilder.Entity<CmsRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_CMS_Role");

                entity.ToTable("CMS_Role");

                entity.HasIndex(e => e.RoleGroupId)
                    .HasName("IX_CMS_Role_RoleGroupID");

                entity.HasIndex(e => new { e.SiteId, e.RoleId })
                    .HasName("IX_CMS_Role_SiteID_RoleID");

                entity.HasIndex(e => new { e.SiteId, e.RoleName, e.RoleDisplayName })
                    .HasName("IX_CMS_Role_SiteID_RoleName_RoleDisplayName");

                entity.HasIndex(e => new { e.SiteId, e.RoleName, e.RoleGroupId })
                    .HasName("IX_CMS_Role_SiteID_RoleName_RoleGroupID")
                    .IsUnique();

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RoleGroupId)
                    .IsRequired()
                    .HasColumnName("RoleGroupID");

                entity.Property(e => e.RoleGuid).HasColumnName("RoleGUID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SiteId)
                    .IsRequired()
                    .HasColumnName("SiteID");

                entity.HasOne(d => d.RoleGroup)
                    .WithMany(p => p.CmsRole)
                    .HasForeignKey(d => d.RoleGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Role_RoleGroupID_Community_Group");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsRole)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Role_SiteID_CMS_SiteID");
            });

            modelBuilder.Entity<CmsRoleApplication>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.ElementId })
                    .HasName("PK_CMS_RoleApplication");

                entity.ToTable("CMS_RoleApplication");

                entity.HasIndex(e => e.ElementId)
                    .HasName("IX_CMS_RoleApplication");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.HasOne(d => d.Element)
                    .WithMany(p => p.CmsRoleApplication)
                    .HasForeignKey(d => d.ElementId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_RoleApplication_CMS_UIElement");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CmsRoleApplication)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_RoleApplication_CMS_Role");
            });

            modelBuilder.Entity<CmsRolePermission>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.PermissionId })
                    .HasName("PK_CMS_RolePermission");

                entity.ToTable("CMS_RolePermission");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("IX_CMS_RolePermission_PermissionID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.CmsRolePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_RolePermission_PermissionID_CMS_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CmsRolePermission)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_RolePermission_RoleID_CMS_Role");
            });

            modelBuilder.Entity<CmsRoleUielement>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.ElementId })
                    .HasName("PK_CMS_RoleUIElement");

                entity.ToTable("CMS_RoleUIElement");

                entity.HasIndex(e => e.ElementId)
                    .HasName("IX_CMS_RoleUIElement_ElementID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.HasOne(d => d.Element)
                    .WithMany(p => p.CmsRoleUielement)
                    .HasForeignKey(d => d.ElementId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_RoleUIElement_ElementID_CMS_UIElement");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CmsRoleUielement)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_RoleUIElement_RoleID_CMS_Role");
            });

            modelBuilder.Entity<CmsScheduledTask>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PK_CMS_ScheduledTask");

                entity.ToTable("CMS_ScheduledTask");

                entity.HasIndex(e => e.TaskResourceId)
                    .HasName("IX_CMS_ScheduledTask_TaskResourceID");

                entity.HasIndex(e => e.TaskUserId)
                    .HasName("IX_CMS_ScheduledTask_TaskUserID");

                entity.HasIndex(e => new { e.TaskSiteId, e.TaskDisplayName })
                    .HasName("IX_CMS_ScheduledTask_TaskSiteID_TaskDisplayName");

                entity.HasIndex(e => new { e.TaskNextRunTime, e.TaskEnabled, e.TaskServerName })
                    .HasName("IX_CMS_ScheduledTask_TaskNextRunTime_TaskEnabled_TaskServerName");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskAllowExternalService).HasDefaultValueSql("0");

                entity.Property(e => e.TaskAssemblyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TaskClass).HasMaxLength(200);

                entity.Property(e => e.TaskCondition).HasMaxLength(400);

                entity.Property(e => e.TaskData).IsRequired();

                entity.Property(e => e.TaskDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TaskEnabled).HasDefaultValueSql("0");

                entity.Property(e => e.TaskExecutingServerName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.TaskGuid).HasColumnName("TaskGUID");

                entity.Property(e => e.TaskInterval)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TaskIsRunning).HasDefaultValueSql("0");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TaskObjectId).HasColumnName("TaskObjectID");

                entity.Property(e => e.TaskObjectType).HasMaxLength(100);

                entity.Property(e => e.TaskResourceId).HasColumnName("TaskResourceID");

                entity.Property(e => e.TaskServerName).HasMaxLength(100);

                entity.Property(e => e.TaskSiteId).HasColumnName("TaskSiteID");

                entity.Property(e => e.TaskUserId).HasColumnName("TaskUserID");

                entity.HasOne(d => d.TaskResource)
                    .WithMany(p => p.CmsScheduledTask)
                    .HasForeignKey(d => d.TaskResourceId)
                    .HasConstraintName("FK_CMS_ScheduledTask_TaskResourceID_CMS_Resource");

                entity.HasOne(d => d.TaskSite)
                    .WithMany(p => p.CmsScheduledTask)
                    .HasForeignKey(d => d.TaskSiteId)
                    .HasConstraintName("FK_CMS_ScheduledTask_TaskSiteID_CMS_Site");

                entity.HasOne(d => d.TaskUser)
                    .WithMany(p => p.CmsScheduledTask)
                    .HasForeignKey(d => d.TaskUserId)
                    .HasConstraintName("FK_CMS_ScheduledTask_TaskUserID_CMS_User");
            });

            modelBuilder.Entity<CmsSearchEngine>(entity =>
            {
                entity.HasKey(e => e.SearchEngineId)
                    .HasName("PK_CMS_SearchEngine");

                entity.ToTable("CMS_SearchEngine");

                entity.Property(e => e.SearchEngineId).HasColumnName("SearchEngineID");

                entity.Property(e => e.SearchEngineCrawler).HasMaxLength(200);

                entity.Property(e => e.SearchEngineDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SearchEngineDomainRule)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.SearchEngineGuid).HasColumnName("SearchEngineGUID");

                entity.Property(e => e.SearchEngineKeywordParameter).HasMaxLength(200);

                entity.Property(e => e.SearchEngineName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CmsSearchIndex>(entity =>
            {
                entity.HasKey(e => e.IndexId)
                    .HasName("PK_CMS_SearchIndex");

                entity.ToTable("CMS_SearchIndex");

                entity.HasIndex(e => e.IndexDisplayName)
                    .HasName("IX_CMS_SearchIndex_IndexDisplayName");

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.IndexAnalyzerType).HasMaxLength(200);

                entity.Property(e => e.IndexCrawlerDomain).HasMaxLength(200);

                entity.Property(e => e.IndexCrawlerFormsUserName).HasMaxLength(200);

                entity.Property(e => e.IndexCrawlerUserName).HasMaxLength(200);

                entity.Property(e => e.IndexCrawlerUserPassword).HasMaxLength(200);

                entity.Property(e => e.IndexCustomAnalyzerAssemblyName).HasMaxLength(200);

                entity.Property(e => e.IndexCustomAnalyzerClassName).HasMaxLength(200);

                entity.Property(e => e.IndexDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IndexGuid).HasColumnName("IndexGUID");

                entity.Property(e => e.IndexIsCommunityGroup).HasDefaultValueSql("0");

                entity.Property(e => e.IndexName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IndexStatus).HasMaxLength(10);

                entity.Property(e => e.IndexStopWordsFile).HasMaxLength(200);

                entity.Property(e => e.IndexType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CmsSearchIndexCulture>(entity =>
            {
                entity.HasKey(e => new { e.IndexId, e.IndexCultureId })
                    .HasName("PK_CMS_SearchIndexCulture");

                entity.ToTable("CMS_SearchIndexCulture");

                entity.HasIndex(e => e.IndexCultureId)
                    .HasName("IX_CMS_SearchIndexCulture_IndexCultureID");

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.IndexCultureId).HasColumnName("IndexCultureID");

                entity.HasOne(d => d.IndexCulture)
                    .WithMany(p => p.CmsSearchIndexCulture)
                    .HasForeignKey(d => d.IndexCultureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_SearchIndexCulture_IndexCultureID_CMS_Culture");

                entity.HasOne(d => d.Index)
                    .WithMany(p => p.CmsSearchIndexCulture)
                    .HasForeignKey(d => d.IndexId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_SearchIndexCulture_IndexID_CMS_SearchIndex");
            });

            modelBuilder.Entity<CmsSearchIndexSite>(entity =>
            {
                entity.HasKey(e => new { e.IndexId, e.IndexSiteId })
                    .HasName("PK_CMS_SearchIndexSite");

                entity.ToTable("CMS_SearchIndexSite");

                entity.HasIndex(e => e.IndexSiteId)
                    .HasName("IX_CMS_SearchIndexSite_IndexSiteID");

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.IndexSiteId).HasColumnName("IndexSiteID");

                entity.HasOne(d => d.Index)
                    .WithMany(p => p.CmsSearchIndexSite)
                    .HasForeignKey(d => d.IndexId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_SearchIndexSite_IndexID_CMS_SearchIndex");

                entity.HasOne(d => d.IndexSite)
                    .WithMany(p => p.CmsSearchIndexSite)
                    .HasForeignKey(d => d.IndexSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_SearchIndexSite_IndexSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsSearchTask>(entity =>
            {
                entity.HasKey(e => e.SearchTaskId)
                    .HasName("PK_CMS_SearchTask");

                entity.ToTable("CMS_SearchTask");

                entity.HasIndex(e => new { e.SearchTaskPriority, e.SearchTaskStatus, e.SearchTaskServerName })
                    .HasName("IX_CMS_SearchTask_SearchTaskPriority_SearchTaskStatus_SearchTaskServerName");

                entity.Property(e => e.SearchTaskId).HasColumnName("SearchTaskID");

                entity.Property(e => e.SearchTaskCreated).HasDefaultValueSql("'4/15/2009 11:23:52 AM'");

                entity.Property(e => e.SearchTaskField).HasMaxLength(200);

                entity.Property(e => e.SearchTaskObjectType).HasMaxLength(100);

                entity.Property(e => e.SearchTaskPriority).HasDefaultValueSql("0");

                entity.Property(e => e.SearchTaskRelatedObjectId).HasColumnName("SearchTaskRelatedObjectID");

                entity.Property(e => e.SearchTaskServerName).HasMaxLength(200);

                entity.Property(e => e.SearchTaskStatus)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SearchTaskType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SearchTaskValue)
                    .IsRequired()
                    .HasMaxLength(600)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CmsSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK_CMS_Session");

                entity.ToTable("CMS_Session");

                entity.HasIndex(e => e.SessionIdentificator)
                    .HasName("IX_CMS_Session_SessionIdentificator")
                    .IsUnique();

                entity.HasIndex(e => e.SessionSiteId)
                    .HasName("IX_CMS_Session_SessionSiteID");

                entity.HasIndex(e => e.SessionUserId)
                    .HasName("IX_CMS_Session_SessionUserID");

                entity.HasIndex(e => e.SessionUserIsHidden)
                    .HasName("IX_CMS_Session_SessionUserIsHidden");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SessionContactId).HasColumnName("SessionContactID");

                entity.Property(e => e.SessionEmail).HasMaxLength(254);

                entity.Property(e => e.SessionExpired).HasDefaultValueSql("0");

                entity.Property(e => e.SessionExpires).HasDefaultValueSql("'9/9/2008 3:45:44 PM'");

                entity.Property(e => e.SessionFullName).HasMaxLength(450);

                entity.Property(e => e.SessionIdentificator)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.SessionLastActive).HasDefaultValueSql("'9/9/2008 3:44:26 PM'");

                entity.Property(e => e.SessionLocation).HasMaxLength(450);

                entity.Property(e => e.SessionNickName).HasMaxLength(254);

                entity.Property(e => e.SessionSiteId).HasColumnName("SessionSiteID");

                entity.Property(e => e.SessionUserId).HasColumnName("SessionUserID");

                entity.Property(e => e.SessionUserName).HasMaxLength(254);

                entity.HasOne(d => d.SessionSite)
                    .WithMany(p => p.CmsSession)
                    .HasForeignKey(d => d.SessionSiteId)
                    .HasConstraintName("FK_CMS_Session_SessionSiteID_CMS_Site");

                entity.HasOne(d => d.SessionUser)
                    .WithMany(p => p.CmsSession)
                    .HasForeignKey(d => d.SessionUserId)
                    .HasConstraintName("FK_CMS_Session_SessionUserID_CMS_User");
            });

            modelBuilder.Entity<CmsSettingsCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_CMS_SettingsCategory");

                entity.ToTable("CMS_SettingsCategory");

                entity.HasIndex(e => e.CategoryOrder)
                    .HasName("IX_CMS_SettingsCategory_CategoryOrder");

                entity.HasIndex(e => e.CategoryParentId)
                    .HasName("IX_CMS_SettingsCategory_CategoryParentID");

                entity.HasIndex(e => e.CategoryResourceId)
                    .HasName("IX_CMS_SettingsCategory_CategoryResourceID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CategoryIconPath).HasMaxLength(200);

                entity.Property(e => e.CategoryIdpath)
                    .HasColumnName("CategoryIDPath")
                    .HasMaxLength(450);

                entity.Property(e => e.CategoryIsCustom).HasDefaultValueSql("0");

                entity.Property(e => e.CategoryIsGroup).HasDefaultValueSql("0");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentID");

                entity.Property(e => e.CategoryResourceId).HasColumnName("CategoryResourceID");

                entity.HasOne(d => d.CategoryParent)
                    .WithMany(p => p.InverseCategoryParent)
                    .HasForeignKey(d => d.CategoryParentId)
                    .HasConstraintName("FK_CMS_SettingsCategory_CMS_SettingsCategory1");

                entity.HasOne(d => d.CategoryResource)
                    .WithMany(p => p.CmsSettingsCategory)
                    .HasForeignKey(d => d.CategoryResourceId)
                    .HasConstraintName("FK_CMS_SettingsCategory_CategoryResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsSettingsKey>(entity =>
            {
                entity.HasKey(e => e.KeyId)
                    .HasName("PK_CMS_SettingsKey");

                entity.ToTable("CMS_SettingsKey");

                entity.HasIndex(e => e.KeyCategoryId)
                    .HasName("IX_CMS_SettingsKey_KeyCategoryID");

                entity.HasIndex(e => new { e.KeyLoadGeneration, e.SiteId })
                    .HasName("IX_CMS_SettingsKey_KeyLoadGeneration_SiteID");

                entity.HasIndex(e => new { e.KeyValue, e.SiteId, e.KeyName })
                    .HasName("IX_CMS_SettingsKey_SiteID_KeyName");

                entity.Property(e => e.KeyId).HasColumnName("KeyID");

                entity.Property(e => e.KeyCategoryId).HasColumnName("KeyCategoryID");

                entity.Property(e => e.KeyDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.KeyEditingControlPath).HasMaxLength(200);

                entity.Property(e => e.KeyExplanationText).HasDefaultValueSql("N''");

                entity.Property(e => e.KeyGuid)
                    .HasColumnName("KeyGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.KeyIsCustom).HasDefaultValueSql("0");

                entity.Property(e => e.KeyIsGlobal).HasDefaultValueSql("0");

                entity.Property(e => e.KeyIsHidden).HasDefaultValueSql("0");

                entity.Property(e => e.KeyLoadGeneration).HasDefaultValueSql("0");

                entity.Property(e => e.KeyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.KeyType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.KeyValidation).HasMaxLength(255);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.KeyCategory)
                    .WithMany(p => p.CmsSettingsKey)
                    .HasForeignKey(d => d.KeyCategoryId)
                    .HasConstraintName("FK_CMS_SettingsKey_KeyCategoryID_CMS_SettingsCategory");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsSettingsKey)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_CMS_SettingsKey_SiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsSite>(entity =>
            {
                entity.HasKey(e => e.SiteId)
                    .HasName("PK_CMS_Site");

                entity.ToTable("CMS_Site");

                entity.HasIndex(e => e.SiteDefaultEditorStylesheet)
                    .HasName("IX_CMS_Site_SiteDefaultEditorStylesheet");

                entity.HasIndex(e => e.SiteDefaultStylesheetId)
                    .HasName("IX_CMS_Site_SiteDefaultStylesheetID");

                entity.HasIndex(e => e.SiteDisplayName)
                    .HasName("IX_CMS_Site_SiteDisplayName");

                entity.HasIndex(e => e.SiteName)
                    .HasName("IX_CMS_Site_SiteName");

                entity.HasIndex(e => new { e.SiteDomainName, e.SiteStatus })
                    .HasName("IX_CMS_Site_SiteDomainName_SiteStatus");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SiteDefaultStylesheetId).HasColumnName("SiteDefaultStylesheetID");

                entity.Property(e => e.SiteDefaultVisitorCulture).HasMaxLength(50);

                entity.Property(e => e.SiteDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SiteDomainName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SiteGuid).HasColumnName("SiteGUID");

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SiteOfflineRedirectUrl)
                    .HasColumnName("SiteOfflineRedirectURL")
                    .HasMaxLength(400);

                entity.Property(e => e.SitePresentationUrl)
                    .HasColumnName("SitePresentationURL")
                    .HasMaxLength(400);

                entity.Property(e => e.SiteStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.SiteDefaultEditorStylesheetNavigation)
                    .WithMany(p => p.CmsSiteSiteDefaultEditorStylesheetNavigation)
                    .HasForeignKey(d => d.SiteDefaultEditorStylesheet)
                    .HasConstraintName("FK_CMS_Site_SiteDefaultEditorStylesheet_CMS_CssStylesheet");

                entity.HasOne(d => d.SiteDefaultStylesheet)
                    .WithMany(p => p.CmsSiteSiteDefaultStylesheet)
                    .HasForeignKey(d => d.SiteDefaultStylesheetId)
                    .HasConstraintName("FK_CMS_Site_SiteDefaultStylesheetID_CMS_CssStylesheet");
            });

            modelBuilder.Entity<CmsSiteCulture>(entity =>
            {
                entity.HasKey(e => new { e.SiteId, e.CultureId })
                    .HasName("PK_CMS_SiteCulture");

                entity.ToTable("CMS_SiteCulture");

                entity.HasIndex(e => e.CultureId)
                    .HasName("IX_CMS_SiteCulture_CultureID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.CultureId).HasColumnName("CultureID");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.CmsSiteCulture)
                    .HasForeignKey(d => d.CultureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_SiteCulture_CultureID_CMS_Culture");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsSiteCulture)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_SiteCulture_SiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsSiteDomainAlias>(entity =>
            {
                entity.HasKey(e => e.SiteDomainAliasId)
                    .HasName("PK_CMS_SiteDomainAlias");

                entity.ToTable("CMS_SiteDomainAlias");

                entity.HasIndex(e => e.SiteDomainAliasName)
                    .HasName("IX_CMS_SiteDomainAlias_SiteDomainAliasName");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_CMS_SiteDomainAlias_SiteID");

                entity.Property(e => e.SiteDomainAliasId).HasColumnName("SiteDomainAliasID");

                entity.Property(e => e.SiteDefaultVisitorCulture).HasMaxLength(50);

                entity.Property(e => e.SiteDomainAliasName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SiteDomainDefaultAliasPath).HasMaxLength(450);

                entity.Property(e => e.SiteDomainGuid).HasColumnName("SiteDomainGUID");

                entity.Property(e => e.SiteDomainRedirectUrl).HasMaxLength(450);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsSiteDomainAlias)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_SiteDomainAlias_SiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsSmtpserver>(entity =>
            {
                entity.HasKey(e => e.ServerId)
                    .HasName("PK_CMS_SMTPServer");

                entity.ToTable("CMS_SMTPServer");

                entity.Property(e => e.ServerId).HasColumnName("ServerID");

                entity.Property(e => e.ServerDeliveryMethod).HasDefaultValueSql("0");

                entity.Property(e => e.ServerGuid).HasColumnName("ServerGUID");

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ServerPassword).HasMaxLength(200);

                entity.Property(e => e.ServerPickupDirectory).HasMaxLength(450);

                entity.Property(e => e.ServerUseSsl).HasColumnName("ServerUseSSL");

                entity.Property(e => e.ServerUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<CmsSmtpserverSite>(entity =>
            {
                entity.HasKey(e => new { e.ServerId, e.SiteId })
                    .HasName("PK_CMS_SMTPServerSite");

                entity.ToTable("CMS_SMTPServerSite");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_CMS_SMTPServerSite_SiteID");

                entity.Property(e => e.ServerId).HasColumnName("ServerID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Server)
                    .WithMany(p => p.CmsSmtpserverSite)
                    .HasForeignKey(d => d.ServerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_SMTPServerSite_CMS_SMTPServer");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsSmtpserverSite)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_SMTPServerSite_CMS_Site");
            });

            modelBuilder.Entity<CmsState>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK_CMS_State");

                entity.ToTable("CMS_State");

                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_CMS_State_CountryID");

                entity.HasIndex(e => e.StateCode)
                    .HasName("IX_CMS_State_StateCode");

                entity.HasIndex(e => e.StateDisplayName)
                    .HasName("IX_CMS_State_CountryID_StateDisplayName");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.StateCode).HasMaxLength(100);

                entity.Property(e => e.StateDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StateGuid)
                    .HasColumnName("StateGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CmsState)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_State_CountryID_CMS_Country");
            });

            modelBuilder.Entity<CmsTag>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PK_CMS_Tag");

                entity.ToTable("CMS_Tag");

                entity.HasIndex(e => e.TagGroupId)
                    .HasName("IX_CMS_Tag_TagGroupID");

                entity.HasIndex(e => e.TagName)
                    .HasName("IX_CMS_Tag_TagName");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.TagGroupId).HasColumnName("TagGroupID");

                entity.Property(e => e.TagGuid)
                    .HasColumnName("TagGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.TagGroup)
                    .WithMany(p => p.CmsTag)
                    .HasForeignKey(d => d.TagGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Tag_TagGroupID_CMS_TagGroup");
            });

            modelBuilder.Entity<CmsTagGroup>(entity =>
            {
                entity.HasKey(e => e.TagGroupId)
                    .HasName("PK_CMS_TagGroup");

                entity.ToTable("CMS_TagGroup");

                entity.HasIndex(e => e.TagGroupDisplayName)
                    .HasName("IX_CMS_TagGroup_TagGroupDisplayName");

                entity.HasIndex(e => e.TagGroupSiteId)
                    .HasName("IX_CMS_TagGroup_TagGroupSiteID");

                entity.Property(e => e.TagGroupId).HasColumnName("TagGroupID");

                entity.Property(e => e.TagGroupDisplayName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TagGroupGuid).HasColumnName("TagGroupGUID");

                entity.Property(e => e.TagGroupIsAdHoc).HasDefaultValueSql("0");

                entity.Property(e => e.TagGroupName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TagGroupSiteId).HasColumnName("TagGroupSiteID");

                entity.HasOne(d => d.TagGroupSite)
                    .WithMany(p => p.CmsTagGroup)
                    .HasForeignKey(d => d.TagGroupSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_TagGroup_TagGroupSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsTemplateDeviceLayout>(entity =>
            {
                entity.HasKey(e => e.TemplateDeviceLayoutId)
                    .HasName("PK_CMS_TemplateDeviceLayout");

                entity.ToTable("CMS_TemplateDeviceLayout");

                entity.HasIndex(e => e.LayoutId)
                    .HasName("IX_CMS_TemplateDeviceLayout_LayoutID");

                entity.HasIndex(e => e.ProfileId)
                    .HasName("IX_CMS_TemplateDeviceLayout_ProfileID");

                entity.HasIndex(e => new { e.PageTemplateId, e.ProfileId })
                    .HasName("IX_CMS_TemplateDeviceLayout_PageTemplateID_ProfileID")
                    .IsUnique();

                entity.Property(e => e.TemplateDeviceLayoutId).HasColumnName("TemplateDeviceLayoutID");

                entity.Property(e => e.LayoutCss).HasColumnName("LayoutCSS");

                entity.Property(e => e.LayoutGuid)
                    .HasColumnName("LayoutGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.LayoutId).HasColumnName("LayoutID");

                entity.Property(e => e.LayoutLastModified).HasDefaultValueSql("'7/31/2012 12:10:49 PM'");

                entity.Property(e => e.LayoutType).HasMaxLength(50);

                entity.Property(e => e.LayoutVersionGuid)
                    .HasColumnName("LayoutVersionGUID")
                    .HasMaxLength(50);

                entity.Property(e => e.PageTemplateId).HasColumnName("PageTemplateID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.CmsTemplateDeviceLayout)
                    .HasForeignKey(d => d.LayoutId)
                    .HasConstraintName("FK_CMS_TemplateDeviceLayout_LayoutID_CMS_Layout");

                entity.HasOne(d => d.PageTemplate)
                    .WithMany(p => p.CmsTemplateDeviceLayout)
                    .HasForeignKey(d => d.PageTemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_TemplateDeviceLayout_PageTemplateID_CMS_PageTemplate");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.CmsTemplateDeviceLayout)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_TemplateDeviceLayout_ProfileID_CMS_DeviceProfile");
            });

            modelBuilder.Entity<CmsTimeZone>(entity =>
            {
                entity.HasKey(e => e.TimeZoneId)
                    .HasName("PK_CMS_TimeZone");

                entity.ToTable("CMS_TimeZone");

                entity.HasIndex(e => e.TimeZoneDisplayName)
                    .HasName("IX_CMS_TimeZone_TimeZoneDisplayName");

                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

                entity.Property(e => e.TimeZoneDaylight).HasDefaultValueSql("0");

                entity.Property(e => e.TimeZoneDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TimeZoneGmt)
                    .HasColumnName("TimeZoneGMT")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TimeZoneGuid).HasColumnName("TimeZoneGUID");

                entity.Property(e => e.TimeZoneName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TimeZoneRuleEndRule)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TimeZoneRuleStartRule)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CmsTransformation>(entity =>
            {
                entity.HasKey(e => e.TransformationId)
                    .HasName("PK_CMS_Transformation");

                entity.ToTable("CMS_Transformation");

                entity.HasIndex(e => e.TransformationClassId)
                    .HasName("IX_CMS_Transformation_TransformationClassID");

                entity.HasIndex(e => new { e.TransformationClassId, e.TransformationName })
                    .HasName("IX_CMS_Transformation_TransformationClassID_TransformationName");

                entity.Property(e => e.TransformationId).HasColumnName("TransformationID");

                entity.Property(e => e.TransformationClassId).HasColumnName("TransformationClassID");

                entity.Property(e => e.TransformationCode)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.TransformationCss).HasColumnName("TransformationCSS");

                entity.Property(e => e.TransformationGuid).HasColumnName("TransformationGUID");

                entity.Property(e => e.TransformationHierarchicalXml).HasColumnName("TransformationHierarchicalXML");

                entity.Property(e => e.TransformationIsHierarchical).HasDefaultValueSql("0");

                entity.Property(e => e.TransformationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.TransformationPreferredDocument).HasMaxLength(700);

                entity.Property(e => e.TransformationType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.TransformationVersionGuid)
                    .HasColumnName("TransformationVersionGUID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.TransformationClass)
                    .WithMany(p => p.CmsTransformation)
                    .HasForeignKey(d => d.TransformationClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Transformation_TransformationClassID_CMS_Class");
            });

            modelBuilder.Entity<CmsTranslationService>(entity =>
            {
                entity.HasKey(e => e.TranslationServiceId)
                    .HasName("PK_CMS_TranslationService");

                entity.ToTable("CMS_TranslationService");

                entity.Property(e => e.TranslationServiceId).HasColumnName("TranslationServiceID");

                entity.Property(e => e.TranslationServiceAssemblyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TranslationServiceClassName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TranslationServiceDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TranslationServiceGenerateTargetTag).HasDefaultValueSql("0");

                entity.Property(e => e.TranslationServiceGuid).HasColumnName("TranslationServiceGUID");

                entity.Property(e => e.TranslationServiceName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TranslationServiceParameter).HasMaxLength(1000);

                entity.Property(e => e.TranslationServiceSupportsCancel).HasDefaultValueSql("0");

                entity.Property(e => e.TranslationServiceSupportsStatusUpdate).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CmsTranslationSubmission>(entity =>
            {
                entity.HasKey(e => e.SubmissionId)
                    .HasName("PK_CMS_TranslationSubmission");

                entity.ToTable("CMS_TranslationSubmission");

                entity.HasIndex(e => e.SubmissionServiceId)
                    .HasName("IX_CMS_TranslationSubmission_SubmissionServiceID");

                entity.HasIndex(e => e.SubmissionSubmittedByUserId)
                    .HasName("IX_CMS_TranslationSubmission_SubmissionSubmittedByUserID");

                entity.Property(e => e.SubmissionId).HasColumnName("SubmissionID");

                entity.Property(e => e.SubmissionGuid).HasColumnName("SubmissionGUID");

                entity.Property(e => e.SubmissionInstructions).HasMaxLength(500);

                entity.Property(e => e.SubmissionName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SubmissionServiceId).HasColumnName("SubmissionServiceID");

                entity.Property(e => e.SubmissionSiteId).HasColumnName("SubmissionSiteID");

                entity.Property(e => e.SubmissionSourceCulture)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SubmissionSubmittedByUserId).HasColumnName("SubmissionSubmittedByUserID");

                entity.Property(e => e.SubmissionTargetCulture)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.SubmissionTicket).HasMaxLength(200);

                entity.HasOne(d => d.SubmissionService)
                    .WithMany(p => p.CmsTranslationSubmission)
                    .HasForeignKey(d => d.SubmissionServiceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_TranslationSubmission_CMS_TranslationService");

                entity.HasOne(d => d.SubmissionSubmittedByUser)
                    .WithMany(p => p.CmsTranslationSubmission)
                    .HasForeignKey(d => d.SubmissionSubmittedByUserId)
                    .HasConstraintName("FK_CMS_TranslationSubmission_CMS_User");
            });

            modelBuilder.Entity<CmsTranslationSubmissionItem>(entity =>
            {
                entity.HasKey(e => e.SubmissionItemId)
                    .HasName("PK_CMS_TranslationSubmissionItem");

                entity.ToTable("CMS_TranslationSubmissionItem");

                entity.HasIndex(e => e.SubmissionItemSubmissionId)
                    .HasName("IX_CMS_TranslationSubmissionItem_SubmissionItemSubmissionID");

                entity.Property(e => e.SubmissionItemId).HasColumnName("SubmissionItemID");

                entity.Property(e => e.SubmissionItemGuid).HasColumnName("SubmissionItemGUID");

                entity.Property(e => e.SubmissionItemName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SubmissionItemObjectId).HasColumnName("SubmissionItemObjectID");

                entity.Property(e => e.SubmissionItemObjectType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SubmissionItemSourceXliff).HasColumnName("SubmissionItemSourceXLIFF");

                entity.Property(e => e.SubmissionItemSubmissionId).HasColumnName("SubmissionItemSubmissionID");

                entity.Property(e => e.SubmissionItemTargetCulture).HasMaxLength(10);

                entity.Property(e => e.SubmissionItemTargetObjectId).HasColumnName("SubmissionItemTargetObjectID");

                entity.Property(e => e.SubmissionItemTargetXliff).HasColumnName("SubmissionItemTargetXLIFF");

                entity.Property(e => e.SubmissionItemType).HasMaxLength(50);

                entity.HasOne(d => d.SubmissionItemSubmission)
                    .WithMany(p => p.CmsTranslationSubmissionItem)
                    .HasForeignKey(d => d.SubmissionItemSubmissionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_TranslationSubmissionItem_CMS_TranslationSubmission");
            });

            modelBuilder.Entity<CmsTree>(entity =>
            {
                entity.HasKey(e => e.NodeId)
                    .HasName("PK_CMS_Tree");

                entity.ToTable("CMS_Tree");

                entity.HasIndex(e => e.NodeAclid)
                    .HasName("IX_CMS_Tree_NodeACLID");

                entity.HasIndex(e => e.NodeAliasPath)
                    .HasName("IX_CMS_Tree_NodeAliasPath");

                entity.HasIndex(e => e.NodeClassId)
                    .HasName("IX_CMS_Tree_NodeClassID");

                entity.HasIndex(e => e.NodeGroupId)
                    .HasName("IX_CMS_Tree_NodeGroupID");

                entity.HasIndex(e => e.NodeLevel)
                    .HasName("IX_CMS_Tree_NodeLevel");

                entity.HasIndex(e => e.NodeLinkedNodeSiteId)
                    .HasName("IX_CMS_Tree_NodeLinkedNodeSiteID");

                entity.HasIndex(e => e.NodeOriginalNodeId)
                    .HasName("IX_CMS_Tree_NodeOriginalNodeID");

                entity.HasIndex(e => e.NodeOwner)
                    .HasName("IX_CMS_Tree_NodeOwner");

                entity.HasIndex(e => e.NodeSkuid)
                    .HasName("IX_CMS_Tree_NodeSKUID");

                entity.HasIndex(e => e.NodeTemplateId)
                    .HasName("IX_CMS_Tree_NodeTemplateID");

                entity.HasIndex(e => new { e.NodeId, e.NodeClassId, e.NodeLinkedNodeId })
                    .HasName("IX_CMS_Tree_NodeLinkedNodeID");

                entity.HasIndex(e => new { e.NodeId, e.NodeSiteId, e.NodeGuid })
                    .HasName("IX_CMS_Tree_NodeSiteID_NodeGUID")
                    .IsUnique();

                entity.HasIndex(e => new { e.NodeParentId, e.NodeAlias, e.NodeName })
                    .HasName("IX_CMS_Tree_NodeParentID_NodeAlias_NodeName");

                entity.Property(e => e.NodeId).HasColumnName("NodeID");

                entity.Property(e => e.NodeAclid).HasColumnName("NodeACLID");

                entity.Property(e => e.NodeAlias)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NodeAliasPath)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.NodeAllowCacheInFileSystem).HasDefaultValueSql("0");

                entity.Property(e => e.NodeClassId).HasColumnName("NodeClassID");

                entity.Property(e => e.NodeGroupId).HasColumnName("NodeGroupID");

                entity.Property(e => e.NodeGuid).HasColumnName("NodeGUID");

                entity.Property(e => e.NodeHasChildren).HasDefaultValueSql("0");

                entity.Property(e => e.NodeHasLinks).HasDefaultValueSql("0");

                entity.Property(e => e.NodeInheritPageLevels).HasMaxLength(200);

                entity.Property(e => e.NodeInheritPageTemplate).HasDefaultValueSql("0");

                entity.Property(e => e.NodeIsAclowner)
                    .HasColumnName("NodeIsACLOwner")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NodeIsContentOnly).HasDefaultValueSql("0");

                entity.Property(e => e.NodeLinkedNodeId).HasColumnName("NodeLinkedNodeID");

                entity.Property(e => e.NodeLinkedNodeSiteId).HasColumnName("NodeLinkedNodeSiteID");

                entity.Property(e => e.NodeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NodeOriginalNodeId).HasColumnName("NodeOriginalNodeID");

                entity.Property(e => e.NodeParentId).HasColumnName("NodeParentID");

                entity.Property(e => e.NodeSiteId).HasColumnName("NodeSiteID");

                entity.Property(e => e.NodeSkuid).HasColumnName("NodeSKUID");

                entity.Property(e => e.NodeTemplateForAllCultures).HasDefaultValueSql("0");

                entity.Property(e => e.NodeTemplateId).HasColumnName("NodeTemplateID");

                entity.Property(e => e.RequiresSsl).HasColumnName("RequiresSSL");

                entity.HasOne(d => d.NodeAcl)
                    .WithMany(p => p.CmsTree)
                    .HasForeignKey(d => d.NodeAclid)
                    .HasConstraintName("FK_CMS_Tree_NodeACLID_CMS_ACL");

                entity.HasOne(d => d.NodeClass)
                    .WithMany(p => p.CmsTree)
                    .HasForeignKey(d => d.NodeClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Tree_NodeClassID_CMS_Class");

                entity.HasOne(d => d.NodeGroup)
                    .WithMany(p => p.CmsTree)
                    .HasForeignKey(d => d.NodeGroupId)
                    .HasConstraintName("FK_CMS_Tree_NodeGroupID_Community_Group");

                entity.HasOne(d => d.NodeLinkedNode)
                    .WithMany(p => p.InverseNodeLinkedNode)
                    .HasForeignKey(d => d.NodeLinkedNodeId)
                    .HasConstraintName("FK_CMS_Tree_NodeLinkedNodeID_CMS_Tree");

                entity.HasOne(d => d.NodeLinkedNodeSite)
                    .WithMany(p => p.CmsTreeNodeLinkedNodeSite)
                    .HasForeignKey(d => d.NodeLinkedNodeSiteId)
                    .HasConstraintName("FK_CMS_Tree_NodeLinkedNodeSiteID_CMS_Site");

                entity.HasOne(d => d.NodeOriginalNode)
                    .WithMany(p => p.InverseNodeOriginalNode)
                    .HasForeignKey(d => d.NodeOriginalNodeId)
                    .HasConstraintName("FK_CMS_Tree_NodeOriginalNodeID_CMS_Tree");

                entity.HasOne(d => d.NodeOwnerNavigation)
                    .WithMany(p => p.CmsTree)
                    .HasForeignKey(d => d.NodeOwner)
                    .HasConstraintName("FK_CMS_Tree_NodeOwner_CMS_User");

                entity.HasOne(d => d.NodeParent)
                    .WithMany(p => p.InverseNodeParent)
                    .HasForeignKey(d => d.NodeParentId)
                    .HasConstraintName("FK_CMS_Tree_NodeParentID_CMS_Tree");

                entity.HasOne(d => d.NodeSite)
                    .WithMany(p => p.CmsTreeNodeSite)
                    .HasForeignKey(d => d.NodeSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Tree_NodeSiteID_CMS_Site");

                entity.HasOne(d => d.NodeSku)
                    .WithMany(p => p.CmsTree)
                    .HasForeignKey(d => d.NodeSkuid)
                    .HasConstraintName("FK_CMS_Tree_NodeSKUID_COM_SKU");

                entity.HasOne(d => d.NodeTemplate)
                    .WithMany(p => p.CmsTree)
                    .HasForeignKey(d => d.NodeTemplateId)
                    .HasConstraintName("FK_CMS_Tree_NodeTemplateID_CMS_PageTemplate");
            });

            modelBuilder.Entity<CmsUielement>(entity =>
            {
                entity.HasKey(e => e.ElementId)
                    .HasName("PK_CMS_UIElement");

                entity.ToTable("CMS_UIElement");

                entity.HasIndex(e => e.ElementGuid)
                    .HasName("IX_CMS_UIElement_ElementGUID")
                    .IsUnique();

                entity.HasIndex(e => e.ElementPageTemplateId)
                    .HasName("IX_CMS_UIElement_ElementPageTemplateID");

                entity.HasIndex(e => e.ElementParentId)
                    .HasName("IX_CMS_UIElement_ElementParentID");

                entity.HasIndex(e => new { e.ElementResourceId, e.ElementLevel, e.ElementParentId, e.ElementOrder, e.ElementCaption })
                    .HasName("IX_CMS_UIElement_ElementResourceID_ElementLevel_ElementParentID_ElementOrder_ElementCaption");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.ElementCaption).HasMaxLength(200);

                entity.Property(e => e.ElementCheckModuleReadPermission).HasDefaultValueSql("1");

                entity.Property(e => e.ElementDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ElementFeature).HasMaxLength(200);

                entity.Property(e => e.ElementFromVersion).HasMaxLength(20);

                entity.Property(e => e.ElementGuid).HasColumnName("ElementGUID");

                entity.Property(e => e.ElementIconClass).HasMaxLength(100);

                entity.Property(e => e.ElementIconPath).HasMaxLength(200);

                entity.Property(e => e.ElementIdpath)
                    .IsRequired()
                    .HasColumnName("ElementIDPath")
                    .HasMaxLength(450);

                entity.Property(e => e.ElementIsCustom).HasDefaultValueSql("0");

                entity.Property(e => e.ElementIsGlobalApplication).HasDefaultValueSql("0");

                entity.Property(e => e.ElementIsMenu).HasDefaultValueSql("0");

                entity.Property(e => e.ElementName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ElementPageTemplateId).HasColumnName("ElementPageTemplateID");

                entity.Property(e => e.ElementParentId).HasColumnName("ElementParentID");

                entity.Property(e => e.ElementResourceId).HasColumnName("ElementResourceID");

                entity.Property(e => e.ElementSize).HasDefaultValueSql("0");

                entity.Property(e => e.ElementTargetUrl)
                    .HasColumnName("ElementTargetURL")
                    .HasMaxLength(650);

                entity.Property(e => e.ElementType).HasMaxLength(50);

                entity.HasOne(d => d.ElementPageTemplate)
                    .WithMany(p => p.CmsUielement)
                    .HasForeignKey(d => d.ElementPageTemplateId)
                    .HasConstraintName("FK_CMS_UIElement_ElementPageTemplateID_CMS_PageTemplate");

                entity.HasOne(d => d.ElementParent)
                    .WithMany(p => p.InverseElementParent)
                    .HasForeignKey(d => d.ElementParentId)
                    .HasConstraintName("FK_CMS_UIElement_ElementParentID_CMS_UIElement");

                entity.HasOne(d => d.ElementResource)
                    .WithMany(p => p.CmsUielement)
                    .HasForeignKey(d => d.ElementResourceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_UIElement_ElementResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_CMS_User");

                entity.ToTable("CMS_User");

                entity.HasIndex(e => e.Email)
                    .HasName("IX_CMS_User_Email");

                entity.HasIndex(e => e.FullName)
                    .HasName("IX_CMS_User_FullName");

                entity.HasIndex(e => e.UserGuid)
                    .HasName("IX_CMS_User_UserGUID")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("IX_CMS_User_UserName")
                    .IsUnique();

                entity.HasIndex(e => e.UserPrivilegeLevel)
                    .HasName("IX_CMS_User_UserPrivilegeLevel");

                entity.HasIndex(e => new { e.UserEnabled, e.UserIsHidden })
                    .HasName("IX_CMS_User_UserEnabled_UserIsHidden");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email).HasMaxLength(254);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(450);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.PreferredCultureCode).HasMaxLength(10);

                entity.Property(e => e.PreferredUicultureCode)
                    .HasColumnName("PreferredUICultureCode")
                    .HasMaxLength(10);

                entity.Property(e => e.UserEnabled).HasDefaultValueSql("0");

                entity.Property(e => e.UserGuid).HasColumnName("UserGUID");

                entity.Property(e => e.UserIsDomain).HasDefaultValueSql("0");

                entity.Property(e => e.UserIsExternal).HasDefaultValueSql("0");

                entity.Property(e => e.UserIsHidden).HasDefaultValueSql("0");

                entity.Property(e => e.UserMfrequired).HasColumnName("UserMFRequired");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.UserPasswordFormat).HasMaxLength(10);

                entity.Property(e => e.UserSecurityStamp).HasMaxLength(72);

                entity.Property(e => e.UserStartingAliasPath).HasMaxLength(200);

                entity.Property(e => e.UserTokenId).HasColumnName("UserTokenID");
            });

            modelBuilder.Entity<CmsUserCulture>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CultureId, e.SiteId })
                    .HasName("PK_CMS_UserCulture");

                entity.ToTable("CMS_UserCulture");

                entity.HasIndex(e => e.CultureId)
                    .HasName("IX_CMS_UserCulture_CultureID");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_CMS_UserCulture_SiteID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CultureId).HasColumnName("CultureID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.CmsUserCulture)
                    .HasForeignKey(d => d.CultureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_UserCulture_CultureID_CMS_Culture");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsUserCulture)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_UserCulture_SiteID_CMS_Site");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsUserCulture)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_UserCulture_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsUserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleId)
                    .HasName("PK_CMS_UserRole");

                entity.ToTable("CMS_UserRole");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_CMS_UserRole_RoleID");

                entity.HasIndex(e => new { e.UserId, e.RoleId })
                    .HasName("IX_CMS_UserRole_UserID_RoleID")
                    .IsUnique();

                entity.HasIndex(e => new { e.RoleId, e.ValidTo, e.UserId })
                    .HasName("IX_CMS_UserRole_UserID");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CmsUserRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_UserRole_RoleID_CMS_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsUserRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_UserRole_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsUserSettings>(entity =>
            {
                entity.HasKey(e => e.UserSettingsId)
                    .HasName("PK_CMS_UserSettings");

                entity.ToTable("CMS_UserSettings");

                entity.HasIndex(e => e.UserActivatedByUserId)
                    .HasName("IX_CMS_UserSettings_UserActivatedByUserID");

                entity.HasIndex(e => e.UserAuthenticationGuid)
                    .HasName("IX_CMS_UserSettings_UserAuthenticationGUID");

                entity.HasIndex(e => e.UserAvatarId)
                    .HasName("IX_CMS_UserSettings_UserAvatarID");

                entity.HasIndex(e => e.UserBadgeId)
                    .HasName("IX_CMS_UserSettings_UserBadgeID");

                entity.HasIndex(e => e.UserFacebookId)
                    .HasName("IX_CMS_UserSettings_UserFacebookID");

                entity.HasIndex(e => e.UserGender)
                    .HasName("IX_CMS_UserSettings_UserGender");

                entity.HasIndex(e => e.UserNickName)
                    .HasName("IX_CMS_UserSettings_UserNickName");

                entity.HasIndex(e => e.UserPasswordRequestHash)
                    .HasName("IX_CMS_UserSettings_UserPasswordRequestHash");

                entity.HasIndex(e => e.UserSettingsUserGuid)
                    .HasName("IX_CMS_UserSettings_UserSettingsUserGUID");

                entity.HasIndex(e => e.UserSettingsUserId)
                    .HasName("IX_CMS_UserSettings_UserSettingsUserID")
                    .IsUnique();

                entity.HasIndex(e => e.UserTimeZoneId)
                    .HasName("IX_CMS_UserSettings_UserTimeZoneID");

                entity.HasIndex(e => e.UserWaitingForApproval)
                    .HasName("IX_CMS_UserSettings_UserWaitingForApproval");

                entity.HasIndex(e => e.WindowsLiveId)
                    .HasName("IX_CMS_UserSettings_WindowsLiveID");

                entity.Property(e => e.UserSettingsId).HasColumnName("UserSettingsID");

                entity.Property(e => e.UserAccountLockReason).HasDefaultValueSql("0");

                entity.Property(e => e.UserActivatedByUserId).HasColumnName("UserActivatedByUserID");

                entity.Property(e => e.UserAuthenticationGuid).HasColumnName("UserAuthenticationGUID");

                entity.Property(e => e.UserAvatarId).HasColumnName("UserAvatarID");

                entity.Property(e => e.UserAvatarType).HasMaxLength(200);

                entity.Property(e => e.UserBadgeId).HasColumnName("UserBadgeID");

                entity.Property(e => e.UserCampaign).HasMaxLength(200);

                entity.Property(e => e.UserDataComPassword).HasMaxLength(200);

                entity.Property(e => e.UserDataComUser).HasMaxLength(200);

                entity.Property(e => e.UserFacebookId)
                    .HasColumnName("UserFacebookID")
                    .HasMaxLength(100);

                entity.Property(e => e.UserIm)
                    .HasColumnName("UserIM")
                    .HasMaxLength(100);

                entity.Property(e => e.UserInvalidLogOnAttempts).HasDefaultValueSql("0");

                entity.Property(e => e.UserInvalidLogOnAttemptsHash).HasMaxLength(100);

                entity.Property(e => e.UserLinkedInId)
                    .HasColumnName("UserLinkedInID")
                    .HasMaxLength(100);

                entity.Property(e => e.UserMessagingNotificationEmail).HasMaxLength(200);

                entity.Property(e => e.UserNickName).HasMaxLength(200);

                entity.Property(e => e.UserPasswordRequestHash).HasMaxLength(100);

                entity.Property(e => e.UserPhone).HasMaxLength(26);

                entity.Property(e => e.UserPicture).HasMaxLength(200);

                entity.Property(e => e.UserPosition).HasMaxLength(200);

                entity.Property(e => e.UserSettingsUserGuid)
                    .HasColumnName("UserSettingsUserGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.UserSettingsUserId)
                    .HasColumnName("UserSettingsUserID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserSkype).HasMaxLength(100);

                entity.Property(e => e.UserTimeZoneId).HasColumnName("UserTimeZoneID");

                entity.Property(e => e.UserUrlreferrer)
                    .HasColumnName("UserURLReferrer")
                    .HasMaxLength(450);

                entity.Property(e => e.UserUsedWebParts).HasMaxLength(1000);

                entity.Property(e => e.UserUsedWidgets).HasMaxLength(1000);

                entity.Property(e => e.UserWaitingForApproval).HasDefaultValueSql("0");

                entity.Property(e => e.WindowsLiveId)
                    .HasColumnName("WindowsLiveID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.UserActivatedByUser)
                    .WithMany(p => p.CmsUserSettingsUserActivatedByUser)
                    .HasForeignKey(d => d.UserActivatedByUserId)
                    .HasConstraintName("FK_CMS_UserSettings_UserActivatedByUserID_CMS_User");

                entity.HasOne(d => d.UserAvatar)
                    .WithMany(p => p.CmsUserSettings)
                    .HasForeignKey(d => d.UserAvatarId)
                    .HasConstraintName("FK_CMS_UserSettings_UserAvatarID_CMS_Avatar");

                entity.HasOne(d => d.UserBadge)
                    .WithMany(p => p.CmsUserSettings)
                    .HasForeignKey(d => d.UserBadgeId)
                    .HasConstraintName("FK_CMS_UserSettings_UserBadgeID_CMS_Badge");

                entity.HasOne(d => d.UserSettingsUserGu)
                    .WithMany(p => p.CmsUserSettingsUserSettingsUserGu)
                    .HasPrincipalKey(p => p.UserGuid)
                    .HasForeignKey(d => d.UserSettingsUserGuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_UserSettings_UserSettingsUserGUID_CMS_User");

                entity.HasOne(d => d.UserSettingsUser)
                    .WithOne(p => p.CmsUserSettingsUserSettingsUser)
                    .HasForeignKey<CmsUserSettings>(d => d.UserSettingsUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_UserSettings_UserSettingsUserID_CMS_User");

                entity.HasOne(d => d.UserTimeZone)
                    .WithMany(p => p.CmsUserSettings)
                    .HasForeignKey(d => d.UserTimeZoneId)
                    .HasConstraintName("FK_CMS_UserSettings_UserTimeZoneID_CMS_TimeZone");
            });

            modelBuilder.Entity<CmsUserSite>(entity =>
            {
                entity.HasKey(e => e.UserSiteId)
                    .HasName("PK_CMS_UserSite");

                entity.ToTable("CMS_UserSite");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_CMS_UserSite_SiteID");

                entity.HasIndex(e => new { e.UserId, e.SiteId })
                    .HasName("IX_CMS_UserSite_UserID_SiteID")
                    .IsUnique();

                entity.Property(e => e.UserSiteId).HasColumnName("UserSiteID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsUserSite)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_UserSite_SiteID_CMS_Site");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsUserSite)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_UserSite_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsVersionAttachment>(entity =>
            {
                entity.HasKey(e => new { e.VersionHistoryId, e.AttachmentHistoryId })
                    .HasName("PK_CMS_VersionAttachment");

                entity.ToTable("CMS_VersionAttachment");

                entity.HasIndex(e => e.AttachmentHistoryId)
                    .HasName("IX_CMS_VersionAttachment_AttachmentHistoryID");

                entity.Property(e => e.VersionHistoryId).HasColumnName("VersionHistoryID");

                entity.Property(e => e.AttachmentHistoryId).HasColumnName("AttachmentHistoryID");

                entity.HasOne(d => d.AttachmentHistory)
                    .WithMany(p => p.CmsVersionAttachment)
                    .HasForeignKey(d => d.AttachmentHistoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_VersionAttachment_AttachmentHistoryID_CMS_AttachmentHistory");

                entity.HasOne(d => d.VersionHistory)
                    .WithMany(p => p.CmsVersionAttachment)
                    .HasForeignKey(d => d.VersionHistoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_VersionAttachment_VersionHistoryID_CMS_VersionHistory");
            });

            modelBuilder.Entity<CmsVersionHistory>(entity =>
            {
                entity.HasKey(e => e.VersionHistoryId)
                    .HasName("PK_CMS_VersionHistory");

                entity.ToTable("CMS_VersionHistory");

                entity.HasIndex(e => e.DocumentId)
                    .HasName("IX_CMS_VersionHistory_DocumentID");

                entity.HasIndex(e => e.ModifiedByUserId)
                    .HasName("IX_CMS_VersionHistory_ModifiedByUserID");

                entity.HasIndex(e => e.NodeSiteId)
                    .HasName("IX_CMS_VersionHistory_NodeSiteID");

                entity.HasIndex(e => e.VersionClassId)
                    .HasName("IX_CMS_VersionHistory_VersionClassID");

                entity.HasIndex(e => e.VersionWorkflowId)
                    .HasName("IX_CMS_VersionHistory_VersionWorkflowID");

                entity.HasIndex(e => e.VersionWorkflowStepId)
                    .HasName("IX_CMS_VersionHistory_VersionWorkflowStepID");

                entity.HasIndex(e => new { e.VersionDeletedByUserId, e.VersionDeletedWhen })
                    .HasName("IX_CMS_VersionHistory_VersionDeletedByUserID_VersionDeletedWhen");

                entity.HasIndex(e => new { e.ToBePublished, e.PublishFrom, e.PublishTo })
                    .HasName("IX_CMS_VersionHistory_ToBePublished_PublishFrom_PublishTo");

                entity.Property(e => e.VersionHistoryId).HasColumnName("VersionHistoryID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.DocumentNamePath)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.NodeSiteId).HasColumnName("NodeSiteID");

                entity.Property(e => e.NodeXml)
                    .IsRequired()
                    .HasColumnName("NodeXML");

                entity.Property(e => e.ToBePublished).HasDefaultValueSql("0");

                entity.Property(e => e.VersionClassId).HasColumnName("VersionClassID");

                entity.Property(e => e.VersionDeletedByUserId).HasColumnName("VersionDeletedByUserID");

                entity.Property(e => e.VersionDocumentName).HasMaxLength(100);

                entity.Property(e => e.VersionDocumentType).HasMaxLength(50);

                entity.Property(e => e.VersionMenuRedirectUrl).HasMaxLength(450);

                entity.Property(e => e.VersionNodeAliasPath).HasMaxLength(450);

                entity.Property(e => e.VersionNumber).HasMaxLength(50);

                entity.Property(e => e.VersionWorkflowId).HasColumnName("VersionWorkflowID");

                entity.Property(e => e.VersionWorkflowStepId).HasColumnName("VersionWorkflowStepID");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.CmsVersionHistoryModifiedByUser)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .HasConstraintName("FK_CMS_VersionHistory_ModifiedByUserID_CMS_User");

                entity.HasOne(d => d.NodeSite)
                    .WithMany(p => p.CmsVersionHistory)
                    .HasForeignKey(d => d.NodeSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_VersionHistory_NodeSiteID_CMS_Site");

                entity.HasOne(d => d.VersionClass)
                    .WithMany(p => p.CmsVersionHistory)
                    .HasForeignKey(d => d.VersionClassId)
                    .HasConstraintName("FK_CMS_VersionHistory_VersionClassID_CMS_Class");

                entity.HasOne(d => d.VersionDeletedByUser)
                    .WithMany(p => p.CmsVersionHistoryVersionDeletedByUser)
                    .HasForeignKey(d => d.VersionDeletedByUserId)
                    .HasConstraintName("FK_CMS_VersionHistory_DeletedByUserID_CMS_User");

                entity.HasOne(d => d.VersionWorkflow)
                    .WithMany(p => p.CmsVersionHistory)
                    .HasForeignKey(d => d.VersionWorkflowId)
                    .HasConstraintName("FK_CMS_VersionHistory_VersionWorkflowID_CMS_Workflow");

                entity.HasOne(d => d.VersionWorkflowStep)
                    .WithMany(p => p.CmsVersionHistory)
                    .HasForeignKey(d => d.VersionWorkflowStepId)
                    .HasConstraintName("FK_CMS_VersionHistory_VersionWorkflowStepID_CMS_WorkflowStep");
            });

            modelBuilder.Entity<CmsWebFarmServer>(entity =>
            {
                entity.HasKey(e => e.ServerId)
                    .HasName("PK_CMS_WebFarmServer");

                entity.ToTable("CMS_WebFarmServer");

                entity.HasIndex(e => e.ServerDisplayName)
                    .HasName("IX_CMS_WebFarmServer_ServerDisplayName");

                entity.HasIndex(e => e.ServerName)
                    .HasName("IX_CMS_WebFarmServer_ServerName")
                    .IsUnique();

                entity.Property(e => e.ServerId).HasColumnName("ServerID");

                entity.Property(e => e.ServerDisplayName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ServerEnabled).HasDefaultValueSql("0");

                entity.Property(e => e.ServerGuid).HasColumnName("ServerGUID");

                entity.Property(e => e.ServerLastModified).HasDefaultValueSql("'9/17/2013 12:18:06 PM'");

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<CmsWebFarmServerLog>(entity =>
            {
                entity.HasKey(e => e.WebFarmServerLogId)
                    .HasName("PK_CMS_WebFarmServerLog");

                entity.ToTable("CMS_WebFarmServerLog");

                entity.Property(e => e.WebFarmServerLogId).HasColumnName("WebFarmServerLogID");

                entity.Property(e => e.LogCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ServerId)
                    .HasColumnName("ServerID")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CmsWebFarmServerMonitoring>(entity =>
            {
                entity.HasKey(e => e.WebFarmServerMonitoringId)
                    .HasName("PK_CMS_WebFarmServerMonitoring");

                entity.ToTable("CMS_WebFarmServerMonitoring");

                entity.Property(e => e.WebFarmServerMonitoringId).HasColumnName("WebFarmServerMonitoringID");

                entity.Property(e => e.ServerId)
                    .HasColumnName("ServerID")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CmsWebFarmServerTask>(entity =>
            {
                entity.HasKey(e => new { e.ServerId, e.TaskId })
                    .HasName("PK_CMS_WebFarmServerTask");

                entity.ToTable("CMS_WebFarmServerTask");

                entity.HasIndex(e => e.TaskId)
                    .HasName("IX_CMS_WebFarmServerTask_TaskID");

                entity.Property(e => e.ServerId).HasColumnName("ServerID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Server)
                    .WithMany(p => p.CmsWebFarmServerTask)
                    .HasForeignKey(d => d.ServerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WebFarmServerTask_ServerID_CMS_WebFarmServer");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.CmsWebFarmServerTask)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WebFarmServerTask_TaskID_CMS_WebFarmTask");
            });

            modelBuilder.Entity<CmsWebFarmTask>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PK_CMS_WebFarmTask");

                entity.ToTable("CMS_WebFarmTask");

                entity.HasIndex(e => new { e.TaskId, e.TaskIsMemory, e.TaskCreated })
                    .HasName("IX_CMS_WebFarmTask_TaskIsMemory_TaskCreated");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskGuid)
                    .HasColumnName("TaskGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.TaskIsMemory).HasDefaultValueSql("0");

                entity.Property(e => e.TaskMachineName).HasMaxLength(450);

                entity.Property(e => e.TaskType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CmsWebPart>(entity =>
            {
                entity.HasKey(e => e.WebPartId)
                    .HasName("PK_CMS_WebPart");

                entity.ToTable("CMS_WebPart");

                entity.HasIndex(e => e.WebPartCategoryId)
                    .HasName("IX_CMS_WebPart_WebPartCategoryID");

                entity.HasIndex(e => e.WebPartLoadGeneration)
                    .HasName("IX_CMS_WebPart_WebPartLoadGeneration");

                entity.HasIndex(e => e.WebPartName)
                    .HasName("IX_CMS_WebPart_WebPartName");

                entity.HasIndex(e => e.WebPartParentId)
                    .HasName("IX_CMS_WebPart_WebPartParentID");

                entity.HasIndex(e => e.WebPartResourceId)
                    .HasName("IX_CMS_WebPart_WebPartResourceID");

                entity.Property(e => e.WebPartId).HasColumnName("WebPartID");

                entity.Property(e => e.WebPartCategoryId)
                    .HasColumnName("WebPartCategoryID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WebPartCss).HasColumnName("WebPartCSS");

                entity.Property(e => e.WebPartDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.WebPartFileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.WebPartGuid)
                    .HasColumnName("WebPartGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.WebPartIconClass).HasMaxLength(200);

                entity.Property(e => e.WebPartLastModified).HasDefaultValueSql("'1/1/0001 12:00:00 AM'");

                entity.Property(e => e.WebPartLoadGeneration).HasDefaultValueSql("0");

                entity.Property(e => e.WebPartName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.WebPartParentId).HasColumnName("WebPartParentID");

                entity.Property(e => e.WebPartProperties)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.WebPartResourceId).HasColumnName("WebPartResourceID");

                entity.Property(e => e.WebPartSkipInsertProperties).HasDefaultValueSql("0");

                entity.Property(e => e.WebPartThumbnailGuid).HasColumnName("WebPartThumbnailGUID");

                entity.HasOne(d => d.WebPartCategory)
                    .WithMany(p => p.CmsWebPart)
                    .HasForeignKey(d => d.WebPartCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WebPart_WebPartCategoryID_CMS_WebPartCategory");

                entity.HasOne(d => d.WebPartParent)
                    .WithMany(p => p.InverseWebPartParent)
                    .HasForeignKey(d => d.WebPartParentId)
                    .HasConstraintName("FK_CMS_WebPart_WebPartParentID_CMS_WebPart");

                entity.HasOne(d => d.WebPartResource)
                    .WithMany(p => p.CmsWebPart)
                    .HasForeignKey(d => d.WebPartResourceId)
                    .HasConstraintName("FK_CMS_WebPart_WebPartResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsWebPartCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_CMS_WebPartCategory");

                entity.ToTable("CMS_WebPartCategory");

                entity.HasIndex(e => e.CategoryParentId)
                    .HasName("IX_CMS_WebPartCategory_CategoryParentID");

                entity.HasIndex(e => e.CategoryPath)
                    .HasName("IX_CMS_WebPartCategory_CategoryPath")
                    .IsUnique();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CategoryGuid).HasColumnName("CategoryGUID");

                entity.Property(e => e.CategoryImagePath).HasMaxLength(450);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentID");

                entity.Property(e => e.CategoryPath)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.CategoryParent)
                    .WithMany(p => p.InverseCategoryParent)
                    .HasForeignKey(d => d.CategoryParentId)
                    .HasConstraintName("FK_CMS_WebPartCategory_CategoryParentID_CMS_WebPartCategory");
            });

            modelBuilder.Entity<CmsWebPartContainer>(entity =>
            {
                entity.HasKey(e => e.ContainerId)
                    .HasName("PK_CMS_WebPartContainer");

                entity.ToTable("CMS_WebPartContainer");

                entity.HasIndex(e => e.ContainerDisplayName)
                    .HasName("IX_CMS_WebPartContainer_ContainerDisplayName");

                entity.HasIndex(e => e.ContainerName)
                    .HasName("IX_CMS_WebPartContainer_ContainerName");

                entity.Property(e => e.ContainerId).HasColumnName("ContainerID");

                entity.Property(e => e.ContainerCss).HasColumnName("ContainerCSS");

                entity.Property(e => e.ContainerDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ContainerGuid).HasColumnName("ContainerGUID");

                entity.Property(e => e.ContainerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CmsWebPartContainerSite>(entity =>
            {
                entity.HasKey(e => new { e.ContainerId, e.SiteId })
                    .HasName("PK_CMS_WebPartContainerSite");

                entity.ToTable("CMS_WebPartContainerSite");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_CMS_WebPartContainerSite_SiteID");

                entity.Property(e => e.ContainerId).HasColumnName("ContainerID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.CmsWebPartContainerSite)
                    .HasForeignKey(d => d.ContainerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WebPartContainerSite_ContainerID_CMS_WebPartContainer");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsWebPartContainerSite)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WebPartContainerSite_SiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsWebPartLayout>(entity =>
            {
                entity.HasKey(e => e.WebPartLayoutId)
                    .HasName("PK_CMS_WebPartLayout");

                entity.ToTable("CMS_WebPartLayout");

                entity.HasIndex(e => e.WebPartLayoutWebPartId)
                    .HasName("IX_CMS_WebPartLayout_WebPartLayoutWebPartID");

                entity.HasIndex(e => new { e.WebPartLayoutWebPartId, e.WebPartLayoutCodeName })
                    .HasName("IX_CMS_WebPartLayout_WebPartLayoutWebPartID_WebPartLayoutCodeName");

                entity.Property(e => e.WebPartLayoutId).HasColumnName("WebPartLayoutID");

                entity.Property(e => e.WebPartLayoutCodeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WebPartLayoutCss).HasColumnName("WebPartLayoutCSS");

                entity.Property(e => e.WebPartLayoutDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WebPartLayoutGuid).HasColumnName("WebPartLayoutGUID");

                entity.Property(e => e.WebPartLayoutVersionGuid)
                    .HasColumnName("WebPartLayoutVersionGUID")
                    .HasMaxLength(100);

                entity.Property(e => e.WebPartLayoutWebPartId).HasColumnName("WebPartLayoutWebPartID");

                entity.HasOne(d => d.WebPartLayoutWebPart)
                    .WithMany(p => p.CmsWebPartLayout)
                    .HasForeignKey(d => d.WebPartLayoutWebPartId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WebPartLayout_WebPartLayoutWebPartID_CMS_WebPart");
            });

            modelBuilder.Entity<CmsWebTemplate>(entity =>
            {
                entity.HasKey(e => e.WebTemplateId)
                    .HasName("PK_CMS_WebTemplate");

                entity.ToTable("CMS_WebTemplate");

                entity.HasIndex(e => e.WebTemplateOrder)
                    .HasName("IX_CMS_WebTemplate_WebTemplateOrder");

                entity.Property(e => e.WebTemplateId).HasColumnName("WebTemplateID");

                entity.Property(e => e.WebTemplateDescription).IsRequired();

                entity.Property(e => e.WebTemplateDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WebTemplateFileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WebTemplateGuid).HasColumnName("WebTemplateGUID");

                entity.Property(e => e.WebTemplateLicenses)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WebTemplateName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WebTemplateOrder).HasDefaultValueSql("99999");

                entity.Property(e => e.WebTemplateThumbnailGuid).HasColumnName("WebTemplateThumbnailGUID");
            });

            modelBuilder.Entity<CmsWidget>(entity =>
            {
                entity.HasKey(e => e.WidgetId)
                    .HasName("PK_CMS_Widget");

                entity.ToTable("CMS_Widget");

                entity.HasIndex(e => e.WidgetCategoryId)
                    .HasName("IX_CMS_Widget_WidgetCategoryID");

                entity.HasIndex(e => e.WidgetLayoutId)
                    .HasName("IX_CMS_Widget_WidgetLayoutID");

                entity.HasIndex(e => e.WidgetWebPartId)
                    .HasName("IX_CMS_Widget_WidgetWebPartID");

                entity.HasIndex(e => new { e.WidgetCategoryId, e.WidgetDisplayName })
                    .HasName("IX_CMS_Widget_WidgetCategoryID_WidgetDisplayName");

                entity.HasIndex(e => new { e.WidgetIsEnabled, e.WidgetForGroup, e.WidgetForEditor, e.WidgetForUser })
                    .HasName("IX_CMS_Widget_WidgetIsEnabled_WidgetForGroup_WidgetForEditor_WidgetForUser");

                entity.Property(e => e.WidgetId).HasColumnName("WidgetID");

                entity.Property(e => e.WidgetCategoryId).HasColumnName("WidgetCategoryID");

                entity.Property(e => e.WidgetDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.WidgetForDashboard).HasDefaultValueSql("0");

                entity.Property(e => e.WidgetForEditor).HasDefaultValueSql("0");

                entity.Property(e => e.WidgetForGroup).HasDefaultValueSql("0");

                entity.Property(e => e.WidgetForInline).HasDefaultValueSql("0");

                entity.Property(e => e.WidgetForUser).HasDefaultValueSql("0");

                entity.Property(e => e.WidgetGuid).HasColumnName("WidgetGUID");

                entity.Property(e => e.WidgetIconClass).HasMaxLength(200);

                entity.Property(e => e.WidgetIsEnabled).HasDefaultValueSql("0");

                entity.Property(e => e.WidgetLayoutId).HasColumnName("WidgetLayoutID");

                entity.Property(e => e.WidgetName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.WidgetSecurity).HasDefaultValueSql("2");

                entity.Property(e => e.WidgetThumbnailGuid).HasColumnName("WidgetThumbnailGUID");

                entity.Property(e => e.WidgetWebPartId).HasColumnName("WidgetWebPartID");

                entity.HasOne(d => d.WidgetCategory)
                    .WithMany(p => p.CmsWidget)
                    .HasForeignKey(d => d.WidgetCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Widget_WidgetCategoryID_CMS_WidgetCategory");

                entity.HasOne(d => d.WidgetLayout)
                    .WithMany(p => p.CmsWidget)
                    .HasForeignKey(d => d.WidgetLayoutId)
                    .HasConstraintName("FK_CMS_Widget_WidgetLayoutID_CMS_WebPartLayout");

                entity.HasOne(d => d.WidgetWebPart)
                    .WithMany(p => p.CmsWidget)
                    .HasForeignKey(d => d.WidgetWebPartId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Widget_WidgetWebPartID_CMS_WebPart");
            });

            modelBuilder.Entity<CmsWidgetCategory>(entity =>
            {
                entity.HasKey(e => e.WidgetCategoryId)
                    .HasName("PK_CMS_WidgetCategory");

                entity.ToTable("CMS_WidgetCategory");

                entity.HasIndex(e => e.WidgetCategoryParentId)
                    .HasName("IX_CMS_WidgetCategory_WidgetCategoryParentID");

                entity.HasIndex(e => e.WidgetCategoryPath)
                    .HasName("IX_CMS_WidgetCategory_CategoryPath")
                    .IsUnique();

                entity.Property(e => e.WidgetCategoryId).HasColumnName("WidgetCategoryID");

                entity.Property(e => e.WidgetCategoryDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.WidgetCategoryGuid).HasColumnName("WidgetCategoryGUID");

                entity.Property(e => e.WidgetCategoryImagePath).HasMaxLength(450);

                entity.Property(e => e.WidgetCategoryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.WidgetCategoryParentId).HasColumnName("WidgetCategoryParentID");

                entity.Property(e => e.WidgetCategoryPath)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.WidgetCategoryParent)
                    .WithMany(p => p.InverseWidgetCategoryParent)
                    .HasForeignKey(d => d.WidgetCategoryParentId)
                    .HasConstraintName("FK_CMS_WidgetCategory_WidgetCategoryParentID_CMS_WidgetCategory");
            });

            modelBuilder.Entity<CmsWidgetRole>(entity =>
            {
                entity.HasKey(e => new { e.WidgetId, e.RoleId, e.PermissionId })
                    .HasName("PK_CMS_WidgetRole");

                entity.ToTable("CMS_WidgetRole");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("IX_CMS_WidgetRole_PermissionID");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_CMS_WidgetRole_RoleID");

                entity.Property(e => e.WidgetId).HasColumnName("WidgetID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.CmsWidgetRole)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WidgetRole_PermissionID_CMS_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CmsWidgetRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WidgetRole_RoleID_CMS_Role");

                entity.HasOne(d => d.Widget)
                    .WithMany(p => p.CmsWidgetRole)
                    .HasForeignKey(d => d.WidgetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WidgetRole_WidgetID_CMS_Widget");
            });

            modelBuilder.Entity<CmsWorkflow>(entity =>
            {
                entity.HasKey(e => e.WorkflowId)
                    .HasName("PK_CMS_Workflow");

                entity.ToTable("CMS_Workflow");

                entity.HasIndex(e => e.WorkflowDisplayName)
                    .HasName("IX_CMS_Workflow_WorkflowDisplayName");

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.Property(e => e.WorkflowApprovedTemplateName).HasMaxLength(200);

                entity.Property(e => e.WorkflowArchivedTemplateName).HasMaxLength(200);

                entity.Property(e => e.WorkflowAutoPublishChanges).HasDefaultValueSql("0");

                entity.Property(e => e.WorkflowDisplayName)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WorkflowEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.WorkflowGuid).HasColumnName("WorkflowGUID");

                entity.Property(e => e.WorkflowName)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WorkflowNotificationTemplateName).HasMaxLength(200);

                entity.Property(e => e.WorkflowPublishedTemplateName).HasMaxLength(200);

                entity.Property(e => e.WorkflowReadyForApprovalTemplateName).HasMaxLength(200);

                entity.Property(e => e.WorkflowRejectedTemplateName).HasMaxLength(200);

                entity.Property(e => e.WorkflowSendApproveEmails).HasDefaultValueSql("1");

                entity.Property(e => e.WorkflowSendArchiveEmails).HasDefaultValueSql("1");

                entity.Property(e => e.WorkflowSendPublishEmails).HasDefaultValueSql("1");

                entity.Property(e => e.WorkflowSendReadyForApprovalEmails).HasDefaultValueSql("1");

                entity.Property(e => e.WorkflowSendRejectEmails).HasDefaultValueSql("1");

                entity.Property(e => e.WorkflowUseCheckinCheckout).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<CmsWorkflowAction>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PK_CMS_WorkflowAction");

                entity.ToTable("CMS_WorkflowAction");

                entity.HasIndex(e => e.ActionResourceId)
                    .HasName("IX_CMS_WorkflowAction_ActionResourceID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ActionAssemblyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ActionClass)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ActionDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ActionEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.ActionGuid).HasColumnName("ActionGUID");

                entity.Property(e => e.ActionIconClass).HasMaxLength(200);

                entity.Property(e => e.ActionIconGuid).HasColumnName("ActionIconGUID");

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ActionResourceId).HasColumnName("ActionResourceID");

                entity.Property(e => e.ActionThumbnailClass).HasMaxLength(200);

                entity.Property(e => e.ActionThumbnailGuid).HasColumnName("ActionThumbnailGUID");

                entity.HasOne(d => d.ActionResource)
                    .WithMany(p => p.CmsWorkflowAction)
                    .HasForeignKey(d => d.ActionResourceId)
                    .HasConstraintName("FK_CMS_WorkflowAction_ActionResourceID");
            });

            modelBuilder.Entity<CmsWorkflowHistory>(entity =>
            {
                entity.HasKey(e => e.WorkflowHistoryId)
                    .HasName("PK_CMS_WorkflowHistory");

                entity.ToTable("CMS_WorkflowHistory");

                entity.HasIndex(e => e.ApprovedByUserId)
                    .HasName("IX_CMS_WorkflowHistory_ApprovedByUserID");

                entity.HasIndex(e => e.ApprovedWhen)
                    .HasName("IX_CMS_WorkflowHistory_ApprovedWhen");

                entity.HasIndex(e => e.HistoryWorkflowId)
                    .HasName("IX_CMS_WorkflowHistory_HistoryWorkflowID");

                entity.HasIndex(e => e.StepId)
                    .HasName("IX_CMS_WorkflowHistory_StepID");

                entity.HasIndex(e => e.TargetStepId)
                    .HasName("IX_CMS_WorkflowHistory_TargetStepID");

                entity.HasIndex(e => e.VersionHistoryId)
                    .HasName("IX_CMS_WorkflowHistory_VersionHistoryID");

                entity.Property(e => e.WorkflowHistoryId).HasColumnName("WorkflowHistoryID");

                entity.Property(e => e.ApprovedByUserId).HasColumnName("ApprovedByUserID");

                entity.Property(e => e.HistoryObjectId).HasColumnName("HistoryObjectID");

                entity.Property(e => e.HistoryObjectType).HasMaxLength(100);

                entity.Property(e => e.HistoryRejected).HasDefaultValueSql("0");

                entity.Property(e => e.HistoryWorkflowId).HasColumnName("HistoryWorkflowID");

                entity.Property(e => e.StepDisplayName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.StepName).HasMaxLength(440);

                entity.Property(e => e.TargetStepDisplayName).HasMaxLength(450);

                entity.Property(e => e.TargetStepId).HasColumnName("TargetStepID");

                entity.Property(e => e.TargetStepName).HasMaxLength(440);

                entity.Property(e => e.VersionHistoryId).HasColumnName("VersionHistoryID");

                entity.HasOne(d => d.ApprovedByUser)
                    .WithMany(p => p.CmsWorkflowHistory)
                    .HasForeignKey(d => d.ApprovedByUserId)
                    .HasConstraintName("FK_CMS_WorkflowHistory_ApprovedByUserID_CMS_User");

                entity.HasOne(d => d.HistoryWorkflow)
                    .WithMany(p => p.CmsWorkflowHistory)
                    .HasForeignKey(d => d.HistoryWorkflowId)
                    .HasConstraintName("FK_CMS_WorkflowHistory_HistoryWorkflowID_CMS_Workflow");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.CmsWorkflowHistoryStep)
                    .HasForeignKey(d => d.StepId)
                    .HasConstraintName("FK_CMS_WorkflowHistory_StepID_CMS_WorkflowStep");

                entity.HasOne(d => d.TargetStep)
                    .WithMany(p => p.CmsWorkflowHistoryTargetStep)
                    .HasForeignKey(d => d.TargetStepId)
                    .HasConstraintName("FK_CMS_WorkflowHistory_TargetStepID_CMS_WorkflowStep");

                entity.HasOne(d => d.VersionHistory)
                    .WithMany(p => p.CmsWorkflowHistory)
                    .HasForeignKey(d => d.VersionHistoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WorkflowHistory_VersionHistoryID_CMS_VersionHistory");
            });

            modelBuilder.Entity<CmsWorkflowScope>(entity =>
            {
                entity.HasKey(e => e.ScopeId)
                    .HasName("PK_CMS_WorkflowScope");

                entity.ToTable("CMS_WorkflowScope");

                entity.HasIndex(e => e.ScopeClassId)
                    .HasName("IX_CMS_WorkflowScope_ScopeClassID");

                entity.HasIndex(e => e.ScopeCultureId)
                    .HasName("IX_CMS_WorkflowScope_ScopeCultureID");

                entity.HasIndex(e => e.ScopeSiteId)
                    .HasName("IX_CMS_WorkflowScope_ScopeSiteID");

                entity.HasIndex(e => e.ScopeStartingPath)
                    .HasName("IX_CMS_WorkflowScope_ScopeStartingPath");

                entity.HasIndex(e => e.ScopeWorkflowId)
                    .HasName("IX_CMS_WorkflowScope_ScopeWorkflowID");

                entity.Property(e => e.ScopeId).HasColumnName("ScopeID");

                entity.Property(e => e.ScopeClassId).HasColumnName("ScopeClassID");

                entity.Property(e => e.ScopeCultureId).HasColumnName("ScopeCultureID");

                entity.Property(e => e.ScopeExcluded).HasDefaultValueSql("0");

                entity.Property(e => e.ScopeGuid).HasColumnName("ScopeGUID");

                entity.Property(e => e.ScopeSiteId)
                    .HasColumnName("ScopeSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScopeStartingPath)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.ScopeWorkflowId)
                    .HasColumnName("ScopeWorkflowID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ScopeClass)
                    .WithMany(p => p.CmsWorkflowScope)
                    .HasForeignKey(d => d.ScopeClassId)
                    .HasConstraintName("FK_CMS_WorkflowScope_ScopeClassID_CMS_Class");

                entity.HasOne(d => d.ScopeCulture)
                    .WithMany(p => p.CmsWorkflowScope)
                    .HasForeignKey(d => d.ScopeCultureId)
                    .HasConstraintName("FK_CMS_WorkflowScope_ScopeCultureID_CMS_Culture");

                entity.HasOne(d => d.ScopeSite)
                    .WithMany(p => p.CmsWorkflowScope)
                    .HasForeignKey(d => d.ScopeSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WorkflowScope_ScopeSiteID_CMS_Site");

                entity.HasOne(d => d.ScopeWorkflow)
                    .WithMany(p => p.CmsWorkflowScope)
                    .HasForeignKey(d => d.ScopeWorkflowId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WorkflowScope_ScopeWorkflowID_CMS_WorkflowID");
            });

            modelBuilder.Entity<CmsWorkflowStep>(entity =>
            {
                entity.HasKey(e => e.StepId)
                    .HasName("PK_CMS_WorkflowStep");

                entity.ToTable("CMS_WorkflowStep");

                entity.HasIndex(e => e.StepActionId)
                    .HasName("IX_CMS_WorkflowStep_StepActionID");

                entity.HasIndex(e => new { e.StepId, e.StepName })
                    .HasName("IX_CMS_WorkflowStep_StepID_StepName");

                entity.HasIndex(e => new { e.StepWorkflowId, e.StepName })
                    .HasName("IX_CMS_WorkflowStep_StepWorkflowID_StepName")
                    .IsUnique();

                entity.HasIndex(e => new { e.StepWorkflowId, e.StepOrder })
                    .HasName("IX_CMS_WorkflowStep_StepWorkflowID_StepOrder");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.StepActionId).HasColumnName("StepActionID");

                entity.Property(e => e.StepAllowPublish).HasDefaultValueSql("0");

                entity.Property(e => e.StepAllowReject).HasDefaultValueSql("1");

                entity.Property(e => e.StepApprovedTemplateName).HasMaxLength(200);

                entity.Property(e => e.StepDisplayName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.StepGuid).HasColumnName("StepGUID");

                entity.Property(e => e.StepName)
                    .IsRequired()
                    .HasMaxLength(440);

                entity.Property(e => e.StepReadyforApprovalTemplateName).HasMaxLength(200);

                entity.Property(e => e.StepRejectedTemplateName).HasMaxLength(200);

                entity.Property(e => e.StepWorkflowId).HasColumnName("StepWorkflowID");

                entity.HasOne(d => d.StepAction)
                    .WithMany(p => p.CmsWorkflowStep)
                    .HasForeignKey(d => d.StepActionId)
                    .HasConstraintName("FK_CMS_WorkflowStep_StepActionID");

                entity.HasOne(d => d.StepWorkflow)
                    .WithMany(p => p.CmsWorkflowStep)
                    .HasForeignKey(d => d.StepWorkflowId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WorkflowStep_StepWorkflowID");
            });

            modelBuilder.Entity<CmsWorkflowStepRoles>(entity =>
            {
                entity.HasKey(e => e.WorkflowStepRoleId)
                    .HasName("PK_CMS_WorkflowStepRoles");

                entity.ToTable("CMS_WorkflowStepRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_CMS_WorkflowStepRoles_RoleID");

                entity.HasIndex(e => new { e.StepId, e.StepSourcePointGuid, e.RoleId })
                    .HasName("IX_CMS_WorkflowStepRoles_StepID_StepSourcePointGUID_RoleID")
                    .IsUnique();

                entity.Property(e => e.WorkflowStepRoleId).HasColumnName("WorkflowStepRoleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.StepSourcePointGuid)
                    .IsRequired()
                    .HasColumnName("StepSourcePointGUID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CmsWorkflowStepRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WorkflowStepRoles_RoleID_CMS_Role");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.CmsWorkflowStepRoles)
                    .HasForeignKey(d => d.StepId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WorkflowStepRoles_StepID_CMS_WorkflowStep");
            });

            modelBuilder.Entity<CmsWorkflowStepUser>(entity =>
            {
                entity.HasKey(e => e.WorkflowStepUserId)
                    .HasName("PK_CMS_WorkflowStepUser");

                entity.ToTable("CMS_WorkflowStepUser");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_CMS_WorkflowStepUser_UserID");

                entity.HasIndex(e => new { e.StepId, e.StepSourcePointGuid, e.UserId })
                    .HasName("IX_CMS_WorkflowStepUser_StepID_StepSourcePointGUID_UserID")
                    .IsUnique();

                entity.Property(e => e.WorkflowStepUserId).HasColumnName("WorkflowStepUserID");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.StepSourcePointGuid)
                    .IsRequired()
                    .HasColumnName("StepSourcePointGUID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.CmsWorkflowStepUser)
                    .HasForeignKey(d => d.StepId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WorkflowStepUser_StepID_CMS_WorkflowStep");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsWorkflowStepUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WorkflowStepUser_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsWorkflowTransition>(entity =>
            {
                entity.HasKey(e => e.TransitionId)
                    .HasName("PK_CMS_WorkflowTransition");

                entity.ToTable("CMS_WorkflowTransition");

                entity.HasIndex(e => e.TransitionEndStepId)
                    .HasName("IX_CMS_WorkflowTransition_TransitionEndStepID");

                entity.HasIndex(e => e.TransitionWorkflowId)
                    .HasName("IX_CMS_WorkflowTransition_TransitionWorkflowID");

                entity.HasIndex(e => new { e.TransitionStartStepId, e.TransitionSourcePointGuid, e.TransitionEndStepId })
                    .HasName("IX_CMS_WorkflowTransition_TransitionStartStepID_TransitionSourcePointGUID_TransitionEndStepID")
                    .IsUnique();

                entity.Property(e => e.TransitionId).HasColumnName("TransitionID");

                entity.Property(e => e.TransitionEndStepId).HasColumnName("TransitionEndStepID");

                entity.Property(e => e.TransitionSourcePointGuid)
                    .IsRequired()
                    .HasColumnName("TransitionSourcePointGUID");

                entity.Property(e => e.TransitionStartStepId).HasColumnName("TransitionStartStepID");

                entity.Property(e => e.TransitionWorkflowId)
                    .HasColumnName("TransitionWorkflowID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.TransitionEndStep)
                    .WithMany(p => p.CmsWorkflowTransitionTransitionEndStep)
                    .HasForeignKey(d => d.TransitionEndStepId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WorkflowTransition_TransitionEndStepID_CMS_WorkflowStep");

                entity.HasOne(d => d.TransitionStartStep)
                    .WithMany(p => p.CmsWorkflowTransitionTransitionStartStep)
                    .HasForeignKey(d => d.TransitionStartStepId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WorkflowTransition_TransitionStartStepID_CMS_WorkflowStep");

                entity.HasOne(d => d.TransitionWorkflow)
                    .WithMany(p => p.CmsWorkflowTransition)
                    .HasForeignKey(d => d.TransitionWorkflowId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WorkflowTransition_TransitionWorkflowID_CMS_Workflow");
            });

            modelBuilder.Entity<CmsWorkflowUser>(entity =>
            {
                entity.HasKey(e => new { e.WorkflowId, e.UserId })
                    .HasName("PK_CMS_WorkflowUser_1");

                entity.ToTable("CMS_WorkflowUser");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_CMS_WorkflowUser_UserID");

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsWorkflowUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WorkflowUser_UserID_CMS_User");

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.CmsWorkflowUser)
                    .HasForeignKey(d => d.WorkflowId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_WorkflowUser_WorkflowID_CMS_Workflow");
            });

            modelBuilder.Entity<ComAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK_COM_CustomerAdress");

                entity.ToTable("COM_Address");

                entity.HasIndex(e => e.AddressCountryId)
                    .HasName("IX_COM_Address_AddressCountryID");

                entity.HasIndex(e => e.AddressCustomerId)
                    .HasName("IX_COM_Address_AddressCustomerID");

                entity.HasIndex(e => e.AddressStateId)
                    .HasName("IX_COM_Address_AddressStateID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressCity)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AddressCountryId).HasColumnName("AddressCountryID");

                entity.Property(e => e.AddressCustomerId).HasColumnName("AddressCustomerID");

                entity.Property(e => e.AddressGuid).HasColumnName("AddressGUID");

                entity.Property(e => e.AddressLastModified).HasDefaultValueSql("'10/18/2012 3:39:07 PM'");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.AddressLine2).HasMaxLength(100);

                entity.Property(e => e.AddressName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AddressPersonalName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.AddressPhone).HasMaxLength(26);

                entity.Property(e => e.AddressStateId).HasColumnName("AddressStateID");

                entity.Property(e => e.AddressZip)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("N''");

                entity.HasOne(d => d.AddressCountry)
                    .WithMany(p => p.ComAddress)
                    .HasForeignKey(d => d.AddressCountryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_Address_AddressCountryID_CMS_Country");

                entity.HasOne(d => d.AddressCustomer)
                    .WithMany(p => p.ComAddress)
                    .HasForeignKey(d => d.AddressCustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_Address_AddressCustomerID_COM_Customer");

                entity.HasOne(d => d.AddressState)
                    .WithMany(p => p.ComAddress)
                    .HasForeignKey(d => d.AddressStateId)
                    .HasConstraintName("FK_COM_Address_AddressStateID_CMS_State");
            });

            modelBuilder.Entity<ComBundle>(entity =>
            {
                entity.HasKey(e => new { e.BundleId, e.Skuid })
                    .HasName("PK_COM_Bundle");

                entity.ToTable("COM_Bundle");

                entity.HasIndex(e => e.Skuid)
                    .HasName("IX_COM_Bundle_SKUID");

                entity.Property(e => e.BundleId).HasColumnName("BundleID");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");

                entity.HasOne(d => d.Bundle)
                    .WithMany(p => p.ComBundleBundle)
                    .HasForeignKey(d => d.BundleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_Bundle_BundleID_COM_SKU");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.ComBundleSku)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_Bundle_SKUID_COM_SKU");
            });

            modelBuilder.Entity<ComCarrier>(entity =>
            {
                entity.HasKey(e => e.CarrierId)
                    .HasName("PK_COM_Carrier");

                entity.ToTable("COM_Carrier");

                entity.HasIndex(e => e.CarrierSiteId)
                    .HasName("IX_COM_Carrier_CarrierSiteID");

                entity.Property(e => e.CarrierId).HasColumnName("CarrierID");

                entity.Property(e => e.CarrierAssemblyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CarrierClassName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CarrierDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CarrierGuid)
                    .HasColumnName("CarrierGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.CarrierLastModified).HasDefaultValueSql("'9/22/2014 3:00:14 PM'");

                entity.Property(e => e.CarrierName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CarrierSiteId)
                    .HasColumnName("CarrierSiteID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.CarrierSite)
                    .WithMany(p => p.ComCarrier)
                    .HasForeignKey(d => d.CarrierSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_Carrier_CarrierSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComCouponCode>(entity =>
            {
                entity.HasKey(e => e.CouponCodeId)
                    .HasName("PK_COM_CouponCode");

                entity.ToTable("COM_CouponCode");

                entity.HasIndex(e => e.CouponCodeDiscountId)
                    .HasName("IX_COM_CouponCode_CouponCodeDiscountID");

                entity.Property(e => e.CouponCodeId).HasColumnName("CouponCodeID");

                entity.Property(e => e.CouponCodeCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CouponCodeDiscountId)
                    .HasColumnName("CouponCodeDiscountID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CouponCodeGuid).HasColumnName("CouponCodeGUID");

                entity.HasOne(d => d.CouponCodeDiscount)
                    .WithMany(p => p.ComCouponCode)
                    .HasForeignKey(d => d.CouponCodeDiscountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_CouponCode_CouponCodeDiscountID_COM_Discount");
            });

            modelBuilder.Entity<ComCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId)
                    .HasName("PK_COM_Currency");

                entity.ToTable("COM_Currency");

                entity.HasIndex(e => e.CurrencyDisplayName)
                    .HasName("IX_COM_Currency_CurrencyDisplayName");

                entity.HasIndex(e => e.CurrencySiteId)
                    .HasName("IX_COM_Currency_CurrencySiteID");

                entity.HasIndex(e => new { e.CurrencyEnabled, e.CurrencyIsMain })
                    .HasName("IX_COM_Currency_CurrencyEnabled_CurrencyIsMain");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CurrencyDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CurrencyFormatString)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CurrencyGuid).HasColumnName("CurrencyGUID");

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CurrencySiteId).HasColumnName("CurrencySiteID");

                entity.HasOne(d => d.CurrencySite)
                    .WithMany(p => p.ComCurrency)
                    .HasForeignKey(d => d.CurrencySiteId)
                    .HasConstraintName("FK_COM_Currency_CurrencySiteID_CMS_Site");
            });

            modelBuilder.Entity<ComCurrencyExchangeRate>(entity =>
            {
                entity.HasKey(e => e.ExchagneRateId)
                    .HasName("PK_COM_CurrencyExchangeRate");

                entity.ToTable("COM_CurrencyExchangeRate");

                entity.HasIndex(e => e.ExchangeRateToCurrencyId)
                    .HasName("IX_COM_CurrencyExchangeRate_ExchangeRateToCurrencyID");

                entity.HasIndex(e => e.ExchangeTableId)
                    .HasName("IX_COM_CurrencyExchangeRate_ExchangeTableID");

                entity.Property(e => e.ExchagneRateId).HasColumnName("ExchagneRateID");

                entity.Property(e => e.ExchangeRateGuid).HasColumnName("ExchangeRateGUID");

                entity.Property(e => e.ExchangeRateToCurrencyId).HasColumnName("ExchangeRateToCurrencyID");

                entity.Property(e => e.ExchangeTableId).HasColumnName("ExchangeTableID");

                entity.HasOne(d => d.ExchangeRateToCurrency)
                    .WithMany(p => p.ComCurrencyExchangeRate)
                    .HasForeignKey(d => d.ExchangeRateToCurrencyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_CurrencyExchangeRate_ExchangeRateToCurrencyID_COM_Currency");

                entity.HasOne(d => d.ExchangeTable)
                    .WithMany(p => p.ComCurrencyExchangeRate)
                    .HasForeignKey(d => d.ExchangeTableId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_CurrencyExchangeRate_ExchangeTableID_COM_ExchangeTable");
            });

            modelBuilder.Entity<ComCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_COM_Customer");

                entity.ToTable("COM_Customer");

                entity.HasIndex(e => e.CustomerCompany)
                    .HasName("IX_COM_Customer_CustomerCompany");

                entity.HasIndex(e => e.CustomerCountryId)
                    .HasName("IX_COM_Customer_CustomerCountryID");

                entity.HasIndex(e => e.CustomerEmail)
                    .HasName("IX_COM_Customer_CustomerEmail");

                entity.HasIndex(e => e.CustomerSiteId)
                    .HasName("IX_COM_Customer_CustomerSiteID");

                entity.HasIndex(e => e.CustomerStateId)
                    .HasName("IX_COM_Customer_CustomerStateID");

                entity.HasIndex(e => e.CustomerUserId)
                    .HasName("IX_COM_Customer_CustomerUserID");

                entity.HasIndex(e => new { e.CustomerLastName, e.CustomerFirstName })
                    .HasName("IX_COM_Customer_CustomerLastName_CustomerFirstName");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerCompany).HasMaxLength(200);

                entity.Property(e => e.CustomerCountryId).HasColumnName("CustomerCountryID");

                entity.Property(e => e.CustomerEmail).HasMaxLength(254);

                entity.Property(e => e.CustomerFax).HasMaxLength(50);

                entity.Property(e => e.CustomerFirstName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerGuid)
                    .HasColumnName("CustomerGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.CustomerLastName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerOrganizationId)
                    .HasColumnName("CustomerOrganizationID")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerPhone).HasMaxLength(26);

                entity.Property(e => e.CustomerSiteId).HasColumnName("CustomerSiteID");

                entity.Property(e => e.CustomerStateId).HasColumnName("CustomerStateID");

                entity.Property(e => e.CustomerTaxRegistrationId)
                    .HasColumnName("CustomerTaxRegistrationID")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerUserId).HasColumnName("CustomerUserID");

                entity.HasOne(d => d.CustomerCountry)
                    .WithMany(p => p.ComCustomer)
                    .HasForeignKey(d => d.CustomerCountryId)
                    .HasConstraintName("FK_COM_Customer_CustomerCountryID_CMS_Country");

                entity.HasOne(d => d.CustomerSite)
                    .WithMany(p => p.ComCustomer)
                    .HasForeignKey(d => d.CustomerSiteId)
                    .HasConstraintName("FK_COM_Customer_CustomerSiteID_CMS_Site");

                entity.HasOne(d => d.CustomerState)
                    .WithMany(p => p.ComCustomer)
                    .HasForeignKey(d => d.CustomerStateId)
                    .HasConstraintName("FK_COM_Customer_CustomerStateID_CMS_State");

                entity.HasOne(d => d.CustomerUser)
                    .WithMany(p => p.ComCustomer)
                    .HasForeignKey(d => d.CustomerUserId)
                    .HasConstraintName("FK_COM_Customer_CustomerUserID_CMS_User");
            });

            modelBuilder.Entity<ComCustomerCreditHistory>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_COM_CustomerCreditHistory");

                entity.ToTable("COM_CustomerCreditHistory");

                entity.HasIndex(e => e.EventCustomerId)
                    .HasName("IX_COM_CustomerCreditHistory_EventCustomerID");

                entity.HasIndex(e => e.EventSiteId)
                    .HasName("IX_COM_CustomerCreditHistory_EventSiteID");

                entity.HasIndex(e => new { e.EventCustomerId, e.EventDate })
                    .HasName("IX_COM_CustomerCreditHistory_EventCustomerID_EventDate");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventCreditChange).HasDefaultValueSql("0");

                entity.Property(e => e.EventCreditGuid).HasColumnName("EventCreditGUID");

                entity.Property(e => e.EventCreditLastModified).HasDefaultValueSql("'9/26/2012 12:21:38 PM'");

                entity.Property(e => e.EventCustomerId).HasColumnName("EventCustomerID");

                entity.Property(e => e.EventDate).HasDefaultValueSql("'9/27/2012 2:48:56 PM'");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EventSiteId).HasColumnName("EventSiteID");

                entity.HasOne(d => d.EventCustomer)
                    .WithMany(p => p.ComCustomerCreditHistory)
                    .HasForeignKey(d => d.EventCustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_CustomerCreditHistory_EventCustomerID_COM_Customer");

                entity.HasOne(d => d.EventSite)
                    .WithMany(p => p.ComCustomerCreditHistory)
                    .HasForeignKey(d => d.EventSiteId)
                    .HasConstraintName("FK_COM_CustomerCreditHistory_EventSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK_COM_Department");

                entity.ToTable("COM_Department");

                entity.HasIndex(e => e.DepartmentDefaultTaxClassId)
                    .HasName("IX_COM_Department_DepartmentDefaultTaxClassID");

                entity.HasIndex(e => e.DepartmentDisplayName)
                    .HasName("IX_COM_Department_DepartmentDisplayName");

                entity.HasIndex(e => e.DepartmentSiteId)
                    .HasName("IX_COM_Department_DepartmentSiteID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentDefaultTaxClassId).HasColumnName("DepartmentDefaultTaxClassID");

                entity.Property(e => e.DepartmentDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.DepartmentGuid)
                    .HasColumnName("DepartmentGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.DepartmentSiteId).HasColumnName("DepartmentSiteID");

                entity.HasOne(d => d.DepartmentDefaultTaxClass)
                    .WithMany(p => p.ComDepartment)
                    .HasForeignKey(d => d.DepartmentDefaultTaxClassId)
                    .HasConstraintName("FK_COM_Department_DepartmentDefaultTaxClassID_COM_TaxClass");

                entity.HasOne(d => d.DepartmentSite)
                    .WithMany(p => p.ComDepartment)
                    .HasForeignKey(d => d.DepartmentSiteId)
                    .HasConstraintName("FK_COM_Department_DepartmentSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComDepartmentTaxClass>(entity =>
            {
                entity.HasKey(e => new { e.DepartmentId, e.TaxClassId })
                    .HasName("PK_COM_TaxClassDepartment");

                entity.ToTable("COM_DepartmentTaxClass");

                entity.HasIndex(e => e.TaxClassId)
                    .HasName("IX_COM_DepartmentTaxClass_TaxClassID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.TaxClassId).HasColumnName("TaxClassID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ComDepartmentTaxClass)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_TaxClassDepartment_DepartmentID_COM_Department");

                entity.HasOne(d => d.TaxClass)
                    .WithMany(p => p.ComDepartmentTaxClass)
                    .HasForeignKey(d => d.TaxClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_TaxClassDepartment_TaxClassID_COM_TaxClass");
            });

            modelBuilder.Entity<ComDiscount>(entity =>
            {
                entity.HasKey(e => e.DiscountId)
                    .HasName("PK_COM_Discount");

                entity.ToTable("COM_Discount");

                entity.HasIndex(e => e.DiscountSiteId)
                    .HasName("IX_COM_Discount_DiscountSiteID");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.DiscountApplyFurtherDiscounts).HasDefaultValueSql("1");

                entity.Property(e => e.DiscountApplyTo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'Order'");

                entity.Property(e => e.DiscountCustomerRestriction).HasMaxLength(200);

                entity.Property(e => e.DiscountDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.DiscountEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.DiscountGuid).HasColumnName("DiscountGUID");

                entity.Property(e => e.DiscountIsFlat).HasDefaultValueSql("0");

                entity.Property(e => e.DiscountName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DiscountOrder).HasDefaultValueSql("1");

                entity.Property(e => e.DiscountRoles).HasMaxLength(400);

                entity.Property(e => e.DiscountSiteId).HasColumnName("DiscountSiteID");

                entity.Property(e => e.DiscountUsesCoupons).HasDefaultValueSql("0");

                entity.Property(e => e.DiscountValue).HasDefaultValueSql("0");

                entity.HasOne(d => d.DiscountSite)
                    .WithMany(p => p.ComDiscount)
                    .HasForeignKey(d => d.DiscountSiteId)
                    .HasConstraintName("FK_COM_Discount_DiscountSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComDiscountCoupon>(entity =>
            {
                entity.HasKey(e => e.DiscountCouponId)
                    .HasName("PK_COM_DiscountCoupon");

                entity.ToTable("COM_DiscountCoupon");

                entity.HasIndex(e => e.DiscountCouponCode)
                    .HasName("IX_COM_DiscountCoupon_DiscountCouponCode");

                entity.HasIndex(e => e.DiscountCouponDisplayName)
                    .HasName("IX_COM_DiscountCoupon_DiscoutCouponDisplayName");

                entity.HasIndex(e => e.DiscountCouponSiteId)
                    .HasName("IX_COM_DiscountCoupon_DiscountCouponSiteID");

                entity.Property(e => e.DiscountCouponId).HasColumnName("DiscountCouponID");

                entity.Property(e => e.DiscountCouponCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.DiscountCouponDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.DiscountCouponGuid).HasColumnName("DiscountCouponGUID");

                entity.Property(e => e.DiscountCouponIsExcluded).HasDefaultValueSql("0");

                entity.Property(e => e.DiscountCouponIsFlatValue).HasDefaultValueSql("0");

                entity.Property(e => e.DiscountCouponSiteId).HasColumnName("DiscountCouponSiteID");

                entity.Property(e => e.DiscountCouponValue).HasDefaultValueSql("0");

                entity.HasOne(d => d.DiscountCouponSite)
                    .WithMany(p => p.ComDiscountCoupon)
                    .HasForeignKey(d => d.DiscountCouponSiteId)
                    .HasConstraintName("FK_COM_DiscountCoupon_DiscountCouponSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComExchangeTable>(entity =>
            {
                entity.HasKey(e => e.ExchangeTableId)
                    .HasName("PK_COM_ExchangeTable");

                entity.ToTable("COM_ExchangeTable");

                entity.HasIndex(e => e.ExchangeTableSiteId)
                    .HasName("IX_COM_ExchangeTable_ExchangeTableSiteID");

                entity.HasIndex(e => new { e.ExchangeTableValidFrom, e.ExchangeTableValidTo })
                    .HasName("IX_COM_ExchangeTable_ExchangeTableValidFrom_ExchangeTableValidTo");

                entity.Property(e => e.ExchangeTableId).HasColumnName("ExchangeTableID");

                entity.Property(e => e.ExchangeTableDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ExchangeTableGuid).HasColumnName("ExchangeTableGUID");

                entity.Property(e => e.ExchangeTableSiteId).HasColumnName("ExchangeTableSiteID");

                entity.HasOne(d => d.ExchangeTableSite)
                    .WithMany(p => p.ComExchangeTable)
                    .HasForeignKey(d => d.ExchangeTableSiteId)
                    .HasConstraintName("FK_COM_ExchangeTable_ExchangeTableSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComInternalStatus>(entity =>
            {
                entity.HasKey(e => e.InternalStatusId)
                    .HasName("PK_COM_InternalStatus");

                entity.ToTable("COM_InternalStatus");

                entity.HasIndex(e => e.InternalStatusSiteId)
                    .HasName("IX_COM_InternalStatus_InternalStatusSiteID");

                entity.HasIndex(e => new { e.InternalStatusDisplayName, e.InternalStatusEnabled })
                    .HasName("IX_COM_InternalStatus_InternalStatusDisplayName_InternalStatusEnabled");

                entity.Property(e => e.InternalStatusId).HasColumnName("InternalStatusID");

                entity.Property(e => e.InternalStatusDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.InternalStatusEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.InternalStatusGuid)
                    .HasColumnName("InternalStatusGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.InternalStatusLastModified).HasDefaultValueSql("'9/20/2012 2:45:44 PM'");

                entity.Property(e => e.InternalStatusName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.InternalStatusSiteId).HasColumnName("InternalStatusSiteID");

                entity.HasOne(d => d.InternalStatusSite)
                    .WithMany(p => p.ComInternalStatus)
                    .HasForeignKey(d => d.InternalStatusSiteId)
                    .HasConstraintName("FK_COM_InternalStatus_InternalStatusSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComManufacturer>(entity =>
            {
                entity.HasKey(e => e.ManufacturerId)
                    .HasName("PK_COM_Manufacturer");

                entity.ToTable("COM_Manufacturer");

                entity.HasIndex(e => e.ManufacturerSiteId)
                    .HasName("IX_COM_Manufacturer_ManufacturerSiteID");

                entity.HasIndex(e => new { e.ManufacturerDisplayName, e.ManufacturerEnabled })
                    .HasName("IX_COM_Manufacturer_ManufacturerDisplayName_ManufacturerEnabled");

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.ManufactureHomepage).HasMaxLength(400);

                entity.Property(e => e.ManufacturerDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ManufacturerEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.ManufacturerGuid)
                    .HasColumnName("ManufacturerGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.ManufacturerLastModified).HasDefaultValueSql("'1/1/0001 12:00:00 AM'");

                entity.Property(e => e.ManufacturerName).HasMaxLength(200);

                entity.Property(e => e.ManufacturerSiteId).HasColumnName("ManufacturerSiteID");

                entity.Property(e => e.ManufacturerThumbnailGuid).HasColumnName("ManufacturerThumbnailGUID");

                entity.HasOne(d => d.ManufacturerSite)
                    .WithMany(p => p.ComManufacturer)
                    .HasForeignKey(d => d.ManufacturerSiteId)
                    .HasConstraintName("FK_COM_Manufacturer_ManufacturerSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComMultiBuyCouponCode>(entity =>
            {
                entity.HasKey(e => e.MultiBuyCouponCodeId)
                    .HasName("PK_COM_MultiBuyCouponCode");

                entity.ToTable("COM_MultiBuyCouponCode");

                entity.HasIndex(e => e.MultiBuyCouponCodeMultiBuyDiscountId)
                    .HasName("IX_COM_MultiBuyCouponCode_MultiBuyCouponCodeMultiBuyDiscountID");

                entity.Property(e => e.MultiBuyCouponCodeId).HasColumnName("MultiBuyCouponCodeID");

                entity.Property(e => e.MultiBuyCouponCodeCode)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.MultiBuyCouponCodeGuid)
                    .HasColumnName("MultiBuyCouponCodeGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.MultiBuyCouponCodeMultiBuyDiscountId)
                    .HasColumnName("MultiBuyCouponCodeMultiBuyDiscountID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MultiBuyCouponCodeUseCount).HasDefaultValueSql("0");

                entity.HasOne(d => d.MultiBuyCouponCodeMultiBuyDiscount)
                    .WithMany(p => p.ComMultiBuyCouponCode)
                    .HasForeignKey(d => d.MultiBuyCouponCodeMultiBuyDiscountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_MultiBuyCouponCode_MultiBuyCouponCodeMultiBuyDiscountID_COM_MultiBuyDiscount");
            });

            modelBuilder.Entity<ComMultiBuyDiscount>(entity =>
            {
                entity.HasKey(e => e.MultiBuyDiscountId)
                    .HasName("PK_COM_MultiBuyDiscount");

                entity.ToTable("COM_MultiBuyDiscount");

                entity.HasIndex(e => e.MultiBuyDiscountApplyToSkuid)
                    .HasName("IX_COM_MultiBuyDiscount_MultiBuyDiscountApplyToSKUID");

                entity.HasIndex(e => e.MultiBuyDiscountSiteId)
                    .HasName("IX_COM_MultiBuyDiscount_MultiBuyDiscountSiteID");

                entity.Property(e => e.MultiBuyDiscountId).HasColumnName("MultiBuyDiscountID");

                entity.Property(e => e.MultiBuyDiscountApplyFurtherDiscounts).HasDefaultValueSql("1");

                entity.Property(e => e.MultiBuyDiscountApplyToSkuid).HasColumnName("MultiBuyDiscountApplyToSKUID");

                entity.Property(e => e.MultiBuyDiscountAutoAddEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.MultiBuyDiscountCustomerRestriction)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N'All'");

                entity.Property(e => e.MultiBuyDiscountDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MultiBuyDiscountEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.MultiBuyDiscountGuid).HasColumnName("MultiBuyDiscountGUID");

                entity.Property(e => e.MultiBuyDiscountIsFlat).HasDefaultValueSql("1");

                entity.Property(e => e.MultiBuyDiscountMinimumBuyCount).HasDefaultValueSql("1");

                entity.Property(e => e.MultiBuyDiscountName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MultiBuyDiscountRoles).HasMaxLength(400);

                entity.Property(e => e.MultiBuyDiscountSiteId).HasColumnName("MultiBuyDiscountSiteID");

                entity.Property(e => e.MultiBuyDiscountUsesCoupons).HasDefaultValueSql("0");

                entity.HasOne(d => d.MultiBuyDiscountApplyToSku)
                    .WithMany(p => p.ComMultiBuyDiscount)
                    .HasForeignKey(d => d.MultiBuyDiscountApplyToSkuid)
                    .HasConstraintName("FK_COM_MultiBuyDiscount_MultiBuyDiscountApplyToSKUID_COM_SKU");

                entity.HasOne(d => d.MultiBuyDiscountSite)
                    .WithMany(p => p.ComMultiBuyDiscount)
                    .HasForeignKey(d => d.MultiBuyDiscountSiteId)
                    .HasConstraintName("FK_COM_MultiBuyDiscount_MultiBuyDiscountSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComMultiBuyDiscountDepartment>(entity =>
            {
                entity.HasKey(e => new { e.MultiBuyDiscountId, e.DepartmentId })
                    .HasName("PK_COM_MultiBuyDiscountDepartment");

                entity.ToTable("COM_MultiBuyDiscountDepartment");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_COM_MultiBuyDiscountDepartment_DepartmentID");

                entity.Property(e => e.MultiBuyDiscountId).HasColumnName("MultiBuyDiscountID");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ComMultiBuyDiscountDepartment)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_MultiBuyDiscountDepartment_DepartmentID_COM_Department");

                entity.HasOne(d => d.MultiBuyDiscount)
                    .WithMany(p => p.ComMultiBuyDiscountDepartment)
                    .HasForeignKey(d => d.MultiBuyDiscountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_MultiBuyDiscountDepartment_MultiBuyDiscountID_COM_MultiBuyDiscount");
            });

            modelBuilder.Entity<ComMultiBuyDiscountSku>(entity =>
            {
                entity.HasKey(e => new { e.MultiBuyDiscountId, e.Skuid })
                    .HasName("PK_COM_MultiBuyDiscountSKU");

                entity.ToTable("COM_MultiBuyDiscountSKU");

                entity.HasIndex(e => e.Skuid)
                    .HasName("IX_COM_MultiBuyDiscountSKU_SKUID");

                entity.Property(e => e.MultiBuyDiscountId).HasColumnName("MultiBuyDiscountID");

                entity.Property(e => e.Skuid)
                    .HasColumnName("SKUID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.MultiBuyDiscount)
                    .WithMany(p => p.ComMultiBuyDiscountSku)
                    .HasForeignKey(d => d.MultiBuyDiscountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_MultiBuyDiscountSKU_MultiBuyDiscountID_COM_MultiBuyDiscount");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.ComMultiBuyDiscountSku)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_MultiBuyDiscountSKU_SKUID_COM_SKU");
            });

            modelBuilder.Entity<ComOptionCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_COM_OptionCategory");

                entity.ToTable("COM_OptionCategory");

                entity.HasIndex(e => e.CategorySiteId)
                    .HasName("IX_COM_OptionCategory_CategorySiteID");

                entity.HasIndex(e => new { e.CategoryDisplayName, e.CategoryEnabled })
                    .HasName("IX_COM_OptionCategory_CategoryDisplayName_CategoryEnabled");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryDefaultOptions).HasMaxLength(200);

                entity.Property(e => e.CategoryDefaultRecord).HasMaxLength(200);

                entity.Property(e => e.CategoryDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CategoryDisplayPrice).HasDefaultValueSql("1");

                entity.Property(e => e.CategoryEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.CategoryFormControlName).HasMaxLength(200);

                entity.Property(e => e.CategoryGuid).HasColumnName("CategoryGUID");

                entity.Property(e => e.CategoryLiveSiteDisplayName).HasMaxLength(200);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CategorySelectionType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.CategorySiteId).HasColumnName("CategorySiteID");

                entity.Property(e => e.CategoryType).HasMaxLength(20);

                entity.HasOne(d => d.CategorySite)
                    .WithMany(p => p.ComOptionCategory)
                    .HasForeignKey(d => d.CategorySiteId)
                    .HasConstraintName("FK_COM_OptionCategory_CategorySiteID_CMS_Site");
            });

            modelBuilder.Entity<ComOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK_COM_Order");

                entity.ToTable("COM_Order");

                entity.HasIndex(e => e.OrderBillingAddressId)
                    .HasName("IX_COM_Order_OrderBillingAddressID");

                entity.HasIndex(e => e.OrderCompanyAddressId)
                    .HasName("IX_COM_Order_OrderCompanyAddressID");

                entity.HasIndex(e => e.OrderCreatedByUserId)
                    .HasName("IX_COM_Order_OrderCreatedByUserID");

                entity.HasIndex(e => e.OrderCurrencyId)
                    .HasName("IX_COM_Order_OrderCurrencyID");

                entity.HasIndex(e => e.OrderCustomerId)
                    .HasName("IX_COM_Order_OrderCustomerID");

                entity.HasIndex(e => e.OrderDiscountCouponId)
                    .HasName("IX_COM_Order_OrderDiscountCouponID");

                entity.HasIndex(e => e.OrderPaymentOptionId)
                    .HasName("IX_COM_Order_OrderPaymentOptionID");

                entity.HasIndex(e => e.OrderShippingAddressId)
                    .HasName("IX_COM_Order_OrderShippingAddressID");

                entity.HasIndex(e => e.OrderShippingOptionId)
                    .HasName("IX_COM_Order_OrderShippingOptionID");

                entity.HasIndex(e => e.OrderSiteId)
                    .HasName("IX_COM_Order_OrderSiteID");

                entity.HasIndex(e => e.OrderStatusId)
                    .HasName("IX_COM_Order_OrderStatusID");

                entity.HasIndex(e => new { e.OrderSiteId, e.OrderDate })
                    .HasName("IX_COM_Order_OrderSiteID_OrderDate");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderBillingAddressId)
                    .HasColumnName("OrderBillingAddressID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OrderCompanyAddressId).HasColumnName("OrderCompanyAddressID");

                entity.Property(e => e.OrderCouponCode).HasMaxLength(200);

                entity.Property(e => e.OrderCreatedByUserId).HasColumnName("OrderCreatedByUserID");

                entity.Property(e => e.OrderCulture).HasMaxLength(10);

                entity.Property(e => e.OrderCurrencyId).HasColumnName("OrderCurrencyID");

                entity.Property(e => e.OrderCustomerId).HasColumnName("OrderCustomerID");

                entity.Property(e => e.OrderDiscountCouponId).HasColumnName("OrderDiscountCouponID");

                entity.Property(e => e.OrderGuid)
                    .HasColumnName("OrderGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.OrderInvoiceNumber).HasMaxLength(200);

                entity.Property(e => e.OrderPaymentOptionId).HasColumnName("OrderPaymentOptionID");

                entity.Property(e => e.OrderShippingAddressId).HasColumnName("OrderShippingAddressID");

                entity.Property(e => e.OrderShippingOptionId).HasColumnName("OrderShippingOptionID");

                entity.Property(e => e.OrderSiteId).HasColumnName("OrderSiteID");

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.OrderTrackingNumber).HasMaxLength(100);

                entity.HasOne(d => d.OrderBillingAddress)
                    .WithMany(p => p.ComOrderOrderBillingAddress)
                    .HasForeignKey(d => d.OrderBillingAddressId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_Order_OrderBillingAddressID_COM_OrderAdress");

                entity.HasOne(d => d.OrderCompanyAddress)
                    .WithMany(p => p.ComOrderOrderCompanyAddress)
                    .HasForeignKey(d => d.OrderCompanyAddressId)
                    .HasConstraintName("FK_COM_Order_OrderCompanyAddressID_COM_OrderAddress");

                entity.HasOne(d => d.OrderCreatedByUser)
                    .WithMany(p => p.ComOrder)
                    .HasForeignKey(d => d.OrderCreatedByUserId)
                    .HasConstraintName("FK_COM_Order_OrderCreatedByUserID_CMS_User");

                entity.HasOne(d => d.OrderCurrency)
                    .WithMany(p => p.ComOrder)
                    .HasForeignKey(d => d.OrderCurrencyId)
                    .HasConstraintName("FK_COM_Order_OrderCurrencyID_COM_Currency");

                entity.HasOne(d => d.OrderCustomer)
                    .WithMany(p => p.ComOrder)
                    .HasForeignKey(d => d.OrderCustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_Order_OrderCustomerID_COM_Customer");

                entity.HasOne(d => d.OrderDiscountCoupon)
                    .WithMany(p => p.ComOrder)
                    .HasForeignKey(d => d.OrderDiscountCouponId)
                    .HasConstraintName("FK_COM_Order_OrderDiscountCouponID_COM_DiscountCoupon");

                entity.HasOne(d => d.OrderPaymentOption)
                    .WithMany(p => p.ComOrder)
                    .HasForeignKey(d => d.OrderPaymentOptionId)
                    .HasConstraintName("FK_COM_Order_OrderPaymentOptionID_COM_PaymentOption");

                entity.HasOne(d => d.OrderShippingAddress)
                    .WithMany(p => p.ComOrderOrderShippingAddress)
                    .HasForeignKey(d => d.OrderShippingAddressId)
                    .HasConstraintName("FK_COM_Order_OrderShippingAddressID_COM_OrderAddress");

                entity.HasOne(d => d.OrderShippingOption)
                    .WithMany(p => p.ComOrder)
                    .HasForeignKey(d => d.OrderShippingOptionId)
                    .HasConstraintName("FK_COM_Order_OrderShippingOptionID_COM_ShippingOption");

                entity.HasOne(d => d.OrderSite)
                    .WithMany(p => p.ComOrder)
                    .HasForeignKey(d => d.OrderSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_Order_OrderSiteID_CMS_Site");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.ComOrder)
                    .HasForeignKey(d => d.OrderStatusId)
                    .HasConstraintName("FK_COM_Order_OrderStatusID_COM_Status");
            });

            modelBuilder.Entity<ComOrderAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK_COM_OrderAddress");

                entity.ToTable("COM_OrderAddress");

                entity.HasIndex(e => e.AddressCountryId)
                    .HasName("IX_COM_OrderAddress_AddressCountryID");

                entity.HasIndex(e => e.AddressStateId)
                    .HasName("IX_COM_OrderAddress_AddressStateID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressCity)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AddressCountryId).HasColumnName("AddressCountryID");

                entity.Property(e => e.AddressGuid).HasColumnName("AddressGUID");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AddressLine2).HasMaxLength(100);

                entity.Property(e => e.AddressPersonalName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AddressPhone).HasMaxLength(26);

                entity.Property(e => e.AddressStateId).HasColumnName("AddressStateID");

                entity.Property(e => e.AddressZip)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.AddressCountry)
                    .WithMany(p => p.ComOrderAddress)
                    .HasForeignKey(d => d.AddressCountryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_OrderAddress_AddressCountryID_CMS_Country");

                entity.HasOne(d => d.AddressState)
                    .WithMany(p => p.ComOrderAddress)
                    .HasForeignKey(d => d.AddressStateId)
                    .HasConstraintName("FK_COM_OrderAddress_AddressStateID_CMS_State");
            });

            modelBuilder.Entity<ComOrderItem>(entity =>
            {
                entity.HasKey(e => e.OrderItemId)
                    .HasName("PK_COM_OrderItem");

                entity.ToTable("COM_OrderItem");

                entity.HasIndex(e => e.OrderItemOrderId)
                    .HasName("IX_COM_OrderItem_OrderItemOrderID");

                entity.HasIndex(e => e.OrderItemSkuid)
                    .HasName("IX_COM_OrderItem_OrderItemSKUID");

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.Property(e => e.OrderItemBundleGuid).HasColumnName("OrderItemBundleGUID");

                entity.Property(e => e.OrderItemGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.OrderItemOrderId).HasColumnName("OrderItemOrderID");

                entity.Property(e => e.OrderItemSku).HasColumnName("OrderItemSKU");

                entity.Property(e => e.OrderItemSkuid).HasColumnName("OrderItemSKUID");

                entity.Property(e => e.OrderItemSkuname)
                    .IsRequired()
                    .HasColumnName("OrderItemSKUName")
                    .HasMaxLength(450);

                entity.HasOne(d => d.OrderItemOrder)
                    .WithMany(p => p.ComOrderItem)
                    .HasForeignKey(d => d.OrderItemOrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_OrderItem_OrderItemOrderID_COM_Order");

                entity.HasOne(d => d.OrderItemSkuNavigation)
                    .WithMany(p => p.ComOrderItem)
                    .HasForeignKey(d => d.OrderItemSkuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_OrderItem_OrderItemSKUID_COM_SKU");
            });

            modelBuilder.Entity<ComOrderItemSkufile>(entity =>
            {
                entity.HasKey(e => e.OrderItemSkufileId)
                    .HasName("PK_COM_OrderItemSKUFile");

                entity.ToTable("COM_OrderItemSKUFile");

                entity.HasIndex(e => e.FileId)
                    .HasName("IX_COM_OrderItemSKUFile_FileID");

                entity.HasIndex(e => e.OrderItemId)
                    .HasName("IX_COM_OrderItemSKUFile_OrderItemID");

                entity.Property(e => e.OrderItemSkufileId).HasColumnName("OrderItemSKUFileID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.ComOrderItemSkufile)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_OrderItemSKUFile_COM_SKUFile");

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.ComOrderItemSkufile)
                    .HasForeignKey(d => d.OrderItemId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_OrderItemSKUFile_COM_OrderItem");
            });

            modelBuilder.Entity<ComOrderStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK_COM_OrderStatus");

                entity.ToTable("COM_OrderStatus");

                entity.HasIndex(e => e.StatusSiteId)
                    .HasName("IX_COM_OrderStatus_StatusSiteID");

                entity.HasIndex(e => new { e.StatusOrder, e.StatusDisplayName, e.StatusEnabled })
                    .HasName("IX_COM_OrderStatus_StatusOrder_StatusDisplayName_StatusEnabled");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusColor).HasMaxLength(7);

                entity.Property(e => e.StatusDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.StatusEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.StatusGuid)
                    .HasColumnName("StatusGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.StatusSendNotification).HasDefaultValueSql("0");

                entity.Property(e => e.StatusSiteId).HasColumnName("StatusSiteID");

                entity.HasOne(d => d.StatusSite)
                    .WithMany(p => p.ComOrderStatus)
                    .HasForeignKey(d => d.StatusSiteId)
                    .HasConstraintName("FK_COM_OrderStatus_StatusSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComOrderStatusUser>(entity =>
            {
                entity.HasKey(e => e.OrderStatusUserId)
                    .HasName("PK_COM_OrderStatusUser");

                entity.ToTable("COM_OrderStatusUser");

                entity.HasIndex(e => e.ChangedByUserId)
                    .HasName("IX_COM_OrderStatusUser_ChangedByUserID");

                entity.HasIndex(e => e.FromStatusId)
                    .HasName("IX_COM_OrderStatusUser_FromStatusID");

                entity.HasIndex(e => e.ToStatusId)
                    .HasName("IX_COM_OrderStatusUser_ToStatusID");

                entity.HasIndex(e => new { e.OrderId, e.Date })
                    .HasName("IX_COM_OrderStatusUser_OrderID_Date");

                entity.Property(e => e.OrderStatusUserId).HasColumnName("OrderStatusUserID");

                entity.Property(e => e.ChangedByUserId).HasColumnName("ChangedByUserID");

                entity.Property(e => e.FromStatusId).HasColumnName("FromStatusID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ToStatusId).HasColumnName("ToStatusID");

                entity.HasOne(d => d.ChangedByUser)
                    .WithMany(p => p.ComOrderStatusUser)
                    .HasForeignKey(d => d.ChangedByUserId)
                    .HasConstraintName("FK_COM_OrderStatusUser_ChangedByUserID_CMS_User");

                entity.HasOne(d => d.FromStatus)
                    .WithMany(p => p.ComOrderStatusUserFromStatus)
                    .HasForeignKey(d => d.FromStatusId)
                    .HasConstraintName("FK_COM_OrderStatusUser_FromStatusID_COM_Status");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ComOrderStatusUser)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_OrderStatusUser_OrderID_COM_Order");

                entity.HasOne(d => d.ToStatus)
                    .WithMany(p => p.ComOrderStatusUserToStatus)
                    .HasForeignKey(d => d.ToStatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_OrderStatusUser_ToStatusID_COM_Status");
            });

            modelBuilder.Entity<ComPaymentOption>(entity =>
            {
                entity.HasKey(e => e.PaymentOptionId)
                    .HasName("PK_COM_PaymentOption");

                entity.ToTable("COM_PaymentOption");

                entity.HasIndex(e => e.PaymentOptionFailedOrderStatusId)
                    .HasName("IX_COM_PaymentOption_PaymentOptionFailedOrderStatusID");

                entity.HasIndex(e => e.PaymentOptionSiteId)
                    .HasName("IX_COM_PaymentOption_PaymentOptionSiteID");

                entity.HasIndex(e => e.PaymentOptionSucceededOrderStatusId)
                    .HasName("IX_COM_PaymentOption_PaymentOptionSucceededOrderStatusID");

                entity.HasIndex(e => new { e.PaymentOptionSiteId, e.PaymentOptionDisplayName, e.PaymentOptionEnabled })
                    .HasName("IX_COM_PaymentOption_PaymentOptionSiteID_PaymentOptionDisplayName_PaymentOptionEnabled");

                entity.Property(e => e.PaymentOptionId).HasColumnName("PaymentOptionID");

                entity.Property(e => e.PaymentOptionAllowIfNoShipping).HasDefaultValueSql("0");

                entity.Property(e => e.PaymentOptionAssemblyName).HasMaxLength(200);

                entity.Property(e => e.PaymentOptionClassName).HasMaxLength(200);

                entity.Property(e => e.PaymentOptionDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.PaymentOptionEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.PaymentOptionFailedOrderStatusId).HasColumnName("PaymentOptionFailedOrderStatusID");

                entity.Property(e => e.PaymentOptionGuid)
                    .HasColumnName("PaymentOptionGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.PaymentOptionLastModified).HasDefaultValueSql("'9/27/2012 4:18:26 PM'");

                entity.Property(e => e.PaymentOptionName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.PaymentOptionPaymentGateUrl).HasMaxLength(500);

                entity.Property(e => e.PaymentOptionSiteId).HasColumnName("PaymentOptionSiteID");

                entity.Property(e => e.PaymentOptionSucceededOrderStatusId).HasColumnName("PaymentOptionSucceededOrderStatusID");

                entity.Property(e => e.PaymentOptionThumbnailGuid).HasColumnName("PaymentOptionThumbnailGUID");

                entity.HasOne(d => d.PaymentOptionFailedOrderStatus)
                    .WithMany(p => p.ComPaymentOptionPaymentOptionFailedOrderStatus)
                    .HasForeignKey(d => d.PaymentOptionFailedOrderStatusId)
                    .HasConstraintName("FK_COM_PaymentOption_PaymentOptionFailedOrderStatusID_COM_OrderStatus");

                entity.HasOne(d => d.PaymentOptionSite)
                    .WithMany(p => p.ComPaymentOption)
                    .HasForeignKey(d => d.PaymentOptionSiteId)
                    .HasConstraintName("FK_COM_PaymentOption_PaymentOptionSiteID_CMS_Site");

                entity.HasOne(d => d.PaymentOptionSucceededOrderStatus)
                    .WithMany(p => p.ComPaymentOptionPaymentOptionSucceededOrderStatus)
                    .HasForeignKey(d => d.PaymentOptionSucceededOrderStatusId)
                    .HasConstraintName("FK_COM_PaymentOption_PaymentOptionSucceededOrderStatusID_COM_OrderStatus");
            });

            modelBuilder.Entity<ComPublicStatus>(entity =>
            {
                entity.HasKey(e => e.PublicStatusId)
                    .HasName("PK_COM_PublicStatus");

                entity.ToTable("COM_PublicStatus");

                entity.HasIndex(e => e.PublicStatusSiteId)
                    .HasName("IX_COM_PublicStatus_PublicStatusSiteID");

                entity.HasIndex(e => new { e.PublicStatusDisplayName, e.PublicStatusEnabled })
                    .HasName("IX_COM_PublicStatus_PublicStatusDisplayName_PublicStatusEnabled");

                entity.Property(e => e.PublicStatusId).HasColumnName("PublicStatusID");

                entity.Property(e => e.PublicStatusDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.PublicStatusEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.PublicStatusGuid).HasColumnName("PublicStatusGUID");

                entity.Property(e => e.PublicStatusName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.PublicStatusSiteId).HasColumnName("PublicStatusSiteID");

                entity.HasOne(d => d.PublicStatusSite)
                    .WithMany(p => p.ComPublicStatus)
                    .HasForeignKey(d => d.PublicStatusSiteId)
                    .HasConstraintName("FK_COM_PublicStatus_PublicStatusSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComShippingCost>(entity =>
            {
                entity.HasKey(e => e.ShippingCostId)
                    .HasName("PK__COM_ShippingCost");

                entity.ToTable("COM_ShippingCost");

                entity.HasIndex(e => e.ShippingCostShippingOptionId)
                    .HasName("IX_COM_ShippingCost_ShippingCostShippingOptionID");

                entity.Property(e => e.ShippingCostId).HasColumnName("ShippingCostID");

                entity.Property(e => e.ShippingCostGuid).HasColumnName("ShippingCostGUID");

                entity.Property(e => e.ShippingCostMinWeight).HasDefaultValueSql("0");

                entity.Property(e => e.ShippingCostShippingOptionId).HasColumnName("ShippingCostShippingOptionID");

                entity.Property(e => e.ShippingCostValue).HasDefaultValueSql("0");

                entity.HasOne(d => d.ShippingCostShippingOption)
                    .WithMany(p => p.ComShippingCost)
                    .HasForeignKey(d => d.ShippingCostShippingOptionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_ShippingCost_ShippingCostShippingOptionID_COM_ShippingOption");
            });

            modelBuilder.Entity<ComShippingOption>(entity =>
            {
                entity.HasKey(e => e.ShippingOptionId)
                    .HasName("PK_COM_ShippingOption");

                entity.ToTable("COM_ShippingOption");

                entity.HasIndex(e => e.ShippingOptionCarrierId)
                    .HasName("IX_COM_ShippingOption_ShippingOptionCarrierID");

                entity.HasIndex(e => e.ShippingOptionDisplayName)
                    .HasName("IX_COM_ShippingOptionDisplayName");

                entity.HasIndex(e => e.ShippingOptionSiteId)
                    .HasName("IX_COM_ShippingOption_ShippingOptionSiteID_ShippingOptionDisplayName_ShippingOptionEnabled");

                entity.Property(e => e.ShippingOptionId).HasColumnName("ShippingOptionID");

                entity.Property(e => e.ShippingOptionCarrierId).HasColumnName("ShippingOptionCarrierID");

                entity.Property(e => e.ShippingOptionCarrierServiceName).HasMaxLength(200);

                entity.Property(e => e.ShippingOptionDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ShippingOptionEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.ShippingOptionGuid)
                    .HasColumnName("ShippingOptionGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.ShippingOptionLastModified).HasDefaultValueSql("'9/26/2012 12:44:18 PM'");

                entity.Property(e => e.ShippingOptionName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ShippingOptionSiteId).HasColumnName("ShippingOptionSiteID");

                entity.Property(e => e.ShippingOptionThumbnailGuid).HasColumnName("ShippingOptionThumbnailGUID");

                entity.HasOne(d => d.ShippingOptionCarrier)
                    .WithMany(p => p.ComShippingOption)
                    .HasForeignKey(d => d.ShippingOptionCarrierId)
                    .HasConstraintName("FK_COM_ShippingOption_ShippingOptionCarrierID_COM_Carrier");

                entity.HasOne(d => d.ShippingOptionSite)
                    .WithMany(p => p.ComShippingOption)
                    .HasForeignKey(d => d.ShippingOptionSiteId)
                    .HasConstraintName("FK_COM_ShippingOption_ShippingOptionSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComShippingOptionTaxClass>(entity =>
            {
                entity.HasKey(e => new { e.ShippingOptionId, e.TaxClassId })
                    .HasName("PK_COM_ShippingOptionTaxClass");

                entity.ToTable("COM_ShippingOptionTaxClass");

                entity.HasIndex(e => e.TaxClassId)
                    .HasName("IX_COM_ShippingOptionTaxClass_TaxClassID");

                entity.Property(e => e.ShippingOptionId).HasColumnName("ShippingOptionID");

                entity.Property(e => e.TaxClassId).HasColumnName("TaxClassID");

                entity.HasOne(d => d.ShippingOption)
                    .WithMany(p => p.ComShippingOptionTaxClass)
                    .HasForeignKey(d => d.ShippingOptionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_ShippingOptionTaxClass_ShippingOptionID_COM_ShippingOption");

                entity.HasOne(d => d.TaxClass)
                    .WithMany(p => p.ComShippingOptionTaxClass)
                    .HasForeignKey(d => d.TaxClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_ShippingOptionTaxClass_TaxClassID_COM_TaxClass");
            });

            modelBuilder.Entity<ComShoppingCart>(entity =>
            {
                entity.HasKey(e => e.ShoppingCartId)
                    .HasName("PK_COM_ShoppingCart");

                entity.ToTable("COM_ShoppingCart");

                entity.HasIndex(e => e.ShoppingCartBillingAddressId)
                    .HasName("IX_COM_ShoppingCart_ShoppingCartBillingAddressID");

                entity.HasIndex(e => e.ShoppingCartCompanyAddressId)
                    .HasName("IX_COM_ShoppingCart_ShoppingCartCompanyAddressID");

                entity.HasIndex(e => e.ShoppingCartCurrencyId)
                    .HasName("IX_COM_ShoppingCart_ShoppingCartCurrencyID");

                entity.HasIndex(e => e.ShoppingCartCustomerId)
                    .HasName("IX_COM_ShoppingCart_ShoppingCartCustomerID");

                entity.HasIndex(e => e.ShoppingCartDiscountCouponId)
                    .HasName("IX_COM_ShoppingCart_ShoppingCartDiscountCouponID");

                entity.HasIndex(e => e.ShoppingCartGuid)
                    .HasName("IX_COM_ShoppingCart_ShoppingCartSiteID_ShoppingCartGUID");

                entity.HasIndex(e => e.ShoppingCartLastUpdate)
                    .HasName("IX_COM_ShoppingCart_ShoppingCartLastUpdate");

                entity.HasIndex(e => e.ShoppingCartPaymentOptionId)
                    .HasName("IX_COM_ShoppingCart_ShoppingCartPaymentOptionID");

                entity.HasIndex(e => e.ShoppingCartShippingAddressId)
                    .HasName("IX_COM_ShoppingCart_ShoppingCartShippingAddressID");

                entity.HasIndex(e => e.ShoppingCartShippingOptionId)
                    .HasName("IX_COM_ShoppingCart_ShoppingCartShippingOptionID");

                entity.HasIndex(e => e.ShoppingCartSiteId)
                    .HasName("IX_COM_ShoppingCart_ShoppingCartSiteID");

                entity.HasIndex(e => e.ShoppingCartUserId)
                    .HasName("IX_COM_ShoppingCart_ShoppingCartUserID");

                entity.Property(e => e.ShoppingCartId).HasColumnName("ShoppingCartID");

                entity.Property(e => e.ShoppingCartBillingAddressId).HasColumnName("ShoppingCartBillingAddressID");

                entity.Property(e => e.ShoppingCartCompanyAddressId).HasColumnName("ShoppingCartCompanyAddressID");

                entity.Property(e => e.ShoppingCartContactId).HasColumnName("ShoppingCartContactID");

                entity.Property(e => e.ShoppingCartCouponCode).HasMaxLength(200);

                entity.Property(e => e.ShoppingCartCurrencyId).HasColumnName("ShoppingCartCurrencyID");

                entity.Property(e => e.ShoppingCartCustomerId).HasColumnName("ShoppingCartCustomerID");

                entity.Property(e => e.ShoppingCartDiscountCouponId).HasColumnName("ShoppingCartDiscountCouponID");

                entity.Property(e => e.ShoppingCartGuid)
                    .HasColumnName("ShoppingCartGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.ShoppingCartPaymentOptionId).HasColumnName("ShoppingCartPaymentOptionID");

                entity.Property(e => e.ShoppingCartShippingAddressId).HasColumnName("ShoppingCartShippingAddressID");

                entity.Property(e => e.ShoppingCartShippingOptionId).HasColumnName("ShoppingCartShippingOptionID");

                entity.Property(e => e.ShoppingCartSiteId).HasColumnName("ShoppingCartSiteID");

                entity.Property(e => e.ShoppingCartUserId).HasColumnName("ShoppingCartUserID");

                entity.HasOne(d => d.ShoppingCartBillingAddress)
                    .WithMany(p => p.ComShoppingCartShoppingCartBillingAddress)
                    .HasForeignKey(d => d.ShoppingCartBillingAddressId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartBillingAddressID_COM_Address");

                entity.HasOne(d => d.ShoppingCartCompanyAddress)
                    .WithMany(p => p.ComShoppingCartShoppingCartCompanyAddress)
                    .HasForeignKey(d => d.ShoppingCartCompanyAddressId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartCompanyAddressID_COM_Address");

                entity.HasOne(d => d.ShoppingCartCurrency)
                    .WithMany(p => p.ComShoppingCart)
                    .HasForeignKey(d => d.ShoppingCartCurrencyId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartCurrencyID_COM_Currency");

                entity.HasOne(d => d.ShoppingCartCustomer)
                    .WithMany(p => p.ComShoppingCart)
                    .HasForeignKey(d => d.ShoppingCartCustomerId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartCustomerID_COM_Customer");

                entity.HasOne(d => d.ShoppingCartDiscountCoupon)
                    .WithMany(p => p.ComShoppingCart)
                    .HasForeignKey(d => d.ShoppingCartDiscountCouponId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartDiscountCouponID_COM_DiscountCoupon");

                entity.HasOne(d => d.ShoppingCartPaymentOption)
                    .WithMany(p => p.ComShoppingCart)
                    .HasForeignKey(d => d.ShoppingCartPaymentOptionId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartPaymentOptionID_COM_PaymentOption");

                entity.HasOne(d => d.ShoppingCartShippingAddress)
                    .WithMany(p => p.ComShoppingCartShoppingCartShippingAddress)
                    .HasForeignKey(d => d.ShoppingCartShippingAddressId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartShippingAddressID_COM_Address");

                entity.HasOne(d => d.ShoppingCartShippingOption)
                    .WithMany(p => p.ComShoppingCart)
                    .HasForeignKey(d => d.ShoppingCartShippingOptionId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartShippingOptionID_COM_ShippingOption");

                entity.HasOne(d => d.ShoppingCartSite)
                    .WithMany(p => p.ComShoppingCart)
                    .HasForeignKey(d => d.ShoppingCartSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartSiteID_CMS_Site");

                entity.HasOne(d => d.ShoppingCartUser)
                    .WithMany(p => p.ComShoppingCart)
                    .HasForeignKey(d => d.ShoppingCartUserId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartUserID_CMS_User");
            });

            modelBuilder.Entity<ComShoppingCartSku>(entity =>
            {
                entity.HasKey(e => e.CartItemId)
                    .HasName("PK_COM_ShoppingCartSKU");

                entity.ToTable("COM_ShoppingCartSKU");

                entity.HasIndex(e => e.ShoppingCartId)
                    .HasName("IX_COM_ShoppingCartSKU_ShoppingCartID");

                entity.HasIndex(e => e.Skuid)
                    .HasName("IX_COM_ShoppingCartSKU_SKUID");

                entity.Property(e => e.CartItemId).HasColumnName("CartItemID");

                entity.Property(e => e.CartItemAutoAddedUnits).HasDefaultValueSql("0");

                entity.Property(e => e.CartItemBundleGuid).HasColumnName("CartItemBundleGUID");

                entity.Property(e => e.ShoppingCartId).HasColumnName("ShoppingCartID");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");

                entity.Property(e => e.Skuunits).HasColumnName("SKUUnits");

                entity.HasOne(d => d.ShoppingCart)
                    .WithMany(p => p.ComShoppingCartSku)
                    .HasForeignKey(d => d.ShoppingCartId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_ShoppingCartSKU_ShoppingCartID_COM_ShoppingCart");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.ComShoppingCartSku)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_ShoppingCartSKU_SKUID_COM_SKU");
            });

            modelBuilder.Entity<ComSku>(entity =>
            {
                entity.HasKey(e => e.Skuid)
                    .HasName("PK_COM_SKU");

                entity.ToTable("COM_SKU");

                entity.HasIndex(e => e.SkudepartmentId)
                    .HasName("IX_COM_SKU_SKUDepartmentID");

                entity.HasIndex(e => e.SkuinternalStatusId)
                    .HasName("IX_COM_SKU_SKUInternalStatusID");

                entity.HasIndex(e => e.SkumanufacturerId)
                    .HasName("IX_COM_SKU_SKUManufacturerID");

                entity.HasIndex(e => e.Skuname)
                    .HasName("IX_COM_SKU_SKUName");

                entity.HasIndex(e => e.SkuoptionCategoryId)
                    .HasName("IX_COM_SKU_SKUOptionCategoryID");

                entity.HasIndex(e => e.SkuparentSkuid)
                    .HasName("IX_COM_SKU_SKUParentSKUID");

                entity.HasIndex(e => e.Skuprice)
                    .HasName("IX_COM_SKU_SKUPrice");

                entity.HasIndex(e => e.SkupublicStatusId)
                    .HasName("IX_COM_SKU_SKUPublicStatusID");

                entity.HasIndex(e => e.SkusiteId)
                    .HasName("IX_COM_SKU_SKUSiteID");

                entity.HasIndex(e => e.SkusupplierId)
                    .HasName("IX_COM_SKU_SKUSupplierID");

                entity.HasIndex(e => new { e.Skuenabled, e.SkuavailableItems })
                    .HasName("IX_COM_SKU_SKUEnabled_SKUAvailableItems");

                entity.HasIndex(e => new { e.Skuname, e.Skuprice, e.SkupublicStatusId, e.SkuimagePath, e.SkuavailableItems, e.SkusellOnlyAvailable, e.Skuid })
                    .HasName("IX_COM_SKU_SKUID_SKUName_SKUPrice_SKUPublicStatusID_SKUImagePath_SKUAvailableItems_SKUSellOnlyAvailable");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");

                entity.Property(e => e.SkuavailableInDays).HasColumnName("SKUAvailableInDays");

                entity.Property(e => e.SkuavailableItems).HasColumnName("SKUAvailableItems");

                entity.Property(e => e.SkubundleInventoryType)
                    .HasColumnName("SKUBundleInventoryType")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'REMOVEBUNDLE'");

                entity.Property(e => e.SkubundleItemsCount).HasColumnName("SKUBundleItemsCount");

                entity.Property(e => e.SkuconversionName)
                    .HasColumnName("SKUConversionName")
                    .HasMaxLength(100);

                entity.Property(e => e.SkuconversionValue)
                    .HasColumnName("SKUConversionValue")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Skucreated).HasColumnName("SKUCreated");

                entity.Property(e => e.SkucustomData).HasColumnName("SKUCustomData");

                entity.Property(e => e.SkudepartmentId).HasColumnName("SKUDepartmentID");

                entity.Property(e => e.Skudepth).HasColumnName("SKUDepth");

                entity.Property(e => e.Skudescription).HasColumnName("SKUDescription");

                entity.Property(e => e.Skuenabled)
                    .HasColumnName("SKUEnabled")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SkueproductFilesCount).HasColumnName("SKUEproductFilesCount");

                entity.Property(e => e.Skuguid)
                    .HasColumnName("SKUGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.Skuheight).HasColumnName("SKUHeight");

                entity.Property(e => e.SkuimagePath)
                    .HasColumnName("SKUImagePath")
                    .HasMaxLength(450);

                entity.Property(e => e.SkuinStoreFrom).HasColumnName("SKUInStoreFrom");

                entity.Property(e => e.SkuinternalStatusId).HasColumnName("SKUInternalStatusID");

                entity.Property(e => e.SkulastModified).HasColumnName("SKULastModified");

                entity.Property(e => e.SkumanufacturerId).HasColumnName("SKUManufacturerID");

                entity.Property(e => e.SkumaxItemsInOrder).HasColumnName("SKUMaxItemsInOrder");

                entity.Property(e => e.SkumaxPrice).HasColumnName("SKUMaxPrice");

                entity.Property(e => e.SkumembershipGuid).HasColumnName("SKUMembershipGUID");

                entity.Property(e => e.SkuminItemsInOrder).HasColumnName("SKUMinItemsInOrder");

                entity.Property(e => e.SkuminPrice).HasColumnName("SKUMinPrice");

                entity.Property(e => e.Skuname)
                    .IsRequired()
                    .HasColumnName("SKUName")
                    .HasMaxLength(440)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SkuneedsShipping).HasColumnName("SKUNeedsShipping");

                entity.Property(e => e.Skunumber)
                    .HasColumnName("SKUNumber")
                    .HasMaxLength(200);

                entity.Property(e => e.SkuoptionCategoryId).HasColumnName("SKUOptionCategoryID");

                entity.Property(e => e.Skuorder).HasColumnName("SKUOrder");

                entity.Property(e => e.SkuparentSkuid).HasColumnName("SKUParentSKUID");

                entity.Property(e => e.Skuprice)
                    .HasColumnName("SKUPrice")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkuprivateDonation).HasColumnName("SKUPrivateDonation");

                entity.Property(e => e.SkuproductType)
                    .HasColumnName("SKUProductType")
                    .HasMaxLength(50);

                entity.Property(e => e.SkupublicStatusId).HasColumnName("SKUPublicStatusID");

                entity.Property(e => e.SkureorderAt).HasColumnName("SKUReorderAt");

                entity.Property(e => e.SkuretailPrice).HasColumnName("SKURetailPrice");

                entity.Property(e => e.SkusellOnlyAvailable)
                    .HasColumnName("SKUSellOnlyAvailable")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SkushortDescription).HasColumnName("SKUShortDescription");

                entity.Property(e => e.SkusiteId).HasColumnName("SKUSiteID");

                entity.Property(e => e.SkusupplierId).HasColumnName("SKUSupplierID");

                entity.Property(e => e.SkutrackInventory)
                    .HasColumnName("SKUTrackInventory")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("N'ByProduct'");

                entity.Property(e => e.SkuvalidFor).HasColumnName("SKUValidFor");

                entity.Property(e => e.SkuvalidUntil).HasColumnName("SKUValidUntil");

                entity.Property(e => e.Skuvalidity)
                    .HasColumnName("SKUValidity")
                    .HasMaxLength(50);

                entity.Property(e => e.Skuweight).HasColumnName("SKUWeight");

                entity.Property(e => e.Skuwidth).HasColumnName("SKUWidth");

                entity.HasOne(d => d.Skudepartment)
                    .WithMany(p => p.ComSku)
                    .HasForeignKey(d => d.SkudepartmentId)
                    .HasConstraintName("FK_COM_SKU_SKUDepartmentID_COM_Department");

                entity.HasOne(d => d.SkuinternalStatus)
                    .WithMany(p => p.ComSku)
                    .HasForeignKey(d => d.SkuinternalStatusId)
                    .HasConstraintName("FK_COM_SKU_SKUInternalStatusID_COM_InternalStatus");

                entity.HasOne(d => d.Skumanufacturer)
                    .WithMany(p => p.ComSku)
                    .HasForeignKey(d => d.SkumanufacturerId)
                    .HasConstraintName("FK_COM_SKU_SKUManufacturerID_COM_Manifacturer");

                entity.HasOne(d => d.SkuoptionCategory)
                    .WithMany(p => p.ComSku)
                    .HasForeignKey(d => d.SkuoptionCategoryId)
                    .HasConstraintName("FK_COM_SKU_SKUOptionCategoryID_COM_OptionCategory");

                entity.HasOne(d => d.SkuparentSku)
                    .WithMany(p => p.InverseSkuparentSku)
                    .HasForeignKey(d => d.SkuparentSkuid)
                    .HasConstraintName("FK_COM_SKU_SKUParentSKUID_COM_SKU");

                entity.HasOne(d => d.SkupublicStatus)
                    .WithMany(p => p.ComSku)
                    .HasForeignKey(d => d.SkupublicStatusId)
                    .HasConstraintName("FK_COM_SKU_SKUPublicStatusID_COM_PublicStatus");

                entity.HasOne(d => d.Skusite)
                    .WithMany(p => p.ComSku)
                    .HasForeignKey(d => d.SkusiteId)
                    .HasConstraintName("FK_COM_SKU_SKUSiteID_CMS_Site");

                entity.HasOne(d => d.Skusupplier)
                    .WithMany(p => p.ComSku)
                    .HasForeignKey(d => d.SkusupplierId)
                    .HasConstraintName("FK_COM_SKU_SKUSupplierID_COM_Supplier");
            });

            modelBuilder.Entity<ComSkuallowedOption>(entity =>
            {
                entity.HasKey(e => new { e.OptionSkuid, e.Skuid })
                    .HasName("PK_COM_SKUOption");

                entity.ToTable("COM_SKUAllowedOption");

                entity.HasIndex(e => e.Skuid)
                    .HasName("IX_COM_SKUAllowedOption_SKUID");

                entity.Property(e => e.OptionSkuid).HasColumnName("OptionSKUID");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");

                entity.HasOne(d => d.OptionSku)
                    .WithMany(p => p.ComSkuallowedOptionOptionSku)
                    .HasForeignKey(d => d.OptionSkuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_SKUOption_OptionSKUID_COM_SKU");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.ComSkuallowedOptionSku)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_SKUOption_SKUID_COM_SKU");
            });

            modelBuilder.Entity<ComSkudiscountCoupon>(entity =>
            {
                entity.HasKey(e => new { e.Skuid, e.DiscountCouponId })
                    .HasName("PK_COM_SKUDiscountCoupon");

                entity.ToTable("COM_SKUDiscountCoupon");

                entity.HasIndex(e => e.DiscountCouponId)
                    .HasName("IX_COM_SKUDiscountCoupon_DiscountCouponID");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");

                entity.Property(e => e.DiscountCouponId).HasColumnName("DiscountCouponID");

                entity.HasOne(d => d.DiscountCoupon)
                    .WithMany(p => p.ComSkudiscountCoupon)
                    .HasForeignKey(d => d.DiscountCouponId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_SKUDiscountCoupon_DiscountCouponID_COM_DiscountCoupon");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.ComSkudiscountCoupon)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_SKUDiscountCoupon_SKUID_COM_SKU");
            });

            modelBuilder.Entity<ComSkufile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_COM_SKUFile");

                entity.ToTable("COM_SKUFile");

                entity.HasIndex(e => e.FileSkuid)
                    .HasName("IX_COM_SKUFile_FileSKUID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileGuid).HasColumnName("FileGUID");

                entity.Property(e => e.FileMetaFileGuid).HasColumnName("FileMetaFileGUID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.FileSkuid).HasColumnName("FileSKUID");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FileSku)
                    .WithMany(p => p.ComSkufile)
                    .HasForeignKey(d => d.FileSkuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_SKUFile_COM_SKU");
            });

            modelBuilder.Entity<ComSkuoptionCategory>(entity =>
            {
                entity.HasKey(e => e.SkucategoryId)
                    .HasName("PK_COM_SKUOptionCategory");

                entity.ToTable("COM_SKUOptionCategory");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_COM_SKUOptionCategory_CategoryID");

                entity.HasIndex(e => e.Skuid)
                    .HasName("IX_COM_SKUOptionCategory_SKUID");

                entity.Property(e => e.SkucategoryId).HasColumnName("SKUCategoryID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.SkucategoryOrder).HasColumnName("SKUCategoryOrder");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ComSkuoptionCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_SKUOptionCategory_CategoryID_COM_OptionCategory");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.ComSkuoptionCategory)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_SKUOptionCategory_SKUID_COM_SKU");
            });

            modelBuilder.Entity<ComSkutaxClasses>(entity =>
            {
                entity.HasKey(e => new { e.Skuid, e.TaxClassId })
                    .HasName("PK_COM_SKUTaxClasses");

                entity.ToTable("COM_SKUTaxClasses");

                entity.HasIndex(e => e.TaxClassId)
                    .HasName("IX_COM_SKUTaxClasses_TaxClassID");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");

                entity.Property(e => e.TaxClassId).HasColumnName("TaxClassID");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.ComSkutaxClasses)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_SKUTaxClasses_SKUID_COM_SKU");

                entity.HasOne(d => d.TaxClass)
                    .WithMany(p => p.ComSkutaxClasses)
                    .HasForeignKey(d => d.TaxClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_SKUTaxClasses_TaxClassID_COM_TaxClass");
            });

            modelBuilder.Entity<ComSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("PK_COM_Supplier");

                entity.ToTable("COM_Supplier");

                entity.HasIndex(e => e.SupplierSiteId)
                    .HasName("IX_COM_Supplier_SupplierSiteID");

                entity.HasIndex(e => new { e.SupplierDisplayName, e.SupplierEnabled })
                    .HasName("IX_COM_Supplier_SupplierDisplayName_SupplierEnabled");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SupplierEmail).HasMaxLength(254);

                entity.Property(e => e.SupplierEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.SupplierFax).HasMaxLength(50);

                entity.Property(e => e.SupplierGuid)
                    .HasColumnName("SupplierGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.SupplierLastModified).HasDefaultValueSql("'9/21/2012 12:34:09 PM'");

                entity.Property(e => e.SupplierName).HasMaxLength(200);

                entity.Property(e => e.SupplierPhone).HasMaxLength(50);

                entity.Property(e => e.SupplierSiteId).HasColumnName("SupplierSiteID");

                entity.HasOne(d => d.SupplierSite)
                    .WithMany(p => p.ComSupplier)
                    .HasForeignKey(d => d.SupplierSiteId)
                    .HasConstraintName("FK_COM_Supplier_SupplierSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComTaxClass>(entity =>
            {
                entity.HasKey(e => e.TaxClassId)
                    .HasName("PK_COM_TaxClass");

                entity.ToTable("COM_TaxClass");

                entity.HasIndex(e => e.TaxClassDisplayName)
                    .HasName("IX_COM_TaxClass_TaxClassDisplayName");

                entity.HasIndex(e => e.TaxClassSiteId)
                    .HasName("IX_COM_TaxClass_TaxClassSiteID");

                entity.Property(e => e.TaxClassId).HasColumnName("TaxClassID");

                entity.Property(e => e.TaxClassDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.TaxClassGuid)
                    .HasColumnName("TaxClassGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.TaxClassLastModified).HasDefaultValueSql("'9/20/2012 1:31:27 PM'");

                entity.Property(e => e.TaxClassName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.TaxClassSiteId).HasColumnName("TaxClassSiteID");

                entity.Property(e => e.TaxClassZeroIfIdsupplied)
                    .HasColumnName("TaxClassZeroIfIDSupplied")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.TaxClassSite)
                    .WithMany(p => p.ComTaxClass)
                    .HasForeignKey(d => d.TaxClassSiteId)
                    .HasConstraintName("FK_COM_TaxClass_TaxClassSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComTaxClassCountry>(entity =>
            {
                entity.HasKey(e => e.TaxClassCountryId)
                    .HasName("PK_COM_TaxClassCountry");

                entity.ToTable("COM_TaxClassCountry");

                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_COM_TaxClassCountry_CountryID");

                entity.HasIndex(e => new { e.TaxClassId, e.CountryId })
                    .HasName("IX_COM_TaxClassCountry_TaxClassID_CountryID")
                    .IsUnique();

                entity.Property(e => e.TaxClassCountryId).HasColumnName("TaxClassCountryID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.TaxClassId).HasColumnName("TaxClassID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ComTaxClassCountry)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_TaxCategoryCountry_CountryID_CMS_Country");

                entity.HasOne(d => d.TaxClass)
                    .WithMany(p => p.ComTaxClassCountry)
                    .HasForeignKey(d => d.TaxClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_TaxCategoryCountry_TaxClassID_COM_TaxClass");
            });

            modelBuilder.Entity<ComTaxClassState>(entity =>
            {
                entity.HasKey(e => e.TaxClassStateId)
                    .HasName("PK_COM_TaxClassState");

                entity.ToTable("COM_TaxClassState");

                entity.HasIndex(e => e.StateId)
                    .HasName("IX_COM_TaxClassState_StateID");

                entity.HasIndex(e => new { e.TaxClassId, e.StateId })
                    .HasName("IX_COM_TaxClassState_TaxClassID_StateID")
                    .IsUnique();

                entity.Property(e => e.TaxClassStateId).HasColumnName("TaxClassStateID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.TaxClassId).HasColumnName("TaxClassID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.ComTaxClassState)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_TaxClassState_StateID_CMS_State");

                entity.HasOne(d => d.TaxClass)
                    .WithMany(p => p.ComTaxClassState)
                    .HasForeignKey(d => d.TaxClassId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_TaxClassState_TaxClassID_COM_TaxClass");
            });

            modelBuilder.Entity<ComVariantOption>(entity =>
            {
                entity.HasKey(e => new { e.VariantSkuid, e.OptionSkuid })
                    .HasName("PK_COM_VariantOption");

                entity.ToTable("COM_VariantOption");

                entity.HasIndex(e => e.OptionSkuid)
                    .HasName("IX_COM_VariantOption_OptionSKUID");

                entity.Property(e => e.VariantSkuid).HasColumnName("VariantSKUID");

                entity.Property(e => e.OptionSkuid).HasColumnName("OptionSKUID");

                entity.HasOne(d => d.OptionSku)
                    .WithMany(p => p.ComVariantOptionOptionSku)
                    .HasForeignKey(d => d.OptionSkuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_VariantOption_OptionSKUID_COM_SKU");

                entity.HasOne(d => d.VariantSku)
                    .WithMany(p => p.ComVariantOptionVariantSku)
                    .HasForeignKey(d => d.VariantSkuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_VariantOption_VariantSKUID_COM_SKU");
            });

            modelBuilder.Entity<ComVolumeDiscount>(entity =>
            {
                entity.HasKey(e => e.VolumeDiscountId)
                    .HasName("PK_COM_VolumeDiscount");

                entity.ToTable("COM_VolumeDiscount");

                entity.HasIndex(e => e.VolumeDiscountSkuid)
                    .HasName("IX_COM_VolumeDiscount_VolumeDiscountSKUID");

                entity.Property(e => e.VolumeDiscountId).HasColumnName("VolumeDiscountID");

                entity.Property(e => e.VolumeDiscountGuid).HasColumnName("VolumeDiscountGUID");

                entity.Property(e => e.VolumeDiscountMinCount).HasDefaultValueSql("0");

                entity.Property(e => e.VolumeDiscountSkuid).HasColumnName("VolumeDiscountSKUID");

                entity.Property(e => e.VolumeDiscountValue).HasDefaultValueSql("0");

                entity.HasOne(d => d.VolumeDiscountSku)
                    .WithMany(p => p.ComVolumeDiscount)
                    .HasForeignKey(d => d.VolumeDiscountSkuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_VolumeDiscount_VolumeDiscountSKUID_COM_SKU");
            });

            modelBuilder.Entity<ComWishlist>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Skuid, e.SiteId })
                    .HasName("PK_COM_Wishlist");

                entity.ToTable("COM_Wishlist");

                entity.HasIndex(e => e.Skuid)
                    .HasName("IX_COM_Wishlist_SKUID");

                entity.HasIndex(e => new { e.SiteId, e.UserId })
                    .HasName("IX_COM_Wishlist_SiteID_UserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.ComWishlist)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_Wishlist_SiteID_CMS_Site");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.ComWishlist)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_Wishlist_SKUID_COM_SKU");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ComWishlist)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_COM_Wishlist_UserID_CMS_User");
            });

            modelBuilder.Entity<CommunityFriend>(entity =>
            {
                entity.HasKey(e => e.FriendId)
                    .HasName("PK_Community_Friend");

                entity.ToTable("Community_Friend");

                entity.HasIndex(e => e.FriendApprovedBy)
                    .HasName("IX_Community_Friend_FriendApprovedBy");

                entity.HasIndex(e => e.FriendRejectedBy)
                    .HasName("IX_Community_Friend_FriendRejectedBy");

                entity.HasIndex(e => new { e.FriendRequestedUserId, e.FriendStatus })
                    .HasName("IX_Community_Friend_FriendRequestedUserID_FriendStatus");

                entity.HasIndex(e => new { e.FriendRequestedUserId, e.FriendUserId })
                    .HasName("IX_Community_Friend_FriendRequestedUserID_FriendUserID")
                    .IsUnique();

                entity.HasIndex(e => new { e.FriendUserId, e.FriendStatus })
                    .HasName("IX_Community_Friend_FriendUserID_FriendStatus");

                entity.Property(e => e.FriendId).HasColumnName("FriendID");

                entity.Property(e => e.FriendGuid).HasColumnName("FriendGUID");

                entity.Property(e => e.FriendRequestedUserId).HasColumnName("FriendRequestedUserID");

                entity.Property(e => e.FriendStatus).HasDefaultValueSql("0");

                entity.Property(e => e.FriendUserId).HasColumnName("FriendUserID");

                entity.HasOne(d => d.FriendApprovedByNavigation)
                    .WithMany(p => p.CommunityFriendFriendApprovedByNavigation)
                    .HasForeignKey(d => d.FriendApprovedBy)
                    .HasConstraintName("FK_CMS_Friend_FriendApprovedBy_CMS_User");

                entity.HasOne(d => d.FriendRejectedByNavigation)
                    .WithMany(p => p.CommunityFriendFriendRejectedByNavigation)
                    .HasForeignKey(d => d.FriendRejectedBy)
                    .HasConstraintName("FK_CMS_Friend_FriendRejectedBy_CMS_User");

                entity.HasOne(d => d.FriendRequestedUser)
                    .WithMany(p => p.CommunityFriendFriendRequestedUser)
                    .HasForeignKey(d => d.FriendRequestedUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Friend_FriendRequestedUserID_CMS_User");

                entity.HasOne(d => d.FriendUser)
                    .WithMany(p => p.CommunityFriendFriendUser)
                    .HasForeignKey(d => d.FriendUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CMS_Friend_FriendUserID_CMS_User");
            });

            modelBuilder.Entity<CommunityGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_Community_Group");

                entity.ToTable("Community_Group");

                entity.HasIndex(e => e.GroupApproved)
                    .HasName("IX_Community_Group_GroupApproved");

                entity.HasIndex(e => e.GroupApprovedByUserId)
                    .HasName("IX_Community_Group_GroupApprovedByUserID");

                entity.HasIndex(e => e.GroupAvatarId)
                    .HasName("IX_Community_Group_GroupAvatarID");

                entity.HasIndex(e => e.GroupCreatedByUserId)
                    .HasName("IX_Community_Group_GroupCreatedByUserID");

                entity.HasIndex(e => new { e.GroupSiteId, e.GroupDisplayName })
                    .HasName("IX_Community_Group_GroupDisplayName");

                entity.HasIndex(e => new { e.GroupSiteId, e.GroupName })
                    .HasName("IX_Community_Group_GroupSiteID_GroupName");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupApproved).HasDefaultValueSql("0");

                entity.Property(e => e.GroupApprovedByUserId).HasColumnName("GroupApprovedByUserID");

                entity.Property(e => e.GroupAvatarId).HasColumnName("GroupAvatarID");

                entity.Property(e => e.GroupCreatedByUserId).HasColumnName("GroupCreatedByUserID");

                entity.Property(e => e.GroupCreatedWhen).HasDefaultValueSql("'10/21/2008 10:17:56 AM'");

                entity.Property(e => e.GroupDescription).IsRequired();

                entity.Property(e => e.GroupDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.GroupGuid).HasColumnName("GroupGUID");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GroupNodeGuid).HasColumnName("GroupNodeGUID");

                entity.Property(e => e.GroupSecurity).HasDefaultValueSql("444");

                entity.Property(e => e.GroupSendJoinLeaveNotification).HasDefaultValueSql("1");

                entity.Property(e => e.GroupSendWaitingForApprovalNotification).HasDefaultValueSql("1");

                entity.Property(e => e.GroupSiteId).HasColumnName("GroupSiteID");

                entity.HasOne(d => d.GroupApprovedByUser)
                    .WithMany(p => p.CommunityGroupGroupApprovedByUser)
                    .HasForeignKey(d => d.GroupApprovedByUserId)
                    .HasConstraintName("FK_Community_Group_GroupApprovedByUserID_CMS_User");

                entity.HasOne(d => d.GroupAvatar)
                    .WithMany(p => p.CommunityGroup)
                    .HasForeignKey(d => d.GroupAvatarId)
                    .HasConstraintName("FK_Community_Group_GroupAvatarID_CMS_Avatar");

                entity.HasOne(d => d.GroupCreatedByUser)
                    .WithMany(p => p.CommunityGroupGroupCreatedByUser)
                    .HasForeignKey(d => d.GroupCreatedByUserId)
                    .HasConstraintName("FK_Community_Group_GroupCreatedByUserID_CMS_User");

                entity.HasOne(d => d.GroupSite)
                    .WithMany(p => p.CommunityGroup)
                    .HasForeignKey(d => d.GroupSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Community_Group_GroupSiteID_CMS_Site");
            });

            modelBuilder.Entity<CommunityGroupMember>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK_Community_GroupMember");

                entity.ToTable("Community_GroupMember");

                entity.HasIndex(e => e.MemberApprovedByUserId)
                    .HasName("IX_Community_GroupMember_MemberApprovedByUserID");

                entity.HasIndex(e => e.MemberGroupId)
                    .HasName("IX_Community_GroupMember_MemberGroupID");

                entity.HasIndex(e => e.MemberInvitedByUserId)
                    .HasName("IX_Community_GroupMember_MemberInvitedByUserID");

                entity.HasIndex(e => e.MemberJoined)
                    .HasName("IX_Community_GroupMember_MemberJoined");

                entity.HasIndex(e => e.MemberStatus)
                    .HasName("IX_Community_GroupMember_MemberStatus");

                entity.HasIndex(e => e.MemberUserId)
                    .HasName("IX_Community_GroupMember_MemberUserID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.MemberApprovedByUserId).HasColumnName("MemberApprovedByUserID");

                entity.Property(e => e.MemberGroupId).HasColumnName("MemberGroupID");

                entity.Property(e => e.MemberGuid).HasColumnName("MemberGUID");

                entity.Property(e => e.MemberInvitedByUserId).HasColumnName("MemberInvitedByUserID");

                entity.Property(e => e.MemberStatus).HasDefaultValueSql("0");

                entity.Property(e => e.MemberUserId).HasColumnName("MemberUserID");

                entity.HasOne(d => d.MemberApprovedByUser)
                    .WithMany(p => p.CommunityGroupMemberMemberApprovedByUser)
                    .HasForeignKey(d => d.MemberApprovedByUserId)
                    .HasConstraintName("FK_Community_GroupMember_MemberApprovedByUserID_CMS_User");

                entity.HasOne(d => d.MemberGroup)
                    .WithMany(p => p.CommunityGroupMember)
                    .HasForeignKey(d => d.MemberGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Community_GroupMember_MemberGroupID_Community_Group");

                entity.HasOne(d => d.MemberInvitedByUser)
                    .WithMany(p => p.CommunityGroupMemberMemberInvitedByUser)
                    .HasForeignKey(d => d.MemberInvitedByUserId)
                    .HasConstraintName("FK_Community_GroupMember_MemberInvitedByUserID_CMS_User");

                entity.HasOne(d => d.MemberUser)
                    .WithMany(p => p.CommunityGroupMemberMemberUser)
                    .HasForeignKey(d => d.MemberUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Community_GroupMember_MemberUserID_CMS_User");
            });

            modelBuilder.Entity<CommunityGroupRolePermission>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.RoleId, e.PermissionId })
                    .HasName("PK_Community_GroupRolePermission");

                entity.ToTable("Community_GroupRolePermission");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("IX_Community_GroupRolePermission_PermissionID");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_Community_GroupRolePermission_RoleID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("PermissionID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CommunityGroupRolePermission)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_community_GroupRolePermission_GroupID_Community_Group");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.CommunityGroupRolePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_community_GroupRolePermission_PermissionID_CMS_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CommunityGroupRolePermission)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_community_GroupRolePermission_RoleID_CMS_Role");
            });

            modelBuilder.Entity<CommunityInvitation>(entity =>
            {
                entity.HasKey(e => e.InvitationId)
                    .HasName("PK_Community_GroupInvitation");

                entity.ToTable("Community_Invitation");

                entity.HasIndex(e => e.InvitationGroupId)
                    .HasName("IX_Community_Invitation_InvitationGroupID");

                entity.HasIndex(e => e.InvitedByUserId)
                    .HasName("IX_Community_Invitation_InvitedByUserID");

                entity.HasIndex(e => e.InvitedUserId)
                    .HasName("IX_Community_Invitation_InvitedUserID");

                entity.Property(e => e.InvitationId).HasColumnName("InvitationID");

                entity.Property(e => e.InvitationGroupId).HasColumnName("InvitationGroupID");

                entity.Property(e => e.InvitationGuid).HasColumnName("InvitationGUID");

                entity.Property(e => e.InvitationUserEmail).HasMaxLength(254);

                entity.Property(e => e.InvitedByUserId).HasColumnName("InvitedByUserID");

                entity.Property(e => e.InvitedUserId).HasColumnName("InvitedUserID");

                entity.HasOne(d => d.InvitationGroup)
                    .WithMany(p => p.CommunityInvitation)
                    .HasForeignKey(d => d.InvitationGroupId)
                    .HasConstraintName("FK_Community_GroupInvitation_InvitationGroupID_Community_Group");

                entity.HasOne(d => d.InvitedByUser)
                    .WithMany(p => p.CommunityInvitationInvitedByUser)
                    .HasForeignKey(d => d.InvitedByUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Community_GroupInvitation_InvitedByUserID_CMS_User");

                entity.HasOne(d => d.InvitedUser)
                    .WithMany(p => p.CommunityInvitationInvitedUser)
                    .HasForeignKey(d => d.InvitedUserId)
                    .HasConstraintName("FK_Community_GroupInvitation_InvitedUserID_CMS_User");
            });

            modelBuilder.Entity<ContentArticle>(entity =>
            {
                entity.HasKey(e => e.ArticleId)
                    .HasName("PK_CONTENT_Article");

                entity.ToTable("CONTENT_Article");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.ArticleName)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<ContentBlog>(entity =>
            {
                entity.HasKey(e => e.BlogId)
                    .HasName("PK_CONTENT_Blog");

                entity.ToTable("CONTENT_Blog");

                entity.Property(e => e.BlogId).HasColumnName("BlogID");

                entity.Property(e => e.BlogAllowAnonymousComments).HasDefaultValueSql("1");

                entity.Property(e => e.BlogDescription)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.BlogEnableOptIn).HasDefaultValueSql("-1");

                entity.Property(e => e.BlogEnableSubscriptions).HasDefaultValueSql("0");

                entity.Property(e => e.BlogModerateComments).HasDefaultValueSql("0");

                entity.Property(e => e.BlogModerators).HasMaxLength(450);

                entity.Property(e => e.BlogName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.BlogOpenCommentsFor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.BlogOptInApprovalUrl)
                    .HasColumnName("BlogOptInApprovalURL")
                    .HasMaxLength(450);

                entity.Property(e => e.BlogRequireEmails).HasDefaultValueSql("0");

                entity.Property(e => e.BlogSendCommentsToEmail).HasMaxLength(254);

                entity.Property(e => e.BlogSendOptInConfirmation).HasDefaultValueSql("-1");

                entity.Property(e => e.BlogUnsubscriptionUrl).HasMaxLength(250);

                entity.Property(e => e.BlogUseCaptchaforComments)
                    .HasColumnName("BlogUseCAPTCHAForComments")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<ContentBlogMonth>(entity =>
            {
                entity.HasKey(e => e.BlogMonthId)
                    .HasName("PK_CONTENT_BlogMonth");

                entity.ToTable("CONTENT_BlogMonth");

                entity.Property(e => e.BlogMonthId).HasColumnName("BlogMonthID");

                entity.Property(e => e.BlogMonthName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.BlogMonthStartingDate).HasDefaultValueSql("'1/1/0001 12:00:00 AM'");
            });

            modelBuilder.Entity<ContentBlogPost>(entity =>
            {
                entity.HasKey(e => e.BlogPostId)
                    .HasName("PK_CONTENT_BlogPost");

                entity.ToTable("CONTENT_BlogPost");

                entity.Property(e => e.BlogPostId).HasColumnName("BlogPostID");

                entity.Property(e => e.BlogLogActivity).HasDefaultValueSql("1");

                entity.Property(e => e.BlogPostAllowComments).HasDefaultValueSql("1");

                entity.Property(e => e.BlogPostBody)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.BlogPostDate).HasDefaultValueSql("'1/1/0001 12:00:00 AM'");

                entity.Property(e => e.BlogPostTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LinkedInAutoPost).HasMaxLength(200);
            });

            modelBuilder.Entity<ContentBookingEvent>(entity =>
            {
                entity.HasKey(e => e.BookingEventId)
                    .HasName("PK_CONTENT_BookingEvent");

                entity.ToTable("CONTENT_BookingEvent");

                entity.Property(e => e.BookingEventId).HasColumnName("BookingEventID");

                entity.Property(e => e.EventAllDay).HasDefaultValueSql("0");

                entity.Property(e => e.EventAllowRegistrationOverCapacity).HasDefaultValueSql("0");

                entity.Property(e => e.EventLogActivity).HasDefaultValueSql("1");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<ContentEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_CONTENT_Event");

                entity.ToTable("CONTENT_Event");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<ContentFaq>(entity =>
            {
                entity.HasKey(e => e.Faqid)
                    .HasName("PK_CONTENT_FAQ");

                entity.ToTable("CONTENT_FAQ");

                entity.Property(e => e.Faqid).HasColumnName("FAQID");

                entity.Property(e => e.Faqanswer)
                    .IsRequired()
                    .HasColumnName("FAQAnswer")
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.Faqquestion)
                    .IsRequired()
                    .HasColumnName("FAQQuestion")
                    .HasMaxLength(450)
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<ContentFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK__CONTENT___6F0F989F1B863013");

                entity.ToTable("CONTENT_File");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileDescription).HasMaxLength(500);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ContentJob>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("PK_CONTENT_Job");

                entity.ToTable("CONTENT_Job");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<ContentKbarticle>(entity =>
            {
                entity.HasKey(e => e.KbarticleId)
                    .HasName("PK_CONTENT_KBArticle");

                entity.ToTable("CONTENT_KBArticle");

                entity.Property(e => e.KbarticleId).HasColumnName("KBArticleID");

                entity.Property(e => e.ArticleAppliesTo)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ArticleIdentifier).HasMaxLength(200);

                entity.Property(e => e.ArticleName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ArticleSummary)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ArticleText)
                    .IsRequired()
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<ContentMenuItem>(entity =>
            {
                entity.HasKey(e => e.MenuItemId)
                    .HasName("PK_CONTENT_MenuItem");

                entity.ToTable("CONTENT_MenuItem");

                entity.Property(e => e.MenuItemId).HasColumnName("MenuItemID");

                entity.Property(e => e.MenuItemGroup).HasMaxLength(100);

                entity.Property(e => e.MenuItemName)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<ContentNews>(entity =>
            {
                entity.HasKey(e => e.NewsId)
                    .HasName("PK_CONTENT_News");

                entity.ToTable("CONTENT_News");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.NewsReleaseDate).HasDefaultValueSql("'1/1/0001 12:00:00 AM'");

                entity.Property(e => e.NewsSummary)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.NewsTitle)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<ContentOffice>(entity =>
            {
                entity.HasKey(e => e.OfficeId)
                    .HasName("PK_CONTENT_Office");

                entity.ToTable("CONTENT_Office");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.OfficeAddress1).HasMaxLength(400);

                entity.Property(e => e.OfficeAddress2).HasMaxLength(400);

                entity.Property(e => e.OfficeCity).HasMaxLength(400);

                entity.Property(e => e.OfficeCompanyName).HasMaxLength(200);

                entity.Property(e => e.OfficeCountry).HasMaxLength(200);

                entity.Property(e => e.OfficeEmail).HasMaxLength(254);

                entity.Property(e => e.OfficeIconUrl)
                    .HasColumnName("OfficeIconURL")
                    .HasMaxLength(200);

                entity.Property(e => e.OfficeIsHeadquarters).HasDefaultValueSql("0");

                entity.Property(e => e.OfficeName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.OfficePhone).HasMaxLength(100);

                entity.Property(e => e.OfficeState).HasMaxLength(200);

                entity.Property(e => e.OfficeZip)
                    .HasColumnName("OfficeZIP")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ContentPressRelease>(entity =>
            {
                entity.HasKey(e => e.PressReleaseId)
                    .HasName("PK_CONTENT_PressRelease");

                entity.ToTable("CONTENT_PressRelease");

                entity.Property(e => e.PressReleaseId).HasColumnName("PressReleaseID");

                entity.Property(e => e.PressReleaseDate).HasDefaultValueSql("'1/1/0001 12:00:00 AM'");

                entity.Property(e => e.PressReleaseSummary)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.PressReleaseText)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.PressReleaseTitle)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<ContentProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK_CONTENT_Product");

                entity.ToTable("CONTENT_Product");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(440);
            });

            modelBuilder.Entity<ContentSimpleArticle>(entity =>
            {
                entity.HasKey(e => e.ArticleId)
                    .HasName("PK_CONTENT_SimpleArticle");

                entity.ToTable("CONTENT_SimpleArticle");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.ArticleText)
                    .IsRequired()
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ArticleTitle)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<CustomtableSampleTable>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK_customtable_SampleTable");

                entity.ToTable("customtable_SampleTable");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemGuid)
                    .HasColumnName("ItemGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.ItemText)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<EventsAttendee>(entity =>
            {
                entity.HasKey(e => e.AttendeeId)
                    .HasName("PK_Events_Attendee");

                entity.ToTable("Events_Attendee");

                entity.HasIndex(e => e.AttendeeEventNodeId)
                    .HasName("IX_Events_Attendee_AttendeeEventNodeID");

                entity.HasIndex(e => new { e.AttendeeEmail, e.AttendeeFirstName, e.AttendeeLastName })
                    .HasName("IX_Events_Attendee_AttendeeEmail_AttendeeFirstName_AttendeeLastName");

                entity.Property(e => e.AttendeeId).HasColumnName("AttendeeID");

                entity.Property(e => e.AttendeeEmail)
                    .IsRequired()
                    .HasMaxLength(254)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.AttendeeEventNodeId).HasColumnName("AttendeeEventNodeID");

                entity.Property(e => e.AttendeeFirstName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.AttendeeGuid)
                    .HasColumnName("AttendeeGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.AttendeeLastModified).HasDefaultValueSql("'1/20/2015 8:52:25 AM'");

                entity.Property(e => e.AttendeeLastName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.AttendeePhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("N''");

                entity.HasOne(d => d.AttendeeEventNode)
                    .WithMany(p => p.EventsAttendee)
                    .HasForeignKey(d => d.AttendeeEventNodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Events_Attendee_AttendeeEventNodeID_CMS_Tree");
            });

            modelBuilder.Entity<ExportHistory>(entity =>
            {
                entity.HasKey(e => e.ExportId)
                    .HasName("PK_Export_History");

                entity.ToTable("Export_History");

                entity.HasIndex(e => e.ExportDateTime)
                    .HasName("IX_Export_History_ExportDateTime");

                entity.HasIndex(e => e.ExportSiteId)
                    .HasName("IX_Export_History_ExportSiteID");

                entity.HasIndex(e => e.ExportUserId)
                    .HasName("IX_Export_History_ExportUserID");

                entity.Property(e => e.ExportId).HasColumnName("ExportID");

                entity.Property(e => e.ExportFileName)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ExportSiteId).HasColumnName("ExportSiteID");

                entity.Property(e => e.ExportUserId).HasColumnName("ExportUserID");

                entity.HasOne(d => d.ExportSite)
                    .WithMany(p => p.ExportHistory)
                    .HasForeignKey(d => d.ExportSiteId)
                    .HasConstraintName("FK_Export_History_ExportSiteID_CMS_Site");

                entity.HasOne(d => d.ExportUser)
                    .WithMany(p => p.ExportHistory)
                    .HasForeignKey(d => d.ExportUserId)
                    .HasConstraintName("FK_Export_History_ExportUserID_CMS_User");
            });

            modelBuilder.Entity<ExportTask>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PK_Export_Task");

                entity.ToTable("Export_Task");

                entity.HasIndex(e => new { e.TaskSiteId, e.TaskObjectType })
                    .HasName("IX_Export_Task_TaskSiteID_TaskObjectType");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskData).IsRequired();

                entity.Property(e => e.TaskObjectId).HasColumnName("TaskObjectID");

                entity.Property(e => e.TaskObjectType).HasMaxLength(100);

                entity.Property(e => e.TaskSiteId).HasColumnName("TaskSiteID");

                entity.Property(e => e.TaskTitle)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TaskType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TaskSite)
                    .WithMany(p => p.ExportTask)
                    .HasForeignKey(d => d.TaskSiteId)
                    .HasConstraintName("FK_Export_Task_TaskSiteID_CMS_Site");
            });

            modelBuilder.Entity<ForumsAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId)
                    .HasName("PK_Forums_Attachment");

                entity.ToTable("Forums_Attachment");

                entity.HasIndex(e => e.AttachmentPostId)
                    .HasName("IX_Forums_Attachment_AttachmentPostID");

                entity.HasIndex(e => new { e.AttachmentSiteId, e.AttachmentGuid })
                    .HasName("IX_Forums_Attachment_AttachmentGUID")
                    .IsUnique();

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.AttachmentFileExtension)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AttachmentFileName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AttachmentGuid).HasColumnName("AttachmentGUID");

                entity.Property(e => e.AttachmentMimeType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AttachmentPostId)
                    .HasColumnName("AttachmentPostID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AttachmentSiteId).HasColumnName("AttachmentSiteID");

                entity.HasOne(d => d.AttachmentPost)
                    .WithMany(p => p.ForumsAttachment)
                    .HasForeignKey(d => d.AttachmentPostId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_Attachment_AttachmentPostID_Forums_ForumPost");

                entity.HasOne(d => d.AttachmentSite)
                    .WithMany(p => p.ForumsAttachment)
                    .HasForeignKey(d => d.AttachmentSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_Attachment_AttachmentSiteID_CMS_Site");
            });

            modelBuilder.Entity<ForumsForum>(entity =>
            {
                entity.HasKey(e => e.ForumId)
                    .HasName("PK_Forums_Forum");

                entity.ToTable("Forums_Forum");

                entity.HasIndex(e => e.ForumCommunityGroupId)
                    .HasName("IX_Forums_Forum_ForumCommunityGroupID");

                entity.HasIndex(e => e.ForumDocumentId)
                    .HasName("IX_Forums_Forum_ForumDocumentID");

                entity.HasIndex(e => new { e.ForumGroupId, e.ForumOrder })
                    .HasName("IX_Forums_Forum_ForumGroupID_ForumOrder");

                entity.HasIndex(e => new { e.ForumSiteId, e.ForumName })
                    .HasName("IX_Forums_Forum_ForumSiteID_ForumName");

                entity.Property(e => e.ForumId).HasColumnName("ForumID");

                entity.Property(e => e.ForumBaseUrl).HasMaxLength(200);

                entity.Property(e => e.ForumCommunityGroupId).HasColumnName("ForumCommunityGroupID");

                entity.Property(e => e.ForumDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ForumDocumentId).HasColumnName("ForumDocumentID");

                entity.Property(e => e.ForumGroupId).HasColumnName("ForumGroupID");

                entity.Property(e => e.ForumGuid).HasColumnName("ForumGUID");

                entity.Property(e => e.ForumHtmleditor).HasColumnName("ForumHTMLEditor");

                entity.Property(e => e.ForumImageMaxSideSize).HasDefaultValueSql("400");

                entity.Property(e => e.ForumIsAnswerLimit).HasDefaultValueSql("5");

                entity.Property(e => e.ForumIsLocked).HasDefaultValueSql("0");

                entity.Property(e => e.ForumLastPostUserName).HasMaxLength(200);

                entity.Property(e => e.ForumLastPostUserNameAbsolute).HasMaxLength(200);

                entity.Property(e => e.ForumName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ForumOptInApprovalUrl)
                    .HasColumnName("ForumOptInApprovalURL")
                    .HasMaxLength(450);

                entity.Property(e => e.ForumSiteId)
                    .HasColumnName("ForumSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ForumUnsubscriptionUrl).HasMaxLength(200);

                entity.Property(e => e.ForumUseCaptcha).HasColumnName("ForumUseCAPTCHA");

                entity.HasOne(d => d.ForumCommunityGroup)
                    .WithMany(p => p.ForumsForum)
                    .HasForeignKey(d => d.ForumCommunityGroupId)
                    .HasConstraintName("FK_Forums_Forum_ForumCommunityGroupID_Community_Group");

                entity.HasOne(d => d.ForumDocument)
                    .WithMany(p => p.ForumsForum)
                    .HasForeignKey(d => d.ForumDocumentId)
                    .HasConstraintName("FK_Forums_Forum_ForumDocumentID_CMS_Document");

                entity.HasOne(d => d.ForumGroup)
                    .WithMany(p => p.ForumsForum)
                    .HasForeignKey(d => d.ForumGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_Forum_ForumGroupID_Forums_ForumGroup");

                entity.HasOne(d => d.ForumSite)
                    .WithMany(p => p.ForumsForum)
                    .HasForeignKey(d => d.ForumSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_Forum_ForumSiteID_CMS_Site");
            });

            modelBuilder.Entity<ForumsForumGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_Forums_ForumGroup");

                entity.ToTable("Forums_ForumGroup");

                entity.HasIndex(e => e.GroupGroupId)
                    .HasName("IX_Forums_ForumGroup_GroupGroupID");

                entity.HasIndex(e => new { e.GroupSiteId, e.GroupName })
                    .HasName("IX_Forums_ForumGroup_GroupSiteID_GroupName");

                entity.HasIndex(e => new { e.GroupSiteId, e.GroupOrder })
                    .HasName("IX_Forums_ForumGroup_GroupSiteID_GroupOrder");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupBaseUrl).HasMaxLength(200);

                entity.Property(e => e.GroupDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.GroupGroupId).HasColumnName("GroupGroupID");

                entity.Property(e => e.GroupGuid)
                    .HasColumnName("GroupGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.GroupHtmleditor)
                    .HasColumnName("GroupHTMLEditor")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GroupImageMaxSideSize).HasDefaultValueSql("400");

                entity.Property(e => e.GroupLastModified).HasDefaultValueSql("'11/6/2013 2:43:02 PM'");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.GroupOptInApprovalUrl)
                    .HasColumnName("GroupOptInApprovalURL")
                    .HasMaxLength(450);

                entity.Property(e => e.GroupSiteId)
                    .HasColumnName("GroupSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GroupUnsubscriptionUrl).HasMaxLength(200);

                entity.Property(e => e.GroupUseCaptcha)
                    .HasColumnName("GroupUseCAPTCHA")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.GroupGroup)
                    .WithMany(p => p.ForumsForumGroup)
                    .HasForeignKey(d => d.GroupGroupId)
                    .HasConstraintName("FK_Forums_ForumGroup_GroupGroupID_Community_Group");

                entity.HasOne(d => d.GroupSite)
                    .WithMany(p => p.ForumsForumGroup)
                    .HasForeignKey(d => d.GroupSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_ForumGroup_GroupSiteID_CMS_Site");
            });

            modelBuilder.Entity<ForumsForumModerators>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ForumId })
                    .HasName("PK_Forums_ForumModerators");

                entity.ToTable("Forums_ForumModerators");

                entity.HasIndex(e => e.ForumId)
                    .HasName("IX_Forums_ForumModerators_ForumID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ForumId).HasColumnName("ForumID");

                entity.HasOne(d => d.Forum)
                    .WithMany(p => p.ForumsForumModerators)
                    .HasForeignKey(d => d.ForumId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_ForumModerators_ForumID_Forums_Forum");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForumsForumModerators)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_ForumModerators_UserID_CMS_User");
            });

            modelBuilder.Entity<ForumsForumPost>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK_Forums_ForumPost");

                entity.ToTable("Forums_ForumPost");

                entity.HasIndex(e => e.PostApproved)
                    .HasName("IX_Forums_ForumPost_PostApproved");

                entity.HasIndex(e => e.PostApprovedByUserId)
                    .HasName("IX_Forums_ForumPost_PostApprovedByUserID");

                entity.HasIndex(e => e.PostForumId)
                    .HasName("IX_Forums_ForumPost_PostForumID");

                entity.HasIndex(e => e.PostIdpath)
                    .HasName("IX_Forums_ForumPost_PostIDPath")
                    .IsUnique();

                entity.HasIndex(e => e.PostLevel)
                    .HasName("IX_Forums_ForumPost_PostLevel");

                entity.HasIndex(e => e.PostParentId)
                    .HasName("IX_Forums_ForumPost_PostParentID");

                entity.HasIndex(e => e.PostUserId)
                    .HasName("IX_Forums_ForumPost_PostUserID");

                entity.Property(e => e.PostApprovedByUserId).HasColumnName("PostApprovedByUserID");

                entity.Property(e => e.PostAttachmentCount).HasDefaultValueSql("0");

                entity.Property(e => e.PostForumId).HasColumnName("PostForumID");

                entity.Property(e => e.PostGuid).HasColumnName("PostGUID");

                entity.Property(e => e.PostIdpath)
                    .IsRequired()
                    .HasColumnName("PostIDPath")
                    .HasMaxLength(450);

                entity.Property(e => e.PostIsLocked).HasDefaultValueSql("0");

                entity.Property(e => e.PostParentId).HasColumnName("PostParentID");

                entity.Property(e => e.PostQuestionSolved).HasDefaultValueSql("0");

                entity.Property(e => e.PostSiteId).HasColumnName("PostSiteID");

                entity.Property(e => e.PostSubject)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.PostThreadLastPostUserName).HasMaxLength(200);

                entity.Property(e => e.PostThreadLastPostUserNameAbsolute).HasMaxLength(200);

                entity.Property(e => e.PostUserId).HasColumnName("PostUserID");

                entity.Property(e => e.PostUserMail).HasMaxLength(254);

                entity.Property(e => e.PostUserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.PostApprovedByUser)
                    .WithMany(p => p.ForumsForumPostPostApprovedByUser)
                    .HasForeignKey(d => d.PostApprovedByUserId)
                    .HasConstraintName("FK_Forums_ForumPost_PostApprovedByUserID_CMS_User");

                entity.HasOne(d => d.PostForum)
                    .WithMany(p => p.ForumsForumPost)
                    .HasForeignKey(d => d.PostForumId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_ForumPost_PostForumID_Forums_Forum");

                entity.HasOne(d => d.PostParent)
                    .WithMany(p => p.InversePostParent)
                    .HasForeignKey(d => d.PostParentId)
                    .HasConstraintName("FK_Forums_ForumPost_PostParentID_Forums_ForumPost");

                entity.HasOne(d => d.PostUser)
                    .WithMany(p => p.ForumsForumPostPostUser)
                    .HasForeignKey(d => d.PostUserId)
                    .HasConstraintName("FK_Forums_ForumPost_PostUserID_CMS_User");
            });

            modelBuilder.Entity<ForumsForumRoles>(entity =>
            {
                entity.HasKey(e => new { e.ForumId, e.RoleId, e.PermissionId })
                    .HasName("PK_Forums_ForumRoles");

                entity.ToTable("Forums_ForumRoles");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("IX_Forums_ForumRoles_PermissionID");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_Forums_ForumRoles_RoleID");

                entity.Property(e => e.ForumId).HasColumnName("ForumID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.HasOne(d => d.Forum)
                    .WithMany(p => p.ForumsForumRoles)
                    .HasForeignKey(d => d.ForumId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_ForumRoles_ForumID_Forums_Forum");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.ForumsForumRoles)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_ForumRoles_PermissionID_CMS_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ForumsForumRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_ForumRoles_RoleID_CMS_Role");
            });

            modelBuilder.Entity<ForumsForumSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId)
                    .HasName("PK_Forums_ForumSubscription");

                entity.ToTable("Forums_ForumSubscription");

                entity.HasIndex(e => e.SubscriptionForumId)
                    .HasName("IX_Forums_ForumSubscription_SubscriptionForumID");

                entity.HasIndex(e => e.SubscriptionPostId)
                    .HasName("IX_Forums_ForumSubscription_SubscriptionPostID");

                entity.HasIndex(e => e.SubscriptionUserId)
                    .HasName("IX_Forums_ForumSubscription_SubscriptionUserID");

                entity.HasIndex(e => new { e.SubscriptionEmail, e.SubscriptionForumId })
                    .HasName("IX_Forums_ForumSubscription_SubscriptionForumID_SubscriptionEmail");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.SubscriptionApprovalHash).HasMaxLength(100);

                entity.Property(e => e.SubscriptionEmail).HasMaxLength(254);

                entity.Property(e => e.SubscriptionForumId).HasColumnName("SubscriptionForumID");

                entity.Property(e => e.SubscriptionGuid).HasColumnName("SubscriptionGUID");

                entity.Property(e => e.SubscriptionPostId).HasColumnName("SubscriptionPostID");

                entity.Property(e => e.SubscriptionUserId).HasColumnName("SubscriptionUserID");

                entity.HasOne(d => d.SubscriptionForum)
                    .WithMany(p => p.ForumsForumSubscription)
                    .HasForeignKey(d => d.SubscriptionForumId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_ForumSubscription_SubscriptionForumID_Forums_Forum");

                entity.HasOne(d => d.SubscriptionPost)
                    .WithMany(p => p.ForumsForumSubscription)
                    .HasForeignKey(d => d.SubscriptionPostId)
                    .HasConstraintName("FK_Forums_ForumSubscription_SubscriptionPostID_Forums_ForumPost");

                entity.HasOne(d => d.SubscriptionUser)
                    .WithMany(p => p.ForumsForumSubscription)
                    .HasForeignKey(d => d.SubscriptionUserId)
                    .HasConstraintName("FK_Forums_ForumSubscription_SubscriptionUserID_CMS_User");
            });

            modelBuilder.Entity<ForumsUserFavorites>(entity =>
            {
                entity.HasKey(e => e.FavoriteId)
                    .HasName("PK_Forums_UserFavorites");

                entity.ToTable("Forums_UserFavorites");

                entity.HasIndex(e => e.ForumId)
                    .HasName("IX_Forums_UserFavorites_ForumID");

                entity.HasIndex(e => e.PostId)
                    .HasName("IX_Forums_UserFavorites_PostID");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_Forums_UserFavorites_SiteID");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_Forums_UserFavorites_UserID");

                entity.HasIndex(e => new { e.UserId, e.PostId, e.ForumId })
                    .HasName("IX_Forums_UserFavorites_UserID_PostID_ForumID")
                    .IsUnique();

                entity.Property(e => e.FavoriteId).HasColumnName("FavoriteID");

                entity.Property(e => e.FavoriteGuid)
                    .HasColumnName("FavoriteGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.FavoriteLastModified).HasDefaultValueSql("'12/4/2008 3:23:57 PM'");

                entity.Property(e => e.FavoriteName).HasMaxLength(100);

                entity.Property(e => e.ForumId)
                    .IsRequired()
                    .HasColumnName("ForumID");

                entity.Property(e => e.PostId)
                    .IsRequired()
                    .HasColumnName("PostID");

                entity.Property(e => e.SiteId)
                    .HasColumnName("SiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Forum)
                    .WithMany(p => p.ForumsUserFavorites)
                    .HasForeignKey(d => d.ForumId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_UserFavorites_ForumID_Forums_Forum");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.ForumsUserFavorites)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_UserFavorites_PostID_Forums_ForumPost");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.ForumsUserFavorites)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_UserFavorites_SiteID_CMS_Site");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForumsUserFavorites)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Forums_UserFavorites_UserID_CMS_User");
            });

            modelBuilder.Entity<IntegrationConnector>(entity =>
            {
                entity.HasKey(e => e.ConnectorId)
                    .HasName("PK_Integration_Connector");

                entity.ToTable("Integration_Connector");

                entity.HasIndex(e => e.ConnectorDisplayName)
                    .HasName("IX_Integration_Connector_ConnectorDisplayName");

                entity.HasIndex(e => e.ConnectorEnabled)
                    .HasName("IX_Integration_Connector_ConnectorEnabled");

                entity.Property(e => e.ConnectorId).HasColumnName("ConnectorID");

                entity.Property(e => e.ConnectorAssemblyName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ConnectorClassName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ConnectorDisplayName)
                    .IsRequired()
                    .HasMaxLength(440);

                entity.Property(e => e.ConnectorEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.ConnectorName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<IntegrationSyncLog>(entity =>
            {
                entity.HasKey(e => e.SyncLogId)
                    .HasName("PK_Integration_SyncLog");

                entity.ToTable("Integration_SyncLog");

                entity.HasIndex(e => e.SyncLogSynchronizationId)
                    .HasName("IX_Integration_SyncLog_SyncLogTaskID");

                entity.Property(e => e.SyncLogId).HasColumnName("SyncLogID");

                entity.Property(e => e.SyncLogSynchronizationId).HasColumnName("SyncLogSynchronizationID");

                entity.HasOne(d => d.SyncLogSynchronization)
                    .WithMany(p => p.IntegrationSyncLog)
                    .HasForeignKey(d => d.SyncLogSynchronizationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Integration_SyncLog_SyncLogSynchronizationID_Integration_Synchronization");
            });

            modelBuilder.Entity<IntegrationSynchronization>(entity =>
            {
                entity.HasKey(e => e.SynchronizationId)
                    .HasName("PK_Integration_Synchronization");

                entity.ToTable("Integration_Synchronization");

                entity.HasIndex(e => e.SynchronizationConnectorId)
                    .HasName("IX_Integration_Synchronization_SynchronizationConnectorID");

                entity.HasIndex(e => e.SynchronizationTaskId)
                    .HasName("IX_Integration_Synchronization_SynchronizationTaskID");

                entity.Property(e => e.SynchronizationId).HasColumnName("SynchronizationID");

                entity.Property(e => e.SynchronizationConnectorId).HasColumnName("SynchronizationConnectorID");

                entity.Property(e => e.SynchronizationTaskId).HasColumnName("SynchronizationTaskID");

                entity.HasOne(d => d.SynchronizationConnector)
                    .WithMany(p => p.IntegrationSynchronization)
                    .HasForeignKey(d => d.SynchronizationConnectorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Integration_Synchronization_SynchronizationConnectorID_Integration_Connector");

                entity.HasOne(d => d.SynchronizationTask)
                    .WithMany(p => p.IntegrationSynchronization)
                    .HasForeignKey(d => d.SynchronizationTaskId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Integration_Synchronization_SynchronizationTaskID_Integration_Task");
            });

            modelBuilder.Entity<IntegrationTask>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PK_Integration_Task");

                entity.ToTable("Integration_Task");

                entity.HasIndex(e => e.TaskNodeAliasPath)
                    .HasName("IX_Integration_Task_TaskNodeAliasPath");

                entity.HasIndex(e => e.TaskSiteId)
                    .HasName("IX_Integration_Task_TaskSiteID");

                entity.HasIndex(e => e.TaskType)
                    .HasName("IX_Integration_Task_TaskType");

                entity.HasIndex(e => new { e.TaskId, e.TaskIsInbound })
                    .HasName("IX_Integration_Task_TaskIsInbound");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskData).IsRequired();

                entity.Property(e => e.TaskDataType).HasMaxLength(50);

                entity.Property(e => e.TaskDocumentId).HasColumnName("TaskDocumentID");

                entity.Property(e => e.TaskNodeAliasPath).HasMaxLength(450);

                entity.Property(e => e.TaskNodeId).HasColumnName("TaskNodeID");

                entity.Property(e => e.TaskObjectId).HasColumnName("TaskObjectID");

                entity.Property(e => e.TaskObjectType).HasMaxLength(100);

                entity.Property(e => e.TaskProcessType).HasMaxLength(50);

                entity.Property(e => e.TaskSiteId).HasColumnName("TaskSiteID");

                entity.Property(e => e.TaskTitle)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TaskType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TaskSite)
                    .WithMany(p => p.IntegrationTask)
                    .HasForeignKey(d => d.TaskSiteId)
                    .HasConstraintName("FK_IntegrationTask_TaskSiteID_CMS_Site");
            });

            modelBuilder.Entity<MediaFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_Media_File");

                entity.ToTable("Media_File");

                entity.HasIndex(e => e.FileCreatedByUserId)
                    .HasName("IX_Media_File_FileCreatedByUserID");

                entity.HasIndex(e => e.FileLibraryId)
                    .HasName("IX_Media_File_FileLibraryID");

                entity.HasIndex(e => e.FileModifiedByUserId)
                    .HasName("IX_Media_File_FileModifiedByUserID");

                entity.HasIndex(e => e.FilePath)
                    .HasName("IX_Media_File_FilePath");

                entity.HasIndex(e => new { e.FileSiteId, e.FileGuid })
                    .HasName("IX_Media_File_FileSiteID_FileGUID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileCreatedByUserId).HasColumnName("FileCreatedByUserID");

                entity.Property(e => e.FileCreatedWhen).HasDefaultValueSql("'11/11/2008 4:10:00 PM'");

                entity.Property(e => e.FileDescription).IsRequired();

                entity.Property(e => e.FileExtension)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FileGuid).HasColumnName("FileGUID");

                entity.Property(e => e.FileLibraryId).HasColumnName("FileLibraryID");

                entity.Property(e => e.FileMimeType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileModifiedByUserId).HasColumnName("FileModifiedByUserID");

                entity.Property(e => e.FileModifiedWhen).HasDefaultValueSql("'11/11/2008 4:11:15 PM'");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.FileSiteId).HasColumnName("FileSiteID");

                entity.Property(e => e.FileSize).HasDefaultValueSql("0");

                entity.Property(e => e.FileTitle)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.FileCreatedByUser)
                    .WithMany(p => p.MediaFileFileCreatedByUser)
                    .HasForeignKey(d => d.FileCreatedByUserId)
                    .HasConstraintName("FK_Media_File_FileCreatedByUserID_CMS_User");

                entity.HasOne(d => d.FileLibrary)
                    .WithMany(p => p.MediaFile)
                    .HasForeignKey(d => d.FileLibraryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Media_File_FileLibraryID_Media_Library");

                entity.HasOne(d => d.FileModifiedByUser)
                    .WithMany(p => p.MediaFileFileModifiedByUser)
                    .HasForeignKey(d => d.FileModifiedByUserId)
                    .HasConstraintName("FK_Media_File_FileModifiedByUserID_CMS_User");

                entity.HasOne(d => d.FileSite)
                    .WithMany(p => p.MediaFile)
                    .HasForeignKey(d => d.FileSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Media_File_FileSiteID_CMS_Site");
            });

            modelBuilder.Entity<MediaLibrary>(entity =>
            {
                entity.HasKey(e => e.LibraryId)
                    .HasName("PK_Media_Library");

                entity.ToTable("Media_Library");

                entity.HasIndex(e => e.LibraryGroupId)
                    .HasName("IX_Media_Library_LibraryGroupID");

                entity.HasIndex(e => new { e.LibrarySiteId, e.LibraryDisplayName })
                    .HasName("IX_Media_Library_LibraryDisplayName");

                entity.HasIndex(e => new { e.LibrarySiteId, e.LibraryName, e.LibraryGuid })
                    .HasName("IX_Media_Library_LibrarySiteID_LibraryName_LibraryGUID")
                    .IsUnique();

                entity.Property(e => e.LibraryId).HasColumnName("LibraryID");

                entity.Property(e => e.LibraryDisplayName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LibraryFolder)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LibraryGroupId).HasColumnName("LibraryGroupID");

                entity.Property(e => e.LibraryGuid)
                    .IsRequired()
                    .HasColumnName("LibraryGUID");

                entity.Property(e => e.LibraryName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LibrarySiteId).HasColumnName("LibrarySiteID");

                entity.Property(e => e.LibraryTeaserGuid).HasColumnName("LibraryTeaserGUID");

                entity.Property(e => e.LibraryTeaserPath).HasMaxLength(450);

                entity.HasOne(d => d.LibraryGroup)
                    .WithMany(p => p.MediaLibrary)
                    .HasForeignKey(d => d.LibraryGroupId)
                    .HasConstraintName("FK_Media_Library_LibraryGroupID_Community_Group");

                entity.HasOne(d => d.LibrarySite)
                    .WithMany(p => p.MediaLibrary)
                    .HasForeignKey(d => d.LibrarySiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Media_Library_LibrarySiteID_CMS_Site");
            });

            modelBuilder.Entity<MediaLibraryRolePermission>(entity =>
            {
                entity.HasKey(e => new { e.LibraryId, e.RoleId, e.PermissionId })
                    .HasName("PK_Media_LibraryRolePermission");

                entity.ToTable("Media_LibraryRolePermission");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("IX_Media_LibraryRolePermission_PermissionID");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_Media_LibraryRolePermission_RoleID");

                entity.Property(e => e.LibraryId).HasColumnName("LibraryID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.MediaLibraryRolePermission)
                    .HasForeignKey(d => d.LibraryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Media_LibraryRolePermission_LibraryID_Media_Library");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.MediaLibraryRolePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Media_LibraryRolePermission_PermissionID_CMS_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.MediaLibraryRolePermission)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Media_LibraryRolePermission_RoleID_CMS_Role");
            });

            modelBuilder.Entity<MessagingContactList>(entity =>
            {
                entity.HasKey(e => new { e.ContactListUserId, e.ContactListContactUserId })
                    .HasName("PK_Messaging_ContactList");

                entity.ToTable("Messaging_ContactList");

                entity.HasIndex(e => e.ContactListContactUserId)
                    .HasName("IX_Messaging_ContactList_ContactListContactUserID");

                entity.Property(e => e.ContactListUserId).HasColumnName("ContactListUserID");

                entity.Property(e => e.ContactListContactUserId).HasColumnName("ContactListContactUserID");

                entity.HasOne(d => d.ContactListContactUser)
                    .WithMany(p => p.MessagingContactListContactListContactUser)
                    .HasForeignKey(d => d.ContactListContactUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Messaging_ContactList_ContactListContactUserID_CMS_User");

                entity.HasOne(d => d.ContactListUser)
                    .WithMany(p => p.MessagingContactListContactListUser)
                    .HasForeignKey(d => d.ContactListUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Messaging_ContactList_ContactListUserID_CMS_User");
            });

            modelBuilder.Entity<MessagingIgnoreList>(entity =>
            {
                entity.HasKey(e => new { e.IgnoreListUserId, e.IgnoreListIgnoredUserId })
                    .HasName("PK_Messaging_IgnoreList");

                entity.ToTable("Messaging_IgnoreList");

                entity.HasIndex(e => e.IgnoreListIgnoredUserId)
                    .HasName("IX_Messaging_IgnoreList_IgnoreListIgnoredUserID");

                entity.Property(e => e.IgnoreListUserId).HasColumnName("IgnoreListUserID");

                entity.Property(e => e.IgnoreListIgnoredUserId).HasColumnName("IgnoreListIgnoredUserID");

                entity.HasOne(d => d.IgnoreListIgnoredUser)
                    .WithMany(p => p.MessagingIgnoreListIgnoreListIgnoredUser)
                    .HasForeignKey(d => d.IgnoreListIgnoredUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Messaging_IgnoreList_IgnoreListIgnoredUserID_CMS_User");

                entity.HasOne(d => d.IgnoreListUser)
                    .WithMany(p => p.MessagingIgnoreListIgnoreListUser)
                    .HasForeignKey(d => d.IgnoreListUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Messaging_IgnoreList_IgnoreListUserID_CMS_User");
            });

            modelBuilder.Entity<MessagingMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK_Messaging_Message");

                entity.ToTable("Messaging_Message");

                entity.HasIndex(e => new { e.MessageRecipientUserId, e.MessageSent, e.MessageRecipientDeleted })
                    .HasName("IX_Messaging_Message_MessageRecipientUserID_MessageSent_MessageRecipientDeleted");

                entity.HasIndex(e => new { e.MessageSenderUserId, e.MessageSent, e.MessageSenderDeleted })
                    .HasName("IX_Messaging_Message_MessageSenderUserID_MessageSent_MessageSenderDeleted");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.MessageBody).IsRequired();

                entity.Property(e => e.MessageGuid).HasColumnName("MessageGUID");

                entity.Property(e => e.MessageRecipientNickName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.MessageRecipientUserId).HasColumnName("MessageRecipientUserID");

                entity.Property(e => e.MessageSenderNickName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.MessageSenderUserId).HasColumnName("MessageSenderUserID");

                entity.Property(e => e.MessageSubject)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.HasOne(d => d.MessageRecipientUser)
                    .WithMany(p => p.MessagingMessageMessageRecipientUser)
                    .HasForeignKey(d => d.MessageRecipientUserId)
                    .HasConstraintName("FK_Messaging_Message_MessageRecipientUserID_CMS_User");

                entity.HasOne(d => d.MessageSenderUser)
                    .WithMany(p => p.MessagingMessageMessageSenderUser)
                    .HasForeignKey(d => d.MessageSenderUserId)
                    .HasConstraintName("FK_Messaging_Message_MessageSenderUserID_CMS_User");
            });

            modelBuilder.Entity<NewsletterAbtest>(entity =>
            {
                entity.HasKey(e => e.TestId)
                    .HasName("PK_Newsletter_ABTest");

                entity.ToTable("Newsletter_ABTest");

                entity.HasIndex(e => e.TestIssueId)
                    .HasName("IX_Newsletter_ABTest_TestIssueID")
                    .IsUnique();

                entity.HasIndex(e => e.TestWinnerIssueId)
                    .HasName("IX_Newsletter_ABTest_TestWinnerIssueID");

                entity.HasIndex(e => e.TestWinnerScheduledTaskId)
                    .HasName("IX_Newsletter_ABTest_TestWinnerScheduledTaskID");

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.Property(e => e.TestGuid).HasColumnName("TestGUID");

                entity.Property(e => e.TestIssueId).HasColumnName("TestIssueID");

                entity.Property(e => e.TestLastModified).HasDefaultValueSql("'12/5/2011 4:56:38 PM'");

                entity.Property(e => e.TestSizePercentage).HasDefaultValueSql("0");

                entity.Property(e => e.TestWinnerIssueId).HasColumnName("TestWinnerIssueID");

                entity.Property(e => e.TestWinnerScheduledTaskId).HasColumnName("TestWinnerScheduledTaskID");

                entity.HasOne(d => d.TestIssue)
                    .WithOne(p => p.NewsletterAbtestTestIssue)
                    .HasForeignKey<NewsletterAbtest>(d => d.TestIssueId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_ABTest_Newsletter_NewsletterIssue");

                entity.HasOne(d => d.TestWinnerIssue)
                    .WithMany(p => p.NewsletterAbtestTestWinnerIssue)
                    .HasForeignKey(d => d.TestWinnerIssueId)
                    .HasConstraintName("FK_Newsletter_ABTest_TestWinnerIssueID_Newsletter_NewsletterIssue");

                entity.HasOne(d => d.TestWinnerScheduledTask)
                    .WithMany(p => p.NewsletterAbtest)
                    .HasForeignKey(d => d.TestWinnerScheduledTaskId)
                    .HasConstraintName("FK_Newsletter_ABTest_TestWinnerScheduledTaskID_CMS_ScheduledTask");
            });

            modelBuilder.Entity<NewsletterClickedLink>(entity =>
            {
                entity.HasKey(e => e.ClickedLinkId)
                    .HasName("PK_Newsletter_ClickedLink");

                entity.ToTable("Newsletter_ClickedLink");

                entity.HasIndex(e => e.ClickedLinkNewsletterLinkId)
                    .HasName("IX_Newsletter_ClickedLink_ClickedLinkNewsletterLinkID");

                entity.Property(e => e.ClickedLinkId).HasColumnName("ClickedLinkID");

                entity.Property(e => e.ClickedLinkEmail)
                    .IsRequired()
                    .HasMaxLength(254)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ClickedLinkGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.ClickedLinkNewsletterLinkId)
                    .HasColumnName("ClickedLinkNewsletterLinkID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ClickedLinkNewsletterLink)
                    .WithMany(p => p.NewsletterClickedLink)
                    .HasForeignKey(d => d.ClickedLinkNewsletterLinkId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_ClickedLink_Newsletter_Link");
            });

            modelBuilder.Entity<NewsletterEmailTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PK_Newsletter_EmailTemplate");

                entity.ToTable("Newsletter_EmailTemplate");

                entity.HasIndex(e => new { e.TemplateSiteId, e.TemplateDisplayName })
                    .HasName("IX_Newsletter_EmailTemplate_TemplateSiteID_TemplateDisplayName");

                entity.HasIndex(e => new { e.TemplateSiteId, e.TemplateName })
                    .HasName("IX_Newsletter_EmailTemplate_TemplateSiteID_TemplateName")
                    .IsUnique();

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.TemplateBody).IsRequired();

                entity.Property(e => e.TemplateDisplayName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TemplateFooter).IsRequired();

                entity.Property(e => e.TemplateGuid).HasColumnName("TemplateGUID");

                entity.Property(e => e.TemplateHeader).IsRequired();

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TemplateSiteId).HasColumnName("TemplateSiteID");

                entity.Property(e => e.TemplateSubject).HasMaxLength(450);

                entity.Property(e => e.TemplateThumbnailGuid).HasColumnName("TemplateThumbnailGUID");

                entity.Property(e => e.TemplateType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.TemplateSite)
                    .WithMany(p => p.NewsletterEmailTemplate)
                    .HasForeignKey(d => d.TemplateSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_EmailTemplate_TemplateSiteID_CMS_Site");
            });

            modelBuilder.Entity<NewsletterEmailTemplateNewsletter>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.NewsletterId })
                    .HasName("PK_Newsletter_EmailTemplateNewsletter");

                entity.ToTable("Newsletter_EmailTemplateNewsletter");

                entity.HasIndex(e => e.NewsletterId)
                    .HasName("IX_Newsletter_EmailTemplateNewsletter_NewsletterID");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.NewsletterId).HasColumnName("NewsletterID");

                entity.HasOne(d => d.Newsletter)
                    .WithMany(p => p.NewsletterEmailTemplateNewsletter)
                    .HasForeignKey(d => d.NewsletterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_EmailTemplateNewsletter_Newsletter_Newsletter");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.NewsletterEmailTemplateNewsletter)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_EmailTemplateNewsletter_Newsletter_EmailTemplate");
            });

            modelBuilder.Entity<NewsletterEmails>(entity =>
            {
                entity.HasKey(e => e.EmailId)
                    .HasName("PK_Newsletter_Emails");

                entity.ToTable("Newsletter_Emails");

                entity.HasIndex(e => e.EmailGuid)
                    .HasName("IX_Newsletter_Emails_EmailGUID")
                    .IsUnique();

                entity.HasIndex(e => e.EmailNewsletterIssueId)
                    .HasName("IX_Newsletter_Emails_EmailNewsletterIssueID");

                entity.HasIndex(e => e.EmailSending)
                    .HasName("IX_Newsletter_Emails_EmailSending");

                entity.HasIndex(e => e.EmailSiteId)
                    .HasName("IX_Newsletter_Emails_EmailSiteID");

                entity.HasIndex(e => e.EmailSubscriberId)
                    .HasName("IX_Newsletter_Emails_EmailSubscriberID");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.EmailAddress).HasMaxLength(254);

                entity.Property(e => e.EmailContactId).HasColumnName("EmailContactID");

                entity.Property(e => e.EmailGuid).HasColumnName("EmailGUID");

                entity.Property(e => e.EmailNewsletterIssueId)
                    .HasColumnName("EmailNewsletterIssueID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmailSiteId)
                    .HasColumnName("EmailSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmailSubscriberId).HasColumnName("EmailSubscriberID");

                entity.HasOne(d => d.EmailNewsletterIssue)
                    .WithMany(p => p.NewsletterEmails)
                    .HasForeignKey(d => d.EmailNewsletterIssueId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_Emails_EmailNewsletterIssueID_Newsletter_NewsletterIssue");

                entity.HasOne(d => d.EmailSite)
                    .WithMany(p => p.NewsletterEmails)
                    .HasForeignKey(d => d.EmailSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_Emails_EmailSiteID_CMS_Site");

                entity.HasOne(d => d.EmailSubscriber)
                    .WithMany(p => p.NewsletterEmails)
                    .HasForeignKey(d => d.EmailSubscriberId)
                    .HasConstraintName("FK_Newsletter_Emails_EmailSubscriberID_Newsletter_Subscriber");
            });

            modelBuilder.Entity<NewsletterIssueContactGroup>(entity =>
            {
                entity.HasKey(e => e.IssueContactGroupId)
                    .HasName("PK_Newsletter_IssueContactGroup");

                entity.ToTable("Newsletter_IssueContactGroup");

                entity.HasIndex(e => e.ContactGroupId)
                    .HasName("IX_Newsletter_IssueContactGroup_ContactGroupID");

                entity.Property(e => e.IssueContactGroupId).HasColumnName("IssueContactGroupID");

                entity.Property(e => e.ContactGroupId)
                    .HasColumnName("ContactGroupID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IssueId)
                    .HasColumnName("IssueID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ContactGroup)
                    .WithMany(p => p.NewsletterIssueContactGroup)
                    .HasForeignKey(d => d.ContactGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_IssueContactGroup_ContactGroupID");
            });

            modelBuilder.Entity<NewsletterLink>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PK_Newsletter_Link");

                entity.ToTable("Newsletter_Link");

                entity.HasIndex(e => e.LinkIssueId)
                    .HasName("IX_Newsletter_Link_LinkIssueID");

                entity.Property(e => e.LinkId).HasColumnName("LinkID");

                entity.Property(e => e.LinkDescription)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.LinkGuid).HasColumnName("LinkGUID");

                entity.Property(e => e.LinkIssueId).HasColumnName("LinkIssueID");

                entity.Property(e => e.LinkOutdated).HasDefaultValueSql("0");

                entity.Property(e => e.LinkTarget).IsRequired();

                entity.HasOne(d => d.LinkIssue)
                    .WithMany(p => p.NewsletterLink)
                    .HasForeignKey(d => d.LinkIssueId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_Link_Newsletter_NewsletterIssue");
            });

            modelBuilder.Entity<NewsletterNewsletter>(entity =>
            {
                entity.HasKey(e => e.NewsletterId)
                    .HasName("PK_Newsletter_Newsletter");

                entity.ToTable("Newsletter_Newsletter");

                entity.HasIndex(e => e.NewsletterDynamicScheduledTaskId)
                    .HasName("IX_Newsletter_Newsletter_NewsletterDynamicScheduledTaskID");

                entity.HasIndex(e => e.NewsletterOptInTemplateId)
                    .HasName("IX_Newsletter_Newsletter_NewsletterOptInTemplateID");

                entity.HasIndex(e => e.NewsletterSubscriptionTemplateId)
                    .HasName("IX_Newsletter_Newsletter_NewsletterSubscriptionTemplateID");

                entity.HasIndex(e => e.NewsletterTemplateId)
                    .HasName("IX_Newsletter_Newsletter_NewsletterTemplateID");

                entity.HasIndex(e => e.NewsletterUnsubscriptionTemplateId)
                    .HasName("IX_Newsletter_Newsletter_NewsletterUnsubscriptionTemplateID");

                entity.HasIndex(e => new { e.NewsletterSiteId, e.NewsletterDisplayName })
                    .HasName("IX_Newsletter_Newsletter_NewsletterSiteID_NewsletterDisplayName");

                entity.HasIndex(e => new { e.NewsletterSiteId, e.NewsletterName })
                    .HasName("IX_Newsletter_Newsletter_NewsletterSiteID_NewsletterName")
                    .IsUnique();

                entity.Property(e => e.NewsletterId).HasColumnName("NewsletterID");

                entity.Property(e => e.NewsletterBaseUrl).HasMaxLength(500);

                entity.Property(e => e.NewsletterDisplayName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NewsletterDraftEmails).HasMaxLength(998);

                entity.Property(e => e.NewsletterDynamicScheduledTaskId).HasColumnName("NewsletterDynamicScheduledTaskID");

                entity.Property(e => e.NewsletterDynamicSubject).HasMaxLength(100);

                entity.Property(e => e.NewsletterDynamicUrl)
                    .HasColumnName("NewsletterDynamicURL")
                    .HasMaxLength(500);

                entity.Property(e => e.NewsletterEnableOptIn).HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterGuid).HasColumnName("NewsletterGUID");

                entity.Property(e => e.NewsletterLastModified).HasDefaultValueSql("'3/13/2015 2:53:28 PM'");

                entity.Property(e => e.NewsletterLogActivity).HasDefaultValueSql("1");

                entity.Property(e => e.NewsletterName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NewsletterOptInApprovalUrl)
                    .HasColumnName("NewsletterOptInApprovalURL")
                    .HasMaxLength(450);

                entity.Property(e => e.NewsletterOptInTemplateId).HasColumnName("NewsletterOptInTemplateID");

                entity.Property(e => e.NewsletterSendOptInConfirmation).HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterSenderEmail)
                    .IsRequired()
                    .HasMaxLength(254)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.NewsletterSenderName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NewsletterSiteId).HasColumnName("NewsletterSiteID");

                entity.Property(e => e.NewsletterSource)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("N'T'");

                entity.Property(e => e.NewsletterSubscriptionTemplateId).HasColumnName("NewsletterSubscriptionTemplateID");

                entity.Property(e => e.NewsletterTemplateId).HasColumnName("NewsletterTemplateID");

                entity.Property(e => e.NewsletterTrackClickedLinks).HasDefaultValueSql("1");

                entity.Property(e => e.NewsletterTrackOpenEmails).HasDefaultValueSql("1");

                entity.Property(e => e.NewsletterType).HasDefaultValueSql("0");

                entity.Property(e => e.NewsletterUnsubscribeUrl).HasMaxLength(1000);

                entity.Property(e => e.NewsletterUnsubscriptionTemplateId).HasColumnName("NewsletterUnsubscriptionTemplateID");

                entity.HasOne(d => d.NewsletterDynamicScheduledTask)
                    .WithMany(p => p.NewsletterNewsletter)
                    .HasForeignKey(d => d.NewsletterDynamicScheduledTaskId)
                    .HasConstraintName("FK_Newsletter_Newsletter_NewsletterDynamicScheduledTaskID_CMS_ScheduledTask");

                entity.HasOne(d => d.NewsletterOptInTemplate)
                    .WithMany(p => p.NewsletterNewsletterNewsletterOptInTemplate)
                    .HasForeignKey(d => d.NewsletterOptInTemplateId)
                    .HasConstraintName("FK_Newsletter_Newsletter_NewsletterOptInTemplateID_EmailTemplate");

                entity.HasOne(d => d.NewsletterSite)
                    .WithMany(p => p.NewsletterNewsletter)
                    .HasForeignKey(d => d.NewsletterSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_Newsletter_NewsletterSiteID_CMS_Site");

                entity.HasOne(d => d.NewsletterTemplate)
                    .WithMany(p => p.NewsletterNewsletterNewsletterTemplate)
                    .HasForeignKey(d => d.NewsletterTemplateId)
                    .HasConstraintName("FK_Newsletter_Newsletter_NewsletterTemplateID_Newsletter_EmailTemplate");

                entity.HasOne(d => d.NewsletterUnsubscriptionTemplate)
                    .WithMany(p => p.NewsletterNewsletterNewsletterUnsubscriptionTemplate)
                    .HasForeignKey(d => d.NewsletterUnsubscriptionTemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_Newsletter_NewsletterUnsubscriptionTemplateID_Newsletter_EmailTemplate");
            });

            modelBuilder.Entity<NewsletterNewsletterIssue>(entity =>
            {
                entity.HasKey(e => e.IssueId)
                    .HasName("PK_Newsletter_NewsletterIssue");

                entity.ToTable("Newsletter_NewsletterIssue");

                entity.HasIndex(e => e.IssueNewsletterId)
                    .HasName("IX_Newsletter_NewsletterIssue_IssueNewsletterID");

                entity.HasIndex(e => e.IssueScheduledTaskId)
                    .HasName("IX_Newsletter_NewsletterIssue_IssueScheduledTaskID");

                entity.HasIndex(e => e.IssueShowInNewsletterArchive)
                    .HasName("IX_Newslettes_NewsletterIssue_IssueShowInNewsletterArchive");

                entity.HasIndex(e => e.IssueSiteId)
                    .HasName("IX_Newsletter_NewsletterIssue_IssueSiteID");

                entity.HasIndex(e => e.IssueTemplateId)
                    .HasName("IX_Newsletter_NewsletterIssue_IssueTemplateID");

                entity.HasIndex(e => e.IssueVariantOfIssueId)
                    .HasName("IX_Newsletter_NewsletterIssue_IssueVariantOfIssueID");

                entity.Property(e => e.IssueId)
                    .HasColumnName("IssueID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IssueGuid).HasColumnName("IssueGUID");

                entity.Property(e => e.IssueIsAbtest).HasColumnName("IssueIsABTest");

                entity.Property(e => e.IssueNewsletterId).HasColumnName("IssueNewsletterID");

                entity.Property(e => e.IssueScheduledTaskId).HasColumnName("IssueScheduledTaskID");

                entity.Property(e => e.IssueSenderEmail).HasMaxLength(254);

                entity.Property(e => e.IssueSenderName).HasMaxLength(200);

                entity.Property(e => e.IssueSiteId)
                    .HasColumnName("IssueSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IssueSubject)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IssueTemplateId).HasColumnName("IssueTemplateID");

                entity.Property(e => e.IssueText).IsRequired();

                entity.Property(e => e.IssueUseUtm)
                    .HasColumnName("IssueUseUTM")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IssueUtmcampaign)
                    .HasColumnName("IssueUTMCampaign")
                    .HasMaxLength(200);

                entity.Property(e => e.IssueUtmsource)
                    .HasColumnName("IssueUTMSource")
                    .HasMaxLength(200);

                entity.Property(e => e.IssueVariantName).HasMaxLength(200);

                entity.Property(e => e.IssueVariantOfIssueId).HasColumnName("IssueVariantOfIssueID");

                entity.HasOne(d => d.Issue)
                    .WithOne(p => p.InverseIssue)
                    .HasForeignKey<NewsletterNewsletterIssue>(d => d.IssueId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_NewsletterIssue_Newsletter_NewsletterIssue");

                entity.HasOne(d => d.IssueNewsletter)
                    .WithMany(p => p.NewsletterNewsletterIssue)
                    .HasForeignKey(d => d.IssueNewsletterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_NewsletterIssue_IssueNewsletterID_Newsletter_Newsletter");

                entity.HasOne(d => d.IssueSite)
                    .WithMany(p => p.NewsletterNewsletterIssue)
                    .HasForeignKey(d => d.IssueSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_NewsletterIssue_IssueSiteID_CMS_Site");

                entity.HasOne(d => d.IssueTemplate)
                    .WithMany(p => p.NewsletterNewsletterIssue)
                    .HasForeignKey(d => d.IssueTemplateId)
                    .HasConstraintName("FK_Newsletter_NewsletterIssue_IssueTemplateID_Newsletter_EmailTemplate");

                entity.HasOne(d => d.IssueVariantOfIssue)
                    .WithMany(p => p.InverseIssueVariantOfIssue)
                    .HasForeignKey(d => d.IssueVariantOfIssueId)
                    .HasConstraintName("FK_Newsletter_NewsletterIssue_IssueVariantOfIssue_NewsletterIssue");
            });

            modelBuilder.Entity<NewsletterOpenedEmail>(entity =>
            {
                entity.HasKey(e => e.OpenedEmailId)
                    .HasName("PK_Newsletter_OpenedEmail");

                entity.ToTable("Newsletter_OpenedEmail");

                entity.HasIndex(e => e.OpenedEmailIssueId)
                    .HasName("IX_Newsletter_OpenedEmail_OpenedEmailIssueID");

                entity.Property(e => e.OpenedEmailId).HasColumnName("OpenedEmailID");

                entity.Property(e => e.OpenedEmailEmail)
                    .IsRequired()
                    .HasMaxLength(254)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.OpenedEmailGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.OpenedEmailIssueId)
                    .HasColumnName("OpenedEmailIssueID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.OpenedEmailIssue)
                    .WithMany(p => p.NewsletterOpenedEmail)
                    .HasForeignKey(d => d.OpenedEmailIssueId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_OpenedEmail_OpenedEmailIssueID_Newsletter_NewsletterIssue");
            });

            modelBuilder.Entity<NewsletterSubscriber>(entity =>
            {
                entity.HasKey(e => e.SubscriberId)
                    .HasName("PK_Newsletter_Subscriber");

                entity.ToTable("Newsletter_Subscriber");

                entity.HasIndex(e => e.SubscriberEmail)
                    .HasName("IX_Newsletter_Subscriber_SubscriberEmail");

                entity.HasIndex(e => new { e.SubscriberSiteId, e.SubscriberFullName })
                    .HasName("IX_Newsletter_Subscriber_SubscriberSiteID_SubscriberFullName");

                entity.HasIndex(e => new { e.SubscriberType, e.SubscriberRelatedId })
                    .HasName("IX_Newsletter_Subscriber_SubscriberType_SubscriberRelatedID");

                entity.Property(e => e.SubscriberId).HasColumnName("SubscriberID");

                entity.Property(e => e.SubscriberEmail).HasMaxLength(254);

                entity.Property(e => e.SubscriberFirstName).HasMaxLength(200);

                entity.Property(e => e.SubscriberFullName).HasMaxLength(440);

                entity.Property(e => e.SubscriberGuid)
                    .HasColumnName("SubscriberGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.SubscriberLastName).HasMaxLength(200);

                entity.Property(e => e.SubscriberRelatedId)
                    .HasColumnName("SubscriberRelatedID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubscriberSiteId)
                    .HasColumnName("SubscriberSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubscriberType)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.HasOne(d => d.SubscriberSite)
                    .WithMany(p => p.NewsletterSubscriber)
                    .HasForeignKey(d => d.SubscriberSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_Subscriber_SubscriberSiteID_CMS_Site");
            });

            modelBuilder.Entity<NewsletterSubscriberNewsletter>(entity =>
            {
                entity.HasKey(e => e.SubscriberNewsletterId)
                    .HasName("PK_Newsletter_SubscriberNewsletter");

                entity.ToTable("Newsletter_SubscriberNewsletter");

                entity.HasIndex(e => new { e.NewsletterId, e.SubscriptionApproved })
                    .HasName("IX_Newsletter_SubscriberNewsletter_NewsletterID_SubscriptionApproved");

                entity.HasIndex(e => new { e.SubscriberId, e.NewsletterId })
                    .HasName("UQ_Newsletter_SubscriberNewsletter")
                    .IsUnique();

                entity.Property(e => e.SubscriberNewsletterId).HasColumnName("SubscriberNewsletterID");

                entity.Property(e => e.NewsletterId).HasColumnName("NewsletterID");

                entity.Property(e => e.SubscriberId).HasColumnName("SubscriberID");

                entity.Property(e => e.SubscriptionApprovalHash).HasMaxLength(100);

                entity.Property(e => e.SubscriptionApproved).HasDefaultValueSql("1");

                entity.HasOne(d => d.Newsletter)
                    .WithMany(p => p.NewsletterSubscriberNewsletter)
                    .HasForeignKey(d => d.NewsletterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_SubscriberNewsletter_NewsletterID_Newsletter_Newsletter");

                entity.HasOne(d => d.Subscriber)
                    .WithMany(p => p.NewsletterSubscriberNewsletter)
                    .HasForeignKey(d => d.SubscriberId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Newsletter_SubscriberNewsletter_SubscriberID_Newsletter_Subscriber");
            });

            modelBuilder.Entity<NewsletterUnsubscription>(entity =>
            {
                entity.HasKey(e => e.UnsubscriptionId)
                    .HasName("PK_Newsletter_Unsubscription");

                entity.ToTable("Newsletter_Unsubscription");

                entity.HasIndex(e => e.UnsubscriptionFromIssueId)
                    .HasName("IX_Newsletter_Unsubscription_UnsubscriptionFromIssueID");

                entity.HasIndex(e => e.UnsubscriptionNewsletterId)
                    .HasName("IX_Newsletter_Unsubscription_NewsletterID");

                entity.HasIndex(e => new { e.UnsubscriptionEmail, e.UnsubscriptionNewsletterId })
                    .HasName("IX_Newsletter_Unsubscription_Email_NewsletterID");

                entity.Property(e => e.UnsubscriptionId).HasColumnName("UnsubscriptionID");

                entity.Property(e => e.UnsubscriptionEmail)
                    .IsRequired()
                    .HasMaxLength(254)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.UnsubscriptionFromIssueId).HasColumnName("UnsubscriptionFromIssueID");

                entity.Property(e => e.UnsubscriptionGuid).HasColumnName("UnsubscriptionGUID");

                entity.Property(e => e.UnsubscriptionNewsletterId).HasColumnName("UnsubscriptionNewsletterID");

                entity.HasOne(d => d.UnsubscriptionFromIssue)
                    .WithMany(p => p.NewsletterUnsubscription)
                    .HasForeignKey(d => d.UnsubscriptionFromIssueId)
                    .HasConstraintName("FK_Newsletter_Unsubscription_UnsubscriptionFromIssueID_Newsletter_NewsletterIssue");

                entity.HasOne(d => d.UnsubscriptionNewsletter)
                    .WithMany(p => p.NewsletterUnsubscription)
                    .HasForeignKey(d => d.UnsubscriptionNewsletterId)
                    .HasConstraintName("FK_Newsletter_Unsubscription_UnsubscriptionNewsletterID_Newsletter_Newsletter");
            });

            modelBuilder.Entity<NotificationGateway>(entity =>
            {
                entity.HasKey(e => e.GatewayId)
                    .HasName("PK_Notification_Gateway");

                entity.ToTable("Notification_Gateway");

                entity.HasIndex(e => e.GatewayDisplayName)
                    .HasName("IX_Notification_Gateway_GatewayDisplayName");

                entity.Property(e => e.GatewayId).HasColumnName("GatewayID");

                entity.Property(e => e.GatewayAssemblyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GatewayClassName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GatewayDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GatewayEnabled).HasDefaultValueSql("0");

                entity.Property(e => e.GatewayGuid).HasColumnName("GatewayGUID");

                entity.Property(e => e.GatewayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GatewaySupportsEmail).HasDefaultValueSql("0");

                entity.Property(e => e.GatewaySupportsHtmltext)
                    .HasColumnName("GatewaySupportsHTMLText")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GatewaySupportsPlainText).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<NotificationSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId)
                    .HasName("PK_Notification_Subscription");

                entity.ToTable("Notification_Subscription");

                entity.HasIndex(e => e.SubscriptionGatewayId)
                    .HasName("IX_Notification_Subscription_SubscriptionGatewayID");

                entity.HasIndex(e => e.SubscriptionSiteId)
                    .HasName("IX_Notification_Subscription_SubscriptionSiteID");

                entity.HasIndex(e => e.SubscriptionTemplateId)
                    .HasName("IX_Notification_Subscription_SubscriptionTemplateID");

                entity.HasIndex(e => e.SubscriptionUserId)
                    .HasName("IX_Notification_Subscription_SubscriptionUserID");

                entity.HasIndex(e => new { e.SubscriptionEventSource, e.SubscriptionEventCode, e.SubscriptionEventObjectId })
                    .HasName("IX_Notification_Subscription_SubscriptionEventSource_SubscriptionEventCode_SubscriptionEventObjectID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.SubscriptionEventCode).HasMaxLength(100);

                entity.Property(e => e.SubscriptionEventDisplayName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SubscriptionEventObjectId).HasColumnName("SubscriptionEventObjectID");

                entity.Property(e => e.SubscriptionEventSource).HasMaxLength(100);

                entity.Property(e => e.SubscriptionGatewayId).HasColumnName("SubscriptionGatewayID");

                entity.Property(e => e.SubscriptionGuid).HasColumnName("SubscriptionGUID");

                entity.Property(e => e.SubscriptionSiteId)
                    .HasColumnName("SubscriptionSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubscriptionTarget)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SubscriptionTemplateId).HasColumnName("SubscriptionTemplateID");

                entity.Property(e => e.SubscriptionUseHtml)
                    .HasColumnName("SubscriptionUseHTML")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SubscriptionUserId).HasColumnName("SubscriptionUserID");

                entity.HasOne(d => d.SubscriptionGateway)
                    .WithMany(p => p.NotificationSubscription)
                    .HasForeignKey(d => d.SubscriptionGatewayId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Notification_Subscription_SubscriptionGatewayID_Notification_Gateway");

                entity.HasOne(d => d.SubscriptionSite)
                    .WithMany(p => p.NotificationSubscription)
                    .HasForeignKey(d => d.SubscriptionSiteId)
                    .HasConstraintName("FK_Notification_Subscription_SubscriptionSiteID_CMS_Site");

                entity.HasOne(d => d.SubscriptionTemplate)
                    .WithMany(p => p.NotificationSubscription)
                    .HasForeignKey(d => d.SubscriptionTemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Notification_Subscription_SubscriptionTemplateID_Notification_Template");

                entity.HasOne(d => d.SubscriptionUser)
                    .WithMany(p => p.NotificationSubscription)
                    .HasForeignKey(d => d.SubscriptionUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Notification_Subscription_SubscriptionUserID_CMS_User");
            });

            modelBuilder.Entity<NotificationTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PK_Notification_Template");

                entity.ToTable("Notification_Template");

                entity.HasIndex(e => e.TemplateSiteId)
                    .HasName("IX_Notification_Template_TemplateSiteID");

                entity.HasIndex(e => new { e.TemplateSiteId, e.TemplateDisplayName })
                    .HasName("IX_Notification_Template_TemplateSiteID_TemplateDisplayName");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.TemplateDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TemplateGuid).HasColumnName("TemplateGUID");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TemplateSiteId).HasColumnName("TemplateSiteID");

                entity.HasOne(d => d.TemplateSite)
                    .WithMany(p => p.NotificationTemplate)
                    .HasForeignKey(d => d.TemplateSiteId)
                    .HasConstraintName("FK_Notification_Template_TemplateSiteID_CMS_Site");
            });

            modelBuilder.Entity<NotificationTemplateText>(entity =>
            {
                entity.HasKey(e => e.TemplateTextId)
                    .HasName("PK_Notification_TemplateText");

                entity.ToTable("Notification_TemplateText");

                entity.HasIndex(e => e.GatewayId)
                    .HasName("IX_Notification_TemplateText_GatewayID");

                entity.HasIndex(e => e.TemplateId)
                    .HasName("IX_Notification_TemplateText_TemplateID");

                entity.Property(e => e.TemplateTextId).HasColumnName("TemplateTextID");

                entity.Property(e => e.GatewayId).HasColumnName("GatewayID");

                entity.Property(e => e.TemplateHtmltext)
                    .IsRequired()
                    .HasColumnName("TemplateHTMLText");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.TemplatePlainText).IsRequired();

                entity.Property(e => e.TemplateSubject)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.TemplateTextGuid).HasColumnName("TemplateTextGUID");

                entity.HasOne(d => d.Gateway)
                    .WithMany(p => p.NotificationTemplateText)
                    .HasForeignKey(d => d.GatewayId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Notification_TemplateText_GatewayID_Notification_Gateway");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.NotificationTemplateText)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Notification_TemplateText_TemplateID_Notification_Template");
            });

            modelBuilder.Entity<OmAbtest>(entity =>
            {
                entity.HasKey(e => e.AbtestId)
                    .HasName("PK_OM_ABTest");

                entity.ToTable("OM_ABTest");

                entity.HasIndex(e => e.AbtestSiteId)
                    .HasName("IX_OM_ABTest_SiteID");

                entity.Property(e => e.AbtestId).HasColumnName("ABTestID");

                entity.Property(e => e.AbtestConversions).HasColumnName("ABTestConversions");

                entity.Property(e => e.AbtestCulture)
                    .HasColumnName("ABTestCulture")
                    .HasMaxLength(50);

                entity.Property(e => e.AbtestDescription).HasColumnName("ABTestDescription");

                entity.Property(e => e.AbtestDisplayName)
                    .IsRequired()
                    .HasColumnName("ABTestDisplayName")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AbtestGuid).HasColumnName("ABTestGUID");

                entity.Property(e => e.AbtestIncludedTraffic)
                    .HasColumnName("ABTestIncludedTraffic")
                    .HasDefaultValueSql("100");

                entity.Property(e => e.AbtestLastModified).HasColumnName("ABTestLastModified");

                entity.Property(e => e.AbtestName)
                    .IsRequired()
                    .HasColumnName("ABTestName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.AbtestOpenFrom).HasColumnName("ABTestOpenFrom");

                entity.Property(e => e.AbtestOpenTo).HasColumnName("ABTestOpenTo");

                entity.Property(e => e.AbtestOriginalPage)
                    .IsRequired()
                    .HasColumnName("ABTestOriginalPage")
                    .HasMaxLength(450)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.AbtestSiteId).HasColumnName("ABTestSiteID");

                entity.Property(e => e.AbtestVisitorTargeting).HasColumnName("ABTestVisitorTargeting");

                entity.Property(e => e.AbtestWinnerGuid).HasColumnName("ABTestWinnerGUID");

                entity.HasOne(d => d.AbtestSite)
                    .WithMany(p => p.OmAbtest)
                    .HasForeignKey(d => d.AbtestSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_ABTest_SiteID_CMS_Site");
            });

            modelBuilder.Entity<OmAbvariant>(entity =>
            {
                entity.HasKey(e => e.AbvariantId)
                    .HasName("PK_OM_ABVariant");

                entity.ToTable("OM_ABVariant");

                entity.HasIndex(e => e.AbvariantSiteId)
                    .HasName("IX_OM_ABVariant_ABVariantSiteID");

                entity.HasIndex(e => e.AbvariantTestId)
                    .HasName("IX_OM_ABVariant_ABVariantTestID");

                entity.Property(e => e.AbvariantId).HasColumnName("ABVariantID");

                entity.Property(e => e.AbvariantDisplayName)
                    .IsRequired()
                    .HasColumnName("ABVariantDisplayName")
                    .HasMaxLength(110)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AbvariantGuid).HasColumnName("ABVariantGUID");

                entity.Property(e => e.AbvariantLastModified).HasColumnName("ABVariantLastModified");

                entity.Property(e => e.AbvariantName)
                    .IsRequired()
                    .HasColumnName("ABVariantName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.AbvariantPath)
                    .IsRequired()
                    .HasColumnName("ABVariantPath")
                    .HasMaxLength(450);

                entity.Property(e => e.AbvariantSiteId)
                    .HasColumnName("ABVariantSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AbvariantTestId).HasColumnName("ABVariantTestID");

                entity.HasOne(d => d.AbvariantSite)
                    .WithMany(p => p.OmAbvariant)
                    .HasForeignKey(d => d.AbvariantSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_ABVariant_CMS_Site");

                entity.HasOne(d => d.AbvariantTest)
                    .WithMany(p => p.OmAbvariant)
                    .HasForeignKey(d => d.AbvariantTestId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_ABVariant_ABVariantTestID_OM_ABTest");
            });

            modelBuilder.Entity<OmAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK_OM_Account");

                entity.ToTable("OM_Account");

                entity.HasIndex(e => e.AccountCountryId)
                    .HasName("IX_OM_Account_AccountCountryID");

                entity.HasIndex(e => e.AccountOwnerUserId)
                    .HasName("IX_OM_Account_AccountOwnerUserID");

                entity.HasIndex(e => e.AccountPrimaryContactId)
                    .HasName("IX_OM_Account_AccountPrimaryContactID");

                entity.HasIndex(e => e.AccountSecondaryContactId)
                    .HasName("IX_OM_Account_AccountSecondaryContactID");

                entity.HasIndex(e => e.AccountStateId)
                    .HasName("IX_OM_Account_AccountStateID");

                entity.HasIndex(e => e.AccountStatusId)
                    .HasName("IX_OM_Account_AccountStatusID");

                entity.HasIndex(e => e.AccountSubsidiaryOfId)
                    .HasName("IX_OM_Account_AccountSubsidiaryOfID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountAddress1).HasMaxLength(100);

                entity.Property(e => e.AccountAddress2).HasMaxLength(100);

                entity.Property(e => e.AccountCity).HasMaxLength(100);

                entity.Property(e => e.AccountCountryId).HasColumnName("AccountCountryID");

                entity.Property(e => e.AccountEmail).HasMaxLength(254);

                entity.Property(e => e.AccountFax).HasMaxLength(26);

                entity.Property(e => e.AccountGuid).HasColumnName("AccountGUID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AccountOwnerUserId).HasColumnName("AccountOwnerUserID");

                entity.Property(e => e.AccountPhone).HasMaxLength(26);

                entity.Property(e => e.AccountPrimaryContactId).HasColumnName("AccountPrimaryContactID");

                entity.Property(e => e.AccountSecondaryContactId).HasColumnName("AccountSecondaryContactID");

                entity.Property(e => e.AccountStateId).HasColumnName("AccountStateID");

                entity.Property(e => e.AccountStatusId).HasColumnName("AccountStatusID");

                entity.Property(e => e.AccountSubsidiaryOfId).HasColumnName("AccountSubsidiaryOfID");

                entity.Property(e => e.AccountWebSite).HasMaxLength(200);

                entity.Property(e => e.AccountZip)
                    .HasColumnName("AccountZIP")
                    .HasMaxLength(20);

                entity.HasOne(d => d.AccountCountry)
                    .WithMany(p => p.OmAccount)
                    .HasForeignKey(d => d.AccountCountryId)
                    .HasConstraintName("FK_OM_Account_CMS_Country");

                entity.HasOne(d => d.AccountOwnerUser)
                    .WithMany(p => p.OmAccount)
                    .HasForeignKey(d => d.AccountOwnerUserId)
                    .HasConstraintName("FK_OM_Account_CMS_User");

                entity.HasOne(d => d.AccountPrimaryContact)
                    .WithMany(p => p.OmAccountAccountPrimaryContact)
                    .HasForeignKey(d => d.AccountPrimaryContactId)
                    .HasConstraintName("FK_OM_Account_OM_Contact_PrimaryContact");

                entity.HasOne(d => d.AccountSecondaryContact)
                    .WithMany(p => p.OmAccountAccountSecondaryContact)
                    .HasForeignKey(d => d.AccountSecondaryContactId)
                    .HasConstraintName("FK_OM_Account_OM_Contact_SecondaryContact");

                entity.HasOne(d => d.AccountState)
                    .WithMany(p => p.OmAccount)
                    .HasForeignKey(d => d.AccountStateId)
                    .HasConstraintName("FK_OM_Account_CMS_State");

                entity.HasOne(d => d.AccountStatus)
                    .WithMany(p => p.OmAccount)
                    .HasForeignKey(d => d.AccountStatusId)
                    .HasConstraintName("FK_OM_Account_OM_AccountStatus");

                entity.HasOne(d => d.AccountSubsidiaryOf)
                    .WithMany(p => p.InverseAccountSubsidiaryOf)
                    .HasForeignKey(d => d.AccountSubsidiaryOfId)
                    .HasConstraintName("FK_OM_Account_OM_Account_SubsidiaryOf");
            });

            modelBuilder.Entity<OmAccountContact>(entity =>
            {
                entity.HasKey(e => e.AccountContactId)
                    .HasName("PK_OM_AccountContact");

                entity.ToTable("OM_AccountContact");

                entity.HasIndex(e => e.AccountId)
                    .HasName("IX_OM_AccountContact_AccountID");

                entity.HasIndex(e => e.ContactId)
                    .HasName("IX_OM_AccountContact_ContactID");

                entity.HasIndex(e => e.ContactRoleId)
                    .HasName("IX_OM_AccountContact_ContactRoleID");

                entity.Property(e => e.AccountContactId).HasColumnName("AccountContactID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactRoleId).HasColumnName("ContactRoleID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.OmAccountContact)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_AccountContact_OM_Account");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.OmAccountContact)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_AccountContact_OM_Contact");

                entity.HasOne(d => d.ContactRole)
                    .WithMany(p => p.OmAccountContact)
                    .HasForeignKey(d => d.ContactRoleId)
                    .HasConstraintName("FK_OM_AccountContact_OM_ContactRole");
            });

            modelBuilder.Entity<OmAccountStatus>(entity =>
            {
                entity.HasKey(e => e.AccountStatusId)
                    .HasName("PK_OM_AccountStatus");

                entity.ToTable("OM_AccountStatus");

                entity.Property(e => e.AccountStatusId).HasColumnName("AccountStatusID");

                entity.Property(e => e.AccountStatusDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AccountStatusName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OmActivity>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK_OM_Activity");

                entity.ToTable("OM_Activity");

                entity.HasIndex(e => e.ActivityContactId)
                    .HasName("IX_OM_Activity_ActivityContactID");

                entity.HasIndex(e => e.ActivityCreated)
                    .HasName("IX_OM_Activity_ActivityCreated");

                entity.HasIndex(e => e.ActivityItemDetailId)
                    .HasName("IX_OM_Activity_ActivityItemDetailID");

                entity.HasIndex(e => e.ActivitySiteId)
                    .HasName("IX_OM_Activity_ActivitySiteID");

                entity.HasIndex(e => new { e.ActivityUtmsource, e.ActivityCampaign, e.ActivityType, e.ActivityItemId, e.ActivityNodeId })
                    .HasName("IX_OM_Activity_ActivityType_ActivityItemID_ActivityNodeID_ActivityUTMSource_ActivityCampaign");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.ActivityAbvariantName)
                    .HasColumnName("ActivityABVariantName")
                    .HasMaxLength(200);

                entity.Property(e => e.ActivityCampaign).HasMaxLength(200);

                entity.Property(e => e.ActivityContactId)
                    .HasColumnName("ActivityContactID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ActivityCulture).HasMaxLength(10);

                entity.Property(e => e.ActivityIpaddress)
                    .HasColumnName("ActivityIPAddress")
                    .HasMaxLength(100);

                entity.Property(e => e.ActivityItemDetailId).HasColumnName("ActivityItemDetailID");

                entity.Property(e => e.ActivityItemId).HasColumnName("ActivityItemID");

                entity.Property(e => e.ActivityMvtcombinationName)
                    .HasColumnName("ActivityMVTCombinationName")
                    .HasMaxLength(200);

                entity.Property(e => e.ActivityNodeId).HasColumnName("ActivityNodeID");

                entity.Property(e => e.ActivitySiteId)
                    .HasColumnName("ActivitySiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ActivityTitle).HasMaxLength(250);

                entity.Property(e => e.ActivityType)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ActivityUrl).HasColumnName("ActivityURL");

                entity.Property(e => e.ActivityUrlhash)
                    .HasColumnName("ActivityURLHash")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ActivityUrlreferrer).HasColumnName("ActivityURLReferrer");

                entity.Property(e => e.ActivityUtmsource)
                    .HasColumnName("ActivityUTMSource")
                    .HasMaxLength(200);

                entity.Property(e => e.ActivityValue).HasMaxLength(250);
            });

            modelBuilder.Entity<OmActivityRecalculationQueue>(entity =>
            {
                entity.HasKey(e => e.ActivityRecalculationQueueId)
                    .HasName("PK_OM_ActivityRecalculationQueue");

                entity.ToTable("OM_ActivityRecalculationQueue");

                entity.Property(e => e.ActivityRecalculationQueueId).HasColumnName("ActivityRecalculationQueueID");

                entity.Property(e => e.ActivityRecalculationQueueActivityId)
                    .HasColumnName("ActivityRecalculationQueueActivityID")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<OmActivityType>(entity =>
            {
                entity.HasKey(e => e.ActivityTypeId)
                    .HasName("PK_OM_ActivityType");

                entity.ToTable("OM_ActivityType");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.ActivityTypeDetailFormControl).HasMaxLength(200);

                entity.Property(e => e.ActivityTypeDisplayName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ActivityTypeEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.ActivityTypeIsCustom).HasDefaultValueSql("1");

                entity.Property(e => e.ActivityTypeIsHiddenInContentOnly).HasDefaultValueSql("0");

                entity.Property(e => e.ActivityTypeMainFormControl).HasMaxLength(200);

                entity.Property(e => e.ActivityTypeName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<OmContact>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK_OM_Contact");

                entity.ToTable("OM_Contact");

                entity.HasIndex(e => e.ContactCountryId)
                    .HasName("IX_OM_Contact_ContactCountryID");

                entity.HasIndex(e => e.ContactEmail)
                    .HasName("IX_OM_Contact_ContactEmail");

                entity.HasIndex(e => e.ContactGuid)
                    .HasName("IX_OM_Contact_ContactGUID")
                    .IsUnique();

                entity.HasIndex(e => e.ContactLastName)
                    .HasName("IX_OM_Contact_ContactLastName");

                entity.HasIndex(e => e.ContactOwnerUserId)
                    .HasName("IX_OM_Contact_ContactOwnerUserID");

                entity.HasIndex(e => e.ContactStateId)
                    .HasName("IX_OM_Contact_ContactStateID");

                entity.HasIndex(e => e.ContactStatusId)
                    .HasName("IX_OM_Contact_ContactStatusID");

                entity.HasIndex(e => new { e.ContactPersonaId, e.ContactLastName })
                    .HasName("IX_OM_Contact_ContactPersonaID_ContactLastName");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactAddress1).HasMaxLength(100);

                entity.Property(e => e.ContactBusinessPhone).HasMaxLength(26);

                entity.Property(e => e.ContactCampaign).HasMaxLength(200);

                entity.Property(e => e.ContactCity).HasMaxLength(100);

                entity.Property(e => e.ContactCompanyName).HasMaxLength(100);

                entity.Property(e => e.ContactCountryId).HasColumnName("ContactCountryID");

                entity.Property(e => e.ContactCreated).HasDefaultValueSql("'5/3/2011 10:51:13 AM'");

                entity.Property(e => e.ContactEmail).HasMaxLength(254);

                entity.Property(e => e.ContactFirstName).HasMaxLength(100);

                entity.Property(e => e.ContactGuid)
                    .HasColumnName("ContactGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.ContactJobTitle).HasMaxLength(50);

                entity.Property(e => e.ContactLastName).HasMaxLength(100);

                entity.Property(e => e.ContactMiddleName).HasMaxLength(100);

                entity.Property(e => e.ContactMobilePhone).HasMaxLength(26);

                entity.Property(e => e.ContactMonitored).HasDefaultValueSql("0");

                entity.Property(e => e.ContactOwnerUserId).HasColumnName("ContactOwnerUserID");

                entity.Property(e => e.ContactPersonaId).HasColumnName("ContactPersonaID");

                entity.Property(e => e.ContactSalesForceLeadId)
                    .HasColumnName("ContactSalesForceLeadID")
                    .HasMaxLength(18);

                entity.Property(e => e.ContactSalesForceLeadReplicationDisabled).HasDefaultValueSql("0");

                entity.Property(e => e.ContactSalesForceLeadReplicationRequired).HasDefaultValueSql("0");

                entity.Property(e => e.ContactStateId).HasColumnName("ContactStateID");

                entity.Property(e => e.ContactStatusId).HasColumnName("ContactStatusID");

                entity.Property(e => e.ContactZip)
                    .HasColumnName("ContactZIP")
                    .HasMaxLength(100);

                entity.HasOne(d => d.ContactCountry)
                    .WithMany(p => p.OmContact)
                    .HasForeignKey(d => d.ContactCountryId)
                    .HasConstraintName("FK_OM_Contact_CMS_Country");

                entity.HasOne(d => d.ContactOwnerUser)
                    .WithMany(p => p.OmContact)
                    .HasForeignKey(d => d.ContactOwnerUserId)
                    .HasConstraintName("FK_OM_Contact_CMS_User");

                entity.HasOne(d => d.ContactState)
                    .WithMany(p => p.OmContact)
                    .HasForeignKey(d => d.ContactStateId)
                    .HasConstraintName("FK_OM_Contact_CMS_State");

                entity.HasOne(d => d.ContactStatus)
                    .WithMany(p => p.OmContact)
                    .HasForeignKey(d => d.ContactStatusId)
                    .HasConstraintName("FK_OM_Contact_OM_ContactStatus");
            });

            modelBuilder.Entity<OmContactChangeRecalculationQueue>(entity =>
            {
                entity.HasKey(e => e.ContactChangeRecalculationQueueId)
                    .HasName("PK_OM_ContactChangeRecalculationQueue");

                entity.ToTable("OM_ContactChangeRecalculationQueue");

                entity.Property(e => e.ContactChangeRecalculationQueueId).HasColumnName("ContactChangeRecalculationQueueID");

                entity.Property(e => e.ContactChangeRecalculationQueueContactId)
                    .HasColumnName("ContactChangeRecalculationQueueContactID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactChangeRecalculationQueueContactIsNew).HasDefaultValueSql("0");

                entity.Property(e => e.ContactChangeRecalculationQueueContactWasMerged).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<OmContactGroup>(entity =>
            {
                entity.HasKey(e => e.ContactGroupId)
                    .HasName("PK_CMS_ContactGroup");

                entity.ToTable("OM_ContactGroup");

                entity.Property(e => e.ContactGroupId).HasColumnName("ContactGroupID");

                entity.Property(e => e.ContactGroupDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ContactGroupGuid).HasColumnName("ContactGroupGUID");

                entity.Property(e => e.ContactGroupName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");
            });

            modelBuilder.Entity<OmContactGroupMember>(entity =>
            {
                entity.HasKey(e => e.ContactGroupMemberId)
                    .HasName("PK_OM_ContactGroupMember");

                entity.ToTable("OM_ContactGroupMember");

                entity.HasIndex(e => e.ContactGroupMemberRelatedId)
                    .HasName("IX_OM_ContactGroupMember_ContactGroupMemberRelatedID");

                entity.HasIndex(e => new { e.ContactGroupMemberContactGroupId, e.ContactGroupMemberType, e.ContactGroupMemberRelatedId })
                    .HasName("IX_OM_ContactGroupMember_ContactGroupID_Type_RelatedID")
                    .IsUnique();

                entity.HasIndex(e => new { e.ContactGroupMemberRelatedId, e.ContactGroupMemberFromCondition, e.ContactGroupMemberFromAccount, e.ContactGroupMemberFromManual, e.ContactGroupMemberContactGroupId, e.ContactGroupMemberType })
                    .HasName("IX_OM_ContactGroupMember_ContactGroupID_Type_MemberID_RelatedID_FromCondition_FromAccount_FromManual");

                entity.Property(e => e.ContactGroupMemberId).HasColumnName("ContactGroupMemberID");

                entity.Property(e => e.ContactGroupMemberContactGroupId).HasColumnName("ContactGroupMemberContactGroupID");

                entity.Property(e => e.ContactGroupMemberFromCondition).HasDefaultValueSql("0");

                entity.Property(e => e.ContactGroupMemberFromManual).HasDefaultValueSql("0");

                entity.Property(e => e.ContactGroupMemberRelatedId)
                    .HasColumnName("ContactGroupMemberRelatedID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ContactGroupMemberType).HasDefaultValueSql("0");

                entity.HasOne(d => d.ContactGroupMemberContactGroup)
                    .WithMany(p => p.OmContactGroupMember)
                    .HasForeignKey(d => d.ContactGroupMemberContactGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_ContactGroupMembers_OM_ContactGroup");
            });

            modelBuilder.Entity<OmContactRole>(entity =>
            {
                entity.HasKey(e => e.ContactRoleId)
                    .HasName("PK_OM_ContactRole");

                entity.ToTable("OM_ContactRole");

                entity.Property(e => e.ContactRoleId).HasColumnName("ContactRoleID");

                entity.Property(e => e.ContactRoleDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ContactRoleName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<OmContactStatus>(entity =>
            {
                entity.HasKey(e => e.ContactStatusId)
                    .HasName("PK_OM_ContactStatus");

                entity.ToTable("OM_ContactStatus");

                entity.Property(e => e.ContactStatusId).HasColumnName("ContactStatusID");

                entity.Property(e => e.ContactStatusDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ContactStatusName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<OmMembership>(entity =>
            {
                entity.HasKey(e => e.MembershipId)
                    .HasName("PK_OM_Membership");

                entity.ToTable("OM_Membership");

                entity.HasIndex(e => e.ContactId)
                    .HasName("IX_OM_Membership_ContactID");

                entity.HasIndex(e => e.RelatedId)
                    .HasName("IX_OM_Membership_RelatedID");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.ContactId)
                    .HasColumnName("ContactID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MemberType).HasDefaultValueSql("0");

                entity.Property(e => e.MembershipGuid).HasColumnName("MembershipGUID");

                entity.Property(e => e.RelatedId).HasColumnName("RelatedID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.OmMembership)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_Membership_OM_Contact");
            });

            modelBuilder.Entity<OmMvtcombination>(entity =>
            {
                entity.HasKey(e => e.MvtcombinationId)
                    .HasName("PK_OM_MVTCombination");

                entity.ToTable("OM_MVTCombination");

                entity.HasIndex(e => e.MvtcombinationPageTemplateId)
                    .HasName("IX_OM_MVTCombination_MVTCombinationPageTemplateID");

                entity.Property(e => e.MvtcombinationId).HasColumnName("MVTCombinationID");

                entity.Property(e => e.MvtcombinationConversions).HasColumnName("MVTCombinationConversions");

                entity.Property(e => e.MvtcombinationCustomName)
                    .HasColumnName("MVTCombinationCustomName")
                    .HasMaxLength(200);

                entity.Property(e => e.MvtcombinationDocumentId).HasColumnName("MVTCombinationDocumentID");

                entity.Property(e => e.MvtcombinationEnabled).HasColumnName("MVTCombinationEnabled");

                entity.Property(e => e.MvtcombinationGuid).HasColumnName("MVTCombinationGUID");

                entity.Property(e => e.MvtcombinationIsDefault)
                    .HasColumnName("MVTCombinationIsDefault")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MvtcombinationLastModified).HasColumnName("MVTCombinationLastModified");

                entity.Property(e => e.MvtcombinationName)
                    .IsRequired()
                    .HasColumnName("MVTCombinationName")
                    .HasMaxLength(200);

                entity.Property(e => e.MvtcombinationPageTemplateId).HasColumnName("MVTCombinationPageTemplateID");
            });

            modelBuilder.Entity<OmMvtcombinationVariation>(entity =>
            {
                entity.HasKey(e => new { e.MvtcombinationId, e.MvtvariantId })
                    .HasName("PK_OM_MVTCombinationVariation");

                entity.ToTable("OM_MVTCombinationVariation");

                entity.HasIndex(e => e.MvtvariantId)
                    .HasName("IX_OM_MVTCombinationVariation_MVTVariantID");

                entity.Property(e => e.MvtcombinationId).HasColumnName("MVTCombinationID");

                entity.Property(e => e.MvtvariantId).HasColumnName("MVTVariantID");

                entity.HasOne(d => d.Mvtcombination)
                    .WithMany(p => p.OmMvtcombinationVariation)
                    .HasForeignKey(d => d.MvtcombinationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_MVTCombinationVariation_OM_MVTCombination");

                entity.HasOne(d => d.Mvtvariant)
                    .WithMany(p => p.OmMvtcombinationVariation)
                    .HasForeignKey(d => d.MvtvariantId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_MVTCombinationVariation_OM_MVTVariant");
            });

            modelBuilder.Entity<OmMvtest>(entity =>
            {
                entity.HasKey(e => e.MvtestId)
                    .HasName("PK_OM_MVTest");

                entity.ToTable("OM_MVTest");

                entity.HasIndex(e => e.MvtestSiteId)
                    .HasName("IX_OM_MVTest_MVTestSiteID");

                entity.Property(e => e.MvtestId).HasColumnName("MVTestID");

                entity.Property(e => e.MvtestConversions).HasColumnName("MVTestConversions");

                entity.Property(e => e.MvtestCulture)
                    .HasColumnName("MVTestCulture")
                    .HasMaxLength(50);

                entity.Property(e => e.MvtestDescription).HasColumnName("MVTestDescription");

                entity.Property(e => e.MvtestDisplayName)
                    .IsRequired()
                    .HasColumnName("MVTestDisplayName")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MvtestEnabled)
                    .HasColumnName("MVTestEnabled")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MvtestGuid).HasColumnName("MVTestGUID");

                entity.Property(e => e.MvtestLastModified).HasColumnName("MVTestLastModified");

                entity.Property(e => e.MvtestMaxConversions).HasColumnName("MVTestMaxConversions");

                entity.Property(e => e.MvtestName)
                    .IsRequired()
                    .HasColumnName("MVTestName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MvtestOpenFrom).HasColumnName("MVTestOpenFrom");

                entity.Property(e => e.MvtestOpenTo).HasColumnName("MVTestOpenTo");

                entity.Property(e => e.MvtestPage)
                    .IsRequired()
                    .HasColumnName("MVTestPage")
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MvtestSiteId)
                    .HasColumnName("MVTestSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MvtestTargetConversionType)
                    .HasColumnName("MVTestTargetConversionType")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'TOTAL'");

                entity.HasOne(d => d.MvtestSite)
                    .WithMany(p => p.OmMvtest)
                    .HasForeignKey(d => d.MvtestSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_MVTest_MVTestSiteID_CMS_Site");
            });

            modelBuilder.Entity<OmMvtvariant>(entity =>
            {
                entity.HasKey(e => e.MvtvariantId)
                    .HasName("PK_OM_MVTVariant");

                entity.ToTable("OM_MVTVariant");

                entity.HasIndex(e => e.MvtvariantPageTemplateId)
                    .HasName("IX_OM_MVTVariant_MVTVariantPageTemplateID");

                entity.Property(e => e.MvtvariantId).HasColumnName("MVTVariantID");

                entity.Property(e => e.MvtvariantDescription).HasColumnName("MVTVariantDescription");

                entity.Property(e => e.MvtvariantDisplayName)
                    .IsRequired()
                    .HasColumnName("MVTVariantDisplayName")
                    .HasMaxLength(200);

                entity.Property(e => e.MvtvariantDocumentId).HasColumnName("MVTVariantDocumentID");

                entity.Property(e => e.MvtvariantEnabled)
                    .HasColumnName("MVTVariantEnabled")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MvtvariantGuid).HasColumnName("MVTVariantGUID");

                entity.Property(e => e.MvtvariantInstanceGuid).HasColumnName("MVTVariantInstanceGUID");

                entity.Property(e => e.MvtvariantLastModified).HasColumnName("MVTVariantLastModified");

                entity.Property(e => e.MvtvariantName)
                    .IsRequired()
                    .HasColumnName("MVTVariantName")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.MvtvariantPageTemplateId).HasColumnName("MVTVariantPageTemplateID");

                entity.Property(e => e.MvtvariantWebParts).HasColumnName("MVTVariantWebParts");

                entity.Property(e => e.MvtvariantZoneId)
                    .HasColumnName("MVTVariantZoneID")
                    .HasMaxLength(200);

                entity.HasOne(d => d.MvtvariantPageTemplate)
                    .WithMany(p => p.OmMvtvariant)
                    .HasForeignKey(d => d.MvtvariantPageTemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_MVTVariant_MVTVariantPageTemplateID_CMS_PageTemplate");
            });

            modelBuilder.Entity<OmPersonalizationVariant>(entity =>
            {
                entity.HasKey(e => e.VariantId)
                    .HasName("PK_OM_PersonalizationVariant");

                entity.ToTable("OM_PersonalizationVariant");

                entity.HasIndex(e => e.VariantDocumentId)
                    .HasName("IX_OM_PersonalizationVariant_VariantPageTemplateID");

                entity.HasIndex(e => e.VariantPageTemplateId)
                    .HasName("IX_OM_PersonalizationVariant_VariantDocumentID");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.Property(e => e.VariantDisplayCondition)
                    .IsRequired()
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VariantDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VariantDocumentId).HasColumnName("VariantDocumentID");

                entity.Property(e => e.VariantEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.VariantGuid).HasColumnName("VariantGUID");

                entity.Property(e => e.VariantInstanceGuid).HasColumnName("VariantInstanceGUID");

                entity.Property(e => e.VariantName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VariantPageTemplateId)
                    .HasColumnName("VariantPageTemplateID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VariantWebParts).IsRequired();

                entity.Property(e => e.VariantZoneId)
                    .HasColumnName("VariantZoneID")
                    .HasMaxLength(200);

                entity.HasOne(d => d.VariantDocument)
                    .WithMany(p => p.OmPersonalizationVariant)
                    .HasForeignKey(d => d.VariantDocumentId)
                    .HasConstraintName("FK_OM_PersonalizationVariant_VariantDocumentID_CMS_Document");

                entity.HasOne(d => d.VariantPageTemplate)
                    .WithMany(p => p.OmPersonalizationVariant)
                    .HasForeignKey(d => d.VariantPageTemplateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_PersonalizationVariant_VariantPageTemplateID_CMS_PageTemplate");
            });

            modelBuilder.Entity<OmRule>(entity =>
            {
                entity.HasKey(e => e.RuleId)
                    .HasName("PK_OM_Rule");

                entity.ToTable("OM_Rule");

                entity.HasIndex(e => e.RuleScoreId)
                    .HasName("IX_OM_Rule_RuleScoreID");

                entity.Property(e => e.RuleId).HasColumnName("RuleID");

                entity.Property(e => e.RuleBelongsToPersona).HasDefaultValueSql("0");

                entity.Property(e => e.RuleCondition).IsRequired();

                entity.Property(e => e.RuleDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.RuleGuid).HasColumnName("RuleGUID");

                entity.Property(e => e.RuleName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N'[_][_]AUTO[_][_]'");

                entity.Property(e => e.RuleParameter).HasMaxLength(250);

                entity.Property(e => e.RuleScoreId).HasColumnName("RuleScoreID");

                entity.Property(e => e.RuleType).HasDefaultValueSql("1");

                entity.Property(e => e.RuleValidity).HasMaxLength(50);

                entity.Property(e => e.RuleValue).HasDefaultValueSql("0");

                entity.HasOne(d => d.RuleScore)
                    .WithMany(p => p.OmRule)
                    .HasForeignKey(d => d.RuleScoreId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_Rule_OM_Score");
            });

            modelBuilder.Entity<OmScore>(entity =>
            {
                entity.HasKey(e => e.ScoreId)
                    .HasName("PK_OM_Score");

                entity.ToTable("OM_Score");

                entity.Property(e => e.ScoreId).HasColumnName("ScoreID");

                entity.Property(e => e.ScoreBelongsToPersona).HasDefaultValueSql("0");

                entity.Property(e => e.ScoreDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ScoreGuid).HasColumnName("ScoreGUID");

                entity.Property(e => e.ScoreName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ScoreNotificationEmail).HasMaxLength(998);

                entity.Property(e => e.ScoreScheduledTaskId).HasColumnName("ScoreScheduledTaskID");
            });

            modelBuilder.Entity<OmScoreContactRule>(entity =>
            {
                entity.HasKey(e => e.ScoreContactRuleId)
                    .HasName("PK_OM_ScoreContactRule");

                entity.ToTable("OM_ScoreContactRule");

                entity.HasIndex(e => e.ContactId)
                    .HasName("IX_OM_ScoreContactRule_ContactID");

                entity.HasIndex(e => e.RuleId)
                    .HasName("IX_OM_ScoreContactRule_RuleID");

                entity.HasIndex(e => new { e.ScoreId, e.ContactId, e.RuleId })
                    .HasName("UQ_OM_ScoreContactRule")
                    .IsUnique();

                entity.HasIndex(e => new { e.ContactId, e.Value, e.Expiration, e.ScoreId })
                    .HasName("IX_OM_ScoreContactRule_ScoreID_ContactID_Value_Expiration");

                entity.Property(e => e.ScoreContactRuleId).HasColumnName("ScoreContactRuleID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.RuleId).HasColumnName("RuleID");

                entity.Property(e => e.ScoreId).HasColumnName("ScoreID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.OmScoreContactRule)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_ScoreContactRule_OM_Contact");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.OmScoreContactRule)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_ScoreContactRule_OM_Rule");

                entity.HasOne(d => d.Score)
                    .WithMany(p => p.OmScoreContactRule)
                    .HasForeignKey(d => d.ScoreId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_ScoreContactRule_OM_Score");
            });

            modelBuilder.Entity<OmVisitorToContact>(entity =>
            {
                entity.HasKey(e => e.VisitorToContactId)
                    .HasName("PK_OM_VisitorToContact");

                entity.ToTable("OM_VisitorToContact");

                entity.HasIndex(e => e.VisitorToContactContactId)
                    .HasName("IX_OM_VisitorToContact_VisitorToContactContactID");

                entity.HasIndex(e => e.VisitorToContactVisitorGuid)
                    .HasName("IX_OM_VisitorToContact_VisitorToContactVisitorGUID")
                    .IsUnique();

                entity.Property(e => e.VisitorToContactId).HasColumnName("VisitorToContactID");

                entity.Property(e => e.VisitorToContactContactId)
                    .HasColumnName("VisitorToContactContactID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VisitorToContactVisitorGuid)
                    .HasColumnName("VisitorToContactVisitorGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.HasOne(d => d.VisitorToContactContact)
                    .WithMany(p => p.OmVisitorToContact)
                    .HasForeignKey(d => d.VisitorToContactContactId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OM_VisitorToContact_OM_Contact_Cascade");
            });

            modelBuilder.Entity<PersonasPersona>(entity =>
            {
                entity.HasKey(e => e.PersonaId)
                    .HasName("PK_Personas_Persona");

                entity.ToTable("Personas_Persona");

                entity.HasIndex(e => e.PersonaScoreId)
                    .HasName("IX_Personas_Persona_PersonaScoreID");

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.Property(e => e.PersonaDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.PersonaEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.PersonaGuid).HasColumnName("PersonaGUID");

                entity.Property(e => e.PersonaName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N'[_][_]AUTO[_][_]'");

                entity.Property(e => e.PersonaPictureMetafileGuid).HasColumnName("PersonaPictureMetafileGUID");

                entity.Property(e => e.PersonaPointsThreshold).HasDefaultValueSql("100");

                entity.Property(e => e.PersonaScoreId)
                    .HasColumnName("PersonaScoreID")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<PersonasPersonaNode>(entity =>
            {
                entity.HasKey(e => new { e.PersonaId, e.NodeId })
                    .HasName("PK_Personas_PersonaNode");

                entity.ToTable("Personas_PersonaNode");

                entity.HasIndex(e => e.NodeId)
                    .HasName("IX_Personas_PersonaNode_NodeID");

                entity.HasIndex(e => e.PersonaId)
                    .HasName("IX_Personas_PersonaNode_PersonaID");

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.Property(e => e.NodeId).HasColumnName("NodeID");

                entity.HasOne(d => d.Node)
                    .WithMany(p => p.PersonasPersonaNode)
                    .HasForeignKey(d => d.NodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Personas_PersonaNode_CMS_Tree");
            });

            modelBuilder.Entity<PollsPoll>(entity =>
            {
                entity.HasKey(e => e.PollId)
                    .HasName("PK_Polls_Poll");

                entity.ToTable("Polls_Poll");

                entity.HasIndex(e => e.PollGroupId)
                    .HasName("IX_Polls_Poll_PollGroupID");

                entity.HasIndex(e => new { e.PollSiteId, e.PollCodeName })
                    .HasName("IX_Polls_Poll_PollSiteID_PollCodeName");

                entity.HasIndex(e => new { e.PollSiteId, e.PollDisplayName })
                    .HasName("IX_Polls_Poll_PollSiteID_PollDisplayName");

                entity.Property(e => e.PollId).HasColumnName("PollID");

                entity.Property(e => e.PollCodeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.PollDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.PollGroupId).HasColumnName("PollGroupID");

                entity.Property(e => e.PollGuid).HasColumnName("PollGUID");

                entity.Property(e => e.PollQuestion)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.PollResponseMessage)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.PollSiteId).HasColumnName("PollSiteID");

                entity.Property(e => e.PollTitle)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.HasOne(d => d.PollGroup)
                    .WithMany(p => p.PollsPoll)
                    .HasForeignKey(d => d.PollGroupId)
                    .HasConstraintName("FK_Polls_Poll_PollGroupID_Community_Group");

                entity.HasOne(d => d.PollSite)
                    .WithMany(p => p.PollsPoll)
                    .HasForeignKey(d => d.PollSiteId)
                    .HasConstraintName("FK_Polls_Poll_PollSiteID_CMS_Site");
            });

            modelBuilder.Entity<PollsPollAnswer>(entity =>
            {
                entity.HasKey(e => e.AnswerId)
                    .HasName("PK_Polls_PollAnswer");

                entity.ToTable("Polls_PollAnswer");

                entity.HasIndex(e => e.AnswerPollId)
                    .HasName("IX_Polls_PollAnswer_AnswerPollID");

                entity.HasIndex(e => new { e.AnswerOrder, e.AnswerPollId, e.AnswerEnabled })
                    .HasName("IX_Polls_PollAnswer_AnswerPollID_AnswerOrder_AnswerEnabled");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.AnswerAlternativeForm).HasMaxLength(100);

                entity.Property(e => e.AnswerForm).HasMaxLength(100);

                entity.Property(e => e.AnswerGuid).HasColumnName("AnswerGUID");

                entity.Property(e => e.AnswerHideForm).HasDefaultValueSql("0");

                entity.Property(e => e.AnswerPollId).HasColumnName("AnswerPollID");

                entity.Property(e => e.AnswerText)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.HasOne(d => d.AnswerPoll)
                    .WithMany(p => p.PollsPollAnswer)
                    .HasForeignKey(d => d.AnswerPollId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Polls_PollAnswer_AnswerPollID_Polls_Poll");
            });

            modelBuilder.Entity<PollsPollRoles>(entity =>
            {
                entity.HasKey(e => new { e.PollId, e.RoleId })
                    .HasName("PK_Polls_PollRoles");

                entity.ToTable("Polls_PollRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_Polls_PollRoles_RoleID");

                entity.Property(e => e.PollId).HasColumnName("PollID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.PollsPollRoles)
                    .HasForeignKey(d => d.PollId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Polls_PollRoles_PollID_Polls_Poll");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PollsPollRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Polls_PollRoles_RoleID_CMS_Role");
            });

            modelBuilder.Entity<PollsPollSite>(entity =>
            {
                entity.HasKey(e => new { e.PollId, e.SiteId })
                    .HasName("PK_Polls_PollSite");

                entity.ToTable("Polls_PollSite");

                entity.HasIndex(e => e.SiteId)
                    .HasName("IX_Polls_PollSite_SiteID");

                entity.Property(e => e.PollId).HasColumnName("PollID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.PollsPollSite)
                    .HasForeignKey(d => d.PollId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Polls_PollSite_PollID_Polls_Poll");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.PollsPollSite)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Polls_PollSite_SiteID_CMS_Site");
            });

            modelBuilder.Entity<ReportingReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK_Reporting_Report");

                entity.ToTable("Reporting_Report");

                entity.HasIndex(e => e.ReportCategoryId)
                    .HasName("IX_Reporting_Report_ReportCategoryID");

                entity.HasIndex(e => e.ReportName)
                    .HasName("IX_Reporting_Report_ReportName")
                    .IsUnique();

                entity.HasIndex(e => new { e.ReportDisplayName, e.ReportCategoryId })
                    .HasName("IX_Reporting_Report_ReportCategoryID_ReportDisplayName");

                entity.HasIndex(e => new { e.ReportGuid, e.ReportName })
                    .HasName("IX_Reporting_Report_ReportGUID_ReportName");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.ReportAccess).HasDefaultValueSql("1");

                entity.Property(e => e.ReportCategoryId).HasColumnName("ReportCategoryID");

                entity.Property(e => e.ReportConnectionString).HasMaxLength(100);

                entity.Property(e => e.ReportDisplayName)
                    .IsRequired()
                    .HasMaxLength(440)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReportEnableSubscription).HasDefaultValueSql("0");

                entity.Property(e => e.ReportGuid)
                    .HasColumnName("ReportGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.ReportCategory)
                    .WithMany(p => p.ReportingReport)
                    .HasForeignKey(d => d.ReportCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Reporting_Report_ReportCategoryID_Reporting_ReportCategory");
            });

            modelBuilder.Entity<ReportingReportCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK_Reporting_ReportCategory");

                entity.ToTable("Reporting_ReportCategory");

                entity.HasIndex(e => e.CategoryParentId)
                    .HasName("IX_Reporting_ReportCategory_CategoryParentID");

                entity.HasIndex(e => e.CategoryPath)
                    .HasName("IX_Reporting_ReportCategory_CategoryPath")
                    .IsUnique();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryCodeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CategoryDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CategoryGuid).HasColumnName("CategoryGUID");

                entity.Property(e => e.CategoryImagePath).HasMaxLength(450);

                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentID");

                entity.Property(e => e.CategoryPath)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.CategoryParent)
                    .WithMany(p => p.InverseCategoryParent)
                    .HasForeignKey(d => d.CategoryParentId)
                    .HasConstraintName("FK_Reporting_ReportCategory_CategoryID_Reporting_ReportCategory_ParentCategoryID");
            });

            modelBuilder.Entity<ReportingReportGraph>(entity =>
            {
                entity.HasKey(e => e.GraphId)
                    .HasName("PK_Reporting_ReportGraph");

                entity.ToTable("Reporting_ReportGraph");

                entity.HasIndex(e => e.GraphGuid)
                    .HasName("IX_Reporting_ReportGraph_GraphGUID")
                    .IsUnique();

                entity.HasIndex(e => new { e.GraphReportId, e.GraphName })
                    .HasName("IX_Reporting_ReportGraph_GraphReportID_GraphName")
                    .IsUnique();

                entity.Property(e => e.GraphId).HasColumnName("GraphID");

                entity.Property(e => e.GraphConnectionString).HasMaxLength(100);

                entity.Property(e => e.GraphDisplayName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.GraphGuid).HasColumnName("GraphGUID");

                entity.Property(e => e.GraphName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GraphQuery).IsRequired();

                entity.Property(e => e.GraphReportId).HasColumnName("GraphReportID");

                entity.Property(e => e.GraphTitle).HasMaxLength(200);

                entity.Property(e => e.GraphType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GraphXaxisTitle)
                    .HasColumnName("GraphXAxisTitle")
                    .HasMaxLength(200);

                entity.Property(e => e.GraphYaxisTitle)
                    .HasColumnName("GraphYAxisTitle")
                    .HasMaxLength(200);

                entity.HasOne(d => d.GraphReport)
                    .WithMany(p => p.ReportingReportGraph)
                    .HasForeignKey(d => d.GraphReportId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Reporting_ReportGraph_GraphReportID_Reporting_Report");
            });

            modelBuilder.Entity<ReportingReportSubscription>(entity =>
            {
                entity.HasKey(e => e.ReportSubscriptionId)
                    .HasName("PK_Reporting_ReportSubscription");

                entity.ToTable("Reporting_ReportSubscription");

                entity.HasIndex(e => e.ReportSubscriptionGraphId)
                    .HasName("IX_Reporting_ReportSubscription_ReportSubscriptionGraphID");

                entity.HasIndex(e => e.ReportSubscriptionReportId)
                    .HasName("IX_Reporting_ReportSubscription_ReportSubscriptionReportID");

                entity.HasIndex(e => e.ReportSubscriptionSiteId)
                    .HasName("IX_Reporting_ReportSubscription_ReportSubscriptionSiteID");

                entity.HasIndex(e => e.ReportSubscriptionTableId)
                    .HasName("IX_Reporting_ReportSubscription_ReportSubscriptionTableID");

                entity.HasIndex(e => e.ReportSubscriptionUserId)
                    .HasName("IX_Reporting_ReportSubscription_ReportSubscriptionUserID");

                entity.HasIndex(e => e.ReportSubscriptionValueId)
                    .HasName("IX_Reporting_ReportSubscription_ReportSubscriptionValueID");

                entity.Property(e => e.ReportSubscriptionId).HasColumnName("ReportSubscriptionID");

                entity.Property(e => e.ReportSubscriptionEmail)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ReportSubscriptionEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.ReportSubscriptionGraphId).HasColumnName("ReportSubscriptionGraphID");

                entity.Property(e => e.ReportSubscriptionGuid).HasColumnName("ReportSubscriptionGUID");

                entity.Property(e => e.ReportSubscriptionInterval)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReportSubscriptionLastModified).HasDefaultValueSql("'3/9/2012 11:17:19 AM'");

                entity.Property(e => e.ReportSubscriptionOnlyNonEmpty).HasDefaultValueSql("1");

                entity.Property(e => e.ReportSubscriptionReportId).HasColumnName("ReportSubscriptionReportID");

                entity.Property(e => e.ReportSubscriptionSiteId).HasColumnName("ReportSubscriptionSiteID");

                entity.Property(e => e.ReportSubscriptionSubject).HasMaxLength(200);

                entity.Property(e => e.ReportSubscriptionTableId).HasColumnName("ReportSubscriptionTableID");

                entity.Property(e => e.ReportSubscriptionUserId).HasColumnName("ReportSubscriptionUserID");

                entity.Property(e => e.ReportSubscriptionValueId).HasColumnName("ReportSubscriptionValueID");

                entity.HasOne(d => d.ReportSubscriptionGraph)
                    .WithMany(p => p.ReportingReportSubscription)
                    .HasForeignKey(d => d.ReportSubscriptionGraphId)
                    .HasConstraintName("FK_Reporting_ReportSubscription_ReportSubscriptionGraphID_Reporting_ReportGraph");

                entity.HasOne(d => d.ReportSubscriptionReport)
                    .WithMany(p => p.ReportingReportSubscription)
                    .HasForeignKey(d => d.ReportSubscriptionReportId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Reporting_ReportSubscription_ReportSubscriptionReportID_Reporting_Report");

                entity.HasOne(d => d.ReportSubscriptionSite)
                    .WithMany(p => p.ReportingReportSubscription)
                    .HasForeignKey(d => d.ReportSubscriptionSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Reporting_ReportSubscription_ReportSubscriptionSiteID_CMS_Site");

                entity.HasOne(d => d.ReportSubscriptionTable)
                    .WithMany(p => p.ReportingReportSubscription)
                    .HasForeignKey(d => d.ReportSubscriptionTableId)
                    .HasConstraintName("FK_Reporting_ReportSubscription_ReportSubscriptionTableID_Reporting_ReportTable");

                entity.HasOne(d => d.ReportSubscriptionUser)
                    .WithMany(p => p.ReportingReportSubscription)
                    .HasForeignKey(d => d.ReportSubscriptionUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Reporting_ReportSubscription_ReportSubscriptionUserID_CMS_User");

                entity.HasOne(d => d.ReportSubscriptionValue)
                    .WithMany(p => p.ReportingReportSubscription)
                    .HasForeignKey(d => d.ReportSubscriptionValueId)
                    .HasConstraintName("FK_Reporting_ReportSubscription_ReportSubscriptionValueID_Reporting_ReportValue");
            });

            modelBuilder.Entity<ReportingReportTable>(entity =>
            {
                entity.HasKey(e => e.TableId)
                    .HasName("PK_Reporting_ReportTable");

                entity.ToTable("Reporting_ReportTable");

                entity.HasIndex(e => e.TableReportId)
                    .HasName("IX_Reporting_ReportTable_TableReportID");

                entity.HasIndex(e => new { e.TableName, e.TableReportId })
                    .HasName("IX_Reporting_ReportTable_TableReportID_TableName")
                    .IsUnique();

                entity.Property(e => e.TableId).HasColumnName("TableID");

                entity.Property(e => e.TableConnectionString).HasMaxLength(100);

                entity.Property(e => e.TableDisplayName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TableGuid).HasColumnName("TableGUID");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TableQuery).IsRequired();

                entity.Property(e => e.TableReportId).HasColumnName("TableReportID");

                entity.HasOne(d => d.TableReport)
                    .WithMany(p => p.ReportingReportTable)
                    .HasForeignKey(d => d.TableReportId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Reporting_ReportTable_TableReportID_Reporting_Report");
            });

            modelBuilder.Entity<ReportingReportValue>(entity =>
            {
                entity.HasKey(e => e.ValueId)
                    .HasName("PK_Reporting_ReportValue");

                entity.ToTable("Reporting_ReportValue");

                entity.HasIndex(e => e.ValueReportId)
                    .HasName("IX_Reporting_ReportValue_ValueReportID");

                entity.HasIndex(e => new { e.ValueName, e.ValueReportId })
                    .HasName("IX_Reporting_ReportValue_ValueName_ValueReportID");

                entity.Property(e => e.ValueId).HasColumnName("ValueID");

                entity.Property(e => e.ValueConnectionString).HasMaxLength(100);

                entity.Property(e => e.ValueDisplayName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.ValueFormatString).HasMaxLength(200);

                entity.Property(e => e.ValueGuid).HasColumnName("ValueGUID");

                entity.Property(e => e.ValueName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ValueQuery).IsRequired();

                entity.Property(e => e.ValueReportId).HasColumnName("ValueReportID");

                entity.HasOne(d => d.ValueReport)
                    .WithMany(p => p.ReportingReportValue)
                    .HasForeignKey(d => d.ValueReportId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Reporting_ReportValue_ValueReportID_Reporting_Report");
            });

            modelBuilder.Entity<ReportingSavedGraph>(entity =>
            {
                entity.HasKey(e => e.SavedGraphId)
                    .HasName("PK_Reporting_SavedGraph");

                entity.ToTable("Reporting_SavedGraph");

                entity.HasIndex(e => e.SavedGraphGuid)
                    .HasName("IX_Reporting_SavedGraph_SavedGraphGUID");

                entity.HasIndex(e => e.SavedGraphSavedReportId)
                    .HasName("IX_Reporting_SavedGraph_SavedGraphSavedReportID");

                entity.Property(e => e.SavedGraphId).HasColumnName("SavedGraphID");

                entity.Property(e => e.SavedGraphBinary).IsRequired();

                entity.Property(e => e.SavedGraphGuid).HasColumnName("SavedGraphGUID");

                entity.Property(e => e.SavedGraphMimeType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SavedGraphSavedReportId).HasColumnName("SavedGraphSavedReportID");

                entity.HasOne(d => d.SavedGraphSavedReport)
                    .WithMany(p => p.ReportingSavedGraph)
                    .HasForeignKey(d => d.SavedGraphSavedReportId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Reporting_SavedGraph_SavedGraphSavedReportID_Reporting_SavedReport");
            });

            modelBuilder.Entity<ReportingSavedReport>(entity =>
            {
                entity.HasKey(e => e.SavedReportId)
                    .HasName("PK_Reporting_SavedReport");

                entity.ToTable("Reporting_SavedReport");

                entity.HasIndex(e => e.SavedReportCreatedByUserId)
                    .HasName("IX_Reporting_SavedReport_SavedReportCreatedByUserID");

                entity.HasIndex(e => new { e.SavedReportReportId, e.SavedReportDate })
                    .HasName("IX_Reporting_SavedReport_SavedReportReportID_SavedReportDate");

                entity.Property(e => e.SavedReportId).HasColumnName("SavedReportID");

                entity.Property(e => e.SavedReportCreatedByUserId).HasColumnName("SavedReportCreatedByUserID");

                entity.Property(e => e.SavedReportGuid).HasColumnName("SavedReportGUID");

                entity.Property(e => e.SavedReportHtml)
                    .IsRequired()
                    .HasColumnName("SavedReportHTML");

                entity.Property(e => e.SavedReportParameters).IsRequired();

                entity.Property(e => e.SavedReportReportId).HasColumnName("SavedReportReportID");

                entity.Property(e => e.SavedReportTitle).HasMaxLength(200);

                entity.HasOne(d => d.SavedReportCreatedByUser)
                    .WithMany(p => p.ReportingSavedReport)
                    .HasForeignKey(d => d.SavedReportCreatedByUserId)
                    .HasConstraintName("FK_Reporting_SavedReport_SavedReportCreatedByUserID_CMS_User");

                entity.HasOne(d => d.SavedReportReport)
                    .WithMany(p => p.ReportingSavedReport)
                    .HasForeignKey(d => d.SavedReportReportId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Reporting_SavedReport_SavedReportReportID_Reporting_Report");
            });

            modelBuilder.Entity<SharePointSharePointConnection>(entity =>
            {
                entity.HasKey(e => e.SharePointConnectionId)
                    .HasName("PK_SharePoint_SharePointConnection");

                entity.ToTable("SharePoint_SharePointConnection");

                entity.HasIndex(e => e.SharePointConnectionSiteId)
                    .HasName("IX_SharePoint_SharePointConnection_SharePointConnectionSiteID");

                entity.Property(e => e.SharePointConnectionId).HasColumnName("SharePointConnectionID");

                entity.Property(e => e.SharePointConnectionAuthMode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("N'default'");

                entity.Property(e => e.SharePointConnectionDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SharePointConnectionDomain).HasMaxLength(100);

                entity.Property(e => e.SharePointConnectionGuid).HasColumnName("SharePointConnectionGUID");

                entity.Property(e => e.SharePointConnectionName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SharePointConnectionPassword).HasMaxLength(100);

                entity.Property(e => e.SharePointConnectionSharePointVersion)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("N'sp2010'");

                entity.Property(e => e.SharePointConnectionSiteId).HasColumnName("SharePointConnectionSiteID");

                entity.Property(e => e.SharePointConnectionSiteUrl)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.SharePointConnectionUserName).HasMaxLength(100);

                entity.HasOne(d => d.SharePointConnectionSite)
                    .WithMany(p => p.SharePointSharePointConnection)
                    .HasForeignKey(d => d.SharePointConnectionSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SharePoint_SharePointConnection_CMS_Site");
            });

            modelBuilder.Entity<SharePointSharePointFile>(entity =>
            {
                entity.HasKey(e => e.SharePointFileId)
                    .HasName("PK_SharePoint_SharePointFile");

                entity.ToTable("SharePoint_SharePointFile");

                entity.HasIndex(e => e.SharePointFileSiteId)
                    .HasName("IX_SharePoint_SharePointFile_SharePointFileSiteID");

                entity.HasIndex(e => new { e.SharePointFileSharePointLibraryId, e.SharePointFileServerRelativeUrl })
                    .HasName("UQ_SharePoint_SharePointFile_LibraryID_ServerRelativeURL")
                    .IsUnique();

                entity.Property(e => e.SharePointFileId).HasColumnName("SharePointFileID");

                entity.Property(e => e.SharePointFileEtag)
                    .HasColumnName("SharePointFileETag")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.SharePointFileExtension)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.SharePointFileGuid)
                    .HasColumnName("SharePointFileGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.SharePointFileMimeType)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.SharePointFileName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.SharePointFileServerRelativeUrl)
                    .IsRequired()
                    .HasColumnName("SharePointFileServerRelativeURL")
                    .HasMaxLength(300)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.SharePointFileSharePointLibraryId)
                    .HasColumnName("SharePointFileSharePointLibraryID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SharePointFileSiteId)
                    .HasColumnName("SharePointFileSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SharePointFileSize).HasDefaultValueSql("0");

                entity.HasOne(d => d.SharePointFileSharePointLibrary)
                    .WithMany(p => p.SharePointSharePointFile)
                    .HasForeignKey(d => d.SharePointFileSharePointLibraryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SharePoint_SharePointFile_SharePoint_SharePointLibrary");

                entity.HasOne(d => d.SharePointFileSite)
                    .WithMany(p => p.SharePointSharePointFile)
                    .HasForeignKey(d => d.SharePointFileSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SharePoint_SharePointFile_CMS_Site");
            });

            modelBuilder.Entity<SharePointSharePointLibrary>(entity =>
            {
                entity.HasKey(e => e.SharePointLibraryId)
                    .HasName("PK_SharePoint_SharePointLibrary");

                entity.ToTable("SharePoint_SharePointLibrary");

                entity.HasIndex(e => e.SharePointLibrarySharePointConnectionId)
                    .HasName("IX_SharePoint_SharePointLibrary_SharePointLibrarySharepointConnectionID");

                entity.HasIndex(e => e.SharePointLibrarySiteId)
                    .HasName("IX_SharePoint_SharePointLibrary_SharePointlibrarySiteID");

                entity.Property(e => e.SharePointLibraryId).HasColumnName("SharePointLibraryID");

                entity.Property(e => e.SharePointLibraryDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.SharePointLibraryGuid)
                    .HasColumnName("SharePointLibraryGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.SharePointLibraryLastModified).HasDefaultValueSql("'10/3/2014 2:45:04 PM'");

                entity.Property(e => e.SharePointLibraryListTitle)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.SharePointLibraryListType).HasDefaultValueSql("0");

                entity.Property(e => e.SharePointLibraryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.SharePointLibrarySharePointConnectionId)
                    .HasColumnName("SharePointLibrarySharePointConnectionID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SharePointLibrarySiteId)
                    .HasColumnName("SharePointLibrarySiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SharePointLibrarySynchronizationPeriod).HasDefaultValueSql("720");

                entity.HasOne(d => d.SharePointLibrarySharePointConnection)
                    .WithMany(p => p.SharePointSharePointLibrary)
                    .HasForeignKey(d => d.SharePointLibrarySharePointConnectionId)
                    .HasConstraintName("FK_SharePoint_SharePointLibrary_SharePoint_SharePointConnection");

                entity.HasOne(d => d.SharePointLibrarySite)
                    .WithMany(p => p.SharePointSharePointLibrary)
                    .HasForeignKey(d => d.SharePointLibrarySiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SharePoint_SharePointLibrary_CMS_Site");
            });

            modelBuilder.Entity<SmFacebookAccount>(entity =>
            {
                entity.HasKey(e => e.FacebookAccountId)
                    .HasName("PK_SM_FacebookAccount");

                entity.ToTable("SM_FacebookAccount");

                entity.HasIndex(e => e.FacebookAccountFacebookApplicationId)
                    .HasName("IX_SM_FacebookAccount_FacebookAccountFacebookApplicationID");

                entity.HasIndex(e => e.FacebookAccountSiteId)
                    .HasName("IX_SM_FacebookAccount_FacebookAccountSiteID");

                entity.Property(e => e.FacebookAccountId).HasColumnName("FacebookAccountID");

                entity.Property(e => e.FacebookAccountDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FacebookAccountFacebookApplicationId)
                    .HasColumnName("FacebookAccountFacebookApplicationID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FacebookAccountGuid).HasColumnName("FacebookAccountGUID");

                entity.Property(e => e.FacebookAccountName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FacebookAccountPageAccessToken)
                    .IsRequired()
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FacebookAccountPageId)
                    .IsRequired()
                    .HasColumnName("FacebookAccountPageID")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FacebookAccountPageUrl).HasMaxLength(1000);

                entity.Property(e => e.FacebookAccountSiteId).HasColumnName("FacebookAccountSiteID");

                entity.HasOne(d => d.FacebookAccountFacebookApplication)
                    .WithMany(p => p.SmFacebookAccount)
                    .HasForeignKey(d => d.FacebookAccountFacebookApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SM_FacebookAccount_SM_FacebookApplication");

                entity.HasOne(d => d.FacebookAccountSite)
                    .WithMany(p => p.SmFacebookAccount)
                    .HasForeignKey(d => d.FacebookAccountSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SM_FacebookAccount_CMS_Site");
            });

            modelBuilder.Entity<SmFacebookApplication>(entity =>
            {
                entity.HasKey(e => e.FacebookApplicationId)
                    .HasName("PK_SM_FacebookApplication");

                entity.ToTable("SM_FacebookApplication");

                entity.HasIndex(e => e.FacebookApplicationSiteId)
                    .HasName("IX_SM_FacebookApplication_FacebookApplicationSiteID");

                entity.Property(e => e.FacebookApplicationId).HasColumnName("FacebookApplicationID");

                entity.Property(e => e.FacebookApplicationConsumerKey)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FacebookApplicationConsumerSecret)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FacebookApplicationDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FacebookApplicationGuid)
                    .HasColumnName("FacebookApplicationGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.FacebookApplicationLastModified).HasDefaultValueSql("'5/28/2013 1:02:36 PM'");

                entity.Property(e => e.FacebookApplicationName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FacebookApplicationSiteId).HasColumnName("FacebookApplicationSiteID");

                entity.HasOne(d => d.FacebookApplicationSite)
                    .WithMany(p => p.SmFacebookApplication)
                    .HasForeignKey(d => d.FacebookApplicationSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SM_FacebookApplication_CMS_Site");
            });

            modelBuilder.Entity<SmFacebookPost>(entity =>
            {
                entity.HasKey(e => e.FacebookPostId)
                    .HasName("PK_SM_FacebookPost");

                entity.ToTable("SM_FacebookPost");

                entity.HasIndex(e => e.FacebookPostCampaignId)
                    .HasName("IX_SM_FacebookPost_FacebookPostCampaignID");

                entity.HasIndex(e => e.FacebookPostFacebookAccountId)
                    .HasName("IX_SM_FacebookPost_FacebookPostFacebookAccountID");

                entity.HasIndex(e => e.FacebookPostSiteId)
                    .HasName("IX_SM_FacebookPost_FacebookPostSiteID");

                entity.Property(e => e.FacebookPostId).HasColumnName("FacebookPostID");

                entity.Property(e => e.FacebookPostCampaignId).HasColumnName("FacebookPostCampaignID");

                entity.Property(e => e.FacebookPostDocumentGuid).HasColumnName("FacebookPostDocumentGUID");

                entity.Property(e => e.FacebookPostExternalId).HasColumnName("FacebookPostExternalID");

                entity.Property(e => e.FacebookPostFacebookAccountId)
                    .HasColumnName("FacebookPostFacebookAccountID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FacebookPostGuid).HasColumnName("FacebookPostGUID");

                entity.Property(e => e.FacebookPostIsCreatedByUser).HasDefaultValueSql("1");

                entity.Property(e => e.FacebookPostSiteId).HasColumnName("FacebookPostSiteID");

                entity.Property(e => e.FacebookPostText).IsRequired();

                entity.Property(e => e.FacebookPostUrlshortenerType).HasColumnName("FacebookPostURLShortenerType");

                entity.HasOne(d => d.FacebookPostCampaign)
                    .WithMany(p => p.SmFacebookPost)
                    .HasForeignKey(d => d.FacebookPostCampaignId);

                entity.HasOne(d => d.FacebookPostFacebookAccount)
                    .WithMany(p => p.SmFacebookPost)
                    .HasForeignKey(d => d.FacebookPostFacebookAccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SM_FacebookPost_SM_FacebookAccount");

                entity.HasOne(d => d.FacebookPostSite)
                    .WithMany(p => p.SmFacebookPost)
                    .HasForeignKey(d => d.FacebookPostSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SM_FacebookPost_CMS_Site");
            });

            modelBuilder.Entity<SmInsight>(entity =>
            {
                entity.HasKey(e => e.InsightId)
                    .HasName("PK_SM_Insight");

                entity.ToTable("SM_Insight");

                entity.HasIndex(e => new { e.InsightCodeName, e.InsightPeriodType })
                    .HasName("IX_SM_Insight_InsightCodeName_InsightPeriodType");

                entity.Property(e => e.InsightId).HasColumnName("InsightID");

                entity.Property(e => e.InsightCodeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.InsightExternalId)
                    .IsRequired()
                    .HasColumnName("InsightExternalID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.InsightPeriodType)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SmInsightHitDay>(entity =>
            {
                entity.HasKey(e => e.InsightHitId)
                    .HasName("PK_SM_InsightHit_Day");

                entity.ToTable("SM_InsightHit_Day");

                entity.HasIndex(e => new { e.InsightHitInsightId, e.InsightHitPeriodFrom, e.InsightHitPeriodTo })
                    .HasName("UQ_SM_InsightHit_Day_InsightHitInsightID_InsightHitPeriodFrom_InsightHitPeriodTo")
                    .IsUnique();

                entity.Property(e => e.InsightHitId).HasColumnName("InsightHitID");

                entity.Property(e => e.InsightHitInsightId).HasColumnName("InsightHitInsightID");

                entity.HasOne(d => d.InsightHitInsight)
                    .WithMany(p => p.SmInsightHitDay)
                    .HasForeignKey(d => d.InsightHitInsightId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SmInsightHitMonth>(entity =>
            {
                entity.HasKey(e => e.InsightHitId)
                    .HasName("PK_SM_InsightHit_Month");

                entity.ToTable("SM_InsightHit_Month");

                entity.HasIndex(e => new { e.InsightHitInsightId, e.InsightHitPeriodFrom, e.InsightHitPeriodTo })
                    .HasName("UQ_SM_InsightHit_Month_InsightHitInsightID_InsightHitPeriodFrom_InsightHitPeriodTo")
                    .IsUnique();

                entity.Property(e => e.InsightHitId).HasColumnName("InsightHitID");

                entity.Property(e => e.InsightHitInsightId).HasColumnName("InsightHitInsightID");

                entity.HasOne(d => d.InsightHitInsight)
                    .WithMany(p => p.SmInsightHitMonth)
                    .HasForeignKey(d => d.InsightHitInsightId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SmInsightHitWeek>(entity =>
            {
                entity.HasKey(e => e.InsightHitId)
                    .HasName("PK_SM_InsightHit_Week");

                entity.ToTable("SM_InsightHit_Week");

                entity.HasIndex(e => new { e.InsightHitInsightId, e.InsightHitPeriodFrom, e.InsightHitPeriodTo })
                    .HasName("UQ_SM_InsightHit_Week_InsightHitInsightID_InsightHitPeriodFrom_InsightHitPeriodTo")
                    .IsUnique();

                entity.Property(e => e.InsightHitId).HasColumnName("InsightHitID");

                entity.Property(e => e.InsightHitInsightId).HasColumnName("InsightHitInsightID");

                entity.HasOne(d => d.InsightHitInsight)
                    .WithMany(p => p.SmInsightHitWeek)
                    .HasForeignKey(d => d.InsightHitInsightId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SmInsightHitYear>(entity =>
            {
                entity.HasKey(e => e.InsightHitId)
                    .HasName("PK_SM_InsightHit_Year");

                entity.ToTable("SM_InsightHit_Year");

                entity.HasIndex(e => new { e.InsightHitInsightId, e.InsightHitPeriodFrom, e.InsightHitPeriodTo })
                    .HasName("UQ_SM_InsightHit_Year_InsightHitInsightID_InsightHitPeriodFrom_InsightHitPeriodTo")
                    .IsUnique();

                entity.Property(e => e.InsightHitId).HasColumnName("InsightHitID");

                entity.Property(e => e.InsightHitInsightId).HasColumnName("InsightHitInsightID");

                entity.HasOne(d => d.InsightHitInsight)
                    .WithMany(p => p.SmInsightHitYear)
                    .HasForeignKey(d => d.InsightHitInsightId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SmLinkedInAccount>(entity =>
            {
                entity.HasKey(e => e.LinkedInAccountId)
                    .HasName("PK_SM_LinkedInAccount");

                entity.ToTable("SM_LinkedInAccount");

                entity.Property(e => e.LinkedInAccountId).HasColumnName("LinkedInAccountID");

                entity.Property(e => e.LinkedInAccountAccessToken)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LinkedInAccountAccessTokenSecret)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LinkedInAccountDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LinkedInAccountGuid)
                    .HasColumnName("LinkedInAccountGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.LinkedInAccountLinkedInApplicationId)
                    .HasColumnName("LinkedInAccountLinkedInApplicationID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LinkedInAccountName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LinkedInAccountProfileId)
                    .IsRequired()
                    .HasColumnName("LinkedInAccountProfileID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LinkedInAccountProfileName).HasMaxLength(200);

                entity.Property(e => e.LinkedInAccountSiteId)
                    .HasColumnName("LinkedInAccountSiteID")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SmLinkedInApplication>(entity =>
            {
                entity.HasKey(e => e.LinkedInApplicationId)
                    .HasName("PK_SM_LinkedInApplication");

                entity.ToTable("SM_LinkedInApplication");

                entity.HasIndex(e => e.LinkedInApplicationSiteId)
                    .HasName("IX_SM_LinkedInApplication_LinkedInApplicationSiteID");

                entity.Property(e => e.LinkedInApplicationId).HasColumnName("LinkedInApplicationID");

                entity.Property(e => e.LinkedInApplicationConsumerKey)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LinkedInApplicationConsumerSecret)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LinkedInApplicationDisplayName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LinkedInApplicationGuid)
                    .HasColumnName("LinkedInApplicationGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.LinkedInApplicationName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LinkedInApplicationSiteId)
                    .HasColumnName("LinkedInApplicationSiteID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.LinkedInApplicationSite)
                    .WithMany(p => p.SmLinkedInApplication)
                    .HasForeignKey(d => d.LinkedInApplicationSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SM_LinkedInApplication_CMS_Site");
            });

            modelBuilder.Entity<SmLinkedInPost>(entity =>
            {
                entity.HasKey(e => e.LinkedInPostId)
                    .HasName("PK_SM_LinkedInPost");

                entity.ToTable("SM_LinkedInPost");

                entity.HasIndex(e => e.LinkedInPostCampaignId)
                    .HasName("IX_SM_LinkedInPost_LinkedInPostCampaignID");

                entity.HasIndex(e => e.LinkedInPostLinkedInAccountId)
                    .HasName("IX_SM_LinkedInPost_LinkedInPostLinkedInAccountID");

                entity.HasIndex(e => e.LinkedInPostSiteId)
                    .HasName("IX_SM_LinkedInPost_LinkedInPostSiteID");

                entity.Property(e => e.LinkedInPostId).HasColumnName("LinkedInPostID");

                entity.Property(e => e.LinkedInPostCampaignId).HasColumnName("LinkedInPostCampaignID");

                entity.Property(e => e.LinkedInPostComment)
                    .IsRequired()
                    .HasMaxLength(700)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.LinkedInPostDocumentGuid).HasColumnName("LinkedInPostDocumentGUID");

                entity.Property(e => e.LinkedInPostGuid)
                    .HasColumnName("LinkedInPostGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.LinkedInPostHttpstatusCode).HasColumnName("LinkedInPostHTTPStatusCode");

                entity.Property(e => e.LinkedInPostIsCreatedByUser).HasDefaultValueSql("1");

                entity.Property(e => e.LinkedInPostLinkedInAccountId)
                    .HasColumnName("LinkedInPostLinkedInAccountID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LinkedInPostSiteId)
                    .HasColumnName("LinkedInPostSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LinkedInPostUpdateKey).HasMaxLength(200);

                entity.Property(e => e.LinkedInPostUrlshortenerType).HasColumnName("LinkedInPostURLShortenerType");

                entity.HasOne(d => d.LinkedInPostCampaign)
                    .WithMany(p => p.SmLinkedInPost)
                    .HasForeignKey(d => d.LinkedInPostCampaignId);

                entity.HasOne(d => d.LinkedInPostLinkedInAccount)
                    .WithMany(p => p.SmLinkedInPost)
                    .HasForeignKey(d => d.LinkedInPostLinkedInAccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SM_LinkedInPost_SM_LinkedInAccount");

                entity.HasOne(d => d.LinkedInPostSite)
                    .WithMany(p => p.SmLinkedInPost)
                    .HasForeignKey(d => d.LinkedInPostSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SM_LinkedInPost_CMS_Site");
            });

            modelBuilder.Entity<SmTwitterAccount>(entity =>
            {
                entity.HasKey(e => e.TwitterAccountId)
                    .HasName("PK_SM_TwitterAccount");

                entity.ToTable("SM_TwitterAccount");

                entity.HasIndex(e => e.TwitterAccountSiteId)
                    .HasName("IX_SM_TwitterAccount_TwitterAccountSiteID");

                entity.HasIndex(e => e.TwitterAccountTwitterApplicationId)
                    .HasName("IX_SM_TwitterAccount_TwitterAccountTwitterApplicationID");

                entity.Property(e => e.TwitterAccountId).HasColumnName("TwitterAccountID");

                entity.Property(e => e.TwitterAccountAccessToken)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TwitterAccountAccessTokenSecret)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TwitterAccountDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TwitterAccountGuid).HasColumnName("TwitterAccountGUID");

                entity.Property(e => e.TwitterAccountMentionsRange).HasMaxLength(40);

                entity.Property(e => e.TwitterAccountName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TwitterAccountSiteId).HasColumnName("TwitterAccountSiteID");

                entity.Property(e => e.TwitterAccountTwitterApplicationId)
                    .HasColumnName("TwitterAccountTwitterApplicationID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TwitterAccountUserId)
                    .HasColumnName("TwitterAccountUserID")
                    .HasMaxLength(20);

                entity.HasOne(d => d.TwitterAccountSite)
                    .WithMany(p => p.SmTwitterAccount)
                    .HasForeignKey(d => d.TwitterAccountSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SM_TwitterAccount_CMS_Site");

                entity.HasOne(d => d.TwitterAccountTwitterApplication)
                    .WithMany(p => p.SmTwitterAccount)
                    .HasForeignKey(d => d.TwitterAccountTwitterApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SM_TwitterAccount_SM_TwitterApplication");
            });

            modelBuilder.Entity<SmTwitterApplication>(entity =>
            {
                entity.HasKey(e => e.TwitterApplicationId)
                    .HasName("PK_SM_TwitterApplication");

                entity.ToTable("SM_TwitterApplication");

                entity.HasIndex(e => e.TwitterApplicationSiteId)
                    .HasName("IX_SM_TwitterApplication_TwitterApplicationSiteID");

                entity.Property(e => e.TwitterApplicationId).HasColumnName("TwitterApplicationID");

                entity.Property(e => e.TwitterApplicationConsumerKey)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TwitterApplicationConsumerSecret)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TwitterApplicationDisplayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TwitterApplicationGuid).HasColumnName("TwitterApplicationGUID");

                entity.Property(e => e.TwitterApplicationName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TwitterApplicationSiteId).HasColumnName("TwitterApplicationSiteID");

                entity.HasOne(d => d.TwitterApplicationSite)
                    .WithMany(p => p.SmTwitterApplication)
                    .HasForeignKey(d => d.TwitterApplicationSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SM_TwitterApplication_CMS_Site");
            });

            modelBuilder.Entity<SmTwitterPost>(entity =>
            {
                entity.HasKey(e => e.TwitterPostId)
                    .HasName("PK_SM_TwitterPost");

                entity.ToTable("SM_TwitterPost");

                entity.HasIndex(e => e.TwitterPostCampaignId)
                    .HasName("IX_SM_TwitterPost_TwitterPostCampaignID");

                entity.HasIndex(e => e.TwitterPostSiteId)
                    .HasName("IX_SM_TwitterPost_TwitterPostSiteID");

                entity.HasIndex(e => e.TwitterPostTwitterAccountId)
                    .HasName("IX_SM_TwitterPost_TwitterPostTwitterAccountID");

                entity.Property(e => e.TwitterPostId).HasColumnName("TwitterPostID");

                entity.Property(e => e.TwitterPostCampaignId).HasColumnName("TwitterPostCampaignID");

                entity.Property(e => e.TwitterPostDocumentGuid).HasColumnName("TwitterPostDocumentGUID");

                entity.Property(e => e.TwitterPostExternalId).HasColumnName("TwitterPostExternalID");

                entity.Property(e => e.TwitterPostGuid).HasColumnName("TwitterPostGUID");

                entity.Property(e => e.TwitterPostIsCreatedByUser).HasDefaultValueSql("1");

                entity.Property(e => e.TwitterPostSiteId).HasColumnName("TwitterPostSiteID");

                entity.Property(e => e.TwitterPostText)
                    .IsRequired()
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TwitterPostTwitterAccountId)
                    .HasColumnName("TwitterPostTwitterAccountID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TwitterPostUrlshortenerType).HasColumnName("TwitterPostURLShortenerType");

                entity.HasOne(d => d.TwitterPostCampaign)
                    .WithMany(p => p.SmTwitterPost)
                    .HasForeignKey(d => d.TwitterPostCampaignId);

                entity.HasOne(d => d.TwitterPostSite)
                    .WithMany(p => p.SmTwitterPost)
                    .HasForeignKey(d => d.TwitterPostSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SM_TwitterPost_CMS_Site");

                entity.HasOne(d => d.TwitterPostTwitterAccount)
                    .WithMany(p => p.SmTwitterPost)
                    .HasForeignKey(d => d.TwitterPostTwitterAccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SM_TwitterPost_SM_TwitterAccount");
            });

            modelBuilder.Entity<StagingServer>(entity =>
            {
                entity.HasKey(e => e.ServerId)
                    .HasName("PK_Staging_Server");

                entity.ToTable("Staging_Server");

                entity.HasIndex(e => e.ServerEnabled)
                    .HasName("IX_Staging_Server_ServerEnabled");

                entity.HasIndex(e => e.ServerSiteId)
                    .HasName("IX_Staging_Server_ServerSiteID");

                entity.HasIndex(e => new { e.ServerSiteId, e.ServerDisplayName })
                    .HasName("IX_Staging_Server_ServerSiteID_ServerDisplayName");

                entity.Property(e => e.ServerId).HasColumnName("ServerID");

                entity.Property(e => e.ServerAuthentication)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'USERNAME'");

                entity.Property(e => e.ServerDisplayName)
                    .IsRequired()
                    .HasMaxLength(440)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ServerEnabled).HasDefaultValueSql("1");

                entity.Property(e => e.ServerGuid)
                    .HasColumnName("ServerGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ServerPassword).HasMaxLength(100);

                entity.Property(e => e.ServerSiteId)
                    .HasColumnName("ServerSiteID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ServerUrl)
                    .IsRequired()
                    .HasColumnName("ServerURL")
                    .HasMaxLength(450)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.ServerUsername).HasMaxLength(100);

                entity.Property(e => e.ServerX509clientKeyId)
                    .HasColumnName("ServerX509ClientKeyID")
                    .HasMaxLength(200);

                entity.Property(e => e.ServerX509serverKeyId)
                    .HasColumnName("ServerX509ServerKeyID")
                    .HasMaxLength(200);

                entity.HasOne(d => d.ServerSite)
                    .WithMany(p => p.StagingServer)
                    .HasForeignKey(d => d.ServerSiteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Staging_Server_ServerSiteID_CMS_Site");
            });

            modelBuilder.Entity<StagingSynchronization>(entity =>
            {
                entity.HasKey(e => e.SynchronizationId)
                    .HasName("PK_Staging_Synchronization");

                entity.ToTable("Staging_Synchronization");

                entity.HasIndex(e => e.SynchronizationServerId)
                    .HasName("IX_Staging_Synchronization_SynchronizationServerID");

                entity.HasIndex(e => e.SynchronizationTaskId)
                    .HasName("IX_Staging_Synchronization_SynchronizationTaskID");

                entity.Property(e => e.SynchronizationId).HasColumnName("SynchronizationID");

                entity.Property(e => e.SynchronizationServerId).HasColumnName("SynchronizationServerID");

                entity.Property(e => e.SynchronizationTaskId).HasColumnName("SynchronizationTaskID");

                entity.HasOne(d => d.SynchronizationServer)
                    .WithMany(p => p.StagingSynchronization)
                    .HasForeignKey(d => d.SynchronizationServerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Staging_Synchronization_SynchronizationServerID_Staging_Server");

                entity.HasOne(d => d.SynchronizationTask)
                    .WithMany(p => p.StagingSynchronization)
                    .HasForeignKey(d => d.SynchronizationTaskId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Staging_Synchronization_SynchronizationTaskID_Staging_Task");
            });

            modelBuilder.Entity<StagingTask>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PK_Staging_Task");

                entity.ToTable("Staging_Task");

                entity.HasIndex(e => e.TaskSiteId)
                    .HasName("IX_Staging_Task_TaskSiteID");

                entity.HasIndex(e => e.TaskType)
                    .HasName("IX_Staging_Task_TaskType");

                entity.HasIndex(e => new { e.TaskDocumentId, e.TaskNodeId, e.TaskRunning })
                    .HasName("IX_Staging_Task_TaskDocumentID_TaskNodeID_TaskRunning");

                entity.HasIndex(e => new { e.TaskObjectType, e.TaskObjectId, e.TaskRunning })
                    .HasName("IX_Staging_Task_TaskObjectType_TaskObjectID_TaskRunning");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskData).IsRequired();

                entity.Property(e => e.TaskDocumentId).HasColumnName("TaskDocumentID");

                entity.Property(e => e.TaskNodeAliasPath).HasMaxLength(450);

                entity.Property(e => e.TaskNodeId).HasColumnName("TaskNodeID");

                entity.Property(e => e.TaskObjectId).HasColumnName("TaskObjectID");

                entity.Property(e => e.TaskObjectType).HasMaxLength(100);

                entity.Property(e => e.TaskServers).HasDefaultValueSql("'null'");

                entity.Property(e => e.TaskSiteId).HasColumnName("TaskSiteID");

                entity.Property(e => e.TaskTitle)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TaskType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TaskSite)
                    .WithMany(p => p.StagingTask)
                    .HasForeignKey(d => d.TaskSiteId)
                    .HasConstraintName("FK_Staging_Task_TaskSiteID_CMS_Site");
            });

            modelBuilder.Entity<StagingTaskGroup>(entity =>
            {
                entity.HasKey(e => e.TaskGroupId)
                    .HasName("PK_staging_TaskGroup");

                entity.ToTable("staging_TaskGroup");

                entity.Property(e => e.TaskGroupId).HasColumnName("TaskGroupID");

                entity.Property(e => e.TaskGroupCodeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("N''");

                entity.Property(e => e.TaskGroupGuid).HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");
            });

            modelBuilder.Entity<StagingTaskGroupTask>(entity =>
            {
                entity.HasKey(e => e.TaskGroupTaskId)
                    .HasName("PK_staging_TaskGroupTask");

                entity.ToTable("staging_TaskGroupTask");

                entity.HasIndex(e => e.TaskGroupId)
                    .HasName("IX_Staging_TaskGroupTask_TaskGroupID");

                entity.HasIndex(e => e.TaskId)
                    .HasName("IX_Staging_TaskGroupTask_TaskID");

                entity.Property(e => e.TaskGroupTaskId).HasColumnName("TaskGroupTaskID");

                entity.Property(e => e.TaskGroupId)
                    .HasColumnName("TaskGroupID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.TaskGroup)
                    .WithMany(p => p.StagingTaskGroupTask)
                    .HasForeignKey(d => d.TaskGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Staging_TaskGroupTask_Staging_TaskGroup");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.StagingTaskGroupTask)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Staging_TaskGroupTask_Staging_Task");
            });

            modelBuilder.Entity<StagingTaskGroupUser>(entity =>
            {
                entity.HasKey(e => e.TaskGroupUserId)
                    .HasName("PK_staging_TaskGroupUser");

                entity.ToTable("staging_TaskGroupUser");

                entity.HasIndex(e => e.TaskGroupId)
                    .HasName("IX_Staging_TaskGroupUser_TaskGroup_ID");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_Staging_TaskGroupUser_UserID")
                    .IsUnique();

                entity.Property(e => e.TaskGroupUserId).HasColumnName("TaskGroupUserID");

                entity.Property(e => e.TaskGroupId)
                    .HasColumnName("TaskGroupID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.TaskGroup)
                    .WithMany(p => p.StagingTaskGroupUser)
                    .HasForeignKey(d => d.TaskGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Staging_TaskGroupUser_Staging_TaskGroup");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.StagingTaskGroupUser)
                    .HasForeignKey<StagingTaskGroupUser>(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Staging_TaskGroupUser_CMS_User");
            });

            modelBuilder.Entity<StagingTaskUser>(entity =>
            {
                entity.HasKey(e => e.TaskUserId)
                    .HasName("PK_Staging_TaskUser");

                entity.ToTable("Staging_TaskUser");

                entity.HasIndex(e => e.TaskId)
                    .HasName("IX_Staging_TaskUser_TaskID");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_Staging_TaskUser_UserID");

                entity.Property(e => e.TaskUserId).HasColumnName("TaskUserID");

                entity.Property(e => e.TaskId)
                    .HasColumnName("TaskID")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.StagingTaskUser)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Staging_TaskUser_StagingTask");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StagingTaskUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Staging_TaskUser_CMS_User");
            });

            modelBuilder.Entity<TempFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK__Temp_Fil__6F0F989FF7C62559");

                entity.ToTable("Temp_File");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileDirectory)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FileExtension)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FileGuid)
                    .HasColumnName("FileGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.FileLastModified).HasDefaultValueSql("'6/29/2010 1:57:54 PM'");

                entity.Property(e => e.FileMimeType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FileNumber).HasDefaultValueSql("0");

                entity.Property(e => e.FileParentGuid)
                    .HasColumnName("FileParentGUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.FileSize).HasDefaultValueSql("0");

                entity.Property(e => e.FileTitle).HasMaxLength(250);
            });
        }
    }
}