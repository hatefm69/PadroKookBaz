using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CntCntrIntroducer
    {
        public int CntCntrIntroducerSi { get; set; }
        public int CntContractSi { get; set; }
        public string CntCntrIntroducerName { get; set; }
        public decimal? CntCntrIntroducerPayment { get; set; }
    }
}
