using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public partial class AstPrms
    {
        public string AstPrmsLgn { get; set; }
        public bool? AssetsIu { get; set; }
        public bool? AssetsD { get; set; }
        public bool? AssetDataU { get; set; }
        public bool? AssetLocationIud { get; set; }
        public bool? AssetAjustI { get; set; }
        public bool? AssetAjustU { get; set; }
        public bool? AssetAjustD { get; set; }
        public bool? DataIu { get; set; }
        public bool? DataD { get; set; }
        public bool? Calculate { get; set; }
        public bool? LocationsIud { get; set; }
        public bool? GroupsIud { get; set; }
    }
}
