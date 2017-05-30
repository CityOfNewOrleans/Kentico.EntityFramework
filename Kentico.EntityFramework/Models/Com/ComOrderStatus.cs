using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComOrderStatus
    {
        public ComOrderStatus()
        {
            ComOrder = new HashSet<ComOrder>();
            ComOrderStatusUserFromStatus = new HashSet<ComOrderStatusUser>();
            ComOrderStatusUserToStatus = new HashSet<ComOrderStatusUser>();
            ComPaymentOptionPaymentOptionFailedOrderStatus = new HashSet<ComPaymentOption>();
            ComPaymentOptionPaymentOptionSucceededOrderStatus = new HashSet<ComPaymentOption>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string StatusDisplayName { get; set; }
        public int? StatusOrder { get; set; }
        public bool StatusEnabled { get; set; }
        public string StatusColor { get; set; }
        public Guid StatusGuid { get; set; }
        public DateTime StatusLastModified { get; set; }
        public bool? StatusSendNotification { get; set; }
        public int? StatusSiteId { get; set; }
        public bool? StatusOrderIsPaid { get; set; }

        public virtual ICollection<ComOrder> ComOrder { get; set; }
        public virtual ICollection<ComOrderStatusUser> ComOrderStatusUserFromStatus { get; set; }
        public virtual ICollection<ComOrderStatusUser> ComOrderStatusUserToStatus { get; set; }
        public virtual ICollection<ComPaymentOption> ComPaymentOptionPaymentOptionFailedOrderStatus { get; set; }
        public virtual ICollection<ComPaymentOption> ComPaymentOptionPaymentOptionSucceededOrderStatus { get; set; }
        public virtual Site StatusSite { get; set; }
    }
}
