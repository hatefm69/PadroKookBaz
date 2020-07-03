using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class G
    {
        public string SystemName { get; set; }
        public string ShDate { get; set; }
        public string Description { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? Si { get; set; }
        public string Typ { get; set; }
    }
}
