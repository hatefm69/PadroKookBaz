using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AstCtrlr
    {
        public int AstCtrlrId { get; set; }
        public string AstCtrlrTx { get; set; }
        public DateTime? AstCtrlrStart { get; set; }
        public DateTime? AstCtrlrFinish { get; set; }
    }
}
