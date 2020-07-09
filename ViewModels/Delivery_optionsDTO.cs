using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
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
