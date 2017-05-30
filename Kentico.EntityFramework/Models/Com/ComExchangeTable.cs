using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComExchangeTable
    {
        public ComExchangeTable()
        {
            ComCurrencyExchangeRate = new HashSet<ComCurrencyExchangeRate>();
        }

        public int ExchangeTableId { get; set; }
        public string ExchangeTableDisplayName { get; set; }
        public DateTime? ExchangeTableValidFrom { get; set; }
        public DateTime? ExchangeTableValidTo { get; set; }
        public Guid ExchangeTableGuid { get; set; }
        public DateTime ExchangeTableLastModified { get; set; }
        public int? ExchangeTableSiteId { get; set; }
        public double? ExchangeTableRateFromGlobalCurrency { get; set; }

        public virtual ICollection<ComCurrencyExchangeRate> ComCurrencyExchangeRate { get; set; }
        public virtual Site ExchangeTableSite { get; set; }
    }
}
