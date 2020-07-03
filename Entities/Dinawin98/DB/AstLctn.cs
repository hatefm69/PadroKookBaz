using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AstLctn
    {
        public AstLctn()
        {
            AstAsset = new HashSet<AstAsset>();
            AstAssetLctn = new HashSet<AstAssetLctn>();
        }

        public int AstLctnId { get; set; }
        public string AstLctnTx { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AstLctnSiParent { get; set; }

        public virtual ICollection<AstAsset> AstAsset { get; set; }
        public virtual ICollection<AstAssetLctn> AstAssetLctn { get; set; }
    }
}
