using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WebFarmServerTask
    {
        public int ServerId { get; set; }
        public int TaskId { get; set; }
        public string ErrorMessage { get; set; }

        public virtual WebFarmServer Server { get; set; }
        public virtual WebFarmTask Task { get; set; }
    }
}
