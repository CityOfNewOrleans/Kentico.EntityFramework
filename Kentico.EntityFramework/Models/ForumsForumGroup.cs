using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ForumsForumGroup
    {
        public ForumsForumGroup()
        {
            ForumsForum = new HashSet<ForumsForum>();
        }

        public int GroupId { get; set; }
        public int GroupSiteId { get; set; }
        public string GroupName { get; set; }
        public string GroupDisplayName { get; set; }
        public int? GroupOrder { get; set; }
        public string GroupDescription { get; set; }
        public Guid GroupGuid { get; set; }
        public DateTime GroupLastModified { get; set; }
        public string GroupBaseUrl { get; set; }
        public string GroupUnsubscriptionUrl { get; set; }
        public int? GroupGroupId { get; set; }
        public bool? GroupAuthorEdit { get; set; }
        public bool? GroupAuthorDelete { get; set; }
        public int? GroupType { get; set; }
        public int? GroupIsAnswerLimit { get; set; }
        public int? GroupImageMaxSideSize { get; set; }
        public bool? GroupDisplayEmails { get; set; }
        public bool? GroupRequireEmail { get; set; }
        public bool? GroupHtmleditor { get; set; }
        public bool? GroupUseCaptcha { get; set; }
        public int? GroupAttachmentMaxFileSize { get; set; }
        public int? GroupDiscussionActions { get; set; }
        public bool? GroupLogActivity { get; set; }
        public bool? GroupEnableOptIn { get; set; }
        public bool? GroupSendOptInConfirmation { get; set; }
        public string GroupOptInApprovalUrl { get; set; }

        public virtual ICollection<ForumsForum> ForumsForum { get; set; }
        public virtual CommunityGroup GroupGroup { get; set; }
        public virtual CmsSite GroupSite { get; set; }
    }
}
