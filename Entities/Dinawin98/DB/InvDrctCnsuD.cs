using Entities;
using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public class InvDrctCnsuD : BaseEntity
    {
        public int InvDrctCnsuHSi { get; set; }
        public int InvGdsSi { get; set; }
        public double InvDrctCnsuDQty { get; set; }
        public decimal? InvDrctCnsuDUntPrc { get; set; }
        public decimal? InvDrctCnsuDTotal { get; set; }
        public int? PurRqstHSi { get; set; }
        public int? InvUntSi { get; set; }
        public virtual InvDrctCnsuH InvDrctCnsuHSiNavigation { get; set; }
        public virtual InvGds InvGdsSiNavigation { get; set; }
    }
}
