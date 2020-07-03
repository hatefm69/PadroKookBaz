using Models.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Models.Shipping.Padro
{
    /// <summary>
    /// بارگذاري گزينه هاي ارسال كالا 
    /// </summary>
    public class Delivery_optionsDTO
    {
        public string source_city { get; set; }
        public string destination_city { get; set; }
        public IEnumerable<ParcelDTO> parcels { get; set; }
    }


}
