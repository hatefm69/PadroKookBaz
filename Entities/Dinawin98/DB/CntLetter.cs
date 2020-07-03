using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class CntLetter
    {
        public int CntLetterSi { get; set; }
        public int? CntContractSi { get; set; }
        public byte CntLetterType { get; set; }
        public string CntLetterNo1 { get; set; }
        public string CntLetterNo2 { get; set; }
        public string CntLetterSubject { get; set; }
        public DateTime? CntLetterDate { get; set; }
        public byte[] CntLetterFile { get; set; }
        public string CntLetterFileName { get; set; }
        public int? CntLetterFileSize { get; set; }
        public string CntLetterFileType { get; set; }
        public int? CntLetterSenderSi { get; set; }
        public int? CntLetterReciverSi { get; set; }
    }
}
