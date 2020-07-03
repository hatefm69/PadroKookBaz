using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccCrossCheck
    {
        public int AccCrossCheckId { get; set; }
        public int? SiDdocDebit { get; set; }
        public int? SiDdocCredit { get; set; }
        public Guid Uid { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? SiAccM { get; set; }
        public int? SiAccT { get; set; }
        public int? SiCost { get; set; }
        public int? SiProject { get; set; }
    }
}
