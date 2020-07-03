﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwInvVchrH
    {
        public int InvVchrHId { get; set; }
        public DateTime? InvVchrHDate { get; set; }
        public DateTime? InvVchrHDateFrom { get; set; }
        public DateTime? InvVchrHDateUntil { get; set; }
        public string InvVchrHTx { get; set; }
        public bool InvVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }
        public int? CuDoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public int? SecCuDoc { get; set; }
    }
}
