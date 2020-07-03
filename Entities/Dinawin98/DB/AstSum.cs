using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AstSum
    {
        public AstSum()
        {
            AstAsset = new HashSet<AstAsset>();
        }

        public string AstSumId { get; set; }
        public string AstSumTx { get; set; }

        public virtual ICollection<AstAsset> AstAsset { get; set; }
    }
}
