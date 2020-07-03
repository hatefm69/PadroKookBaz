using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccCtbMinfoDefault
    {
        public int AccCtbMinfoDefaultSi { get; set; }
        public int? SiAccM { get; set; }
        public string AccCtbMinfoTp { get; set; }
        public bool? IsInput { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsUnique { get; set; }

        public virtual CtbAccM SiAccMNavigation { get; set; }
    }
}
