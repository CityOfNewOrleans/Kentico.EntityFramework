using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class MessagingMessage
    {
        public int MessageId { get; set; }
        public int? MessageSenderUserId { get; set; }
        public string MessageSenderNickName { get; set; }
        public int? MessageRecipientUserId { get; set; }
        public string MessageRecipientNickName { get; set; }
        public DateTime MessageSent { get; set; }
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }
        public DateTime? MessageRead { get; set; }
        public bool? MessageSenderDeleted { get; set; }
        public bool? MessageRecipientDeleted { get; set; }
        public Guid MessageGuid { get; set; }
        public DateTime MessageLastModified { get; set; }
        public bool? MessageIsRead { get; set; }

        public virtual User MessageRecipientUser { get; set; }
        public virtual User MessageSenderUser { get; set; }
    }
}
