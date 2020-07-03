using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwAstLocationNew
    {
        public string AstAssetId { get; set; }
        public string AstAssetTx { get; set; }
        public int? AstLctnId { get; set; }
        public string AstLctnTx { get; set; }
    }
}
