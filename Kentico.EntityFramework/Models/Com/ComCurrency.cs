using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComCurrency
    {
        public ComCurrency()
        {
            ComCurrencyExchangeRate = new HashSet<ComCurrencyExchangeRate>();
            ComOrder = new HashSet<ComOrder>();
            ComShoppingCart = new HashSet<ComShoppingCart>();
        }

        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyDisplayName { get; set; }
        public string CurrencyCode { get; set; }
        public int? CurrencyRoundTo { get; set; }
        public bool CurrencyEnabled { get; set; }
        public string CurrencyFormatString { get; set; }
        public bool CurrencyIsMain { get; set; }
        public Guid? CurrencyGuid { get; set; }
        public DateTime CurrencyLastModified { get; set; }
        public int? CurrencySiteId { get; set; }

        public virtual ICollection<ComCurrencyExchangeRate> ComCurrencyExchangeRate { get; set; }
        public virtual ICollection<ComOrder> ComOrder { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCart { get; set; }
        public virtual Site CurrencySite { get; set; }
    }
}
