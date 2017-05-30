using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class OmContact
    {
        public OmContact()
        {
            OmAccountAccountPrimaryContact = new HashSet<OmAccount>();
            OmAccountAccountSecondaryContact = new HashSet<OmAccount>();
            OmAccountContact = new HashSet<OmAccountContact>();
            OmMembership = new HashSet<OmMembership>();
            OmScoreContactRule = new HashSet<OmScoreContactRule>();
            OmVisitorToContact = new HashSet<OmVisitorToContact>();
        }

        public int ContactId { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactMiddleName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactJobTitle { get; set; }
        public string ContactAddress1 { get; set; }
        public string ContactCity { get; set; }
        public string ContactZip { get; set; }
        public int? ContactStateId { get; set; }
        public int? ContactCountryId { get; set; }
        public string ContactMobilePhone { get; set; }
        public string ContactBusinessPhone { get; set; }
        public string ContactEmail { get; set; }
        public DateTime? ContactBirthday { get; set; }
        public int? ContactGender { get; set; }
        public int? ContactStatusId { get; set; }
        public string ContactNotes { get; set; }
        public int? ContactOwnerUserId { get; set; }
        public bool? ContactMonitored { get; set; }
        public Guid ContactGuid { get; set; }
        public DateTime ContactLastModified { get; set; }
        public DateTime ContactCreated { get; set; }
        public int? ContactBounces { get; set; }
        public string ContactCampaign { get; set; }
        public string ContactSalesForceLeadId { get; set; }
        public bool? ContactSalesForceLeadReplicationDisabled { get; set; }
        public DateTime? ContactSalesForceLeadReplicationDateTime { get; set; }
        public DateTime? ContactSalesForceLeadReplicationSuspensionDateTime { get; set; }
        public string ContactCompanyName { get; set; }
        public bool? ContactSalesForceLeadReplicationRequired { get; set; }
        public int? ContactPersonaId { get; set; }

        public virtual ICollection<OmAccount> OmAccountAccountPrimaryContact { get; set; }
        public virtual ICollection<OmAccount> OmAccountAccountSecondaryContact { get; set; }
        public virtual ICollection<OmAccountContact> OmAccountContact { get; set; }
        public virtual ICollection<OmMembership> OmMembership { get; set; }
        public virtual ICollection<OmScoreContactRule> OmScoreContactRule { get; set; }
        public virtual ICollection<OmVisitorToContact> OmVisitorToContact { get; set; }
        public virtual Country ContactCountry { get; set; }
        public virtual User ContactOwnerUser { get; set; }
        public virtual CmsState ContactState { get; set; }
        public virtual OmContactStatus ContactStatus { get; set; }
    }
}
