using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComSupplier
    {
        public ComSupplier()
        {
            ComSku = new HashSet<ComSku>();
        }

        public int SupplierId { get; set; }
        public string SupplierDisplayName { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierFax { get; set; }
        public bool SupplierEnabled { get; set; }
        public Guid SupplierGuid { get; set; }
        public DateTime SupplierLastModified { get; set; }
        public int? SupplierSiteId { get; set; }
        public string SupplierName { get; set; }

        public virtual ICollection<ComSku> ComSku { get; set; }
        public virtual CmsSite SupplierSite { get; set; }
    }
}
