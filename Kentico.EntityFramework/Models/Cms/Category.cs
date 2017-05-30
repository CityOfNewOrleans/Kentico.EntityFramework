using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class Category
    {
        public Category()
        {
            CmsDocumentCategory = new HashSet<DocumentCategory>();
        }

        public int CategoryId { get; set; }
        public string CategoryDisplayName { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int? CategoryCount { get; set; }
        public bool CategoryEnabled { get; set; }
        public int? CategoryUserId { get; set; }
        public Guid CategoryGuid { get; set; }
        public DateTime CategoryLastModified { get; set; }
        public int? CategorySiteId { get; set; }
        public int? CategoryParentId { get; set; }
        public string CategoryIdpath { get; set; }
        public string CategoryNamePath { get; set; }
        public int? CategoryLevel { get; set; }
        public int? CategoryOrder { get; set; }

        public virtual ICollection<DocumentCategory> CmsDocumentCategory { get; set; }
        public virtual Site CategorySite { get; set; }
        public virtual User CategoryUser { get; set; }
    }
}
