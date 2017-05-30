using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComTaxClass
    {
        public ComTaxClass()
        {
            ComDepartment = new HashSet<ComDepartment>();
            ComDepartmentTaxClass = new HashSet<ComDepartmentTaxClass>();
            ComShippingOptionTaxClass = new HashSet<ComShippingOptionTaxClass>();
            ComSkutaxClasses = new HashSet<ComSkutaxClasses>();
            ComTaxClassCountry = new HashSet<ComTaxClassCountry>();
            ComTaxClassState = new HashSet<ComTaxClassState>();
        }

        public int TaxClassId { get; set; }
        public string TaxClassName { get; set; }
        public string TaxClassDisplayName { get; set; }
        public bool? TaxClassZeroIfIdsupplied { get; set; }
        public Guid TaxClassGuid { get; set; }
        public DateTime TaxClassLastModified { get; set; }
        public int? TaxClassSiteId { get; set; }

        public virtual ICollection<ComDepartment> ComDepartment { get; set; }
        public virtual ICollection<ComDepartmentTaxClass> ComDepartmentTaxClass { get; set; }
        public virtual ICollection<ComShippingOptionTaxClass> ComShippingOptionTaxClass { get; set; }
        public virtual ICollection<ComSkutaxClasses> ComSkutaxClasses { get; set; }
        public virtual ICollection<ComTaxClassCountry> ComTaxClassCountry { get; set; }
        public virtual ICollection<ComTaxClassState> ComTaxClassState { get; set; }
        public virtual Site TaxClassSite { get; set; }
    }
}
