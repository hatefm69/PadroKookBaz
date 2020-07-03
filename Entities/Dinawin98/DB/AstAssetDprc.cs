using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AstAssetDprc
    {
        public string AstAssetId { get; set; }
        public DateTime AstAssetDprcDate { get; set; }
        public decimal AstAssetDprcPrice { get; set; }
        public int? AstVchrId { get; set; }

        public virtual AstAsset AstAsset { get; set; }
    }
}
