using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Query
    {
        public int QueryId { get; set; }
        public string QueryName { get; set; }
        public int QueryTypeId { get; set; }
        public string QueryText { get; set; }
        public bool QueryRequiresTransaction { get; set; }
        public int? ClassId { get; set; }
        public bool QueryIsLocked { get; set; }
        public DateTime QueryLastModified { get; set; }
        public Guid QueryGuid { get; set; }
        public int QueryLoadGeneration { get; set; }
        public bool? QueryIsCustom { get; set; }
        public string QueryConnectionString { get; set; }

        public virtual Class Class { get; set; }
    }
}
