using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AssMachineModel
    {
        public AssMachineModel()
        {
            AssMachinId = new HashSet<AssMachinId>();
            AssReception = new HashSet<AssReception>();
        }

        public int AssMachineModelSi { get; set; }
        public string AssMachineModelCu { get; set; }
        public string AssMachineModelTp { get; set; }
        public int AssMachineSi { get; set; }

        public virtual AssMachine AssMachineSiNavigation { get; set; }
        public virtual ICollection<AssMachinId> AssMachinId { get; set; }
        public virtual ICollection<AssReception> AssReception { get; set; }
    }
}
