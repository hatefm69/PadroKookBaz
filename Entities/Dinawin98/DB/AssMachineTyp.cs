using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AssMachineTyp
    {
        public AssMachineTyp()
        {
            AssReceiptH = new HashSet<AssReceiptH>();
        }

        public int AssMachineTypSi { get; set; }
        public int? AssMachineTypCu { get; set; }
        public string AssMachineTypTp { get; set; }
        public int? AssMachineTypKm { get; set; }
        public int? AssMachineTypGuranteDur { get; set; }
        public int? AssMachineTypFirstGuranteDur { get; set; }

        public virtual ICollection<AssReceiptH> AssReceiptH { get; set; }
    }
}
