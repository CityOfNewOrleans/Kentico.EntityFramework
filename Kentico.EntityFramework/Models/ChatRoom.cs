using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ChatRoom
    {
        public ChatRoom()
        {
            ChatMessage = new HashSet<ChatMessage>();
            ChatNotification = new HashSet<ChatNotification>();
            ChatRoomUser = new HashSet<ChatRoomUser>();
            ChatSupportTakenRoom = new HashSet<ChatSupportTakenRoom>();
        }

        public int ChatRoomId { get; set; }
        public string ChatRoomName { get; set; }
        public string ChatRoomDisplayName { get; set; }
        public int? ChatRoomSiteId { get; set; }
        public bool ChatRoomEnabled { get; set; }
        public bool ChatRoomPrivate { get; set; }
        public bool ChatRoomAllowAnonym { get; set; }
        public DateTime ChatRoomCreatedWhen { get; set; }
        public string ChatRoomPassword { get; set; }
        public int? ChatRoomCreatedByChatUserId { get; set; }
        public bool ChatRoomIsSupport { get; set; }
        public bool ChatRoomIsOneToOne { get; set; }
        public string ChatRoomDescription { get; set; }
        public DateTime ChatRoomLastModification { get; set; }
        public DateTime? ChatRoomScheduledToDelete { get; set; }
        public DateTime ChatRoomPrivateStateLastModification { get; set; }
        public Guid ChatRoomGuid { get; set; }

        public virtual ChatInitiatedChatRequest ChatInitiatedChatRequest { get; set; }
        public virtual ICollection<ChatMessage> ChatMessage { get; set; }
        public virtual ICollection<ChatNotification> ChatNotification { get; set; }
        public virtual ICollection<ChatRoomUser> ChatRoomUser { get; set; }
        public virtual ICollection<ChatSupportTakenRoom> ChatSupportTakenRoom { get; set; }
        public virtual ChatUser ChatRoomCreatedByChatUser { get; set; }
        public virtual CmsSite ChatRoomSite { get; set; }
    }
}
