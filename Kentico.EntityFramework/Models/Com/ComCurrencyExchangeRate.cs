using System;
using System.Collections.Generic;

namespace Kentico.EntityFramework.Models
{
    public partial class ComCurrencyExchangeRate
    {
        public int ExchagneRateId { get; set; }
        public int ExchangeRateToCurrencyId { get; set; }
        public double ExchangeRateValue { get; set; }
        public int ExchangeTableId { get; set; }
        public Guid ExchangeRateGuid { get; set; }
        public DateTime ExchangeRateLastModified { get; set; }

        public virtual ComCurrency ExchangeRateToCurrency { get; set; }
        public virtual ComExchangeTable ExchangeTable { get; set; }
    }
}
