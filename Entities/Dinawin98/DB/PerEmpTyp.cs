using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class PerEmpTyp
    {
        public PerEmpTyp()
        {
            PerCmd = new HashSet<PerCmd>();
        }

        public int PerEmpTypSi { get; set; }
        public string PerEmpTypCu { get; set; }
        public string PerEmpTypTp { get; set; }

        public virtual ICollection<PerCmd> PerCmd { get; set; }
    }
}
