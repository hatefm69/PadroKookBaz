using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AstDataH
    {
        public AstDataH()
        {
            AstDataD = new HashSet<AstDataD>();
        }

        public int AstDataHId { get; set; }
        public string AstDataHTx { get; set; }

        public virtual ICollection<AstDataD> AstDataD { get; set; }
    }
}
