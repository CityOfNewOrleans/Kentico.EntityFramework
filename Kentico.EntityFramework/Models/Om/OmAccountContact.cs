using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmAccountContact
    {
        public int AccountContactId { get; set; }
        public int? ContactRoleId { get; set; }
        public int AccountId { get; set; }
        public int ContactId { get; set; }

        public virtual OmAccount Account { get; set; }
        public virtual OmContact Contact { get; set; }
        public virtual OmContactRole ContactRole { get; set; }
    }
}
