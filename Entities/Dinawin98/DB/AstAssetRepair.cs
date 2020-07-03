using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AstAssetRepair
    {
        public string AstAssetId { get; set; }
        public DateTime AstAssetRepairDate { get; set; }
        public decimal AstAssetRepairPrice { get; set; }
        public string AstAssetRepairTx { get; set; }
    }
}
