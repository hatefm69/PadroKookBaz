using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccCtbMinfoCompany
    {
        public AccCtbMinfoCompany()
        {
            AccCtbMinfo = new HashSet<AccCtbMinfo>();
        }

        public int AccCtbMinfoCompanySi { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<AccCtbMinfo> AccCtbMinfo { get; set; }
    }
}
