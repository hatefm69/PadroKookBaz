using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwCntPaymentOpr
    {
        public int CntPaymentOprSi { get; set; }
        public string CntPaymentOprTx { get; set; }
        public decimal? CntPaymentOprDefaultValue { get; set; }
        public byte? CntPaymentOprValueTyp { get; set; }
        public short? CntPaymentOprTyp { get; set; }
    }
}
