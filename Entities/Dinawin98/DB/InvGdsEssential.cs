using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvGdsEssential
    {
        public int InvGdsEssentialSi { get; set; }
        public string InvGdsEssentialDesc { get; set; }
        public double? InvGdsEssentialQty { get; set; }
        public int? InvControlGdsSi { get; set; }
        public int? InvDocTmpHSi { get; set; }
        public string InvGdsEssentialStmpMus { get; set; }
        public DateTime? InvGdsEssentialStmpCdt { get; set; }
        public string InvGdsEssentialAcptMus { get; set; }
        public DateTime? InvGdsEssentialAcptCdt { get; set; }
        public bool? InvGdsEssentialStatus { get; set; }
        public bool? InvGdsEssentialAccepted { get; set; }
        public int? InvGdsEssentialSts { get; set; }
        public bool? InvGdsEssentialAcp1 { get; set; }
        public bool? InvGdsEssentialAcp2 { get; set; }
        public bool? InvGdsEssentialSndGdsControl { get; set; }
        public bool? InvGdsEssentialSndInv { get; set; }
    }
}
