using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccountGeneral
    {
        public int GeneralId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string LatinName { get; set; }
    }
}
