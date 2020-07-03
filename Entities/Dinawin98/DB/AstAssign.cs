using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AstAssign
    {
        public int AstAssignSi { get; set; }
        public string AstAssetId { get; set; }
        public byte AstAssignType { get; set; }
        public DateTime? AstAssignDate { get; set; }

        public virtual AstAsset AstAsset { get; set; }
    }
}
