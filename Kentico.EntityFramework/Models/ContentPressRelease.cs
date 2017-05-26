using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ContentPressRelease
    {
        public int PressReleaseId { get; set; }
        public string PressReleaseTitle { get; set; }
        public DateTime PressReleaseDate { get; set; }
        public string PressReleaseSummary { get; set; }
        public string PressReleaseText { get; set; }
        public string PressReleaseAbout { get; set; }
        public string PressReleaseTrademarks { get; set; }
    }
}
