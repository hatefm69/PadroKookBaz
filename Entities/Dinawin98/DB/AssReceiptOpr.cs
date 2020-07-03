using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AssReceiptOpr
    {
        public int AssReceiptOprSi { get; set; }
        public int? SalOprSi { get; set; }
        public int? AssReceiptHSi { get; set; }
        public double? AssReceiptOprValue { get; set; }
        public double? AssReceiptOprCalcValue { get; set; }
        public int? AssReceiptOprAccMSi { get; set; }
        public int? AssReceiptOprAccTSi { get; set; }

        public virtual AssReceiptH AssReceiptHSiNavigation { get; set; }
    }
}
