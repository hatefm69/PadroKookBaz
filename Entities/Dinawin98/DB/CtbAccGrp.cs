using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CtbAccGrp
    {
        public CtbAccGrp()
        {
            CtbAccK = new HashSet<CtbAccK>();
        }

        public int SiAccGrp { get; set; }
        public string CuAcc { get; set; }
        public string TpAcc { get; set; }
        public DateTime CreateRec { get; set; }
        public string LoginName { get; set; }
        public string TpAcc2 { get; set; }
        public int? CuAcc2 { get; set; }
        public int? SiFather { get; set; }

        public virtual ICollection<CtbAccK> CtbAccK { get; set; }
    }
}
