using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmVisitorToContact
    {
        public int VisitorToContactId { get; set; }
        public Guid VisitorToContactVisitorGuid { get; set; }
        public int VisitorToContactContactId { get; set; }

        public virtual OmContact VisitorToContactContact { get; set; }
    }
}
