using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AccDocTypes
    {
        public AccDocTypes()
        {
            AccHdoc = new HashSet<AccHdoc>();
        }

        public int SiDocType { get; set; }
        public string CuDocType { get; set; }
        public string TpDocType { get; set; }
        public DateTime CreateRec { get; set; }
        public string LoginName { get; set; }

        public virtual ICollection<AccHdoc> AccHdoc { get; set; }
    }
}
