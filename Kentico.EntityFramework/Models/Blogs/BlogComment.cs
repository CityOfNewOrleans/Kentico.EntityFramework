﻿using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class BlogComment
    {
        public int CommentId { get; set; }
        public string CommentUserName { get; set; }
        public int? CommentUserId { get; set; }
        public string CommentUrl { get; set; }
        public string CommentText { get; set; }
        public int? CommentApprovedByUserId { get; set; }
        public int CommentPostDocumentId { get; set; }
        public DateTime CommentDate { get; set; }
        public bool? CommentIsSpam { get; set; }
        public bool? CommentApproved { get; set; }
        public string CommentEmail { get; set; }
        public string CommentInfo { get; set; }
        public Guid CommentGuid { get; set; }

        public virtual User CommentApprovedByUser { get; set; }
        public virtual Document CommentPostDocument { get; set; }
        public virtual User CommentUser { get; set; }
    }
}
