﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ChatMessage
    {
        public int ChatMessageId { get; set; }
        public DateTime ChatMessageCreatedWhen { get; set; }
        public string ChatMessageIpaddress { get; set; }
        public int? ChatMessageUserId { get; set; }
        public int ChatMessageRoomId { get; set; }
        public bool ChatMessageRejected { get; set; }
        public DateTime ChatMessageLastModified { get; set; }
        public string ChatMessageText { get; set; }
        public int ChatMessageSystemMessageType { get; set; }
        public int? ChatMessageRecipientId { get; set; }

        public virtual ChatUser ChatMessageRecipient { get; set; }
        public virtual ChatRoom ChatMessageRoom { get; set; }
        public virtual ChatUser ChatMessageUser { get; set; }
    }
}
