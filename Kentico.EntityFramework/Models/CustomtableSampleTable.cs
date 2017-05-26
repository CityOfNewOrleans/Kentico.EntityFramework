using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CustomtableSampleTable
    {
        public int ItemId { get; set; }
        public int? ItemCreatedBy { get; set; }
        public DateTime? ItemCreatedWhen { get; set; }
        public int? ItemModifiedBy { get; set; }
        public DateTime? ItemModifiedWhen { get; set; }
        public int? ItemOrder { get; set; }
        public string ItemText { get; set; }
        public Guid ItemGuid { get; set; }
    }
}
