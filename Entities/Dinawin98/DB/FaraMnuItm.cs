using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class FaraMnuItm
    {
        public int FaraMnuItmSi { get; set; }
        public string FaraMnuItmProc { get; set; }
        public string FaraMnuItmFileName { get; set; }
        public string FaraMnuItmCaption { get; set; }
        public string FaraMnuItmUserGuide { get; set; }
        public string FaraMnuItmSrcUnitName { get; set; }
        public string FaraMnuItmSrcDeclaration { get; set; }
        public string FaraMnuItmParam { get; set; }
    }
}
