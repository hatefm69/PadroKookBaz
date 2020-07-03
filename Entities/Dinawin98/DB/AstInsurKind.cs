using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AstInsurKind
    {
        public AstInsurKind()
        {
            AstInsurance = new HashSet<AstInsurance>();
        }

        public string AstInsurKindCu { get; set; }
        public string AstInsurKindTp { get; set; }

        public virtual ICollection<AstInsurance> AstInsurance { get; set; }
    }
}
