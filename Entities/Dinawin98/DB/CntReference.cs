﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CntReference
    {
        public int CntReferenceSi { get; set; }
        public int CntContractSi { get; set; }
        public int? CntContractSi2 { get; set; }
        public string CntReferenceTx { get; set; }
        public int? CntReferenceTypSi { get; set; }

        public virtual CntContract CntContractSiNavigation { get; set; }
        public virtual CntReferenceTyp CntReferenceTypSiNavigation { get; set; }
    }
}
