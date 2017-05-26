using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class BoardBoard
    {
        public BoardBoard()
        {
            BoardMessage = new HashSet<BoardMessage>();
            BoardModerator = new HashSet<BoardModerator>();
            BoardRole = new HashSet<BoardRole>();
            BoardSubscription = new HashSet<BoardSubscription>();
        }

        public int BoardId { get; set; }
        public string BoardName { get; set; }
        public string BoardDisplayName { get; set; }
        public string BoardDescription { get; set; }
        public bool BoardOpened { get; set; }
        public DateTime? BoardOpenedFrom { get; set; }
        public DateTime? BoardOpenedTo { get; set; }
        public bool BoardEnabled { get; set; }
        public int BoardAccess { get; set; }
        public bool BoardModerated { get; set; }
        public bool BoardUseCaptcha { get; set; }
        public int BoardMessages { get; set; }
        public DateTime BoardLastModified { get; set; }
        public Guid BoardGuid { get; set; }
        public int BoardDocumentId { get; set; }
        public int? BoardUserId { get; set; }
        public int? BoardGroupId { get; set; }
        public DateTime? BoardLastMessageTime { get; set; }
        public string BoardLastMessageUserName { get; set; }
        public string BoardUnsubscriptionUrl { get; set; }
        public bool? BoardRequireEmails { get; set; }
        public int BoardSiteId { get; set; }
        public bool BoardEnableSubscriptions { get; set; }
        public string BoardBaseUrl { get; set; }
        public bool? BoardLogActivity { get; set; }
        public bool? BoardEnableOptIn { get; set; }
        public bool? BoardSendOptInConfirmation { get; set; }
        public string BoardOptInApprovalUrl { get; set; }

        public virtual ICollection<BoardMessage> BoardMessage { get; set; }
        public virtual ICollection<BoardModerator> BoardModerator { get; set; }
        public virtual ICollection<BoardRole> BoardRole { get; set; }
        public virtual ICollection<BoardSubscription> BoardSubscription { get; set; }
        public virtual CmsDocument BoardDocument { get; set; }
        public virtual CommunityGroup BoardGroup { get; set; }
        public virtual CmsSite BoardSite { get; set; }
        public virtual CmsUser BoardUser { get; set; }
    }
}
