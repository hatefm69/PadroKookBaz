﻿using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class InvCostQcUser
    {
        public int InvCostQcUserSi { get; set; }
        public int? InvCostQcSi { get; set; }
        public string UserRec { get; set; }
        public bool? InvCostQcUserAccept { get; set; }

        public virtual InvCostQc InvCostQcSiNavigation { get; set; }
    }
}
