using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComDepartment
    {
        public ComDepartment()
        {
            ComDepartmentTaxClass = new HashSet<ComDepartmentTaxClass>();
            ComMultiBuyDiscountDepartment = new HashSet<ComMultiBuyDiscountDepartment>();
            ComSku = new HashSet<ComSku>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDisplayName { get; set; }
        public int? DepartmentDefaultTaxClassId { get; set; }
        public Guid DepartmentGuid { get; set; }
        public DateTime DepartmentLastModified { get; set; }
        public int? DepartmentSiteId { get; set; }

        public virtual ICollection<ComDepartmentTaxClass> ComDepartmentTaxClass { get; set; }
        public virtual ICollection<ComMultiBuyDiscountDepartment> ComMultiBuyDiscountDepartment { get; set; }
        public virtual ICollection<ComSku> ComSku { get; set; }
        public virtual ComTaxClass DepartmentDefaultTaxClass { get; set; }
        public virtual CmsSite DepartmentSite { get; set; }
    }
}
