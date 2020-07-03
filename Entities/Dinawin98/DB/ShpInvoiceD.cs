using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class ShpInvoiceD
    {
        public int ShpInvoiceHId { get; set; }
        public int ShpInvoiceDId { get; set; }
        public string ShpInvoiceDBarCode { get; set; }
        public int? InvGdsSi { get; set; }
        public decimal? ShpInvoiceDPrice { get; set; }
        public int? ShpInvoiceDSerial { get; set; }
        public int? ShpInvoiceDQty { get; set; }
        public int? ShpInvoiceDUnitPrice { get; set; }
    }
}
