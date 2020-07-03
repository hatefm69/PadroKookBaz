using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CntContractPaymentOpr
    {
        public int CntContractPaymentOprSi { get; set; }
        public int? CntContractSi { get; set; }
        public int? CntPaymentOprSi { get; set; }
        public double? CntContractPaymentOprValue { get; set; }
        public double? CntContractPaymentOprIncValue { get; set; }
        public double? CntContractPaymentOprDecValue { get; set; }
    }
}
