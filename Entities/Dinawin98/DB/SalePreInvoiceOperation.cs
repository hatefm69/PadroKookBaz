using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SalePreInvoiceOperation
    {
        public int SalePreInvoiceOperationId { get; set; }
        public int SalePreInvoiceId { get; set; }
        public int SalOprSi { get; set; }
        public double OperationTotalPrice { get; set; }

        public virtual SalePreInvoice SalePreInvoice { get; set; }
    }
}
