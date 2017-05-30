using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class MessagingContactList
    {
        public int ContactListUserId { get; set; }
        public int ContactListContactUserId { get; set; }

        public virtual User ContactListContactUser { get; set; }
        public virtual User ContactListUser { get; set; }
    }
}
