using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Cms
{
    public partial class WebFarmServerLog
    {
        public int WebFarmServerLogId { get; set; }
        public DateTime LogTime { get; set; }
        public string LogCode { get; set; }
        public int ServerId { get; set; }
    }
}
