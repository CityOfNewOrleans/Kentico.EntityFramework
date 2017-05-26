using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComOptionCategory
    {
        public ComOptionCategory()
        {
            ComSku = new HashSet<ComSku>();
            ComSkuoptionCategory = new HashSet<ComSkuoptionCategory>();
        }

        public int CategoryId { get; set; }
        public string CategoryDisplayName { get; set; }
        public string CategoryName { get; set; }
        public string CategorySelectionType { get; set; }
        public string CategoryDefaultOptions { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryDefaultRecord { get; set; }
        public bool CategoryEnabled { get; set; }
        public Guid CategoryGuid { get; set; }
        public DateTime CategoryLastModified { get; set; }
        public bool? CategoryDisplayPrice { get; set; }
        public int? CategorySiteId { get; set; }
        public int? CategoryTextMaxLength { get; set; }
        public string CategoryFormControlName { get; set; }
        public string CategoryType { get; set; }
        public int? CategoryTextMinLength { get; set; }
        public string CategoryLiveSiteDisplayName { get; set; }

        public virtual ICollection<ComSku> ComSku { get; set; }
        public virtual ICollection<ComSkuoptionCategory> ComSkuoptionCategory { get; set; }
        public virtual CmsSite CategorySite { get; set; }
    }
}
