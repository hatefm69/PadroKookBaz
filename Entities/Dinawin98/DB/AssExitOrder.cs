using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AssExitOrder
    {
        public int AssExitOrderSi { get; set; }
        public int? AssExitOrderCu { get; set; }
        public string AssExitOrderDate { get; set; }
        public int? PerPrsnlSi { get; set; }
        public string AssExitOrderGetDate { get; set; }
        public int? AssReceiptHSi { get; set; }
        public byte? AssExitOrderDrOwFlag { get; set; }

        public virtual AssReceiptH AssReceiptHSiNavigation { get; set; }
    }
}
