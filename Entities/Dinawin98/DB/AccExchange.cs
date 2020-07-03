using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccExchange
    {
        public int AccExchangeSi { get; set; }
        public DateTime? AccExchangeStartDate { get; set; }
        public DateTime? AccExchangeEndDate { get; set; }
        public double? AccExchangeStartRate { get; set; }
        public double? AccExchangeEndRate { get; set; }
        public int? CtbCurncySi { get; set; }
        public int? AccDocHSi { get; set; }
    }
}
