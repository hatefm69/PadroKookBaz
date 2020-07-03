using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalCustAtntc
    {
        public int SalCustAtntcSi { get; set; }
        public int SalCustSi { get; set; }
        public string SalCustAtntcDs { get; set; }
        public decimal SalCustAtntcPrice { get; set; }
        public byte SalCustAtntcTyp { get; set; }
        public bool? SalCustAtntcActv { get; set; }
        public int? SalCustAtntcSaleType { get; set; }

        public virtual SalCust SalCustSiNavigation { get; set; }
    }
}
