﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class VwSalVchrH
    {
        public int SalVchrHId { get; set; }
        public DateTime SalVchrHDate { get; set; }
        public DateTime SalVchrHDateFrom { get; set; }
        public DateTime SalVchrHDateUntil { get; set; }
        public string SalVchrHTx { get; set; }
        public bool? SalVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }
        public int? CuDoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public int? SecCuDoc { get; set; }
    }
}
