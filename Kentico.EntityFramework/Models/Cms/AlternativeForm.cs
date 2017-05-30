﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class AlternativeForm
    {
        public int FormId { get; set; }
        public string FormDisplayName { get; set; }
        public string FormName { get; set; }
        public int FormClassId { get; set; }
        public string FormDefinition { get; set; }
        public string FormLayout { get; set; }
        public Guid FormGuid { get; set; }
        public DateTime FormLastModified { get; set; }
        public int? FormCoupledClassId { get; set; }
        public bool? FormHideNewParentFields { get; set; }
        public string FormLayoutType { get; set; }
        public string FormVersionGuid { get; set; }
        public string FormCustomizedColumns { get; set; }
        public bool? FormIsCustom { get; set; }

        public virtual Class FormClass { get; set; }
        public virtual Class FormCoupledClass { get; set; }
    }
}
