using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class FaraBarcode
    {
        public int FaraBarcodeSi { get; set; }
        public int? PrcCount { get; set; }
        public int? QtyCount { get; set; }
        public int? GdsCount { get; set; }
        public int? BatchCount { get; set; }
    }
}
