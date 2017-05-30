using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ChatSupportCannedResponse
    {
        public int ChatSupportCannedResponseId { get; set; }
        public int? ChatSupportCannedResponseChatUserId { get; set; }
        public string ChatSupportCannedResponseText { get; set; }
        public string ChatSupportCannedResponseTagName { get; set; }
        public int? ChatSupportCannedResponseSiteId { get; set; }
        public string ChatSupportCannedResponseName { get; set; }

        public virtual ChatUser ChatSupportCannedResponseChatUser { get; set; }
        public virtual Site ChatSupportCannedResponseSite { get; set; }
    }
}
