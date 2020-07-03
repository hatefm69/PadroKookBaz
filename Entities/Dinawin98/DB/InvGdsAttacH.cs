using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvGdsAttacH
    {
        public int InvGdsAttacHSi { get; set; }
        public string InvGdsAttacHDs { get; set; }
        public string InvGdsAttacHTp { get; set; }
        public string InvGdsAttacHFileName { get; set; }
        public byte[] InvGdsAttacHFile { get; set; }
        public int? InvGdsSi { get; set; }
    }
}
