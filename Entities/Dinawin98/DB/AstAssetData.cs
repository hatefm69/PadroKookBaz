using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AstAssetData
    {
        public string AstAssetId { get; set; }
        public int AstDataHId { get; set; }
        public int AstDataDId { get; set; }
        public string AstAssetDataValue { get; set; }

        public virtual AstAsset AstAsset { get; set; }
        public virtual AstDataD AstData { get; set; }
    }
}
