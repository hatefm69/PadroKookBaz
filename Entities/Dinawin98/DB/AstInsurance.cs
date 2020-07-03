using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AstInsurance
    {
        public int AstInsuranceSi { get; set; }
        public string AstAssetId { get; set; }
        public string AstInsuranceCu { get; set; }
        public string AstInsurKindCu { get; set; }
        public string AstInsuranceMan { get; set; }
        public string AstInsuranceOffice { get; set; }
        public DateTime? AstInsuranceDateS { get; set; }
        public DateTime? AstInsuranceDateE { get; set; }
        public decimal? AstInsuranceAmnt { get; set; }

        public virtual AstInsurKind AstInsurKindCuNavigation { get; set; }
    }
}
