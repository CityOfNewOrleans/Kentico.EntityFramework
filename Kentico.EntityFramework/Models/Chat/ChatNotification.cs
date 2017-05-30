using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ChatNotification
    {
        public int ChatNotificationId { get; set; }
        public int ChatNotificationSenderId { get; set; }
        public int ChatNotificationReceiverId { get; set; }
        public bool ChatNotificationIsRead { get; set; }
        public int ChatNotificationType { get; set; }
        public int? ChatNotificationRoomId { get; set; }
        public DateTime ChatNotificationSendDateTime { get; set; }
        public DateTime? ChatNotificationReadDateTime { get; set; }
        public int? ChatNotificationSiteId { get; set; }

        public virtual ChatUser ChatNotificationReceiver { get; set; }
        public virtual ChatRoom ChatNotificationRoom { get; set; }
        public virtual ChatUser ChatNotificationSender { get; set; }
        public virtual Site ChatNotificationSite { get; set; }
    }
}
