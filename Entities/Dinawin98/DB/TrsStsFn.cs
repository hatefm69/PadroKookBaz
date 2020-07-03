using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class TrsStsFn
    {
        public TrsStsFn()
        {
            TrsStsTrsStsFnSiCreditNavigation = new HashSet<TrsSts>();
            TrsStsTrsStsFnSiDebitNavigation = new HashSet<TrsSts>();
        }

        public byte TrsStsFnSi { get; set; }
        public string TrsStsFnTp { get; set; }
        public string TrsStsFnFn { get; set; }

        public virtual ICollection<TrsSts> TrsStsTrsStsFnSiCreditNavigation { get; set; }
        public virtual ICollection<TrsSts> TrsStsTrsStsFnSiDebitNavigation { get; set; }
    }
}
