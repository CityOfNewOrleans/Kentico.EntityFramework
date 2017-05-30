using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ContentBlog
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public string BlogDescription { get; set; }
        public string BlogSideColumnText { get; set; }
        public Guid? BlogTeaser { get; set; }
        public string BlogOpenCommentsFor { get; set; }
        public bool? BlogRequireEmails { get; set; }
        public string BlogSendCommentsToEmail { get; set; }
        public bool BlogAllowAnonymousComments { get; set; }
        public bool BlogUseCaptchaforComments { get; set; }
        public bool BlogModerateComments { get; set; }
        public string BlogModerators { get; set; }
        public bool? BlogEnableSubscriptions { get; set; }
        public int? BlogEnableOptIn { get; set; }
        public int? BlogSendOptInConfirmation { get; set; }
        public string BlogUnsubscriptionUrl { get; set; }
        public string BlogOptInApprovalUrl { get; set; }
    }
}
