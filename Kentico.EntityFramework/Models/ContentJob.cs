﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ContentJob
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public string JobSummary { get; set; }
        public string JobDescription { get; set; }
        public string JobLocation { get; set; }
        public string JobCompensation { get; set; }
        public string JobContact { get; set; }
        public Guid? JobAttachment { get; set; }
    }
}
