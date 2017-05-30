using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models.Content
{
    public partial class Faq
    {
        public int Faqid { get; set; }
        public string Faqquestion { get; set; }
        public string Faqanswer { get; set; }
    }
}
