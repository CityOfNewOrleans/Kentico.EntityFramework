﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ContentFile
    {
        public int FileId { get; set; }
        public string FileDescription { get; set; }
        public string FileName { get; set; }
        public Guid? FileAttachment { get; set; }
    }
}
