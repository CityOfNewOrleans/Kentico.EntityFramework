using Kentico.EntityFramework.Models.Cms;
using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class User
    {
        public User()
        {
            BlogCommentCommentApprovedByUser = new HashSet<BlogComment>();
            BlogCommentCommentUser = new HashSet<BlogComment>();
            BlogPostSubscription = new HashSet<BlogPostSubscription>();
            BoardBoard = new HashSet<BoardBoard>();
            BoardMessageMessageApprovedByUser = new HashSet<BoardMessage>();
            BoardMessageMessageUser = new HashSet<BoardMessage>();
            BoardModerator = new HashSet<BoardModerator>();
            BoardSubscription = new HashSet<BoardSubscription>();
            ChatInitiatedChatRequest = new HashSet<ChatInitiatedChatRequest>();
            ChatUser = new HashSet<ChatUser>();
            AbuseReports = new HashSet<AbuseReport>();
            CmsAclitemLastModifiedByUser = new HashSet<UserLevelPermissionItem>();
            CmsAclitemUser = new HashSet<UserLevelPermissionItem>();
            CmsAutomationHistory = new HashSet<AutomationHistory>();
            CmsAutomationState = new HashSet<AutomationState>();
            CmsCategory = new HashSet<Category>();
            CmsDocumentDocumentCheckedOutByUser = new HashSet<Document>();
            CmsDocumentDocumentCreatedByUser = new HashSet<Document>();
            CmsDocumentDocumentModifiedByUser = new HashSet<Document>();
            CmsEmailUser = new HashSet<EmailUser>();
            CmsExternalLogin = new HashSet<ExternalLogin>();
            CmsMembershipUser = new HashSet<MembershipUser>();
            CmsObjectSettings = new HashSet<ObjectSettings>();
            CmsObjectVersionHistoryVersionDeletedByUser = new HashSet<ObjectVersionHistory>();
            CmsObjectVersionHistoryVersionModifiedByUser = new HashSet<ObjectVersionHistory>();
            CmsOpenIduser = new HashSet<OpenIduser>();
            CmsPersonalization = new HashSet<Personalization>();
            CmsScheduledTask = new HashSet<ScheduledTask>();
            CmsSession = new HashSet<Session>();
            CmsTranslationSubmission = new HashSet<TranslationSubmission>();
            CmsTree = new HashSet<Tree>();
            CmsUserCulture = new HashSet<UserCulture>();
            CmsUserRole = new HashSet<UserRole>();
            CmsUserSettingsUserActivatedByUser = new HashSet<UserSettings>();
            CmsUserSettingsUserSettingsUserGu = new HashSet<UserSettings>();
            CmsUserSite = new HashSet<UserSite>();
            CmsVersionHistoryModifiedByUser = new HashSet<VersionHistory>();
            CmsVersionHistoryVersionDeletedByUser = new HashSet<VersionHistory>();
            CmsWorkflowHistory = new HashSet<WorkflowHistory>();
            CmsWorkflowStepUser = new HashSet<WorkflowStepUser>();
            CmsWorkflowUser = new HashSet<WorkflowUser>();
            ComCustomer = new HashSet<ComCustomer>();
            CommunityFriendFriendApprovedByNavigation = new HashSet<CommunityFriend>();
            CommunityFriendFriendRejectedByNavigation = new HashSet<CommunityFriend>();
            CommunityFriendFriendRequestedUser = new HashSet<CommunityFriend>();
            CommunityFriendFriendUser = new HashSet<CommunityFriend>();
            CommunityGroupGroupApprovedByUser = new HashSet<CommunityGroup>();
            CommunityGroupGroupCreatedByUser = new HashSet<CommunityGroup>();
            CommunityGroupMemberMemberApprovedByUser = new HashSet<CommunityGroupMember>();
            CommunityGroupMemberMemberInvitedByUser = new HashSet<CommunityGroupMember>();
            CommunityGroupMemberMemberUser = new HashSet<CommunityGroupMember>();
            CommunityInvitationInvitedByUser = new HashSet<CommunityInvitation>();
            CommunityInvitationInvitedUser = new HashSet<CommunityInvitation>();
            ComOrder = new HashSet<ComOrder>();
            ComOrderStatusUser = new HashSet<ComOrderStatusUser>();
            ComShoppingCart = new HashSet<ComShoppingCart>();
            ComWishlist = new HashSet<ComWishlist>();
            ExportHistory = new HashSet<ExportHistory>();
            ForumsForumModerators = new HashSet<ForumsForumModerators>();
            ForumsForumPostPostApprovedByUser = new HashSet<ForumsForumPost>();
            ForumsForumPostPostUser = new HashSet<ForumsForumPost>();
            ForumsForumSubscription = new HashSet<ForumsForumSubscription>();
            ForumsUserFavorites = new HashSet<ForumsUserFavorites>();
            MediaFileFileCreatedByUser = new HashSet<MediaFile>();
            MediaFileFileModifiedByUser = new HashSet<MediaFile>();
            MessagingContactListContactListContactUser = new HashSet<MessagingContactList>();
            MessagingContactListContactListUser = new HashSet<MessagingContactList>();
            MessagingIgnoreListIgnoreListIgnoredUser = new HashSet<MessagingIgnoreList>();
            MessagingIgnoreListIgnoreListUser = new HashSet<MessagingIgnoreList>();
            MessagingMessageMessageRecipientUser = new HashSet<MessagingMessage>();
            MessagingMessageMessageSenderUser = new HashSet<MessagingMessage>();
            NotificationSubscription = new HashSet<NotificationSubscription>();
            OmAccount = new HashSet<OmAccount>();
            OmContact = new HashSet<OmContact>();
            ReportingReportSubscription = new HashSet<ReportingReportSubscription>();
            ReportingSavedReport = new HashSet<ReportingSavedReport>();
            StagingTaskUser = new HashSet<StagingTaskUser>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string UserPassword { get; set; }
        public string PreferredCultureCode { get; set; }
        public string PreferredUicultureCode { get; set; }
        public bool UserEnabled { get; set; }
        public bool? UserIsExternal { get; set; }
        public string UserPasswordFormat { get; set; }
        public DateTime? UserCreated { get; set; }
        public DateTime? LastLogon { get; set; }
        public string UserStartingAliasPath { get; set; }
        public Guid UserGuid { get; set; }
        public DateTime UserLastModified { get; set; }
        public string UserLastLogonInfo { get; set; }
        public bool? UserIsHidden { get; set; }
        public string UserVisibility { get; set; }
        public bool? UserIsDomain { get; set; }
        public bool? UserHasAllowedCultures { get; set; }
        public Guid? UserTokenId { get; set; }
        public bool? UserMfrequired { get; set; }
        public int? UserTokenIteration { get; set; }
        public int UserPrivilegeLevel { get; set; }
        public string UserSecurityStamp { get; set; }

        public virtual ICollection<BlogComment> BlogCommentCommentApprovedByUser { get; set; }
        public virtual ICollection<BlogComment> BlogCommentCommentUser { get; set; }
        public virtual ICollection<BlogPostSubscription> BlogPostSubscription { get; set; }
        public virtual ICollection<BoardBoard> BoardBoard { get; set; }
        public virtual ICollection<BoardMessage> BoardMessageMessageApprovedByUser { get; set; }
        public virtual ICollection<BoardMessage> BoardMessageMessageUser { get; set; }
        public virtual ICollection<BoardModerator> BoardModerator { get; set; }
        public virtual ICollection<BoardSubscription> BoardSubscription { get; set; }
        public virtual ICollection<ChatInitiatedChatRequest> ChatInitiatedChatRequest { get; set; }
        public virtual ICollection<ChatUser> ChatUser { get; set; }
        public virtual ICollection<AbuseReport> AbuseReports { get; set; }
        public virtual ICollection<UserLevelPermissionItem> CmsAclitemLastModifiedByUser { get; set; }
        public virtual ICollection<UserLevelPermissionItem> CmsAclitemUser { get; set; }
        public virtual ICollection<AutomationHistory> CmsAutomationHistory { get; set; }
        public virtual ICollection<AutomationState> CmsAutomationState { get; set; }
        public virtual ICollection<Category> CmsCategory { get; set; }
        public virtual ICollection<Document> CmsDocumentDocumentCheckedOutByUser { get; set; }
        public virtual ICollection<Document> CmsDocumentDocumentCreatedByUser { get; set; }
        public virtual ICollection<Document> CmsDocumentDocumentModifiedByUser { get; set; }
        public virtual ICollection<EmailUser> CmsEmailUser { get; set; }
        public virtual ICollection<ExternalLogin> CmsExternalLogin { get; set; }
        public virtual ICollection<MembershipUser> CmsMembershipUser { get; set; }
        public virtual ICollection<ObjectSettings> CmsObjectSettings { get; set; }
        public virtual ICollection<ObjectVersionHistory> CmsObjectVersionHistoryVersionDeletedByUser { get; set; }
        public virtual ICollection<ObjectVersionHistory> CmsObjectVersionHistoryVersionModifiedByUser { get; set; }
        public virtual ICollection<OpenIduser> CmsOpenIduser { get; set; }
        public virtual ICollection<Personalization> CmsPersonalization { get; set; }
        public virtual ICollection<ScheduledTask> CmsScheduledTask { get; set; }
        public virtual ICollection<Session> CmsSession { get; set; }
        public virtual ICollection<TranslationSubmission> CmsTranslationSubmission { get; set; }
        public virtual ICollection<Tree> CmsTree { get; set; }
        public virtual ICollection<UserCulture> CmsUserCulture { get; set; }
        public virtual ICollection<UserRole> CmsUserRole { get; set; }
        public virtual ICollection<UserSettings> CmsUserSettingsUserActivatedByUser { get; set; }
        public virtual ICollection<UserSettings> CmsUserSettingsUserSettingsUserGu { get; set; }
        public virtual UserSettings CmsUserSettingsUserSettingsUser { get; set; }
        public virtual ICollection<UserSite> CmsUserSite { get; set; }
        public virtual ICollection<VersionHistory> CmsVersionHistoryModifiedByUser { get; set; }
        public virtual ICollection<VersionHistory> CmsVersionHistoryVersionDeletedByUser { get; set; }
        public virtual ICollection<WorkflowHistory> CmsWorkflowHistory { get; set; }
        public virtual ICollection<WorkflowStepUser> CmsWorkflowStepUser { get; set; }
        public virtual ICollection<WorkflowUser> CmsWorkflowUser { get; set; }
        public virtual ICollection<ComCustomer> ComCustomer { get; set; }
        public virtual ICollection<CommunityFriend> CommunityFriendFriendApprovedByNavigation { get; set; }
        public virtual ICollection<CommunityFriend> CommunityFriendFriendRejectedByNavigation { get; set; }
        public virtual ICollection<CommunityFriend> CommunityFriendFriendRequestedUser { get; set; }
        public virtual ICollection<CommunityFriend> CommunityFriendFriendUser { get; set; }
        public virtual ICollection<CommunityGroup> CommunityGroupGroupApprovedByUser { get; set; }
        public virtual ICollection<CommunityGroup> CommunityGroupGroupCreatedByUser { get; set; }
        public virtual ICollection<CommunityGroupMember> CommunityGroupMemberMemberApprovedByUser { get; set; }
        public virtual ICollection<CommunityGroupMember> CommunityGroupMemberMemberInvitedByUser { get; set; }
        public virtual ICollection<CommunityGroupMember> CommunityGroupMemberMemberUser { get; set; }
        public virtual ICollection<CommunityInvitation> CommunityInvitationInvitedByUser { get; set; }
        public virtual ICollection<CommunityInvitation> CommunityInvitationInvitedUser { get; set; }
        public virtual ICollection<ComOrder> ComOrder { get; set; }
        public virtual ICollection<ComOrderStatusUser> ComOrderStatusUser { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCart { get; set; }
        public virtual ICollection<ComWishlist> ComWishlist { get; set; }
        public virtual ICollection<ExportHistory> ExportHistory { get; set; }
        public virtual ICollection<ForumsForumModerators> ForumsForumModerators { get; set; }
        public virtual ICollection<ForumsForumPost> ForumsForumPostPostApprovedByUser { get; set; }
        public virtual ICollection<ForumsForumPost> ForumsForumPostPostUser { get; set; }
        public virtual ICollection<ForumsForumSubscription> ForumsForumSubscription { get; set; }
        public virtual ICollection<ForumsUserFavorites> ForumsUserFavorites { get; set; }
        public virtual ICollection<MediaFile> MediaFileFileCreatedByUser { get; set; }
        public virtual ICollection<MediaFile> MediaFileFileModifiedByUser { get; set; }
        public virtual ICollection<MessagingContactList> MessagingContactListContactListContactUser { get; set; }
        public virtual ICollection<MessagingContactList> MessagingContactListContactListUser { get; set; }
        public virtual ICollection<MessagingIgnoreList> MessagingIgnoreListIgnoreListIgnoredUser { get; set; }
        public virtual ICollection<MessagingIgnoreList> MessagingIgnoreListIgnoreListUser { get; set; }
        public virtual ICollection<MessagingMessage> MessagingMessageMessageRecipientUser { get; set; }
        public virtual ICollection<MessagingMessage> MessagingMessageMessageSenderUser { get; set; }
        public virtual ICollection<NotificationSubscription> NotificationSubscription { get; set; }
        public virtual ICollection<OmAccount> OmAccount { get; set; }
        public virtual ICollection<OmContact> OmContact { get; set; }
        public virtual ICollection<ReportingReportSubscription> ReportingReportSubscription { get; set; }
        public virtual ICollection<ReportingSavedReport> ReportingSavedReport { get; set; }
        public virtual StagingTaskGroupUser StagingTaskGroupUser { get; set; }
        public virtual ICollection<StagingTaskUser> StagingTaskUser { get; set; }
    }
}
