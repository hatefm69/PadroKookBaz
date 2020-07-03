using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwAstVchrH
    {
        public int AstVchrHId { get; set; }
        public DateTime? AstVchrHDate { get; set; }
        public bool? AstVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }
        public string AstVchrHTx { get; set; }
        public int? SiHdoc { get; set; }
        public int? CuDoc { get; set; }
        public string TpHdoc { get; set; }
        public int? SecCuDoc { get; set; }
    }
}
