using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class CmsMacroRule
    {
        public int MacroRuleId { get; set; }
        public string MacroRuleName { get; set; }
        public string MacroRuleText { get; set; }
        public string MacroRuleParameters { get; set; }
        public string MacroRuleResourceName { get; set; }
        public DateTime MacroRuleLastModified { get; set; }
        public Guid MacroRuleGuid { get; set; }
        public string MacroRuleCondition { get; set; }
        public string MacroRuleDisplayName { get; set; }
        public bool? MacroRuleIsCustom { get; set; }
        public bool MacroRuleRequiresContext { get; set; }
        public string MacroRuleDescription { get; set; }
        public string MacroRuleRequiredData { get; set; }
        public bool? MacroRuleEnabled { get; set; }
    }
}
