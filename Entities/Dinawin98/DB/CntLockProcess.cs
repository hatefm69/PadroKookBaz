using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CntLockProcess
    {
        public int CntLockProcessSi { get; set; }
        public string CntLockProcessUserName { get; set; }
        public string CntLockProcessLevelTx { get; set; }
        public int? CntLockProcessLevelNo { get; set; }
        public bool? CntLockProcessEndLevel { get; set; }
    }
}
