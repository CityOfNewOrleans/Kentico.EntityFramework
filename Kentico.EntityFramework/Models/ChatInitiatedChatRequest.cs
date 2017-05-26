using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ChatInitiatedChatRequest
    {
        public int InitiatedChatRequestId { get; set; }
        public int? InitiatedChatRequestUserId { get; set; }
        public int? InitiatedChatRequestContactId { get; set; }
        public int InitiatedChatRequestRoomId { get; set; }
        public int InitiatedChatRequestState { get; set; }
        public string InitiatedChatRequestInitiatorName { get; set; }
        public int InitiatedChatRequestInitiatorChatUserId { get; set; }
        public DateTime InitiatedChatRequestLastModification { get; set; }

        public virtual ChatUser InitiatedChatRequestInitiatorChatUser { get; set; }
        public virtual ChatRoom InitiatedChatRequestRoom { get; set; }
        public virtual CmsUser InitiatedChatRequestUser { get; set; }
    }
}
