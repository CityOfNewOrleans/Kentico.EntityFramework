using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ChatUser
    {
        public ChatUser()
        {
            ChatInitiatedChatRequest = new HashSet<ChatInitiatedChatRequest>();
            ChatMessageChatMessageRecipient = new HashSet<ChatMessage>();
            ChatMessageChatMessageUser = new HashSet<ChatMessage>();
            ChatNotificationChatNotificationReceiver = new HashSet<ChatNotification>();
            ChatNotificationChatNotificationSender = new HashSet<ChatNotification>();
            ChatOnlineSupport = new HashSet<ChatOnlineSupport>();
            ChatOnlineUser = new HashSet<ChatOnlineUser>();
            ChatRoom = new HashSet<ChatRoom>();
            ChatRoomUser = new HashSet<ChatRoomUser>();
            ChatSupportCannedResponse = new HashSet<ChatSupportCannedResponse>();
            ChatSupportTakenRoom = new HashSet<ChatSupportTakenRoom>();
        }

        public int ChatUserId { get; set; }
        public int? ChatUserUserId { get; set; }
        public string ChatUserNickname { get; set; }
        public DateTime ChatUserLastModification { get; set; }

        public virtual ICollection<ChatInitiatedChatRequest> ChatInitiatedChatRequest { get; set; }
        public virtual ICollection<ChatMessage> ChatMessageChatMessageRecipient { get; set; }
        public virtual ICollection<ChatMessage> ChatMessageChatMessageUser { get; set; }
        public virtual ICollection<ChatNotification> ChatNotificationChatNotificationReceiver { get; set; }
        public virtual ICollection<ChatNotification> ChatNotificationChatNotificationSender { get; set; }
        public virtual ICollection<ChatOnlineSupport> ChatOnlineSupport { get; set; }
        public virtual ICollection<ChatOnlineUser> ChatOnlineUser { get; set; }
        public virtual ICollection<ChatRoom> ChatRoom { get; set; }
        public virtual ICollection<ChatRoomUser> ChatRoomUser { get; set; }
        public virtual ICollection<ChatSupportCannedResponse> ChatSupportCannedResponse { get; set; }
        public virtual ICollection<ChatSupportTakenRoom> ChatSupportTakenRoom { get; set; }
        public virtual User ChatUserUser { get; set; }
    }
}
