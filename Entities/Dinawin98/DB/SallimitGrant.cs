﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class SallimitGrant
    {
        public int SallimitGrantSi { get; set; }
        public decimal? GrantQtyFrom { get; set; }
        public decimal? GrantQtyTo { get; set; }
        public string SallimitGrantTp { get; set; }
        public int? SalDivisionSi { get; set; }
    }
}
