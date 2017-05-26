using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ChatOnlineSupport
    {
        public int ChatOnlineSupportId { get; set; }
        public int ChatOnlineSupportChatUserId { get; set; }
        public DateTime ChatOnlineSupportLastChecking { get; set; }
        public int ChatOnlineSupportSiteId { get; set; }
        public string ChatOnlineSupportToken { get; set; }

        public virtual ChatUser ChatOnlineSupportChatUser { get; set; }
        public virtual CmsSite ChatOnlineSupportSite { get; set; }
    }
}
