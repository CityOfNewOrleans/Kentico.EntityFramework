using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class EmailUser
    {
        public int EmailId { get; set; }
        public int UserId { get; set; }
        public string LastSendResult { get; set; }
        public DateTime? LastSendAttempt { get; set; }
        public int? Status { get; set; }

        public virtual Email Email { get; set; }
        public virtual User User { get; set; }
    }
}
