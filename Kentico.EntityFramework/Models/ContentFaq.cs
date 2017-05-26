using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ContentFaq
    {
        public int Faqid { get; set; }
        public string Faqquestion { get; set; }
        public string Faqanswer { get; set; }
    }
}
