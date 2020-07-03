using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AstCnsMthd
    {
        public AstCnsMthd()
        {
            AstGrup = new HashSet<AstGrup>();
        }

        public byte AstCnsMthdId { get; set; }
        public string AstCnsMthdTx { get; set; }

        public virtual ICollection<AstGrup> AstGrup { get; set; }
    }
}
