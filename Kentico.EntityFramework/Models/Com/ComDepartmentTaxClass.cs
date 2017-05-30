using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComDepartmentTaxClass
    {
        public int DepartmentId { get; set; }
        public int TaxClassId { get; set; }

        public virtual ComDepartment Department { get; set; }
        public virtual ComTaxClass TaxClass { get; set; }
    }
}
