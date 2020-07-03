using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwAstAssetDprc
    {
        public string AstAssetId { get; set; }
        public DateTime AstAssetDprcDate { get; set; }
        public decimal AstAssetDprcPrice { get; set; }
        public string AstAssetTx { get; set; }
        public string AstGrupId { get; set; }
    }
}
