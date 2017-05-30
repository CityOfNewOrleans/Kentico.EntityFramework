using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComMultiBuyDiscountDepartment
    {
        public int MultiBuyDiscountId { get; set; }
        public int DepartmentId { get; set; }

        public virtual ComDepartment Department { get; set; }
        public virtual ComMultiBuyDiscount MultiBuyDiscount { get; set; }
    }
}
