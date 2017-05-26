using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsHelpTopic
    {
        public int HelpTopicId { get; set; }
        public int HelpTopicUielementId { get; set; }
        public string HelpTopicName { get; set; }
        public string HelpTopicLink { get; set; }
        public DateTime HelpTopicLastModified { get; set; }
        public Guid HelpTopicGuid { get; set; }
        public int? HelpTopicOrder { get; set; }
    }
}
