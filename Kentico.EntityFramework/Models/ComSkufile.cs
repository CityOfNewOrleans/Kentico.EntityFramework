using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComSkufile
    {
        public ComSkufile()
        {
            ComOrderItemSkufile = new HashSet<ComOrderItemSkufile>();
        }

        public int FileId { get; set; }
        public Guid FileGuid { get; set; }
        public int FileSkuid { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public DateTime FileLastModified { get; set; }
        public string FileName { get; set; }
        public Guid? FileMetaFileGuid { get; set; }

        public virtual ICollection<ComOrderItemSkufile> ComOrderItemSkufile { get; set; }
        public virtual ComSku FileSku { get; set; }
    }
}
