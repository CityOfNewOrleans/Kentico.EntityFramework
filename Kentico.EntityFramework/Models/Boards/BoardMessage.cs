using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class BoardMessage
    {
        public int MessageId { get; set; }
        public string MessageUserName { get; set; }
        public string MessageText { get; set; }
        public string MessageEmail { get; set; }
        public string MessageUrl { get; set; }
        public bool MessageIsSpam { get; set; }
        public int MessageBoardId { get; set; }
        public bool MessageApproved { get; set; }
        public int? MessageApprovedByUserId { get; set; }
        public int? MessageUserId { get; set; }
        public string MessageUserInfo { get; set; }
        public Guid? MessageAvatarGuid { get; set; }
        public DateTime MessageInserted { get; set; }
        public DateTime MessageLastModified { get; set; }
        public Guid MessageGuid { get; set; }
        public double? MessageRatingValue { get; set; }

        public virtual User MessageApprovedByUser { get; set; }
        public virtual BoardBoard MessageBoard { get; set; }
        public virtual User MessageUser { get; set; }
    }
}
