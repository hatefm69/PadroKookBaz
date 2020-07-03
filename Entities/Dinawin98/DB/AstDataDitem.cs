using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AstDataDitem
    {
        public int AstDataHId { get; set; }
        public int AstDataDId { get; set; }
        public string AstDataDitemId { get; set; }

        public virtual AstDataD AstData { get; set; }
    }
}
